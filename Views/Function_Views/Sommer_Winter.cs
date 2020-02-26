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
            if (Sommer_Winter_ON_OFF_Switch.Checked)
                Program.TemperaturesForm.SommerON = false;
            else
                Program.TemperaturesForm.SommerON = true;
        }
    }
}
