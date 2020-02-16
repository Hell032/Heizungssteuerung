using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplwinform_v1_1.Views
{
    public partial class Temperatures : Form
    {
        public Temperatures()
        {
            InitializeComponent();


            //needed for transparent form
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //SetStyle(ControlStyles.Opaque, true);
            //this.BackColor = Color.Transparent;
            //this.FormBorderStyle = FormBorderStyle.None;


            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.Visible = false;



        }
    }
}
