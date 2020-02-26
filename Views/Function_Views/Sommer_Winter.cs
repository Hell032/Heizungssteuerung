using System;
using System.Drawing;
using System.Windows.Forms;

namespace Heizungsregelung.Views.Function_Views
{
    public partial class Sommer_Winter : UserControl
    {
        public Sommer_Winter()
        {
            InitializeComponent();

            this.Visible = false;
            this.BackColor = Color.Transparent;
        }

        private void Sommer_Winter_ON_OFF_Switch_CheckedChanged(object sender, EventArgs e)
        {

            this.BeginInvoke((Action)delegate
            {
                if (Sommer_Winter_ON_OFF_Switch.Checked)
                {
                    Program.TemperaturesForm.SommerON = false;
                    if (Program.MenuForm.Active_Function_Label.Text.Contains("S/W"))
                        Program.MenuForm.Active_Function_Label.Text.Replace("S/W", " ");
                }
                else
                {
                    Program.TemperaturesForm.SommerON = true;
                    if (Program.MenuForm.Active_Function_Label.Text != " " || !Program.MenuForm.Active_Function_Label.Text.Contains("S/W"))
                        Program.MenuForm.Active_Function_Label.Text += " | S/W";
                }

            });
        }
    }
}
