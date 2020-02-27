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

        //variable used across the form to display the status of the selected function
        public bool TagON = false;

        public Tag_Nacht()
        {
            InitializeComponent();
            this.Visible = false;
            this.BackColor = Color.Transparent;
        }

        private void Tag_Nacht_ON_OFF_Switch_CheckedChanged(object sender, EventArgs e)
        {
            //switch the variable according to the toggle button
            if (Tag_Nacht_ON_OFF_Switch.Checked)
                TagON = true;
            else
                TagON = false;
        }
    }
}
