using System;
using System.Drawing;
using System.Windows.Forms;

namespace Heizungsregelung.Views.Function_Views
{
    public partial class Anti_Freeze : UserControl
    {

        public Anti_Freeze()
        {
            InitializeComponent();

            this.Visible = false;
            this.BackColor = Color.Transparent;
        }

        private void Anti_Freeze_ON_OFF_Switch_CheckedChanged(object sender, EventArgs e)
        {
            if (Anti_Freeze_ON_OFF_Switch.Checked)
                Program.TemperaturesForm.AntiFreezeON = false;
            else
                Program.TemperaturesForm.AntiFreezeON = true;
        }
    }
}
