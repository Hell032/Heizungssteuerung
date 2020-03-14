using Heizungsregelung.Views;
using System;
using System.Drawing;
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
        public static Image BackIm;
        public static Image SimulationIm;

        public static Calculations myCalculations;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Environment.OSVersion.Platform.ToString() == "Unix")
            {
                try
                {
                    MinusIm = Image.FromFile($"Pictures/Minus_white.png");

                    PlusIm = Image.FromFile($"Pictures/Plus_white.png");

                    BackIm = Image.FromFile($"Pictures/Back_Button.png");

                    SimulationIm = Image.FromFile($"Pictures/SimulationBackgroundPic.png");

                    Cursor.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR WHILE LOADING STUFF\n\n{ex}\n\n{Path.AltDirectorySeparatorChar} and {Path.DirectorySeparatorChar}");
                }
            }
            else 
            {
                MinusIm = Image.FromFile($"Pictures{Path.AltDirectorySeparatorChar}Minus_white.png");
                PlusIm = Image.FromFile($"Pictures{Path.AltDirectorySeparatorChar}Plus_white.png");
                BackIm = Image.FromFile($"Pictures{Path.AltDirectorySeparatorChar}Back_Button.png");
                SimulationIm = Image.FromFile($"Pictures{Path.AltDirectorySeparatorChar}SimulationBackgroundPic.png");
            }

            SetupForm = new Setup();
            FunctionsForm = new Functions();
            SimulationForm = new Simulation();
            TemperaturesForm = new Temperatures();


            //---------- initialize last to avoid errors -------------------------
            MenuForm = new Menu();

            myCalculations = new Calculations();

            Application.Run(MenuForm);


        }

    }
}
