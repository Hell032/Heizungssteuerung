﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplwinform_v1_1.Views
{
    public partial class Temperatures : UserControl
    {
        public Temperatures()
        {
            InitializeComponent();

            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.Visible = false;
            this.BackColor = Color.Transparent;
        }
    }
}
