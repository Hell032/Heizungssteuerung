﻿using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;
using System.Drawing;

namespace diplwinform_v1_1.Views
{
    public partial class Setup : UserControl
    {
        public Setup()
        {
            InitializeComponent();


            this.AutoScroll = true;
            this.Dock = DockStyle.Fill;
            this.Visible = false;
            this.BackColor = Color.Transparent;


            GetAvailablePorts();

            this.BaudrateBox.SelectedIndex = 5;

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
                if (Program.mySerialPort.IsOpen)
                {
                    Program.mySerialPort.Close();
                    //Debug.WriteLine($"serialport on {Program.mySerialPort.PortName} is closed: {!Program.mySerialPort.IsOpen}");
                    message += $"\nSerialPort on {Program.mySerialPort.PortName} Closed";
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
                Program.mySerialPort = new SerialPort(port, baudrate, Parity.None);
                Program.mySerialPort.Open();
                Debug.WriteLine($"serialport on {Program.mySerialPort.PortName} Open: {Program.mySerialPort.IsOpen}");

                PortStatusLabel.Text = "Port Status:\nConnection\nestablished";

                message += $"\nSerialPort on {Program.mySerialPort.PortName} Open";
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to open SerialPort\n{ex}");

                PortStatusLabel.Text = "Port Status:\nConnection\nrefused";
                message += $"\nUnable to Open SerialPort on {Program.mySerialPort.PortName}";
            }


            //------------------------------------output message 
            //Debug.WriteLine(message);

            BeginInvoke((Action)delegate
            {
                MessageBox.Show($"{message}", "SerialPort Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });

            //this.Refresh();

            Program.MenuForm.Refresh();
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
                else
                {
                    PortListBox.Items.Add(port);
                }

            }
        }
    }
}
