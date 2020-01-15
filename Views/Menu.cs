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

            // Define the border style of the form to a dialog box.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;

            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;

            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            // Display the form as a modal dialog box.
            //this.ShowDialog();


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
