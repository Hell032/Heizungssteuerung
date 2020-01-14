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
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();


            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            this.BackColor = Color.Transparent;

            //this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.Transparent;

            this.label1.BackColor = Color.Transparent;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent , e.ClipRectangle);
        }

    }


    class MyLabel : Label
    {
        public MyLabel()
    {
        this.SetStyle(ControlStyles.Opaque, true);
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
    }
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams parms = base.CreateParams;
            parms.ExStyle |= 0x20;  // Turn on WS_EX_TRANSPARENT
            return parms;
        }
    }
}
}
