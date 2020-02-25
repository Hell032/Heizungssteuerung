using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace diplwinform_v1_1
{

    class Calculations
    {

        //---------------------------------------------variables--------------------------------------
        //---------------------------------------------private----------------------------------------

        private static int m_außen_Mittel, m_quelle_Soll = 80, m_hk_Soll = 60, m_boiler_Soll = 75, m_raum_Soll = 20;
        private static int m_außentemp_Ist, m_quelle_Ist, m_hk_Ist, m_boiler_Ist,  m_boiler_hysterese = 10;

        private Thread averageThread;
        private Thread SollCalcThread;

        //---------------------------------------------public-----------------------------------------

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
            set => m_außentemp_Ist = value;
        }

        /// <summary>
        /// takes the IST value and calculates the SOLL value
        /// </summary>
        public int QuellenTemp_Soll
        {
            get => m_quelle_Soll;
            set => m_quelle_Ist = value;
        }


        /// <summary>
        /// takes the IST value and calculates the SOLL value
        /// </summary>
        public int HKTemp_Soll
        {
            get => m_hk_Soll;
            set => m_hk_Ist = value;
        }


        /// <summary>
        /// takes the Soll value
        /// </summary>
        public int BoilerTemp_Soll
        {
            get => m_boiler_Soll;
            set
            {
                if (value >= 1 && value < 100)
                    m_boiler_Soll = value;
            }
        }

        public int BoilerTemp_Ist
        {
            set => m_boiler_Ist = value;
        }

        /// <summary>
        /// sets the hysterese (tolerance for boiler temperature)
        /// </summary>
        public int Boiler_Hysterese
        {
            get => m_boiler_hysterese;
            set
            {
                if (value >= 1 && value <= 50)
                    m_boiler_hysterese = value;
                else
                    m_boiler_hysterese = 1;
            }
        }


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

            SollCalcThread = new Thread(new ThreadStart(CalcSollTemperatures));
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

                //approx. after 60 second i.e. 60 items added calc the average
                m_außen_Mittel = (int)wert.Average();
            }

        }

        private static void CalcSollTemperatures()
        {
            while (true)
            {
                //TODO
                //for debugging
                m_quelle_Soll = m_quelle_Ist + 10;
                m_hk_Soll = m_hk_Ist + 10;

                //m_boiler_Soll = m_boiler_Ist + 10;
            }
            
        }

    }
}
