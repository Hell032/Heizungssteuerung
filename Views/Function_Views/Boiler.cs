using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Heizungsregelung.Views.Function_Views
{
    public partial class Boiler : UserControl
    {

        public Boiler()
        {
            InitializeComponent();


            this.Visible = false;
            this.BackColor = Color.Transparent;

            //Set the up and down pictures for the buttons
            BoilerSoll_DOWN_Button.Image = new Bitmap(
                Program.MinusIm, 
                new Size(BoilerSoll_DOWN_Button.Bounds.Height, BoilerSoll_DOWN_Button.Bounds.Height)
                );
            BoilerSoll_UP_Button.Image = new Bitmap(
                Program.PlusIm, 
                new Size(BoilerSoll_UP_Button.Bounds.Height, BoilerSoll_UP_Button.Bounds.Height)
                );
            Hyterese_Boiler_DOWN.Image = new Bitmap(
               Program.MinusIm,
               new Size(Hyterese_Boiler_DOWN.Height, Hyterese_Boiler_DOWN.Bounds.Height)
               );
            Hyterese_Boiler_UP.Image = new Bitmap(
               Program.PlusIm,
               new Size(Hyterese_Boiler_UP.Bounds.Height, Hyterese_Boiler_UP.Bounds.Height)
               );

            BoilerSoll_Label.Text = Program.myCalculations.BoilerTemp_Soll + " °C";
            BoilerHysterese_Label.Text = Program.myCalculations.Boiler_Hysterese + " °C";
        }

        //BoilerSoll Button Events
        private void BoilerSoll_DOWN_Button_Click(object sender, EventArgs e)
        {
            Program.myCalculations.BoilerTemp_Soll--;
            this.BoilerSoll_Label.Text = Program.myCalculations.BoilerTemp_Soll + " °C";
            Debug.WriteLine("BoilerSoll_DOWN_Button_Click");
        }

        private void BoilerSoll_UP_Button_Click(object sender, EventArgs e)
        {
            Program.myCalculations.BoilerTemp_Soll++;
            this.BoilerSoll_Label.Text = Program.myCalculations.BoilerTemp_Soll + " °C";
            Debug.WriteLine("BoilerSoll_UP_Button_Click");
        }


        //Boiler Hysterese Click Events
        private void Boiler_Hyterese_DOWN_Click(object sender, EventArgs e)
        {
            Program.myCalculations.Boiler_Hysterese--;
            this.BoilerHysterese_Label.Text = Program.myCalculations.Boiler_Hysterese + " °C";
            Debug.WriteLine("Hyterese_Boiler_DOWN_Click");
        }

        private void Boiler_Hyterese_UP_Click(object sender, EventArgs e)
        {
            Program.myCalculations.Boiler_Hysterese++;
            this.BoilerHysterese_Label.Text = Program.myCalculations.Boiler_Hysterese + " °C";
            Debug.WriteLine("Hyterese_Boiler_UP_Click");
        }
    }
}
