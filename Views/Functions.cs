﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Heizungsregelung.Views.Function_Views;

namespace Heizungsregelung.Views
{
    public partial class Functions : UserControl
    {

        public Boiler BoilerForm;
        public Anti_Freeze AntiFreezeForm;
        //public Sommer_Winter SommerWinterForm;
        //public Tag_Nacht TagNachtForm;

        public Functions()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.Visible = false;
            this.BackColor = Color.Transparent;

            BoilerForm = new Boiler();
            this.Function_Panel.Controls.Add(this.BoilerForm);
            Functions_Back_Button.FlatAppearance.MouseOverBackColor = Color.Transparent;

            AntiFreezeForm = new Anti_Freeze();
            this.Function_Panel.Controls.Add(this.AntiFreezeForm);
            Functions_Back_Button.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        //set visibility of selected form to true, display name in label and 
        private void Boiler_Click(object sender, EventArgs e)
        {
            ModifyFunctionsForm("Boiler");

            //dont show the other forms
            AntiFreezeForm.Visible = false;
            //SommerWinterForm.Visible = false;
            //TagNachtForm.Visible = false;

            //set size and show selected form
            BoilerForm.Size = Function_Panel.Size;
            BoilerForm.Visible = true;


        }

        private void Sommer_Winter_Click(object sender, EventArgs e)
        {
            ModifyFunctionsForm("Sommer / Winter");


            //dont show the other forms
            AntiFreezeForm.Visible = false;
            Boiler.Visible = false;
            //TagNachtForm.Visible = false;

            //set size and show selected form
            //SommerWinterForm.Size = Function_Panel.Size;
            //SommerWinterForm.Visible = true;

        }

        private void AntiFreeze_Click(object sender, EventArgs e)
        {
            ModifyFunctionsForm("Anti-Freeze");

            //dont show the other forms
            BoilerForm.Visible = false;
            //SommerWinterForm.Visible = false;
            //TagNachtForm.Visible = false;

            //set size and show selected form
            AntiFreezeForm.Size = Function_Panel.Size;
            AntiFreezeForm.Visible = true;
        }

        private void Tag_Nacht_Click(object sender, EventArgs e)
        {
            ModifyFunctionsForm("Tag / Nacht");

            //dont show the other forms
            BoilerForm.Visible = false;
            //SommerWinterForm.Visible = false;
            AntiFreezeForm.Visible = false;

            //set size and show selected form
            //TagNachtForm.Size = Function_Panel.Size;
            //TagNachtForm.Visible = true;
        }




        private void Back_Click(object sender, EventArgs e)
        {
            //set visibility of function forms to false
            BoilerForm.Visible = false;
            AntiFreezeForm.Visible = false;
            //SommerWinterForm.Visible = false;
            //TagNachtForm.Visible = false;

            Functions_Back_Button.Text = "Functions";
            Functions_Back_Button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Functions_Back_Button.FlatAppearance.BorderSize = 0;
            SelectedFunctionLabel.Text = "";
            Function_ButtonPanel.Visible = true;
            Function_Panel.BorderStyle = BorderStyle.None;
        }

        private void ModifyFunctionsForm(string FormName)
        {
            //modify FuncitonForm and Controls
            Functions_Back_Button.Text = "<--";
            Functions_Back_Button.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Functions_Back_Button.FlatAppearance.BorderSize = 0;
            Function_ButtonPanel.Visible = false;
            SelectedFunctionLabel.Text = FormName;
            Function_Panel.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
