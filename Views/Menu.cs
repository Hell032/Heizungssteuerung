﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace diplwinform_v1_1
{
    public partial class Menu : Form
    {
        public Menu()
        {

            InitializeComponent();


            //add forms to panel in menu form
            this.FormPanel.Controls.Add(Program.SetupForm);
            this.FormPanel.Controls.Add(Program.FunctionsForm);
            this.FormPanel.Controls.Add(Program.TemperaturesForm);
            this.FormPanel.Controls.Add(Program.SimulationForm);

            SetSimulationLabels(false);

            //show no window bar
            this.ControlBox = false;

            //--------------------dont delete---------------------------------
            //somwhow needed to load the background
            this.AutoScroll = true;

            //Screen myScreen = Screen.PrimaryScreen.Bounds.Width;
            //Rectangle area = myScreen.Bounds;
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);


            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.TopLevel = true;

            //set window size to maximum
            this.WindowState = FormWindowState.Maximized;

        }

        //---------------------------------------------click events--------------------------------------


        /// <summary>
        /// shwos the temperatures form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TempButton_Click(object sender, EventArgs e)
        {
            SetSimulationLabels(false);

            Program.SetupForm.Visible = false;
            Program.TemperaturesForm.Visible = true;
            Program.FunctionsForm.Visible = false;
            Program.SimulationForm.Visible = false;

        }


        /// <summary>
        /// shows the setup form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetupButton_Click(object sender, EventArgs e)
        {
            SetSimulationLabels(false);

            Program.SetupForm.Visible = true;
            Program.TemperaturesForm.Visible = true;
            Program.FunctionsForm.Visible = false;
            Program.SimulationForm.Visible = false;
        }


        /// <summary>
        /// shows the functions form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FunctionsButton_Click(object sender, EventArgs e)
        {
            SetSimulationLabels(false);

            Program.SetupForm.Visible = false;
            Program.TemperaturesForm.Visible = false;
            Program.FunctionsForm.Visible = true;
            Program.SimulationForm.Visible = false;
        }


        /// <summary>
        /// enters the simulation mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterSimulation_DoubleClick(object sender, EventArgs e)
        {
            SetSimulationLabels(true);
            
            Program.SetupForm.Visible = false;
            Program.TemperaturesForm.Visible = false;
            Program.FunctionsForm.Visible = false;
            Program.SimulationForm.Visible = true;
            Program.SimulationForm.Enabled = true;
            Program.SimulationForm.Dock = DockStyle.Fill;
        }


        /// <summary>
        /// exits the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //-------------------------------------- helper methodes ---------------------------------------

        /// <summary>
        /// set labels for Simulation and ger site of various control elements
        /// </summary>
        /// <param name="status"></param>
        private void SetSimulationLabels(bool status)
        {
            gesamtlabel.Visible = status;
            gesamtheight.Visible = status;
            gesamtwidth.Visible = status;

            Formpanellabel.Visible = status;
            Formpanelheight.Visible = status;
            Formpanelwidth.Visible = status;

            MenuPanellabel.Visible = status;
            MenuPanelHeight.Visible = status;
            MenuPanelWidth.Visible = status;

            if (status)
            {
                gesamtheight.Text = this.Size.Height.ToString();
                gesamtwidth.Text = this.Size.Width.ToString();

                Formpanelheight.Text = FormPanel.Size.Height.ToString();
                Formpanelwidth.Text = FormPanel.Size.Width.ToString();

                MenuPanelHeight.Text = MenuPanel.Size.Height.ToString();
                MenuPanelWidth.Text = MenuPanel.Size.Width.ToString();
            }

        }

    }
}
