﻿using System;
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
            this.BackColor = 

            //this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.Transparent;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.Transparent , e.ClipRectangle);
        }

    }
}
