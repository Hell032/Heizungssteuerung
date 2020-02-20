using diplwinform_v1_1.Views;
using System;
using System.IO.Ports;
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
        public static Temperatures TemperaturesForm;
        public static Simulation SimulationForm;



        //public static SerialPort mySerialPort = new SerialPort();

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            SetupForm = new Setup();
            FunctionsForm = new Functions();
            TemperaturesForm = new Temperatures();
            SimulationForm = new Simulation();

            //---------- initialize last to avoid errors -------------------------
            MenuForm = new Menu();



            Application.Run(MenuForm);
        }


        public static void CheckOS()
        {
            
            
        
        }
    }
}
