﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Heizungsregelung
{

    class Calculations
    {

        //---------------------------------------------variables--------------------------------------
        //---------------------------------------------private----------------------------------------

        //needed for outside variables
        private static int m_außen_Mittel, m_quelle_Soll, m_hk_Soll = 60, m_boiler_Soll = 65, m_raum_Soll = 20;
        private static int m_außentemp_Ist, m_quelle_Ist, m_hk_Ist, m_boiler_Ist,  m_boiler_hysterese = 10;
        //only used internally for calculations, mischer repräsentiert den gesamtzyklus dees HK Mischers in Sekunden
        private static double heizkurve = 1.2, fußpunkt = 25, mischer = 7, abweichung_mischer;
        private static int hk_anforderung, boiler_anforderung;
        //
        private static bool m_anforderung_quelle, m_pumpe_boiler, m_pumpe_hk, m_mischer_auf_hk, m_mischer_zu_hk;

        #region variables to activate simulated pumps and valves 
        //for outside-the-class use to symbolise if the pumps should be running or not
        /// <summary>
        /// Zeigt ob eine Anforderung an die Quelle besteht
        /// </summary>
        public bool Anforderung_Quelle
        {
            get => m_anforderung_quelle;
        }

        /// <summary>
        /// gets if the pump of the boiler should be running or not
        /// </summary>
        public bool Pumpe_Boiler
        {
            get => m_pumpe_boiler;
        }

        /// <summary>
        /// gets if the pump of the heizkreis should be running
        /// </summary>
        public bool Pumpe_HK
        {
            get => m_pumpe_hk;
        }

        /// <summary>
        /// gets if the mischer for the heizkreis should be open
        /// </summary>
        public bool Mischer_Auf_HK
        {
            get => m_mischer_auf_hk;
        }

        /// <summary>
        /// gets if the mischer for the heizkreis should be open
        /// </summary>
        public bool Mischer_Zu_HK
        {
            get => m_mischer_zu_hk;
        }

        #endregion variables to activate simulated pumps and valves 

        private Thread averageThread;
        private Thread SollCalcThread;

        //---------------------------------------------public-----------------------------------------

        #region Außen- und RaumTemps
        /// <summary>
        /// selected Raumtemperature
        /// </summary>
        public int RaumTemp_Soll
        {
            get => m_raum_Soll;
            set
            {
                if (value >= 1 && value < 100)
                    m_raum_Soll = value;
            }
        }

        /// <summary>
        /// takes the IST wert and gets the average of the last 30 seconds
        /// </summary>
        public int AußenTemp_Mittelwert
        {
            get => m_außen_Mittel;
        }

        /// <summary>
        /// gets and sets the IST AußenTemp 
        /// </summary>
        public int AußenTemp_Ist
        {
            get => m_außentemp_Ist;
            //gets set through datastream of sensors
            set => m_außentemp_Ist = value;
        }
        #endregion Außen- und RaumTemps


        #region Quelle
        /// <summary>
        /// takes the IST value and calculates the SOLL value
        /// </summary>
        public int VorlaufQuelle_Ist 
        { 
            get => m_quelle_Ist;
            //gets set through datastream of sensors
            set
            {
                if (value >= 1 && value < 100)
                    m_quelle_Ist = value;
            }
        }
        
        /// <summary>
        /// Anforderung and die Quelle; grundsatzlich 
        /// </summary>
        public int VorlaufQuelle_Soll
        {
            get => m_quelle_Soll;
        }
        #endregion Quelle


        #region Heizkreis

        /// <summary>
        /// takes the IST value and calculates the SOLL value
        /// </summary>
        public int VorlaufHeizkreis_Soll
        {
            get => m_hk_Soll;
        }
        
        
        /// <summary>
        /// gets and sets the IST heizkreis temperature
        /// </summary>
        public int VorlaufHeizkreis_Ist
        {
            get => m_hk_Ist;
            //gets set through datastream of sensors
            set
            {
                if (value >= 1 && value < 100)
                    m_hk_Ist = value;
            }
        }


        #endregion Heizkreis


        #region Boiler
        /// <summary>
        ///  gets and sets the SOLL boiler temperature
        /// </summary>
        public int BoilerTemp_Soll
        {
            get => m_boiler_Soll;
            //set available because user can change this value
            set
            {
                if (value >= 1 && value < 100)
                    m_boiler_Soll = value;
            }
        }

        /// <summary>
        /// gets and sets the IST boiler temperature
        /// </summary>
        public int BoilerTemp_Ist
        {
            get => m_boiler_Ist;
            //gets set through data stream of sensors
            set
            {
                if (value >= 1 && value < 100)
                    m_boiler_Ist = value;
            }
        }

        /// <summary>
        /// sets the hysterese (tolerance for boiler temperature)
        /// </summary>
        public int Boiler_Hysterese
        {
            get => m_boiler_hysterese;
            //set available because user can change this value
            set
            {
                if (value >= 1 && value <= 50)
                    m_boiler_hysterese = value;
            }
        }
        #endregion




        //-----------------------------------------------------methodes and ctor---------------------------------

        /// <summary>
        /// ctor
        /// used to start the average-calculation thread
        /// </summary>
        public Calculations()
        {
            averageThread = new Thread(new ThreadStart(AverageOutsideTemp));
            averageThread.IsBackground = true;
            averageThread.Priority = ThreadPriority.Lowest;
            averageThread.Start();

            SollCalcThread = new Thread(new ThreadStart(CalculateTemperatures));
            SollCalcThread.IsBackground = true;
            SollCalcThread.Priority = ThreadPriority.Lowest;
            SollCalcThread.Start();

        }

        /// <summary>
        /// average the outside temperature over 1 minute
        /// </summary>
        private static void AverageOutsideTemp()
        {
            //sets initial temperature to ist value
            m_außen_Mittel = m_außentemp_Ist;

            int items = 30;

            //create a list of integers
            int[] wert = new int[items];

            while (true)
            {
                //set to 60
                for (int i = 0; i < items; i++)
                {
                    //add the ist wert every second to the list 
                    wert[i] = m_außentemp_Ist;
                    Thread.Sleep(1000);
                }

                //approx. after 30 second i.e. 30 items added calc the average
                //in reality this should take about 2 minutes!!
                m_außen_Mittel = (int)wert.Average();
            }

        }

        private static void CalculateTemperatures()
        {
            while (true)
            {

                #region Berechnung Quelle

                if (hk_anforderung > boiler_anforderung)
                    m_quelle_Soll = hk_anforderung;
                else if (hk_anforderung < boiler_anforderung)
                    m_quelle_Soll = boiler_anforderung;

                //Ist die Vorlauftemperatur der Quelle um die fixe Hysteres 5° unterschritten, wird Wärme angefordert.
                if (m_quelle_Ist < (m_quelle_Soll - 5))
                {
                    //Anforderung an Quelle HIGH
                    m_anforderung_quelle = true;
                }
                else
                {
                    //Anforderung an Quelle LOW
                    m_anforderung_quelle = false;
                }

                #endregion Berechnung Quelle



                #region Berechnungen Heizkreis 

                //Heizkurvenberechnung, je kälter aussen bzw höher eingestellte RT, desto mehr Vorlauftemperatur (Max 70°!)
                m_hk_Soll = (int)((m_raum_Soll - m_außentemp_Ist) * heizkurve + fußpunkt);
                if (m_hk_Soll >= 70)
                    m_hk_Soll = 70;

                //wenn der mittelwert (letzten 30 Sekunden) höher als 18°C ist, 
                //wird die hk pumpe aktiviert und eine anforderung an die quelle gestellt
                if (m_außen_Mittel < 18)
                {
                    //turn pump on
                    m_pumpe_hk = true;
                    //set hk_anforderung
                    hk_anforderung = m_hk_Soll + 5;
                }
                //wenn nicht wird die hk pumpe nicht aktiviert --> somit ist heizung aus
                else 
                {
                    //turn pump off
                    m_pumpe_hk = false;
                }

                //abweichung zwischen soll und ist
                abweichung_mischer = (m_hk_Soll - m_hk_Ist);
                //bei kleiner abweichung wird der mischer nicht angesteuert
                if (abweichung_mischer >= -2 || abweichung_mischer <= 2)
                    abweichung_mischer = 0;
                //Abweichung negativ - Mischer fährt zu für die dauer von t1*1s 
                //(also je weiter die abweichung, desto länger steht der Befehl an,
                //nach 8sec wird wieder verglichen - geringere abweichung - kürzerer befehl) ------ ? matze fragen
                else if (abweichung_mischer < 0)
                {
                    m_mischer_auf_hk = false;
                    m_mischer_zu_hk = true;
                }
                //Abweichung positiv - Mischer fährt auf 
                //(Achtung: Mischer darf niemals gleichzeitg die befehle Auf+Zu erhalten)
                else if (abweichung_mischer > 0)
                {
                    m_mischer_auf_hk = true;
                    m_mischer_zu_hk = false;
                }

                #endregion Berechnungen Heizkreis 



                #region Berechnungen Boiler 

                //Sinkt die Boilertemperatur unter die Eingestellte Schwelle 
                //(üblich ca 10°, also z.B. Soll 65°-HB 10°=55°), beginnt die Boilerladung
                if (m_boiler_Ist < m_boiler_Soll - m_boiler_hysterese)
                {
                    //Pumpe Boiler HIGH
                    m_pumpe_boiler = true;
                    //Anforderung an die Quelle
                    boiler_anforderung = m_boiler_Soll + 5;
                }
                else if (m_boiler_Ist >= m_boiler_Soll)
                {
                    //Pumpe Boiler LOW
                    m_pumpe_boiler = false;
                    boiler_anforderung = 0;
                }

                #endregion Berechnungen Boiler 


            }

        }



    }
}
