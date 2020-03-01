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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Soll_Quelle_Label = new System.Windows.Forms.Label();
            this.Außentemp_Label = new System.Windows.Forms.Label();
            this.Pumpe_Boiler_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Raumtemp_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HK_Mischer_Zu_Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Soll_HK_Label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Ist_HK_Label = new System.Windows.Forms.Label();
            this.HK_Mischer_Auf_Label = new System.Windows.Forms.Label();
            this.Anforderung_Quelle_Label = new System.Windows.Forms.Label();
            this.Pumpe_HK_Label = new System.Windows.Forms.Label();
            this.Ist_Quelle_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Soll_Boiler_Label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Ist_Boiler_Label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SimulationPicture.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.SimulationPicture.Controls.Add(this.tableLayoutPanel2);
            this.SimulationPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimulationPicture.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SimulationPicture.Location = new System.Drawing.Point(0, 38);
            this.SimulationPicture.Margin = new System.Windows.Forms.Padding(0);
            this.SimulationPicture.Name = "SimulationPicture";
            this.SimulationPicture.Size = new System.Drawing.Size(512, 318);
            this.SimulationPicture.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.88079F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.81678F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.03118F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.24944F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.70379F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.725159F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.81607F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.Controls.Add(this.Pumpe_Boiler_Label, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Raumtemp_Label, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.HK_Mischer_Zu_Label, 5, 8);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.Soll_HK_Label, 7, 5);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.Ist_HK_Label, 7, 4);
            this.tableLayoutPanel2.Controls.Add(this.HK_Mischer_Auf_Label, 5, 7);
            this.tableLayoutPanel2.Controls.Add(this.Anforderung_Quelle_Label, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.Pumpe_HK_Label, 6, 6);
            this.tableLayoutPanel2.Controls.Add(this.Ist_Quelle_Label, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.Soll_Quelle_Label, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label7, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.Soll_Boiler_Label, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.label11, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.Ist_Boiler_Label, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.Außentemp_Label, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 6, 5);
            this.tableLayoutPanel2.Controls.Add(this.label6, 6, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 4, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.433962F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.06289F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(512, 318);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // Soll_Quelle_Label
            // 
            this.Soll_Quelle_Label.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.Soll_Quelle_Label, 2);
            this.Soll_Quelle_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Soll_Quelle_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soll_Quelle_Label.ForeColor = System.Drawing.Color.Black;
            this.Soll_Quelle_Label.Location = new System.Drawing.Point(83, 248);
            this.Soll_Quelle_Label.Name = "Soll_Quelle_Label";
            this.Soll_Quelle_Label.Size = new System.Drawing.Size(104, 31);
            this.Soll_Quelle_Label.TabIndex = 8;
            this.Soll_Quelle_Label.Text = "0 °C";
            this.Soll_Quelle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Außentemp_Label
            // 
            this.Außentemp_Label.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.Außentemp_Label, 2);
            this.Außentemp_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Außentemp_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Außentemp_Label.ForeColor = System.Drawing.Color.Black;
            this.Außentemp_Label.Location = new System.Drawing.Point(83, 0);
            this.Außentemp_Label.Name = "Außentemp_Label";
            this.Außentemp_Label.Size = new System.Drawing.Size(104, 31);
            this.Außentemp_Label.TabIndex = 1;
            this.Außentemp_Label.Text = "0 °C";
            this.Außentemp_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pumpe_Boiler_Label
            // 
            this.Pumpe_Boiler_Label.AutoSize = true;
            this.Pumpe_Boiler_Label.BackColor = System.Drawing.Color.Red;
            this.Pumpe_Boiler_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pumpe_Boiler_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pumpe_Boiler_Label.ForeColor = System.Drawing.Color.Black;
            this.Pumpe_Boiler_Label.Location = new System.Drawing.Point(131, 155);
            this.Pumpe_Boiler_Label.Name = "Pumpe_Boiler_Label";
            this.Pumpe_Boiler_Label.Size = new System.Drawing.Size(56, 30);
            this.Pumpe_Boiler_Label.TabIndex = 26;
            this.Pumpe_Boiler_Label.Text = "Pumpe";
            this.Pumpe_Boiler_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Außen:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Raumtemp_Label
            // 
            this.Raumtemp_Label.AutoSize = true;
            this.Raumtemp_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Raumtemp_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raumtemp_Label.ForeColor = System.Drawing.Color.Black;
            this.Raumtemp_Label.Location = new System.Drawing.Point(448, 31);
            this.Raumtemp_Label.Name = "Raumtemp_Label";
            this.Raumtemp_Label.Size = new System.Drawing.Size(61, 31);
            this.Raumtemp_Label.TabIndex = 14;
            this.Raumtemp_Label.Text = "0 °C";
            this.Raumtemp_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(364, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "Raum:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HK_Mischer_Zu_Label
            // 
            this.HK_Mischer_Zu_Label.AutoSize = true;
            this.HK_Mischer_Zu_Label.BackColor = System.Drawing.Color.Red;
            this.HK_Mischer_Zu_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HK_Mischer_Zu_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HK_Mischer_Zu_Label.ForeColor = System.Drawing.Color.Black;
            this.HK_Mischer_Zu_Label.Location = new System.Drawing.Point(318, 253);
            this.HK_Mischer_Zu_Label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.HK_Mischer_Zu_Label.Name = "HK_Mischer_Zu_Label";
            this.HK_Mischer_Zu_Label.Size = new System.Drawing.Size(43, 26);
            this.HK_Mischer_Zu_Label.TabIndex = 24;
            this.HK_Mischer_Zu_Label.Text = " ZU";
            this.HK_Mischer_Zu_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ist:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Soll_HK_Label
            // 
            this.Soll_HK_Label.AutoSize = true;
            this.Soll_HK_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Soll_HK_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soll_HK_Label.ForeColor = System.Drawing.Color.Black;
            this.Soll_HK_Label.Location = new System.Drawing.Point(448, 155);
            this.Soll_HK_Label.Name = "Soll_HK_Label";
            this.Soll_HK_Label.Size = new System.Drawing.Size(61, 30);
            this.Soll_HK_Label.TabIndex = 13;
            this.Soll_HK_Label.Text = "0 °C";
            this.Soll_HK_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 31);
            this.label10.TabIndex = 10;
            this.label10.Text = "Soll:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ist_HK_Label
            // 
            this.Ist_HK_Label.AutoSize = true;
            this.Ist_HK_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ist_HK_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ist_HK_Label.ForeColor = System.Drawing.Color.Black;
            this.Ist_HK_Label.Location = new System.Drawing.Point(448, 124);
            this.Ist_HK_Label.Name = "Ist_HK_Label";
            this.Ist_HK_Label.Size = new System.Drawing.Size(61, 31);
            this.Ist_HK_Label.TabIndex = 3;
            this.Ist_HK_Label.Text = "0 °C";
            this.Ist_HK_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HK_Mischer_Auf_Label
            // 
            this.HK_Mischer_Auf_Label.AutoSize = true;
            this.HK_Mischer_Auf_Label.BackColor = System.Drawing.Color.Red;
            this.HK_Mischer_Auf_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HK_Mischer_Auf_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HK_Mischer_Auf_Label.ForeColor = System.Drawing.Color.Black;
            this.HK_Mischer_Auf_Label.Location = new System.Drawing.Point(318, 222);
            this.HK_Mischer_Auf_Label.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.HK_Mischer_Auf_Label.Name = "HK_Mischer_Auf_Label";
            this.HK_Mischer_Auf_Label.Size = new System.Drawing.Size(43, 26);
            this.HK_Mischer_Auf_Label.TabIndex = 20;
            this.HK_Mischer_Auf_Label.Text = "AUF";
            this.HK_Mischer_Auf_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Anforderung_Quelle_Label
            // 
            this.Anforderung_Quelle_Label.AutoSize = true;
            this.Anforderung_Quelle_Label.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanel2.SetColumnSpan(this.Anforderung_Quelle_Label, 2);
            this.Anforderung_Quelle_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Anforderung_Quelle_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anforderung_Quelle_Label.ForeColor = System.Drawing.Color.Black;
            this.Anforderung_Quelle_Label.Location = new System.Drawing.Point(3, 279);
            this.Anforderung_Quelle_Label.Name = "Anforderung_Quelle_Label";
            this.Anforderung_Quelle_Label.Size = new System.Drawing.Size(122, 39);
            this.Anforderung_Quelle_Label.TabIndex = 23;
            this.Anforderung_Quelle_Label.Text = "Anforderung";
            this.Anforderung_Quelle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pumpe_HK_Label
            // 
            this.Pumpe_HK_Label.AutoSize = true;
            this.Pumpe_HK_Label.BackColor = System.Drawing.Color.Red;
            this.Pumpe_HK_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pumpe_HK_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pumpe_HK_Label.ForeColor = System.Drawing.Color.Black;
            this.Pumpe_HK_Label.Location = new System.Drawing.Point(361, 185);
            this.Pumpe_HK_Label.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Pumpe_HK_Label.Name = "Pumpe_HK_Label";
            this.Pumpe_HK_Label.Size = new System.Drawing.Size(84, 27);
            this.Pumpe_HK_Label.TabIndex = 19;
            this.Pumpe_HK_Label.Text = "Pumpe";
            this.Pumpe_HK_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ist_Quelle_Label
            // 
            this.Ist_Quelle_Label.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.Ist_Quelle_Label, 2);
            this.Ist_Quelle_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ist_Quelle_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ist_Quelle_Label.ForeColor = System.Drawing.Color.Black;
            this.Ist_Quelle_Label.Location = new System.Drawing.Point(83, 217);
            this.Ist_Quelle_Label.Name = "Ist_Quelle_Label";
            this.Ist_Quelle_Label.Size = new System.Drawing.Size(104, 31);
            this.Ist_Quelle_Label.TabIndex = 11;
            this.Ist_Quelle_Label.Text = "0 °C";
            this.Ist_Quelle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(193, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ist:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Soll_Boiler_Label
            // 
            this.Soll_Boiler_Label.AutoSize = true;
            this.Soll_Boiler_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Soll_Boiler_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soll_Boiler_Label.ForeColor = System.Drawing.Color.Black;
            this.Soll_Boiler_Label.Location = new System.Drawing.Point(247, 93);
            this.Soll_Boiler_Label.Name = "Soll_Boiler_Label";
            this.Soll_Boiler_Label.Size = new System.Drawing.Size(68, 31);
            this.Soll_Boiler_Label.TabIndex = 11;
            this.Soll_Boiler_Label.Text = "0 °C";
            this.Soll_Boiler_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(193, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 31);
            this.label11.TabIndex = 10;
            this.label11.Text = "Soll:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ist_Boiler_Label
            // 
            this.Ist_Boiler_Label.AutoSize = true;
            this.Ist_Boiler_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ist_Boiler_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ist_Boiler_Label.ForeColor = System.Drawing.Color.Black;
            this.Ist_Boiler_Label.Location = new System.Drawing.Point(247, 62);
            this.Ist_Boiler_Label.Name = "Ist_Boiler_Label";
            this.Ist_Boiler_Label.Size = new System.Drawing.Size(68, 31);
            this.Ist_Boiler_Label.TabIndex = 2;
            this.Ist_Boiler_Label.Text = "0 °C";
            this.Ist_Boiler_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(364, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 30);
            this.label13.TabIndex = 12;
            this.label13.Text = "Soll:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(247, 217);
            this.label2.Name = "label2";
            this.tableLayoutPanel2.SetRowSpan(this.label2, 2);
            this.label2.Size = new System.Drawing.Size(68, 62);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mischer:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(364, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ist:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SimulationPicture;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label Raumtemp_Label;
        public System.Windows.Forms.Label Soll_HK_Label;
        public System.Windows.Forms.Label Soll_Boiler_Label;
        public System.Windows.Forms.Label Soll_Quelle_Label;
        public System.Windows.Forms.Label Ist_HK_Label;
        public System.Windows.Forms.Label Ist_Boiler_Label;
        public System.Windows.Forms.Label Außentemp_Label;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label HK_Mischer_Auf_Label;
        public System.Windows.Forms.Label Pumpe_HK_Label;
        public System.Windows.Forms.Label HK_Mischer_Zu_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label Pumpe_Boiler_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label Anforderung_Quelle_Label;
        public System.Windows.Forms.Label Ist_Quelle_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}
