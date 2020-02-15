using diplwinform_v1_1.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
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

            MenuForm = new Menu();
            //MenuForm.StartPosition = FormStartPosition.CenterScreen;




            //-----------------TODO -------------------------------------set size to fit display 
            //check for system value and set size 







            Application.Run(MenuForm);
        }
    }
}
