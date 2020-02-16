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
        public static Functions FunctionsForm;
        


        public static SerialPort mySerialPort = new SerialPort();

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            SetupForm = new Setup();
            FunctionsForm = new Functions();

            MenuForm = new Menu();


            Application.Run(MenuForm);
        }
    }
}
