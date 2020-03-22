using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Heizungsregelung.Views
{


    public partial class Simulation : UserControl
    {
        public Simulation()
        {
            InitializeComponent();

            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.Visible = false;
            this.BackColor = Color.Transparent;


        }

        /// <summary>
        /// methode that writes to labels via  invoke 
        /// </summary>
        public void WriteToSimulationFormLabels()
        {
                //change the labels asynchronously of the TemperatureForm UI Thread
                this.BeginInvoke((Action)delegate
                {
                    #region write to labels on simulation form

                    #region labels 
                    //Write ist werte To Simulation form labels
                    this.Außentemp_Label.Text = Program.myCalculations.AußenTemp_Ist + " °C";
                    this.Ist_Quelle_Label.Text = Program.myCalculations.VorlaufQuelle_Ist + " °C";
                    this.Ist_HK_Label.Text = Program.myCalculations.VorlaufHeizkreis_Ist + " °C";
                    this.Ist_Boiler_Label.Text = Program.myCalculations.BoilerTemp_Ist + " °C";
                    this.Wasserverbrauch_label.Text = Program.myCalculations.Wasserverbrauch + " %";
                    this.RuecklaufHK_Ist_label.Text = Program.myCalculations.RueklaufHK_Ist + " °C";

                    //write soll werte to simulation form labels
                    this.Soll_Quelle_Label.Text = Program.myCalculations.VorlaufQuelle_Soll + " °C";
                    this.Soll_HK_Label.Text = Program.myCalculations.VorlaufHeizkreis_Soll + " °C";
                    this.Soll_Boiler_Label.Text = Program.myCalculations.BoilerTemp_Soll + " °C";
                    this.Raumtemp_Label.Text = Program.myCalculations.RaumTemp_Soll + " °C";
                    #endregion labels

                    #region Anforderung Quelle
                    if (Program.myCalculations.Anforderung_Quelle)
                        this.Anforderung_Quelle_Label.BackColor = Color.Green;
                    else
                        this.Anforderung_Quelle_Label.BackColor = Color.Red;
                    #endregion Anforderung Quelle

                    #region Pumpe Boiler
                    if (Program.myCalculations.Pumpe_Boiler)
                        this.Pumpe_Boiler_Label.BackColor = Color.Green;
                    else
                        this.Pumpe_Boiler_Label.BackColor = Color.Red;
                    #endregion Pumpe HK

                    #region Pumpe HK

                    if (Program.myCalculations.Pumpe_HK)
                        this.Pumpe_HK_Label.BackColor = Color.Green;
                    else
                        this.Pumpe_HK_Label.BackColor = Color.Red;
                    #endregion Pumpe HK

                    #region Mischer HK
                    //handle mischer auf
                    if (Program.myCalculations.Mischer_Auf_HK)
                        this.HK_Mischer_Auf_Label.BackColor = Color.Green;
                    else
                        this.HK_Mischer_Auf_Label.BackColor = Color.Red;

                    //handle mischer auf
                    if (Program.myCalculations.Mischer_Zu_HK)
                        this.HK_Mischer_Zu_Label.BackColor = Color.Green;
                    else
                        this.HK_Mischer_Zu_Label.BackColor = Color.Red;

                    Mischer_offen_Prozent_label.Text = Program.myCalculations.Mischer_offen.ToString() + " %";

                    #endregion Mischer HK

                    #endregion write to labels on simulation form

                });
         
        }

    }
}
