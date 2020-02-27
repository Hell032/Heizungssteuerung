﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heizungsregelung
{
    public partial class Menu : Form
    {
        private Thread StatusThread;

        public Menu()
        {
            //set size of program to fit the running operation system
            switch (Environment.OSVersion.Platform.ToString())
            {
                case "Win32NT":
                    this.Size = new Size(640, 480);
                    //MessageBox.Show("Win32NT");
                    break;
                case "Unix":
                    //this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                    this.WindowState = FormWindowState.Maximized;
                    //MessageBox.Show("Unix");
                    break;
                default:
                    this.Size = new Size(640, 480);
                    MessageBox.Show($"{Environment.OSVersion.Platform.ToString()} is not recogniced\nWindowsize is set to default");
                    break;
            }

            InitializeComponent();


            //add forms to panel in menu form
            this.FormPanel.Controls.Add(Program.SetupForm);
            this.FormPanel.Controls.Add(Program.FunctionsForm);
            this.FormPanel.Controls.Add(Program.TemperaturesForm);
            this.FormPanel.Controls.Add(Program.SimulationForm);


            //show no window bar
            this.ControlBox = false;

            //--------------------dont delete---------------------------------
            //somwhow needed to load the background
            this.AutoScroll = true;


            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.TopLevel = true;

            //set window size to maximum
            //this.WindowState = FormWindowState.Maximized;

            //set labels for debugging
            SetDebugLabels(false);

            RaumTemp_DOWN_Button.Text = "";
            RaumTemp_DOWN_Button.Image = new Bitmap(Program.MinusIm, new Size(RaumTemp_DOWN_Button.Bounds.Height, RaumTemp_DOWN_Button.Bounds.Height - 5));

            RaumTemp_UP_Button.Text = "";
            RaumTemp_UP_Button.Image = new Bitmap(Program.PlusIm, new Size(RaumTemp_UP_Button.Bounds.Height, RaumTemp_UP_Button.Bounds.Height - 5));

            this.CreateHandle();

            StatusThread = new Thread(new ThreadStart(WriteStatus));
            StatusThread.IsBackground = true;
            StatusThread.Priority = ThreadPriority.Lowest;
            StatusThread.Start();

        }

        //---------------------------------------------click events--------------------------------------
        #region Buttons

        /// <summary>
        /// shwos the temperatures form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TempButton_Click(object sender, EventArgs e)
        {
            SetDebugLabels(false);

            Program.SetupForm.Visible = false;
            Program.FunctionsForm.Visible = false;
            Program.SimulationForm.Visible = false;
            Program.GPIOTestForm.Visible = false;
            //-------------------------------------set visible form last to avoid rendering errors on raspberry 
            Program.TemperaturesForm.Visible = true;

        }

        //all the buttons that are on the menu 

        /// <summary>
        /// shows the setup form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetupButton_Click(object sender, EventArgs e)
        {
            SetDebugLabels(false);

            Program.TemperaturesForm.Visible = false;
            Program.FunctionsForm.Visible = false;
            Program.SimulationForm.Visible = false;
            Program.GPIOTestForm.Visible = false;
            //-------------------------------------set visible form last to avoid rendering errors on raspberry 
            Program.SetupForm.Visible = true;
        }


        /// <summary>
        /// shows the functions form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FunctionsButton_Click(object sender, EventArgs e)
        {
            SetDebugLabels(false);

            Program.SetupForm.Visible = false;
            Program.TemperaturesForm.Visible = false;
            Program.SimulationForm.Visible = false;
            Program.GPIOTestForm.Visible = false;

            //-------------------------------------set visible form last to avoid rendering errors on raspberry 
            Program.FunctionsForm.Visible = true;
        }


        /// <summary>
        /// enters the simulation mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterSimulation_Click(object sender, EventArgs e)
        {
            SetDebugLabels(false);
            
            Program.SetupForm.Visible = false;
            Program.TemperaturesForm.Visible = false;
            Program.FunctionsForm.Visible = false;

            Program.SimulationForm.Visible = true;
            Program.SimulationForm.Enabled = true;
            Program.SimulationForm.Dock = DockStyle.Fill;

            //if (!Program.GPIOTestForm.Visible || Program.GPIOTestForm.IsDisposed) Program.GPIOTestForm.Visible = true;

        }


        /// <summary>
        /// exits the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {   
            if(!Program.GPIOTestForm.IsDisposed) 
                Program.GPIOTestForm.Dispose();
            Application.Exit();
            Cursor.Show();
        }


        /// <summary>
        /// lowers the room temperature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RaumTemp_DOWN_Button_Click(object sender, EventArgs e)
        {
            Program.myCalculations.RaumTemp_Soll--;
            this.RaumTemp_Soll_Label.Text = Program.myCalculations.RaumTemp_Soll + " °C";
        }


        /// <summary>
        /// sets the room temp higher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RaumTemp_UP_Button_Click(object sender, EventArgs e)
        {
            Program.myCalculations.RaumTemp_Soll++;
            this.RaumTemp_Soll_Label.Text = Program.myCalculations.RaumTemp_Soll + " °C";
        }

#endregion Buttons


        //-------------------------------------- helper methodes ---------------------------------------

        /// <summary>
        /// set labels for Simulation and ger site of various control elements
        /// </summary>
        /// <param name="status"></param>
        private void SetDebugLabels(bool status)
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

            OS_label.Visible = status;

            if (status)
            {
                gesamtheight.Text = this.Size.Height.ToString();
                gesamtwidth.Text = this.Size.Width.ToString();

                Formpanelheight.Text = FormPanel.Size.Height.ToString();
                Formpanelwidth.Text = FormPanel.Size.Width.ToString();

                MenuPanelHeight.Text = MenuPanel.Size.Height.ToString();
                MenuPanelWidth.Text = MenuPanel.Size.Width.ToString();


                this.OS_label.Text = Environment.OSVersion.Platform.ToString();

            }

        }


        private void WriteStatus()
        {
            string text;
            Stopwatch mystopwatch = new Stopwatch();

            while (true)
            {
                text = "";

                Thread.Sleep(1500);
                mystopwatch.Start();
                if (Program.FunctionsForm.AntiFreezeForm != null && Program.FunctionsForm.SommerWinterForm != null && Program.FunctionsForm.TagNachtForm != null)
                {
                    this.BeginInvoke((Action)delegate
                    {
                        #region Menu active function label

                        //change anti-freeze status
                        if (Program.FunctionsForm.AntiFreezeForm.AntiFreezeON)
                            text += "| A-F ";
                        else
                            text += "";

                        //change sommer winter status
                        if (Program.FunctionsForm.SommerWinterForm.SommerON)
                            text += "| S-W ";
                        else
                            text += "";

                        //change tag nacht status
                        if (Program.FunctionsForm.TagNachtForm.TagON)
                            text += "| T-N |";
                        else
                            text += "";


                        this.Active_Function_Label.Text = text;


                        //if (Program.FunctionsForm.AntiFreezeForm.AntiFreezeON && this.Active_Function_Label.Text.Contains("A-F") == false)
                        //    this.Active_Function_Label.Text += " | A-F";
                        //
                        //else if(this.Active_Function_Label.Text.Contains("A-F") == true)
                        //        this.Active_Function_Label.Text.Replace("A-F", "");
                        //
                        //
                        //if (!Program.FunctionsForm.SommerWinterForm.SommerON)
                        //{
                        //    if (this.Active_Function_Label.Text.Contains("S/W"))
                        //        this.Active_Function_Label.Text.Replace("S/W", " ");
                        //}
                        //else
                        //{
                        //    if (this.Active_Function_Label.Text != " " || !this.Active_Function_Label.Text.Contains("S/W"))
                        //        this.Active_Function_Label.Text += " | S/W";
                        //}
                        //
                        //if (!Program.FunctionsForm.TagNachtForm.TagON)
                        //{
                        //    if (this.Active_Function_Label.Text.Contains("T/N"))
                        //        this.Active_Function_Label.Text.Replace("T/N", " ");
                        //}
                        //else
                        //{
                        //    if (this.Active_Function_Label.Text != " " || !this.Active_Function_Label.Text.Contains("T/N"))
                        //        this.Active_Function_Label.Text += " | T/N";
                        //}


                        #endregion menu active function label
                    });
                }
                if (mystopwatch.ElapsedMilliseconds <= 1000)
                    Thread.Sleep( (int)Math.Abs(1000 - mystopwatch.ElapsedMilliseconds));

                mystopwatch.Reset();
            }

        }


    }
}
