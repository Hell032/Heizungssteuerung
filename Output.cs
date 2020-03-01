using System;
using System.Threading;
using System.Windows.Forms;
using WiringPi;

namespace Heizungsregelung
{
    class Output
    {

        //set physical gpio pins 
        private static int pin0 = 29;
        private static int pin1 = 31;
        private static int pin2 = 33;
        private static int pin3 = 35;
        private static int pin4 = 37;


        private static bool WiringPiAvailable
        {
            get;
            set;
        }


        public Output()
        {
            if (CheckForWiringPiSetuPhys()) WiringPiAvailable = true;
            else WiringPiAvailable = false;

            if (WiringPiAvailable)
            {
                GPIO.pinMode(pin0, (int)GPIO.GPIOpinmode.Output);
                GPIO.pinMode(pin1, (int)GPIO.GPIOpinmode.Output);
                GPIO.pinMode(pin2, (int)GPIO.GPIOpinmode.Output);
                GPIO.pinMode(pin3, (int)GPIO.GPIOpinmode.Output);
                GPIO.pinMode(pin4, (int)GPIO.GPIOpinmode.Output);

                GPIO.digitalWrite(pin0, (int)GPIO.GPIOpinvalue.High);
                GPIO.digitalWrite(pin1, (int)GPIO.GPIOpinvalue.High);
                GPIO.digitalWrite(pin2, (int)GPIO.GPIOpinvalue.High);
                GPIO.digitalWrite(pin3, (int)GPIO.GPIOpinvalue.High);
                GPIO.digitalWrite(pin4, (int)GPIO.GPIOpinvalue.High);

                StartUP();
            }



        }

        public void Anforderung_Quelle(bool status)
        {
            if (WiringPiAvailable) 
            {
                if (status)
                    GPIO.digitalWrite(pin0, (int)GPIO.GPIOpinvalue.Low);
                else
                    GPIO.digitalWrite(pin0, (int)GPIO.GPIOpinvalue.High);
            }
        }
        public void Pumpe_Boiler(bool status)
        {
            if (WiringPiAvailable)
            {
                if (status)
                    GPIO.digitalWrite(pin1, (int)GPIO.GPIOpinvalue.Low);
                else
                    GPIO.digitalWrite(pin1, (int)GPIO.GPIOpinvalue.High);
            }
        }
        public void Pumpe_HK(bool status)
        {
            if (WiringPiAvailable)
            {
                if (status)
                    GPIO.digitalWrite(pin2, (int)GPIO.GPIOpinvalue.Low);
                else
                    GPIO.digitalWrite(pin2, (int)GPIO.GPIOpinvalue.High);
            }
        }
        public void Mischer_AUF(bool status)
        {
            if (WiringPiAvailable)
            {
                if (status)
                    GPIO.digitalWrite(pin3, (int)GPIO.GPIOpinvalue.Low);
                else
                    GPIO.digitalWrite(pin3, (int)GPIO.GPIOpinvalue.High);
            }
        }
        public void Mischer_ZU(bool status)
        {
            if (WiringPiAvailable)
            {
                if (status)
                    GPIO.digitalWrite(pin4, (int)GPIO.GPIOpinvalue.Low);
                else
                    GPIO.digitalWrite(pin4, (int)GPIO.GPIOpinvalue.High);
            }
        }



        //------------------------------------------------- HELPER ---- METHODE -----------------------------------------------------------
        private bool CheckForWiringPiSetuPhys()
        {
            if (Environment.OSVersion.Platform.ToString() == "Unix")
            {
                // The WiringPiSetup method is static and returns either true or false
                // Any value less than 0 represents a failure
                if (Init.WiringPiSetupPhys() >= 0) return true;
                else
                {
                    //ensures that it initializes the GPIO interface and reports ready to work. We will use Physical Pin Numbers
                    MessageBox.Show($"Unable to get the gpio interface and reports to work", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No Unix Platform detected", "Error", MessageBoxButtons.OK);
                return false;
            }

        }

        private void StartUP()
        {
                Thread.Sleep(1000);
                GPIO.digitalWrite(pin0, (int)GPIO.GPIOpinvalue.Low);
                Thread.Sleep(250);
                GPIO.digitalWrite(pin1, (int)GPIO.GPIOpinvalue.Low);
                Thread.Sleep(250);
                GPIO.digitalWrite(pin2, (int)GPIO.GPIOpinvalue.Low);
                Thread.Sleep(250);
                GPIO.digitalWrite(pin3, (int)GPIO.GPIOpinvalue.Low);
                Thread.Sleep(250);
                GPIO.digitalWrite(pin4, (int)GPIO.GPIOpinvalue.Low);
                Thread.Sleep(1000);
                GPIO.digitalWrite(pin0, (int)GPIO.GPIOpinvalue.High);
                Thread.Sleep(250);
                GPIO.digitalWrite(pin1, (int)GPIO.GPIOpinvalue.High);
                Thread.Sleep(250);
                GPIO.digitalWrite(pin2, (int)GPIO.GPIOpinvalue.High);
                Thread.Sleep(250);
                GPIO.digitalWrite(pin3, (int)GPIO.GPIOpinvalue.High);
                Thread.Sleep(250);
                GPIO.digitalWrite(pin4, (int)GPIO.GPIOpinvalue.High);
                Thread.Sleep(1000);

        }

    }
}
