using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Heizungsregelung.Views
{
    public partial class Temperatures : UserControl
    {

        //---------------------------------------------ctor--------------------------------------
        /// <summary>
        /// ctor
        /// </summary>
        public Temperatures()
        {
            InitializeComponent();

            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.Visible = false;
            this.BackColor = Color.Transparent;

            //-----------------------------------------------------------TODO----------------------------------------
            //put serialstuff in a seperate class where all inputs come together

            tempthread = new Thread(new ThreadStart(TempThread));
            tempthread.IsBackground = true;
            tempthread.Priority = ThreadPriority.Lowest;
            tempthread.Start();

            //AusentempLabel.Text = "0";
            //VLQuelleLabel.Text = "0";
            //VLHKLabel.Text = "0";
            //BoilertempLabel.Text = "0";

        }



        //---------------------------------------------variables--------------------------------------

        //---------------------------------------------private----------------------------------------
        private string m_außenTemp = "X", m_quelleTemp = "X", m_hkTemp = "X", m_boilerTemp = "X";

        private Thread tempthread;


        //---------------------------------------------public-----------------------------------------

        //variables to display which function is on and display on menu form 
        public bool AntiFreezeON;

        //---------------------------------------------methodes--------------------------------------
        /// <summary>
        /// methode which is used in the tempthread
        /// </summary>
        private void TempThread()
        {
            string data;
            string[] pieces;
            System.IO.Ports.SerialPort mySerialPort = Setup.mySerialPort;
            mySerialPort.ReadTimeout = 500;

            while (true)
            {
                if (Setup.mySerialPort.IsOpen)
                {
                    try
                    {
                        //gets the simulated values from the serialport
                        Setup.mySerialPort.DiscardOutBuffer();
                        data = Setup.mySerialPort.ReadLine();

                        //splits the data via a delimiter string into a data array
                        string[] delimiter = { "\t" };
                        pieces = data.Split(delimiter, StringSplitOptions.None);

                        //writes the splited data array to the 
                        m_außenTemp = pieces[0];
                        m_quelleTemp = pieces[1];
                        m_hkTemp = pieces[2];
                        m_boilerTemp = pieces[3];

                        //writes the simulated values to the variables used to perform the calculations
                        Program.myCalculations.AußenTemp_Ist = int.Parse(m_außenTemp);
                        Program.myCalculations.VorlaufQuelle_Ist = int.Parse(m_quelleTemp);
                        //---------------------------------------------------------------must change back to the correct variables
                        //---------------------------------------------------------------only for debugging
                        
                        Program.myCalculations.VorlaufHeizkreis_Ist = int.Parse(m_quelleTemp);
                        Program.myCalculations.BoilerTemp_Ist = int.Parse(m_quelleTemp);

                        //Thread.Sleep(100);
                        //Debug.WriteLine("Working The Thread");
                    }
                    catch (Exception)
                    {
                        Debug.WriteLine("Unable To Read From SerialPort");
                    }

                    WriteToLabels();
 
                }
                else
                {
                    Debug.WriteLine("SerialPort not open");
                }

                //for debuging
                #region debuging
                /*
                for (int i = 0; i < 35; i++)
                {
                    Debug.WriteLine(i);

                    this.BeginInvoke((Action)delegate
                    {
                        AusentempLabel.Text = i.ToString();
                        VLQuelleLabel.Text = i.ToString();
                        VLHKLabel.Text = i.ToString();
                        BoilertempLabel.Text = i.ToString();
                    });

                    Thread.Sleep(750);
                }

                /*
                AusentempLabel.BeginInvoke(delegate (
                    this.Text = m_außenTemp
                    ));
                */
                #endregion

            }
        }

        /// <summary>
        /// methode that writes to labels via  invoke 
        /// </summary>
        private void WriteToLabels()
        {
            //change the labels asynchronously of the TemperatureForm UI Thread
            _ = this.BeginInvoke((Action)delegate
              {
                #region write to labels on temperature form
                //set ist werte labels
                Außentemp_Ist_Label.Text = m_außenTemp + " °C";
                  Quellentemp_Ist_Label.Text = m_quelleTemp + " °C";
                //----------------------------------------------------------change values for debugging-------------------------
                HKtemp_Ist_Label.Text = m_quelleTemp + " °C";
                  Boilertemp_Ist_Label.Text = m_quelleTemp + " °C";

                //set soll werte labels
                Außentemp_Mittel_Label.Text = Program.myCalculations.AußenTemp_Mittelwert + " °C";
                  Quellentemp_Soll_Label.Text = Program.myCalculations.VorlaufQuelle_Soll + " °C";
                  HKtemp_Soll_Label.Text = Program.myCalculations.VorlaufHeizkreis_Soll + " °C";
                  Boilertemp_Soll_Label.Text = Program.myCalculations.BoilerTemp_Soll + " °C";
                #endregion write to labels on temperature form

                #region write temperatures to labels on simulation form
                //Write ist werte To Simulation form labels
                Program.SimulationForm.Außentemp_Label.Text = Program.myCalculations.AußenTemp_Ist + " °C";
                  Program.SimulationForm.Ist_Quelle_Label.Text = Program.myCalculations.VorlaufQuelle_Ist + " °C";
                  Program.SimulationForm.Ist_HK_Label.Text = Program.myCalculations.VorlaufHeizkreis_Ist + " °C";
                  Program.SimulationForm.Ist_Boiler_Label.Text = Program.myCalculations.BoilerTemp_Ist + " °C";

                //write soll werte to simulation form labels
                Program.SimulationForm.Soll_Quelle_Label.Text = Program.myCalculations.VorlaufQuelle_Soll + " °C";
                  Program.SimulationForm.Soll_HK_Label.Text = Program.myCalculations.VorlaufHeizkreis_Soll + " °C";
                  Program.SimulationForm.Soll_Boiler_Label.Text = Program.myCalculations.BoilerTemp_Soll + " °C";
                  Program.SimulationForm.Raumtemp_Label.Text = Program.myCalculations.RaumTemp_Soll + " °C";
                #endregion write temperatures to labels on simulation form

                #region Anforderung Quelle
                if (Program.myCalculations.Anforderung_Quelle)
                  {
                      Program.SimulationForm.Anforderung_Quelle_Label.BackColor = Color.Green;
                      Program.SimulationForm.Anforderung_Quelle_Label.ForeColor = Color.Green;
                  }
                  else
                  {
                      Program.SimulationForm.Anforderung_Quelle_Label.BackColor = Color.Red;
                      Program.SimulationForm.Anforderung_Quelle_Label.ForeColor = Color.Red;
                  }
                #endregion Anforderung Quelle

                #region Pumpe HK
                if (Program.myCalculations.Pumpe_HK)
                  {
                      Program.SimulationForm.Pumpe_HK_Label.BackColor = Color.Green;
                      Program.SimulationForm.Pumpe_HK_Label.ForeColor = Color.Green;
                  }
                  else
                  {
                      Program.SimulationForm.Pumpe_HK_Label.BackColor = Color.Red;
                      Program.SimulationForm.Pumpe_HK_Label.ForeColor = Color.Red;
                  }
                #endregion Pumpe HK

                #region Mischer HK
                //handle mischer auf
                if (Program.myCalculations.Mischer_Auf_HK)
                  {
                      Program.SimulationForm.HK_Mischer_Auf_Label.BackColor = Color.Green;
                      Program.SimulationForm.HK_Mischer_Auf_Label.ForeColor = Color.Green;
                  }
                  else
                  {
                      Program.SimulationForm.HK_Mischer_Auf_Label.BackColor = Color.Red;
                      Program.SimulationForm.HK_Mischer_Auf_Label.ForeColor = Color.Red;
                  }

                //handle mischer auf
                if (Program.myCalculations.Mischer_Zu_HK)
                  {
                      Program.SimulationForm.HK_Mischer_Zu_Label.BackColor = Color.Green;
                      Program.SimulationForm.HK_Mischer_Zu_Label.ForeColor = Color.Green;
                  }
                  else
                  {
                      Program.SimulationForm.HK_Mischer_Zu_Label.BackColor = Color.Red;
                      Program.SimulationForm.HK_Mischer_Zu_Label.ForeColor = Color.Red;
                  }

                #endregion Mischer HK

                #region Pumpe Boiler
                if (Program.myCalculations.Pumpe_Boiler)
                  {
                      Program.SimulationForm.Pumpe_Boiler_Label.BackColor = Color.Green;
                      Program.SimulationForm.Pumpe_Boiler_Label.ForeColor = Color.Green;
                  }
                  else
                  {
                      Program.SimulationForm.Pumpe_Boiler_Label.BackColor = Color.Red;
                      Program.SimulationForm.Pumpe_Boiler_Label.ForeColor = Color.Red;
                  }
                #endregion Pumpe HK

                #region Menu active function label

                if (AntiFreezeON)
                  {
                      Program.MenuForm.Active_Function_Label.Text = "Anti-Freeze ";
                      Debug.WriteLine("AntiFreeze ON");
                  }
                  else
                  {
                      Program.MenuForm.Active_Function_Label.Text = "";
                      Debug.WriteLine("AntiFreeze OFF");
                  }


                #endregion menu active function label
            });

        }

    }
}
