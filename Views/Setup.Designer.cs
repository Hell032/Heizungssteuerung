namespace diplwinform_v1_1.Views
{
    partial class Setup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.transparentLabel1 = new diplwinform_v1_1.TransparentLabel();
            this.transparentButton1 = new diplwinform_v1_1.TransparentButton();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(309, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(240, 55);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.AutoSize = true;
            this.transparentLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel1.ForeColor = System.Drawing.Color.White;
            this.transparentLabel1.Location = new System.Drawing.Point(53, 162);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(688, 108);
            this.transparentLabel1.TabIndex = 4;
            this.transparentLabel1.Text = "transparentLab";
            // 
            // transparentButton1
            // 
            this.transparentButton1.BackColor = System.Drawing.Color.Transparent;
            this.transparentButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transparentButton1.ForeColor = System.Drawing.Color.White;
            this.transparentButton1.Location = new System.Drawing.Point(209, 311);
            this.transparentButton1.Name = "transparentButton1";
            this.transparentButton1.Size = new System.Drawing.Size(340, 117);
            this.transparentButton1.TabIndex = 5;
            this.transparentButton1.Text = "transparentButton1";
            this.transparentButton1.UseVisualStyleBackColor = false;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transparentButton1);
            this.Controls.Add(this.transparentLabel1);
            this.Controls.Add(this.linkLabel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Setup";
            this.Opacity = 0D;
            this.Text = "Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private TransparentLabel transparentLabel1;
        private TransparentButton transparentButton1;
    }
}