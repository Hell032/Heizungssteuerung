using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiringPi;

namespace Heizungsregelung
{
    class Output
    {

        //set physical gpio pins with coresponding colours of used wires
        // used pins of raspberry pi: 29, 31, 33, 35, 37
        //white
        private static int quelle = 29;
        //orange
        private static int pump_boiler = 37;
        //yellow
        private static int pump_hk = 35;
        //green
        private static int  mischer_auf = 33;
        //blue
        private static int mischer_zu = 31;


        private static bool WiringPiAvailable;


        public Output()
        {
            //if a unix platform ie rpi and physical gpio pins are detected then set WiringPiAvailable to true
            if (CheckForWiringPiSetuPhys()) WiringPiAvailable = true;
            else WiringPiAvailable = false;

            //declare the gpio pins as outputs and set them to high 
            if (WiringPiAvailable)
            {
                GPIO.pinMode(quelle, (int)GPIO.GPIOpinmode.Output);
                GPIO.pinMode(pump_boiler, (int)GPIO.GPIOpinmode.Output);
                GPIO.pinMode(pump_hk, (int)GPIO.GPIOpinmode.Output);
                GPIO.pinMode( mischer_auf, (int)GPIO.GPIOpinmode.Output);
                GPIO.pinMode(mischer_zu, (int)GPIO.GPIOpinmode.Output);

                GPIO.digitalWrite(quelle, (int)GPIO.GPIOpinvalue.High);
                GPIO.digitalWrite(pump_boiler, (int)GPIO.GPIOpinvalue.High);
                GPIO.digitalWrite(pump_hk, (int)GPIO.GPIOpinvalue.High);
                GPIO.digitalWrite( mischer_auf, (int)GPIO.GPIOpinvalue.High);
                GPIO.digitalWrite(mischer_zu, (int)GPIO.GPIOpinvalue.High);


                //start the startup thread to check all the pins functionality
                Thread outputstart = new Thread(new ThreadStart(StartUP));
                outputstart.IsBackground = true;
                outputstart.Start();
            }
        }

        #region set pins 

        /// <summary>
        /// set the pin for Anforderung_Quelle HIGH or LOW via the status variable
        /// </summary>
        /// <param name="status"></param>
        public void Anforderung_Quelle(bool status)
        {
            if (WiringPiAvailable) 
            {
                if (status)
                    GPIO.digitalWrite(quelle, (int)GPIO.GPIOpinvalue.Low);
                else
                    GPIO.digitalWrite(quelle, (int)GPIO.GPIOpinvalue.High);
            }
        }

        /// <summary>
        /// set the pin for Pumpe_Boiler HIGH or LOW via the status variable
        /// </summary>
        /// <param name="status"></param>
        public void Pumpe_Boiler(bool status)
        {
            if (WiringPiAvailable)
            {
                if (status)
                    GPIO.digitalWrite(pump_boiler, (int)GPIO.GPIOpinvalue.Low);
                else
                    GPIO.digitalWrite(pump_boiler, (int)GPIO.GPIOpinvalue.High);
            }
        }

        /// <summary>
        /// set the pin for Pumpe_HK HIGH or LOW via the status variable 
        /// </summary>
        /// <param name="status"></param>
        public void Pumpe_HK(bool status)
        {
            if (WiringPiAvailable)
            {
                if (status)
                    GPIO.digitalWrite(pump_hk, (int)GPIO.GPIOpinvalue.Low);
                else
                    GPIO.digitalWrite(pump_hk, (int)GPIO.GPIOpinvalue.High);
            }
        }

        /// <summary>
        /// set the pin for Mischer_AUF HIGH or LOW via the status variable
        /// </summary>
        /// <param name="status"></param>
        public void Mischer_AUF(bool status)
        {
            if (WiringPiAvailable)
            {
                if (status)
                    GPIO.digitalWrite(mischer_zu, (int)GPIO.GPIOpinvalue.Low);
                else
                    GPIO.digitalWrite(mischer_zu, (int)GPIO.GPIOpinvalue.High);
            }
        }

        /// <summary>
        /// set the pin for Mischer_ZU HIGH or LOW via the status variable
        /// </summary>
        /// <param name="status"></param>
        public void Mischer_ZU(bool status)
        {
            if (WiringPiAvailable)
            {
                if (status)
                    GPIO.digitalWrite(mischer_zu, (int)GPIO.GPIOpinvalue.Low);
                else
                    GPIO.digitalWrite(mischer_zu, (int)GPIO.GPIOpinvalue.High);
            }
        }

        #endregion set pins


        //------------------------------------------------- HELPER METHODES -----------------------------------------------------------
        //checks if a unix platform and gpio pins are available
        private bool CheckForWiringPiSetuPhys()
        {
            if (Environment.OSVersion.Platform.ToString() == "Unix")
            {
                // The WiringPiSetup method is static and returns either true or false
                // Any value less than 0 represents a failure
                if (Init.WiringPiSetupPhys() >= 0)
                    return true;
                else
                {
                    //ensures that it initializes the GPIO interface and reports ready to work. We will use Physical Pin Numbers
                    MessageBox.Show($"Unable to get the gpio interface and reports to work\nWiringPi Error", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No Unix Platform detected in WiringPi Setup", "Error", MessageBoxButtons.OK);
                return false;
            }

        }


        /// <summary>
        /// used at startup to test all the gpio pins functionality
        /// </summary>
        private void StartUP()
        {
            Thread.Sleep(500);
            GPIO.digitalWrite(quelle, (int)GPIO.GPIOpinvalue.Low);
            Thread.Sleep(250);
            GPIO.digitalWrite(pump_boiler, (int)GPIO.GPIOpinvalue.Low);
            Thread.Sleep(250);
            GPIO.digitalWrite(pump_hk, (int)GPIO.GPIOpinvalue.Low);
            Thread.Sleep(250);
            GPIO.digitalWrite( mischer_auf, (int)GPIO.GPIOpinvalue.Low);
            Thread.Sleep(250);
            GPIO.digitalWrite(mischer_zu, (int)GPIO.GPIOpinvalue.Low);
            Thread.Sleep(500);
            GPIO.digitalWrite(quelle, (int)GPIO.GPIOpinvalue.High);
            GPIO.digitalWrite(pump_boiler, (int)GPIO.GPIOpinvalue.High);
            GPIO.digitalWrite(pump_hk, (int)GPIO.GPIOpinvalue.High);
            GPIO.digitalWrite( mischer_auf, (int)GPIO.GPIOpinvalue.High);
            GPIO.digitalWrite(mischer_zu, (int)GPIO.GPIOpinvalue.High);           
        }


        /// <summary>
        /// dispose all the gpio pins when the application is closed
        /// </summary>
        public void DisposeOpenConnections()
        {
            if (WiringPiAvailable)
            {
                GPIO.digitalWrite(quelle, (int)GPIO.GPIOpinvalue.High);
                GPIO.digitalWrite(pump_boiler, (int)GPIO.GPIOpinvalue.High);
                GPIO.digitalWrite(pump_hk, (int)GPIO.GPIOpinvalue.High);
                GPIO.digitalWrite(mischer_auf, (int)GPIO.GPIOpinvalue.High);
                GPIO.digitalWrite(mischer_zu, (int)GPIO.GPIOpinvalue.High);
            }
        }

    }
}
