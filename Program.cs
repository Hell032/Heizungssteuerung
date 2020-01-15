using diplwinform_v1_1.Views;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplwinform_v1_1
{



    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]


        public static Menu MenuForm;
        public static Setup SetupForm;


        public static SerialPort mySerialPort = new SerialPort();

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            SetupForm = new Setup();

            SetupForm.ControlBox = false;
            SetupForm.FormBorderStyle = FormBorderStyle.None;
            SetupForm.StartPosition = FormStartPosition.CenterScreen;
            SetupForm.TopLevel = false;
            SetupForm.AutoScroll = true;
            SetupForm.Dock = DockStyle.Fill;
            SetupForm.Show();
            SetupForm.Visible = false;

            MenuForm = new Menu();
            MenuForm.ControlBox = false;
            MenuForm.FormBorderStyle = FormBorderStyle.None;
            MenuForm.StartPosition = FormStartPosition.CenterScreen;
            MenuForm.Size = new System.Drawing.Size(600, 300);

            MenuForm.TopLevel = true;
            MenuForm.AutoScroll = true;






            Application.Run(MenuForm);
        }
    }
}
