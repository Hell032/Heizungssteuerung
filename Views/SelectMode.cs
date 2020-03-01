using System;
using System.Drawing;
using System.Windows.Forms;

namespace Heizungsregelung.Views
{
    public partial class SelectMode : Form
    {
        public bool SimulationMode;

        public SelectMode()
        {
            InitializeComponent();

            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RealData_CheckedChanged(object sender, EventArgs e)
        {
            SimulationData.Checked = false;
            SimulationMode = false;
            this.Visible = false;
        }

        private void SimulationData_CheckedChanged(object sender, EventArgs e)
        {
            RealData.Checked = false;
            SimulationMode = true;
            this.Visible = false;
        }
    }
}
