using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace diplwinform_v1_1
{

    class Calculations
    {

        //---------------------------------------------variables--------------------------------------
        //---------------------------------------------private----------------------------------------

        private static int m_außen_Mittel, m_quelle_Soll, m_hk_Soll, m_boiler_Soll;
        private static int m_außentemp_Ist, m_quelle_Ist, m_hk_Ist, m_boiler_Ist, m_raum_ist, m_boiler_hysterese;

        private Thread averageThread;
        private Thread SollCalcThread;

        //---------------------------------------------public-----------------------------------------

        public int RaumTemp_Soll
        {
            get => m_raum_ist;
            set
            {
                if (value >= 1)
                    m_raum_ist = value;
                else
                    m_raum_ist = 1;
            }
        }

        public int AußenTemp_Mittelwert
        {
            get => m_außen_Mittel;
            set => m_außentemp_Ist = value;
        }

        public int QuellenTemp_Soll
        {
            get => m_quelle_Soll;
            set => m_quelle_Ist = value;
        }

        public int HKTemp_Soll
        {
            get => m_hk_Soll;
            set => m_hk_Ist = value;
        }

        public int BoilerTemp_Soll
        {
            get => m_boiler_Soll;
            set => m_boiler_Ist = value;
        }

        public int Boiler_Hysterese
        {
            get => m_boiler_hysterese;
            set
            {
                if (value >= 0 && value <= 50)
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

            RaumTemp_Soll = 20;
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
                m_quelle_Soll = m_quelle_Ist;
                m_hk_Soll = m_hk_Ist;
                m_boiler_Soll = 70;
            }
            
        }

    }
}
