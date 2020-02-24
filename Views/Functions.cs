using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diplwinform_v1_1.Views.Function_Views;

namespace diplwinform_v1_1.Views
{
    public partial class Functions : UserControl
    {

        public Boiler BoilerForm;

        public Functions()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.Visible = false;
            this.BackColor = Color.Transparent;

            BoilerForm = new Boiler();
            this.Function_Panel.Controls.Add(this.BoilerForm);
            Functions_Back_Button.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        //set visibility of selected form to true, display name in label and 
        private void Boiler_Click(object sender, EventArgs e)
        {
            BoilerForm.Size = Function_Panel.Size;
            Functions_Back_Button.Text = "<--";
            Functions_Back_Button.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Functions_Back_Button.FlatAppearance.BorderSize = 0;
            SelectedFunctionLabel.Text = "Boiler";
            Function_ButtonPanel.Visible = false;
            BoilerForm.Visible = true;
            Function_Panel.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Sommer_Winter_Click(object sender, EventArgs e)
        {
            Functions_Back_Button.Text = "<--";
            Functions_Back_Button.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Functions_Back_Button.FlatAppearance.BorderSize = 1;
            SelectedFunctionLabel.Text = "Sommer\nWinter";
            Function_ButtonPanel.Visible = false;
            Function_Panel.BorderStyle = BorderStyle.Fixed3D;

            //set visibility of function forms to false
            BoilerForm.Visible = false;
        }

        private void AntiFreeze_Click(object sender, EventArgs e)
        {
            Functions_Back_Button.Text = "<--";
            Functions_Back_Button.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Functions_Back_Button.FlatAppearance.BorderSize = 1;
            SelectedFunctionLabel.Text = "Anti-\nFrezze";
            Function_ButtonPanel.Visible = false;
            Function_Panel.BorderStyle = BorderStyle.Fixed3D;

            //set visibility of function forms to false
            BoilerForm.Visible = false;
        }

        private void Tag_Nacht_Click(object sender, EventArgs e)
        {
            Functions_Back_Button.Text = "<--";
            Functions_Back_Button.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            Functions_Back_Button.FlatAppearance.BorderSize = 1;
            SelectedFunctionLabel.Text = "Tag\nNacht";
            Function_ButtonPanel.Visible = false;
            Function_Panel.BorderStyle = BorderStyle.Fixed3D;

            //set visibility of function forms to false
            BoilerForm.Visible = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            //set visibility of function forms to false
            BoilerForm.Visible = false;

            Functions_Back_Button.Text = "Functions";
            Functions_Back_Button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Functions_Back_Button.FlatAppearance.BorderSize = 0;
            SelectedFunctionLabel.Text = "";
            Function_ButtonPanel.Visible = true;
            Function_Panel.BorderStyle = BorderStyle.None;

        }
    }
}
