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
using System.IO.Ports;

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

        }


        //---------------------------------------------methodes--------------------------------------
        
        /// <summary>
        /// methode that writes to labels via  invoke 
        /// </summary>
        public void WriteToTemperatureFormLabels()
        {   
            //change the labels asynchronously of the TemperatureForm UI Thread
            this.BeginInvoke((Action) delegate
            {
                #region write to labels on temperature form

                //set ist werte labels
                Außentemp_Ist_Label.Text = Program.myCalculations.AußenTemp_Ist + " °C";
                Quellentemp_Ist_Label.Text = Program.myCalculations.VorlaufQuelle_Ist + " °C";
                HKtemp_Ist_Label.Text = Program.myCalculations.VorlaufHeizkreis_Ist + " °C";
                Boilertemp_Ist_Label.Text = Program.myCalculations.BoilerTemp_Ist + " °C";

                //set soll werte labels
                Außentemp_Mittel_Label.Text = Program.myCalculations.AußenTemp_Mittelwert + " °C";
                Quellentemp_Soll_Label.Text = Program.myCalculations.VorlaufQuelle_Soll + " °C";
                HKtemp_Soll_Label.Text = Program.myCalculations.VorlaufHeizkreis_Soll + " °C";
                Boilertemp_Soll_Label.Text = Program.myCalculations.BoilerTemp_Soll + " °C";

                #endregion write to labels on temperature form
            });
        }

    }
}
