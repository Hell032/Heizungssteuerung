using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplwinform_v1_1.Views.Function_Views
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



        }
    }
}
