namespace RaspGPIOTest
{
    partial class Form1
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
            this.GPIO_0 = new System.Windows.Forms.Button();
            this.GPIO_1 = new System.Windows.Forms.Button();
            this.GPIO_2 = new System.Windows.Forms.Button();
            this.GPIO_3 = new System.Windows.Forms.Button();
            this.GPIO_4 = new System.Windows.Forms.Button();
            this.transparentLabel1 = new Heizungsregelung.TransparentLabel();
            this.SuspendLayout();
            // 
            // GPIO_0
            // 
            this.GPIO_0.Location = new System.Drawing.Point(25, 25);
            this.GPIO_0.Name = "GPIO_0";
            this.GPIO_0.Size = new System.Drawing.Size(75, 23);
            this.GPIO_0.TabIndex = 0;
            this.GPIO_0.Text = "GPIO_29";
            this.GPIO_0.UseVisualStyleBackColor = true;
            this.GPIO_0.Click += new System.EventHandler(this.GPIO_0_Click);
            // 
            // GPIO_1
            // 
            this.GPIO_1.Location = new System.Drawing.Point(25, 70);
            this.GPIO_1.Name = "GPIO_1";
            this.GPIO_1.Size = new System.Drawing.Size(75, 23);
            this.GPIO_1.TabIndex = 1;
            this.GPIO_1.Text = "GPIO_31";
            this.GPIO_1.UseVisualStyleBackColor = true;
            this.GPIO_1.Click += new System.EventHandler(this.GPIO_1_Click);
            // 
            // GPIO_2
            // 
            this.GPIO_2.Location = new System.Drawing.Point(25, 116);
            this.GPIO_2.Name = "GPIO_2";
            this.GPIO_2.Size = new System.Drawing.Size(75, 23);
            this.GPIO_2.TabIndex = 2;
            this.GPIO_2.Text = "GPIO_33";
            this.GPIO_2.UseVisualStyleBackColor = true;
            this.GPIO_2.Click += new System.EventHandler(this.GPIO_2_Click);
            // 
            // GPIO_3
            // 
            this.GPIO_3.Location = new System.Drawing.Point(25, 164);
            this.GPIO_3.Name = "GPIO_3";
            this.GPIO_3.Size = new System.Drawing.Size(75, 23);
            this.GPIO_3.TabIndex = 4;
            this.GPIO_3.Text = "GPIO_35";
            this.GPIO_3.UseVisualStyleBackColor = true;
            this.GPIO_3.Click += new System.EventHandler(this.GPIO_3_Click);
            // 
            // GPIO_4
            // 
            this.GPIO_4.Location = new System.Drawing.Point(25, 210);
            this.GPIO_4.Name = "GPIO_4";
            this.GPIO_4.Size = new System.Drawing.Size(75, 23);
            this.GPIO_4.TabIndex = 8;
            this.GPIO_4.Text = "GPIO_37";
            this.GPIO_4.UseVisualStyleBackColor = true;
            this.GPIO_4.Click += new System.EventHandler(this.GPIO_4_Click);
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.AutoSize = true;
            this.transparentLabel1.Enabled = false;
            this.transparentLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel1.Location = new System.Drawing.Point(12, 9);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(109, 13);
            this.transparentLabel1.TabIndex = 9;
            this.transparentLabel1.Text = "Physical Adresses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(125, 257);
            this.Controls.Add(this.transparentLabel1);
            this.Controls.Add(this.GPIO_4);
            this.Controls.Add(this.GPIO_3);
            this.Controls.Add(this.GPIO_2);
            this.Controls.Add(this.GPIO_1);
            this.Controls.Add(this.GPIO_0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GPIO_0;
        private System.Windows.Forms.Button GPIO_1;
        private System.Windows.Forms.Button GPIO_2;
        private System.Windows.Forms.Button GPIO_3;
        private System.Windows.Forms.Button GPIO_4;
        private Heizungsregelung.TransparentLabel transparentLabel1;
    }
}

