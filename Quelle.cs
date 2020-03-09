using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heizungsregelung
{
    class Quelle
    {
        //-------------------------------------------------private variables
        private static int quelle_Ist, quelle_SOLL;
        private static bool anforderung_quelle;


        //-------------------------------------------------public variables
        /// <summary>
        /// Zeigt ob eine Anforderung an die Quelle besteht
        /// </summary>
        public bool Anforderung_Quelle
        {
            get => anforderung_quelle;
        }

        /// <summary>
        /// takes the IST value and calculates the SOLL value
        /// </summary>
        public int VorlaufQuelle_Ist
        {
            get => quelle_Ist;
            //gets set through datastream of sensors
            set
            {
                if (value >= 0 && value < 90)
                    quelle_Ist = value;
            }
        }

        /// <summary>
        /// Anforderung and die Quelle; grundsatzlich 
        /// </summary>
        public int VorlaufQuelle_Soll
        {
            get => quelle_SOLL;
        }

    }
}
