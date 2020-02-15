using System;
using System.Drawing;
using System.Windows.Forms;

namespace diplwinform_v1_1
{
    public partial class Menu : Form
    {
        public Menu()
        {


            InitializeComponent();

            this.MenuPanel.Controls.Add(Program.SetupForm);


            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;

            this.TopLevel = true;

            //--------------------dont delete--------------------
            //somwhow needed to load the background
            this.AutoScroll = true;

            //get the size of the display and set the form to it
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.Bounds;
            this.Size = new Size(area.Width, area.Height);


            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            //set window size to maximum
            this.WindowState = FormWindowState.Maximized;

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

        private void TempButton_Click(object sender, EventArgs e)
        {

        }
    }
}
