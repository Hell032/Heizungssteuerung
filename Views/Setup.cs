using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;
using System.Drawing;
using System.Threading;

namespace Heizungsregelung.Views
{
    public partial class Setup : UserControl
    {
        public static SerialPort mySerialPort = new SerialPort();
        //flag for starting the hleper threads in different classes
        public bool StatusFlag_Connected;
        public bool SimulationMode;

        //---------------------------------------------private----------------------------------------
        private Thread tempthread;

        private string port;

        public Setup()
        {
            InitializeComponent();


            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.Visible = false;
            this.BackColor = Color.Transparent;

            GetAvailablePorts();

            this.BaudrateBox.SelectedIndex = 5;


            tempthread = new Thread(new ThreadStart(GetTemps_Thread));
            tempthread.IsBackground = true;
            tempthread.Priority = ThreadPriority.Highest;

            //-----------------------------------------------------------TODO----------------------------------------
            //put serialstuff in a seperate class where all inputs come together

        }


        //---------------------------------------------events--------------------------------------

        //select mode --> real data is used 
        private void RealData_CheckedChanged(object sender, EventArgs e)
        {
            if (RealData.Checked == true)
            {
                SimulationMode = false;
                SimulationData.Checked = false;
            }
            else
                SimulationMode = false;
        }

        //simulated data is used 
        private void SimulationData_CheckedChanged(object sender, EventArgs e)
        {
            if (SimulationData.Checked == true)
            {
                RealData.Checked = false;
                SimulationMode = true;
            }
            else
                SimulationMode = false;
        }

        //when a different item in portlist is selected autofill it in the port box
        private void SelectedValueChanged(object sender, EventArgs e)
        {
            if (PortListBox.SelectedItem != null)
            {
                port = PortListBox.SelectedItem.ToString();
            }
        }


        private void SetupSerialport(object sender, EventArgs e)
        {
            string message = "";
            int baudrate = int.Parse(BaudrateBox.Text);

            //check if serialport is open and display a message 
            if (mySerialPort.IsOpen)
            {
                mySerialPort.Close();
                //Debug.WriteLine($"serialport on {Program.mySerialPort.PortName} is closed: {!Program.mySerialPort.IsOpen}");
                message += $"\nSerialPort on {mySerialPort.PortName} Closed";
                StatusFlag_Connected = false;
            }

            if (SimulationData.Checked || RealData.Checked)
            {
                try
                {
                    mySerialPort = new SerialPort(port, baudrate, Parity.None);
                    mySerialPort.Open();

                    Debug.WriteLine($"serialport on {mySerialPort.PortName} Open: {mySerialPort.IsOpen}");
                    PortStatusLabel.Text = "Port Status:\nConnection\nestablished";
                    message += $"\nSerialPort on {mySerialPort.PortName} Open";

                    //set flag to true to start helper-threads
                    StatusFlag_Connected = true;


                    tempthread.Start();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Unable to open SerialPort\n{ex}");

                    PortStatusLabel.Text = "Port Status:\nConnection\nrefused";
                    message += $"\nUnable to Open SerialPort on {mySerialPort.PortName}";

                    //set flag to false
                    StatusFlag_Connected = false;
                }


                //------------------------------------output message 
                //BeginInvoke((Action)delegate
                //{
                //    //MessageBox.Show($"{message}", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //});

                Program.MenuForm.Refresh();
                Program.SetupForm.Refresh();
            }
            else
            {
                MessageBox.Show("HOPPALA ! !\nYou must choose a mode\n", "I guess something happend", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void CheckForConnections_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                try
                {
                    //if (Program.mySerialPort.IsOpen)
                    //PortStatus.Text = ($"{Program.mySerialPort.PortName}, {Program.mySerialPort.BaudRate}, {Program.mySerialPort.IsOpen}");
                }
                catch (Exception)
                {
                    Debug.WriteLine("No Port open");
                }
            }
        }


        //used to refresh the port box to get newly mounted devices
        private void Refresh_Click(object sender, EventArgs e)
        {
            GetAvailablePorts();
        }


        //---------------------------------------------helper methods----------------------------------

        /// <summary>
        /// methode which is used in the tempthread
        /// </summary>
        private void GetTemps_Thread()
        {

            string data;
            string[] pieces;

            while (true)
            {
                if (mySerialPort.IsOpen)
                {
                    try
                    {
                        //gets the simulated values from the serialport
                        Setup.mySerialPort.DiscardOutBuffer();
                        data = Setup.mySerialPort.ReadLine();

                        //splits the data via a delimiter string into a data array
                        string[] delimiter = { "\t" };
                        pieces = data.Split(delimiter, StringSplitOptions.None);

                        //writes the splited data array to the 
                        if (Program.SetupForm.SimulationMode)
                        {
                            //writes the simulated values to the variables used to perform the calculations
                            Program.myCalculations.VorlaufQuelle_Ist = int.Parse(pieces[0]);
                            Program.myCalculations.Wasserverbrauch = int.Parse(pieces[1]);
                            Program.myCalculations.NachlaufHeizkreis_Ist = int.Parse(pieces[2]);
                            Program.myCalculations.AußenTemp_Ist = int.Parse(pieces[3]);
                        }
                        else
                        {
                            //writes the real values to the variables used to perform the calculations
                            Program.myCalculations.VorlaufQuelle_Ist = int.Parse(pieces[4]);
                            Program.myCalculations.Wasserverbrauch = int.Parse(pieces[5]);
                            Program.myCalculations.NachlaufHeizkreis_Ist = int.Parse(pieces[6]);
                            Program.myCalculations.AußenTemp_Ist = int.Parse(pieces[7]);
                        }

                        Program.TemperaturesForm.WriteToTemperatureFormLabels();
                        Program.SimulationForm.WriteToSimulationFormLabels();
                    }
                    catch
                    {
                        //this.BeginInvoke((Action)delegate
                        //{
                        //    PortStatusLabel.Text = "Port Status:\nConnection\nrefused";
                        //});
                        Debug.WriteLine("Error occourd while reading from serialport");
                    }
                }
                else
                {
                    //this.BeginInvoke((Action)delegate
                    //{
                    //    PortStatusLabel.Text = "Port Status:\nConnection\nrefused";
                    //}); 
                    Debug.WriteLine("SerialPort not open");
                }
                //for debuging
                #region debuging
                /*
                for (int i = 0; i < 35; i++)
                {
                    Debug.WriteLine(i);

                    this.BeginInvoke((Action)delegate
                    {
                        AusentempLabel.Text = i.ToString();
                        VLQuelleLabel.Text = i.ToString();
                        VLHKLabel.Text = i.ToString();
                        BoilertempLabel.Text = i.ToString();
                    });

                    Thread.Sleep(750);
                }

                /*
                AusentempLabel.BeginInvoke(delegate (
                    this.Text = m_außenTemp
                    ));
                */
                #endregion
            }
        }


        //gets all available ports on the device
        private void GetAvailablePorts()
        {
            PortListBox.Items.Clear();

            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                if (port.Contains("ttyS"))
                {
                    Debug.WriteLine("some ports are not displayed");
                    PortListBox.Items.Add("Arduino not detected");
                }
                else if (port.Contains("USB") || port.Contains("COM") || port.Contains("ACM"))
                {
                    PortListBox.Items.Add(port);
                }

            }
        }
    }
}
