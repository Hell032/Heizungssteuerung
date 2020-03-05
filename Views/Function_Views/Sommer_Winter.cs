using System;
using System.Drawing;
using System.Windows.Forms;

namespace Heizungsregelung.Views.Function_Views
{
    public partial class Sommer_Winter : UserControl
    {
        //variable used across the form to display the status of the selected function
        public bool SommerON = false;

        public Sommer_Winter()
        {
            InitializeComponent();

            this.Visible = false;
            this.BackColor = Color.Transparent;
        }

        private void Sommer_Winter_ON_OFF_Switch_CheckedChanged(object sender, EventArgs e)
        {
            //switch the variable according to the toggle button
            if (Sommer_Winter_ON_OFF_Switch.Checked)
                SommerON = true;
            else
                SommerON = false;
        }

    }
}
