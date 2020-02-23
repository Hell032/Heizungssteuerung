﻿using System;
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

namespace diplwinform_v1_1.Views
{
    public partial class Temperatures : UserControl
    {

        Calculations myCalculations;

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

            myCalculations = new Calculations();

            //AusentempLabel.Text = "0";
            //VLQuelleLabel.Text = "0";
            //VLHKLabel.Text = "0";
            //BoilertempLabel.Text = "0";
        }



        //---------------------------------------------variables--------------------------------------

        //---------------------------------------------private----------------------------------------
        private string m_außenTemp, m_quelleTemp, m_hkTemp, m_boilerTemp, m_raumTemp;

        private Thread tempthread;


        //---------------------------------------------public-----------------------------------------

        public string AußenTemp_Mittel
        {
            get => myCalculations.AußenTemp_Mittelwert.ToString();
            set => myCalculations.AußenTemp_Mittelwert = int.Parse(value);
        }

        public string QuellenTemp_Soll
        {
            get => myCalculations.QuellenTemp_Soll.ToString();
            set => myCalculations.QuellenTemp_Soll = int.Parse(value);
        }

        public string HKTemp_Soll
        {
            get => myCalculations.HKTemp_Soll.ToString();
            set => myCalculations.HKTemp_Soll = int.Parse(value);
        }

        public string BoilerTemp_Soll
        {
            get => myCalculations.BoilerTemp_Soll.ToString();
            set => myCalculations.BoilerTemp_Soll = int.Parse(value);
        }





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
                        Setup.mySerialPort.DiscardOutBuffer();
                        data = Setup.mySerialPort.ReadLine();
                        //data = "34\t65\t21\t48";
                        string[] delimiter = { "\t" };
                        pieces = data.Split(delimiter, StringSplitOptions.None);


                        m_außenTemp = pieces[0];
                        m_quelleTemp = pieces[1];
                        m_hkTemp = pieces[2];
                        m_boilerTemp = pieces[3];

                        AußenTemp_Mittel = m_außenTemp;
                        QuellenTemp_Soll = m_quelleTemp;
                        HKTemp_Soll = m_hkTemp;
                        BoilerTemp_Soll = m_boilerTemp;

                        WriteToLabels();  

                        //Thread.Sleep(100);
                        Debug.WriteLine("Working The Thread");
                    }
                    catch (Exception)
                    {
                        Debug.WriteLine("Unable To Read From SerialPort");
                    }
                }
                else
                {
                    Debug.WriteLine("SerialPort not open");
                }


                ///-----------------------------------------for debuging
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
            this.BeginInvoke((Action)delegate
            {
                //set ist werte labels
                Außentemp_Ist_Label.Text = m_außenTemp + " °C";
                Quellentemp_Ist_Label.Text = m_quelleTemp + " °C";
                HKtemp_Ist_Label.Text = m_hkTemp + " °C";
                Boilertemp_Ist_Label.Text = m_boilerTemp + " °C";

                //set soll werte labels
                Außentemp_Mittel_Label.Text = AußenTemp_Mittel + " °C";
                Quellentemp_Soll_Label.Text = QuellenTemp_Soll + " °C";
                HKtemp_Soll_Label.Text = HKTemp_Soll + " °C";
                Boilertemp_Soll_Label.Text = BoilerTemp_Soll + " °C";

            });

        }

    }
}
