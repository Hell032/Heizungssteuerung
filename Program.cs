﻿using Heizungsregelung.Views;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;
using RaspGPIOTest;
using System.Threading.Tasks;

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
                    MinusIm = Image.FromFile($"../Regler/Pictures/Minus_white.png");

                    PlusIm = Image.FromFile($"../Regler/Pictures/Plus_white.png");

                    BackIm = Image.FromFile($"../Regler/Pictures/Back_Button.png");

                    SimulationIm = Image.FromFile($"../Regler/Pictures/SimulationBackgroundPic.png");

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

            myCalculations = new Calculations();
            SetupForm = new Setup();
            FunctionsForm = new Functions();
            SimulationForm = new Simulation();
            GPIOTestForm = new Form1();
            TemperaturesForm = new Temperatures();


            //---------- initialize last to avoid errors -------------------------
            MenuForm = new Menu();
            MenuForm.Refresh();
            Application.Run(MenuForm);


        }

    }
}
