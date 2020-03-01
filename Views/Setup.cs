using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;
using System.Drawing;

namespace Heizungsregelung.Views
{
    public partial class Setup : UserControl
    {
        public static SerialPort mySerialPort = new SerialPort();
        //flag for starting the hleper threads in different classes
        public bool StatusFlag_Connected = false;

        public Setup()
        {
            InitializeComponent();


            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.Visible = false;
            this.BackColor = Color.Transparent;


            GetAvailablePorts();

            this.BaudrateBox.SelectedIndex = 5;

            this.PortBox.ReadOnly = true;

        }


        //---------------------------------------------events--------------------------------------

        //when a different item in portlist is selected autofill it in the port box
        private void SelectedValueChanged(object sender, EventArgs e)
        {
            if (PortListBox.SelectedItem != null)
            {
                PortBox.Text = PortListBox.SelectedItem.ToString();
            }
        }


        private void SetupSerialport(object sender, EventArgs e)
        {
            string message = "";
            try
            {
                //check if serialport is open and display a message 
                if (mySerialPort.IsOpen)
                {
                    mySerialPort.Close();
                    //Debug.WriteLine($"serialport on {Program.mySerialPort.PortName} is closed: {!Program.mySerialPort.IsOpen}");
                    message += $"\nSerialPort on {mySerialPort.PortName} Closed";
                    StatusFlag_Connected = false;
                }
            }
            catch (Exception)
            {
                Debug.WriteLine("serialport not open");
            }


            //-----------------------------------TODO  portname and baudrate try catch when nothing is entered
            string port = PortBox.Text;
            int baudrate = int.Parse(BaudrateBox.Text);

            try
            {
                mySerialPort = new SerialPort(port, baudrate, Parity.None);
                mySerialPort.Open();

                Debug.WriteLine($"serialport on {mySerialPort.PortName} Open: {mySerialPort.IsOpen}");
                PortStatusLabel.Text = "Port Status:\nConnection\nestablished";
                message += $"\nSerialPort on {mySerialPort.PortName} Open";

                //set flag to true to start helper-threads
                StatusFlag_Connected = true;

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
            BeginInvoke((Action)delegate
            {
                //MessageBox.Show($"{message}", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });

            Program.MenuForm.Refresh();
            Program.SetupForm.Refresh();
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
                }
                else if (port.Contains("USB") || port.Contains("COM") || port.Contains("ACM"))
                {
                    PortListBox.Items.Add(port);
                }

            }
        }
    }
}
