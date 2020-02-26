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
            this.BeginInvoke((Action)delegate
            {
                if (Anti_Freeze_ON_OFF_Switch.Checked)
                {
                    Program.TemperaturesForm.AntiFreezeON = false;
                    if (Program.MenuForm.Active_Function_Label.Text.Contains("A-F"))
                        Program.MenuForm.Active_Function_Label.Text.Replace("A-F", " ");
                }
                else
                {
                    Program.TemperaturesForm.AntiFreezeON = true;
                    if (Program.MenuForm.Active_Function_Label.Text != " " || !Program.MenuForm.Active_Function_Label.Text.Contains("A-F"))
                        Program.MenuForm.Active_Function_Label.Text += " | A-F";
                }

            });
            
        }
    }
}
