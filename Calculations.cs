using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Heizungsregelung
{

    class Calculations
    {

        public static Output myoutput;

        //---------------------------------------------variables--------------------------------------
        //---------------------------------------------private----------------------------------------

        //needed for outside variables
        private static int m_außen_Mittel, m_quelle_Soll, m_hk_Soll = 60, m_boiler_Soll = 65, m_raum_Soll = 20;
        private static int m_außentemp_Ist, m_quelle_Ist, m_hk_Ist, m_boiler_Ist, m_boiler_hysterese = 10, m_tag_nacht = 4, m_wasserverbrauch;
        //only used internally for calculations, mischer repräsentiert den gesamtzyklus dees HK Mischers in millisekunden
        private static double heizkurve = 1.2, fußpunkt = 25, abweichung_mischer;
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

        //---------------------------------------------public variables-----------------------------------------

        #region Außentemperatures

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
                if (value >= 0 && value < 100)
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
        /// selected Raumtemperature
        /// </summary>
        public int RaumTemp_Soll
        {
            get => m_raum_Soll;
            set
            {
                if (value >= 0 && value < 100)
                    m_raum_Soll = value;
            }
        }

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
                if (value >= 0 && value < 100)
                    m_hk_Ist = value;
            }
        }


        /// <summary>
        /// gets and sets the IST heizkreis temperature
        /// </summary>
        public int NachlaufHeizkreis_Ist
        {
            get => m_hk_Ist;
            //gets set through datastream of sensors
            set
            {
                if (value >= 0 && value < 100)
                    m_hk_Ist = value;
            }
        }

        /// <summary>
        /// gets and sets the temperature difference between day and night
        /// </summary>
        public int Tag_Nacht_Abweichung
        {
            get => m_tag_nacht;
            set
            {
                if (value >= 0 && value <= 10)
                    m_tag_nacht = value;
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
                if (value >= 0 && value < 100)
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
                if (value >= 0 && value < 100)
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
                if (value >= 0 && value <= 50)
                    m_boiler_hysterese = value;
            }
        }

        public int Wasserverbrauch
        {
            get => m_wasserverbrauch;
            //gets set through data stream of sensors
            set
            {
                if (value >= 0 && value < 100)
                    m_wasserverbrauch = value;
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
            //start the helper thread used to calculate the temperatures

            averageThread = new Thread(new ThreadStart(AverageOutsideTemp));
            averageThread.IsBackground = true;
            averageThread.Priority = ThreadPriority.Lowest;
            averageThread.Start();

            myoutput = new Output();

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
            #region calculate average outside temperature
            //sets initial temperature to ist value
            m_außen_Mittel = m_außentemp_Ist;

            int items = 15;

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
            #endregion calculate average outside temperature

        }

        private static void CalculateTemperatures()
        {
            //used to buffer the thread to load forms and avoid null exceptions
            Thread.Sleep(5000);

            while (true)
            {


                #region First Try
                /*
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
                    myoutput.Anforderung_Quelle(true);
                }
                else
                {
                    //Anforderung an Quelle LOW
                    m_anforderung_quelle = false;
                    myoutput.Anforderung_Quelle(false);
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
                    myoutput.Pumpe_HK(true);
                    //set hk_anforderung
                    hk_anforderung = m_hk_Soll + 5;
                }
                //wenn nicht wird die hk pumpe nicht aktiviert --> somit ist heizung aus
                else
                {
                    //turn pump off
                    m_pumpe_hk = false;
                    myoutput.Pumpe_HK(false);
                }

                //abweichung zwischen soll und ist
                abweichung_mischer = (m_hk_Soll - m_hk_Ist);

                //Abweichung positiv - Mischer fährt auf 
                //(Achtung: Mischer darf niemals gleichzeitg die befehle Auf+Zu erhalten)
                if (abweichung_mischer > 2)
                {
                    m_mischer_zu_hk = false;
                    myoutput.Mischer_ZU(false);
                    //kleiner buffer - mischer darf nicht bei signale gleichzeitig erhalten
                    Thread.Sleep(250);
                    m_mischer_auf_hk = true;
                    myoutput.Mischer_AUF(true);
                }
                //Abweichung negativ - Mischer fährt zu für die dauer von t1*1s 
                //(also je weiter die abweichung, desto länger steht der Befehl an,
                //nach 8sec wird wieder verglichen - geringere abweichung - kürzerer befehl) ------ ? matze fragen
                else if (abweichung_mischer < -2)
                {
                    m_mischer_auf_hk = false;
                    myoutput.Mischer_AUF(false);

                    //kleiner buffer - mischer darf nicht bei signale gleichzeitig erhalten
                    Thread.Sleep(250);
                    m_mischer_zu_hk = true;
                    myoutput.Mischer_ZU(true);
                }
                //bei kleiner abweichung wird der mischer nicht angesteuert
                else
                {
                    m_mischer_auf_hk = false;
                    myoutput.Mischer_AUF(false);
                    m_mischer_zu_hk = false;
                    myoutput.Mischer_ZU(false);
                }

                #endregion Berechnungen Heizkreis 


                #region Berechnungen Boiler 

                //Sinkt die Boilertemperatur unter die Eingestellte Schwelle 
                //(üblich ca 10°, also z.B. Soll 65°-HB 10°=55°), beginnt die Boilerladung
                if (m_boiler_Ist < m_boiler_Soll - m_boiler_hysterese)
                {
                    //Pumpe Boiler HIGH
                    m_pumpe_boiler = true;
                    myoutput.Pumpe_Boiler(true);
                    //Anforderung an die Quelle
                    boiler_anforderung = m_boiler_Soll + 5;
                }
                else if (m_boiler_Ist >= m_boiler_Soll)
                {
                    //Pumpe Boiler LOW
                    m_pumpe_boiler = false;
                    myoutput.Pumpe_Boiler(false);
                    //keine anforderung an die quelle
                    boiler_anforderung = 0;
                }

                #endregion Berechnungen Boiler 
                */







                //check what temperatures should be and then set the pumps/valves accordingly 

                //first check the selected functions

                #endregion


                //newly written function-------------------------------------------------------------------------------------


                


                #region Berechnungen Heizkreis 

                //Heizkurvenberechnung, je kälter aussen bzw höher eingestellte RT, desto mehr Vorlauftemperatur (Max 70°!)
                m_hk_Soll = (int)((m_raum_Soll - m_außentemp_Ist) * heizkurve + fußpunkt);
                
                //check for limits 
                if (m_hk_Soll >= 70)
                    m_hk_Soll = 70;
                if (m_hk_Soll < 0)
                    m_hk_Soll = 0;

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
                    hk_anforderung = 0;
                }

                if (m_hk_Soll == 0)
                    m_pumpe_hk = false;


                #region Berechnung Mischer HK
                //abweichung zwischen soll und ist
                abweichung_mischer = (m_hk_Soll - m_hk_Ist);

                //Abweichung positiv - Mischer fährt auf 
                //(Achtung: Mischer darf niemals gleichzeitg die befehle Auf+Zu erhalten)
                if (abweichung_mischer > 2)
                {
                    m_mischer_auf_hk = true;
                    m_mischer_zu_hk = false;
                }
                //Abweichung negativ - Mischer fährt zu für die dauer von t1*1s 
                //(also je weiter die abweichung, desto länger steht der Befehl an,
                //nach 8sec wird wieder verglichen - geringere abweichung - kürzerer befehl) ------ ? matze fragen
                else if (abweichung_mischer < -2)
                {
                    m_mischer_auf_hk = false;
                    m_mischer_zu_hk = true;
                }
                //bei kleiner abweichung wird der mischer nicht angesteuert
                else
                {
                    m_mischer_auf_hk = false;
                    m_mischer_zu_hk = false;
                }
                #endregion Berechnung Mischer HK

                #endregion Berechnungen Heizkreis 


                #region Berechnungen Boiler 

                //Sinkt die Boilertemperatur unter die Eingestellte Schwelle 
                //(üblich ca 10°, also z.B. Soll 65°-HB 10°=55°), beginnt die Boilerladung
                if (m_boiler_Ist < ( m_boiler_Soll - m_boiler_hysterese))
                {
                    //Pumpe Boiler HIGH
                    m_pumpe_boiler = true;
                    boiler_anforderung = m_boiler_Soll + 5;
                }
                else if (m_boiler_Ist >= m_boiler_Soll)
                {
                    //Pumpe Boiler LOW
                    m_pumpe_boiler = false;
                    //keine anforderung an die quelle
                    boiler_anforderung = 0;
                }

                //check for limit
                if (m_boiler_Soll == 0)
                    m_pumpe_boiler = false;

                #endregion Berechnungen Boiler 


                #region take selected function into account

                //check if a function is active
                //
                if (Program.FunctionsForm.AntiFreezeForm.AntiFreezeON)
                {
                    //set boiler soll und hk soll auf 0
                    m_boiler_Soll = 0;
                    boiler_anforderung = 0;
                    hk_anforderung = 0;
                    m_hk_Soll = 0;
                    //set mischer von hk auf zu das kein wasser zirkulieren kann 
                    m_mischer_auf_hk = false;
                    m_mischer_zu_hk = true;
                    m_pumpe_hk = false;
                    m_pumpe_boiler = false;

                }

                if (Program.FunctionsForm.SommerWinterForm.SommerON && m_außen_Mittel > 5)
                {
                    //heizung ist aus, boiler unverändert bzw. auf normalem sollwert
                    m_hk_Soll = 0;
                    hk_anforderung = 0;
                    //set mischer zu auf true zu das kein wasser zirkulieren kann und pumpe auschalten
                    m_mischer_auf_hk = false;
                    m_mischer_zu_hk = true;
                    m_pumpe_hk = false;
                }

                if (Program.FunctionsForm.TagNachtForm.NachtON)
                {
                    //raum soll temp um vom user eingestellte temp verringern
                    m_raum_Soll = m_raum_Soll - m_tag_nacht;

                    if (m_außen_Mittel > 15)
                        m_pumpe_hk = false;

                }

                #endregion handle selected functions


                #region Berechnung Quelle
                //ist die anforderungstemp des hk höher soll die quelle diese temp liefern, andernfalls die des boilers
                //falls beide anforderungen an die quelle unter 20 °C liegen und außentemp unter 5°C liegt 
                //--> fixe quellen anforderung von 20°C wegen anti - frezze
                if (hk_anforderung > boiler_anforderung && hk_anforderung >= 20)
                    m_quelle_Soll = hk_anforderung;         // hk größer als boiler und hk größer als 20 
                else if (hk_anforderung < boiler_anforderung && boiler_anforderung >= 20)
                    m_quelle_Soll = boiler_anforderung;     //boiler größer als hk und boiler größer als 20
                else if (hk_anforderung < 20 && boiler_anforderung < 20 && m_außentemp_Ist <= 5)
                {
                    m_quelle_Soll = 20;
                    m_boiler_Soll = 20;
                    m_hk_Soll = 20;
                }                     //wenn hk und boiler kleiner als 20 und außentemp unter 5 ist
                else
                    m_quelle_Soll = 0;


                //Ist die Vorlauftemperatur der Quelle um die fixe Hysteres 5° unterschritten, wird Wärme angefordert.
                if (m_quelle_Ist < (m_quelle_Soll - 5))
                    m_anforderung_quelle = true;    //Anforderung an Quelle HIGH
                else
                    m_anforderung_quelle = false;   //Anforderung an Quelle LOW

                if (m_quelle_Soll == 0)
                    m_anforderung_quelle = false;   //wenn außentemp über <= 5 und keine sonstifge anforderung
                #endregion Berechnung Quelle



                #region fixed Anti-Freeze / heating system protection
                //standard antifreeze to protect the whole heatingsystem when lower outside temps are detected

                #endregion Fixed Anti-Freeze / heating system protection


                SetActuators();

            }

        }

        private static void SetActuators()
        {
            //set the pumps and valves
            myoutput.Anforderung_Quelle(m_anforderung_quelle);
            myoutput.Pumpe_Boiler(m_pumpe_boiler);
            myoutput.Pumpe_HK(m_pumpe_hk);

            //the valves MUST NOT be activated (get HIGH signal) at the same time
            if (m_mischer_auf_hk && !m_mischer_zu_hk)
            {
                myoutput.Mischer_AUF(m_mischer_auf_hk);
                //add a small buffer
                Thread.Sleep(500);
                myoutput.Mischer_ZU(m_mischer_zu_hk);

            }
            else if (!m_mischer_auf_hk && m_mischer_zu_hk)
            {
                myoutput.Mischer_AUF(m_mischer_auf_hk);
                //add a small buffer
                Thread.Sleep(500);
                myoutput.Mischer_ZU(m_mischer_zu_hk);
            }
            else if (m_mischer_auf_hk && m_mischer_zu_hk)
            {
                //myoutput.Mischer_AUF(false);
                //myoutput.Mischer_ZU(false);
                System.Diagnostics.Debug.WriteLine("ERROR WITH MISCHER SOMEWHERE - both are set to true");
            }
            else if (!m_mischer_auf_hk && !m_mischer_zu_hk)
            {
                myoutput.Mischer_AUF(false);
                myoutput.Mischer_ZU(false);
            }
        }

    }
}
