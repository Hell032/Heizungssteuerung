using Heizungsregelung.Views;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;
using RaspGPIOTest;

namespace Heizungsregelung
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
        public static Form1 GPIOTestForm;

        public static Image MinusIm;
        public static Image PlusIm;

        public static Calculations myCalculations = new Calculations();

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Environment.OSVersion.Platform.ToString() == "Unix")
            {
                try
                {

                    MinusIm = Image.FromFile($"../Regler/Pictures/Minus_white.png");

                    PlusIm = Image.FromFile($"../Regler/Pictures/Plus_white.png");

                    Cursor.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}\n{Path.AltDirectorySeparatorChar} and {Path.DirectorySeparatorChar}");
                }

            }
            else 
            {
                MinusIm = Image.FromFile($"../Debug{Path.AltDirectorySeparatorChar}Pictures{Path.AltDirectorySeparatorChar}Minus_white.png");
                PlusIm = Image.FromFile($"../Debug{Path.AltDirectorySeparatorChar}Pictures{Path.AltDirectorySeparatorChar}Plus_white.png");
            }

            SetupForm = new Setup();
            FunctionsForm = new Functions();
            TemperaturesForm = new Temperatures();
            SimulationForm = new Simulation();
            GPIOTestForm = new Form1();


            //---------- initialize last to avoid errors -------------------------
            MenuForm = new Menu();

            Application.Run(MenuForm);

        }

    }
}
