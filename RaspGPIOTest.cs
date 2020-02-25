using System;
using System.Drawing;
using System.Windows.Forms;
using WiringPi;


namespace RaspGPIOTest
{
    public partial class Form1 : Form
    {
        //flags for the ui buttons
        public static bool gpio0;
        public static bool gpio1;
        public static bool gpio2;
        public static bool gpio3;
        public static bool gpio4;

        //set physical gpio pins 
        public static int pin0 = 29;
        public static int pin1 = 31;
        public static int pin2 = 33;
        public static int pin3 = 35;
        public static int pin4 = 37;


        public static bool WiringPiAvailable
        {
            get;
            set;
        }

        public Form1()
        {
            if (CheckForWiringPiSetuPhys()) WiringPiAvailable = true;
            else WiringPiAvailable = false;
            InitializeComponent();

            gpio0 = false;
            gpio1 = false;
            gpio2 = false;
            gpio3 = false;
            gpio4 = false;

            GPIO_0.BackColor = Color.Red;
            GPIO_1.BackColor = Color.Red;
            GPIO_2.BackColor = Color.Red;
            GPIO_3.BackColor = Color.Red;
            GPIO_4.BackColor = Color.Red;



            if (WiringPiAvailable)
            {
                GPIO.pinMode(pin0, (int)GPIO.GPIOpinmode.Output);
                GPIO.pinMode(pin1, (int)GPIO.GPIOpinmode.Output);
                GPIO.pinMode(pin2, (int)GPIO.GPIOpinmode.Output);
                GPIO.pinMode(pin3, (int)GPIO.GPIOpinmode.Output);
                GPIO.pinMode(pin4, (int)GPIO.GPIOpinmode.Output);
            }

            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
        }

        #region Buttons 

        private void GPIO_0_Click(object sender, EventArgs e)
        {
            //Place the LED on GPIO 5 (Physical Pin 29)
            const int redLedPin = 29;

            if (!gpio0)
            {
                GPIO_0.BackColor = Color.Green;
                gpio0 = true;

                if (WiringPiAvailable)
                    GPIO.digitalWrite(pin0, (int)GPIO.GPIOpinvalue.Low);
            }
            else
            {
                GPIO_0.BackColor = Color.Red;
                gpio0 = false;

                if (WiringPiAvailable)
                    GPIO.digitalWrite(pin0, (int)GPIO.GPIOpinvalue.High);
            }
        }

        private void GPIO_1_Click(object sender, EventArgs e)
        {
            if (!gpio1)
            {
                GPIO_1.BackColor = Color.Green;
                gpio1 = true;

                if (WiringPiAvailable)
                    GPIO.digitalWrite(pin1, (int)GPIO.GPIOpinvalue.Low);
            }
            else
            {
                GPIO_1.BackColor = Color.Red;
                gpio1 = false;

                if (WiringPiAvailable)
                    GPIO.digitalWrite(pin1, (int)GPIO.GPIOpinvalue.High);
            }
        }

        private void GPIO_2_Click(object sender, EventArgs e)
        {
            if (!gpio2)
            {
                GPIO_2.BackColor = Color.Green;
                gpio2 = true;

                if (WiringPiAvailable)
                    GPIO.digitalWrite(pin2, (int)GPIO.GPIOpinvalue.Low);
            }
            else
            {
                GPIO_2.BackColor = Color.Red;
                gpio2 = false;

                if (WiringPiAvailable)
                    GPIO.digitalWrite(pin2, (int)GPIO.GPIOpinvalue.High);
            }
        }

        private void GPIO_3_Click(object sender, EventArgs e)
        {
            if (!gpio3)
            {
                GPIO_3.BackColor = Color.Green;
                gpio3 = true;

                if (WiringPiAvailable)
                    GPIO.digitalWrite(pin3, (int)GPIO.GPIOpinvalue.Low);
            }
            else
            {
                GPIO_3.BackColor = Color.Red;
                gpio3 = false;

                if (WiringPiAvailable)
                    GPIO.digitalWrite(pin3, (int)GPIO.GPIOpinvalue.High);
            }
        }

        private void GPIO_4_Click(object sender, EventArgs e)
        {
            if (!gpio4)
            {
                GPIO_4.BackColor = Color.Green;
                gpio4 = true;

                if (WiringPiAvailable)
                    GPIO.digitalWrite(pin4, (int)GPIO.GPIOpinvalue.Low);
            }
            else
            {
                GPIO_4.BackColor = Color.Red;
                gpio4 = false;

                if (WiringPiAvailable)
                    GPIO.digitalWrite(pin4, (int)GPIO.GPIOpinvalue.High);
            }
        }

        #endregion

        //------------------------------------------------- HELPER ---- METHODE -----------------------------------------------------------
        public bool CheckForWiringPiSetuPhys()
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

    }
}
