using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heizungsregelung.Views.Function_Views
{
    public partial class Tag_Nacht : UserControl
    {
        public Tag_Nacht()
        {
            InitializeComponent();
            this.Visible = false;
            this.BackColor = Color.Transparent;
        }

        private void Tag_Nacht_ON_OFF_Switch_CheckedChanged(object sender, EventArgs e)
        {

            this.BeginInvoke((Action)delegate
            {
                if (Tag_Nacht_ON_OFF_Switch.Checked)
                {
                    Program.TemperaturesForm.TagON = false;
                    if (Program.MenuForm.Active_Function_Label.Text.Contains("T/N"))
                        Program.MenuForm.Active_Function_Label.Text.Replace("T/N", " ");
                }
                else
                {
                    Program.TemperaturesForm.TagON = true;
                    if (Program.MenuForm.Active_Function_Label.Text != " " || !Program.MenuForm.Active_Function_Label.Text.Contains("T/N"))
                        Program.MenuForm.Active_Function_Label.Text += " | T/N";
                }

            });
        }
    }
}
