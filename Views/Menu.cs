using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplwinform_v1_1
{
    public partial class Menu : Form
    {
        public Menu()
        {

            InitializeComponent();

            this.MenuPanel.Controls.Add(Program.SetupForm);
        }



        //---------------------------------------------click events--------------------------------------
       

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetupButton_Click(object sender, EventArgs e)
        {
            Program.SetupForm.Visible = true;
        }

    }
}
