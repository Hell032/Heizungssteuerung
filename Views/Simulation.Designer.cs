namespace Heizungsregelung.Views
{
    partial class Simulation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulation));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SimulationPicture = new System.Windows.Forms.Panel();
            this.HK_Mischer_Zu_Label = new System.Windows.Forms.Label();
            this.Anforderung_Quelle_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HK_Mischer_Auf_Label = new System.Windows.Forms.Label();
            this.Pumpe_HK_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pumpe_Boiler_Label = new System.Windows.Forms.Label();
            this.Raumtemp_Label = new System.Windows.Forms.Label();
            this.Soll_HK_Label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Soll_Boiler_Label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Soll_Quelle_Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Ist_Quelle_Label = new System.Windows.Forms.Label();
            this.Ist_HK_Label = new System.Windows.Forms.Label();
            this.Ist_Boiler_Label = new System.Windows.Forms.Label();
            this.Außentemp_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SimulationPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SimulationPicture, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.67416F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.32584F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 356);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simulation Mode";
            // 
            // SimulationPicture
            // 
            this.SimulationPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SimulationPicture.BackgroundImage")));
            this.SimulationPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SimulationPicture.Controls.Add(this.HK_Mischer_Zu_Label);
            this.SimulationPicture.Controls.Add(this.Anforderung_Quelle_Label);
            this.SimulationPicture.Controls.Add(this.label5);
            this.SimulationPicture.Controls.Add(this.HK_Mischer_Auf_Label);
            this.SimulationPicture.Controls.Add(this.Pumpe_HK_Label);
            this.SimulationPicture.Controls.Add(this.label3);
            this.SimulationPicture.Controls.Add(this.Pumpe_Boiler_Label);
            this.SimulationPicture.Controls.Add(this.Raumtemp_Label);
            this.SimulationPicture.Controls.Add(this.Soll_HK_Label);
            this.SimulationPicture.Controls.Add(this.label13);
            this.SimulationPicture.Controls.Add(this.Soll_Boiler_Label);
            this.SimulationPicture.Controls.Add(this.label11);
            this.SimulationPicture.Controls.Add(this.label10);
            this.SimulationPicture.Controls.Add(this.Soll_Quelle_Label);
            this.SimulationPicture.Controls.Add(this.label8);
            this.SimulationPicture.Controls.Add(this.label7);
            this.SimulationPicture.Controls.Add(this.label6);
            this.SimulationPicture.Controls.Add(this.Ist_Quelle_Label);
            this.SimulationPicture.Controls.Add(this.Ist_HK_Label);
            this.SimulationPicture.Controls.Add(this.Ist_Boiler_Label);
            this.SimulationPicture.Controls.Add(this.Außentemp_Label);
            this.SimulationPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimulationPicture.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SimulationPicture.Location = new System.Drawing.Point(0, 38);
            this.SimulationPicture.Margin = new System.Windows.Forms.Padding(0);
            this.SimulationPicture.Name = "SimulationPicture";
            this.SimulationPicture.Size = new System.Drawing.Size(512, 318);
            this.SimulationPicture.TabIndex = 4;
            // 
            // HK_Mischer_Zu_Label
            // 
            this.HK_Mischer_Zu_Label.AutoSize = true;
            this.HK_Mischer_Zu_Label.BackColor = System.Drawing.Color.Red;
            this.HK_Mischer_Zu_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HK_Mischer_Zu_Label.ForeColor = System.Drawing.Color.Black;
            this.HK_Mischer_Zu_Label.Location = new System.Drawing.Point(290, 232);
            this.HK_Mischer_Zu_Label.Name = "HK_Mischer_Zu_Label";
            this.HK_Mischer_Zu_Label.Size = new System.Drawing.Size(40, 24);
            this.HK_Mischer_Zu_Label.TabIndex = 24;
            this.HK_Mischer_Zu_Label.Text = " ZU";
            // 
            // Anforderung_Quelle_Label
            // 
            this.Anforderung_Quelle_Label.AutoSize = true;
            this.Anforderung_Quelle_Label.BackColor = System.Drawing.Color.Red;
            this.Anforderung_Quelle_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anforderung_Quelle_Label.ForeColor = System.Drawing.Color.Red;
            this.Anforderung_Quelle_Label.Location = new System.Drawing.Point(43, 275);
            this.Anforderung_Quelle_Label.Name = "Anforderung_Quelle_Label";
            this.Anforderung_Quelle_Label.Size = new System.Drawing.Size(116, 24);
            this.Anforderung_Quelle_Label.TabIndex = 23;
            this.Anforderung_Quelle_Label.Text = "Anforderung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(308, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Raum:";
            // 
            // HK_Mischer_Auf_Label
            // 
            this.HK_Mischer_Auf_Label.AutoSize = true;
            this.HK_Mischer_Auf_Label.BackColor = System.Drawing.Color.Red;
            this.HK_Mischer_Auf_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HK_Mischer_Auf_Label.ForeColor = System.Drawing.Color.Black;
            this.HK_Mischer_Auf_Label.Location = new System.Drawing.Point(285, 208);
            this.HK_Mischer_Auf_Label.Name = "HK_Mischer_Auf_Label";
            this.HK_Mischer_Auf_Label.Size = new System.Drawing.Size(48, 24);
            this.HK_Mischer_Auf_Label.TabIndex = 20;
            this.HK_Mischer_Auf_Label.Text = "AUF";
            // 
            // Pumpe_HK_Label
            // 
            this.Pumpe_HK_Label.AutoSize = true;
            this.Pumpe_HK_Label.BackColor = System.Drawing.Color.Red;
            this.Pumpe_HK_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pumpe_HK_Label.ForeColor = System.Drawing.Color.Red;
            this.Pumpe_HK_Label.Location = new System.Drawing.Point(279, 184);
            this.Pumpe_HK_Label.Name = "Pumpe_HK_Label";
            this.Pumpe_HK_Label.Size = new System.Drawing.Size(71, 24);
            this.Pumpe_HK_Label.TabIndex = 19;
            this.Pumpe_HK_Label.Text = "Pumpe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Außen:";
            // 
            // Pumpe_Boiler_Label
            // 
            this.Pumpe_Boiler_Label.AutoSize = true;
            this.Pumpe_Boiler_Label.BackColor = System.Drawing.Color.Red;
            this.Pumpe_Boiler_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pumpe_Boiler_Label.ForeColor = System.Drawing.Color.Red;
            this.Pumpe_Boiler_Label.Location = new System.Drawing.Point(75, 165);
            this.Pumpe_Boiler_Label.Name = "Pumpe_Boiler_Label";
            this.Pumpe_Boiler_Label.Size = new System.Drawing.Size(71, 24);
            this.Pumpe_Boiler_Label.TabIndex = 15;
            this.Pumpe_Boiler_Label.Text = "Pumpe";
            // 
            // Raumtemp_Label
            // 
            this.Raumtemp_Label.AutoSize = true;
            this.Raumtemp_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raumtemp_Label.ForeColor = System.Drawing.Color.Black;
            this.Raumtemp_Label.Location = new System.Drawing.Point(373, 32);
            this.Raumtemp_Label.Name = "Raumtemp_Label";
            this.Raumtemp_Label.Size = new System.Drawing.Size(44, 24);
            this.Raumtemp_Label.TabIndex = 14;
            this.Raumtemp_Label.Text = "0 °C";
            // 
            // Soll_HK_Label
            // 
            this.Soll_HK_Label.AutoSize = true;
            this.Soll_HK_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soll_HK_Label.ForeColor = System.Drawing.Color.Black;
            this.Soll_HK_Label.Location = new System.Drawing.Point(365, 143);
            this.Soll_HK_Label.Name = "Soll_HK_Label";
            this.Soll_HK_Label.Size = new System.Drawing.Size(44, 24);
            this.Soll_HK_Label.TabIndex = 13;
            this.Soll_HK_Label.Text = "0 °C";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(313, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 24);
            this.label13.TabIndex = 12;
            this.label13.Text = "Soll:";
            // 
            // Soll_Boiler_Label
            // 
            this.Soll_Boiler_Label.AutoSize = true;
            this.Soll_Boiler_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soll_Boiler_Label.ForeColor = System.Drawing.Color.Black;
            this.Soll_Boiler_Label.Location = new System.Drawing.Point(200, 80);
            this.Soll_Boiler_Label.Name = "Soll_Boiler_Label";
            this.Soll_Boiler_Label.Size = new System.Drawing.Size(44, 24);
            this.Soll_Boiler_Label.TabIndex = 11;
            this.Soll_Boiler_Label.Text = "0 °C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(162, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Soll:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(33, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Soll:";
            // 
            // Soll_Quelle_Label
            // 
            this.Soll_Quelle_Label.AutoSize = true;
            this.Soll_Quelle_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soll_Quelle_Label.ForeColor = System.Drawing.Color.Black;
            this.Soll_Quelle_Label.Location = new System.Drawing.Point(71, 242);
            this.Soll_Quelle_Label.Name = "Soll_Quelle_Label";
            this.Soll_Quelle_Label.Size = new System.Drawing.Size(44, 24);
            this.Soll_Quelle_Label.TabIndex = 8;
            this.Soll_Quelle_Label.Text = "0 °C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ist:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(162, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ist:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(313, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ist:";
            // 
            // Ist_Quelle_Label
            // 
            this.Ist_Quelle_Label.AutoSize = true;
            this.Ist_Quelle_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ist_Quelle_Label.ForeColor = System.Drawing.Color.Black;
            this.Ist_Quelle_Label.Location = new System.Drawing.Point(71, 218);
            this.Ist_Quelle_Label.Name = "Ist_Quelle_Label";
            this.Ist_Quelle_Label.Size = new System.Drawing.Size(44, 24);
            this.Ist_Quelle_Label.TabIndex = 4;
            this.Ist_Quelle_Label.Text = "0 °C";
            // 
            // Ist_HK_Label
            // 
            this.Ist_HK_Label.AutoSize = true;
            this.Ist_HK_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ist_HK_Label.ForeColor = System.Drawing.Color.Black;
            this.Ist_HK_Label.Location = new System.Drawing.Point(365, 119);
            this.Ist_HK_Label.Name = "Ist_HK_Label";
            this.Ist_HK_Label.Size = new System.Drawing.Size(44, 24);
            this.Ist_HK_Label.TabIndex = 3;
            this.Ist_HK_Label.Text = "0 °C";
            // 
            // Ist_Boiler_Label
            // 
            this.Ist_Boiler_Label.AutoSize = true;
            this.Ist_Boiler_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ist_Boiler_Label.ForeColor = System.Drawing.Color.Black;
            this.Ist_Boiler_Label.Location = new System.Drawing.Point(200, 56);
            this.Ist_Boiler_Label.Name = "Ist_Boiler_Label";
            this.Ist_Boiler_Label.Size = new System.Drawing.Size(44, 24);
            this.Ist_Boiler_Label.TabIndex = 2;
            this.Ist_Boiler_Label.Text = "0 °C";
            // 
            // Außentemp_Label
            // 
            this.Außentemp_Label.AutoSize = true;
            this.Außentemp_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Außentemp_Label.ForeColor = System.Drawing.Color.Black;
            this.Außentemp_Label.Location = new System.Drawing.Point(102, 11);
            this.Außentemp_Label.Name = "Außentemp_Label";
            this.Außentemp_Label.Size = new System.Drawing.Size(44, 24);
            this.Außentemp_Label.TabIndex = 1;
            this.Außentemp_Label.Text = "0 °C";
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Simulation";
            this.Size = new System.Drawing.Size(512, 356);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SimulationPicture.ResumeLayout(false);
            this.SimulationPicture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SimulationPicture;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label Raumtemp_Label;
        public System.Windows.Forms.Label Soll_HK_Label;
        public System.Windows.Forms.Label Soll_Boiler_Label;
        public System.Windows.Forms.Label Soll_Quelle_Label;
        public System.Windows.Forms.Label Ist_Quelle_Label;
        public System.Windows.Forms.Label Ist_HK_Label;
        public System.Windows.Forms.Label Ist_Boiler_Label;
        public System.Windows.Forms.Label Außentemp_Label;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label Anforderung_Quelle_Label;
        public System.Windows.Forms.Label Pumpe_Boiler_Label;
        public System.Windows.Forms.Label HK_Mischer_Auf_Label;
        public System.Windows.Forms.Label Pumpe_HK_Label;
        public System.Windows.Forms.Label HK_Mischer_Zu_Label;
    }
}
