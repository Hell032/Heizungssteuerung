using System;
using System.Drawing;
using System.Windows.Forms;

namespace Heizungsregelung.Views.Function_Views
{
    public partial class Tag_Nacht : UserControl
    {
        //variable used across the form to display the status of the selected function
        public bool NachtON = false;

        public Tag_Nacht()
        {
            InitializeComponent();

            this.Visible = false;
            this.BackColor = Color.Transparent;

            //set pictures of buttons
            Tag_Nacht_DOWN_Button.Text = "";
            Tag_Nacht_DOWN_Button.Image = new Bitmap(Program.MinusIm, new Size(Tag_Nacht_DOWN_Button.Bounds.Height, Tag_Nacht_DOWN_Button.Bounds.Height - 5));

            Tag_Nacht_UP_Button.Text = "";
            Tag_Nacht_UP_Button.Image = new Bitmap(Program.PlusIm, new Size(Tag_Nacht_UP_Button.Bounds.Height, Tag_Nacht_UP_Button.Bounds.Height - 5));

            Tag_Nacht_Temp_Label.Text = "";
            Tag_Nacht_Temp_Label.Text = "- " + Program.myCalculations.Tag_Nacht_Abweichung + " °C";
        }

        private void Tag_Nacht_ON_OFF_Switch_CheckedChanged(object sender, EventArgs e)
        {
            //switch the variable according to the toggle button
            if (Tag_Nacht_ON_OFF_Switch.Checked)
                NachtON = true;
            else
                NachtON = false;
        }

        /// <summary>
        /// lowers the room temperature if night mode is activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tag_Nacht_DOWN_Button_Click(object sender, EventArgs e)
        {
            Program.myCalculations.Tag_Nacht_Abweichung--;
            this.Tag_Nacht_Temp_Label.Text = "- " + Program.myCalculations.Tag_Nacht_Abweichung + " °C";
        }


        /// <summary>
        /// sets the room temp higher if night mode is activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tag_Nacht_UP_Button_Click(object sender, EventArgs e)
        {
            Program.myCalculations.Tag_Nacht_Abweichung++;
            this.Tag_Nacht_Temp_Label.Text = "- " + Program.myCalculations.Tag_Nacht_Abweichung + " °C";
        }
    }
}
