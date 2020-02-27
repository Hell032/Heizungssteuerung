using System;
using System.Drawing;
using System.Windows.Forms;

namespace Heizungsregelung.Views.Function_Views
{
    public partial class Anti_Freeze : UserControl
    {

        //variable used across the form to display the status of the selected function
        public bool AntiFreezeON = false;

        public Anti_Freeze()
        {
            InitializeComponent();

            this.Visible = false;
            this.BackColor = Color.Transparent;
        }

        private void Anti_Freeze_ON_OFF_Switch_CheckedChanged(object sender, EventArgs e)
        {
            //switch the variable according to the toggle button
            if (Anti_Freeze_ON_OFF_Switch.Checked)
                AntiFreezeON = true;
            else
                AntiFreezeON = false;
        }
    }
}
