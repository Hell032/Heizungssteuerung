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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.transparentLabel1 = new diplwinform_v1_1.TransparentLabel();
            this.PortListBox = new System.Windows.Forms.ListBox();
            this.transparentButton1 = new diplwinform_v1_1.TransparentButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.transparentLabel2 = new diplwinform_v1_1.TransparentLabel();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transparentLabel3 = new diplwinform_v1_1.TransparentLabel();
            this.BaudrateBox = new System.Windows.Forms.ComboBox();
            this.transparentButton2 = new diplwinform_v1_1.TransparentButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SetupLabel = new diplwinform_v1_1.TransparentLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 404);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 318F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(779, 318);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.transparentLabel1);
            this.flowLayoutPanel1.Controls.Add(this.PortListBox);
            this.flowLayoutPanel1.Controls.Add(this.transparentButton1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(383, 312);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.AutoSize = true;
            this.transparentLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.SetFlowBreak(this.transparentLabel1, true);
            this.transparentLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transparentLabel1.Location = new System.Drawing.Point(3, 0);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(297, 46);
            this.transparentLabel1.TabIndex = 0;
            this.transparentLabel1.Text = "Available Ports:";
            this.transparentLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortListBox
            // 
            this.PortListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortListBox.FormattingEnabled = true;
            this.PortListBox.ItemHeight = 38;
            this.PortListBox.Location = new System.Drawing.Point(3, 49);
            this.PortListBox.Name = "PortListBox";
            this.PortListBox.Size = new System.Drawing.Size(380, 194);
            this.PortListBox.TabIndex = 8;
            this.PortListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedValueChanged);
            // 
            // transparentButton1
            // 
            this.transparentButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transparentButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentButton1.Location = new System.Drawing.Point(3, 249);
            this.transparentButton1.Name = "transparentButton1";
            this.transparentButton1.Size = new System.Drawing.Size(380, 63);
            this.transparentButton1.TabIndex = 9;
            this.transparentButton1.Text = "Refresh";
            this.transparentButton1.UseVisualStyleBackColor = true;
            this.transparentButton1.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.transparentLabel2);
            this.flowLayoutPanel2.Controls.Add(this.PortBox);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.transparentLabel3);
            this.flowLayoutPanel2.Controls.Add(this.BaudrateBox);
            this.flowLayoutPanel2.Controls.Add(this.transparentButton2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(392, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(384, 312);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // transparentLabel2
            // 
            this.transparentLabel2.AutoSize = true;
            this.transparentLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.SetFlowBreak(this.transparentLabel2, true);
            this.transparentLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transparentLabel2.Location = new System.Drawing.Point(3, 0);
            this.transparentLabel2.Name = "transparentLabel2";
            this.transparentLabel2.Size = new System.Drawing.Size(211, 46);
            this.transparentLabel2.TabIndex = 1;
            this.transparentLabel2.Text = "Enter Port:";
            this.transparentLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortBox
            // 
            this.PortBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortBox.Location = new System.Drawing.Point(3, 49);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(381, 45);
            this.PortBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 46);
            this.panel1.TabIndex = 3;
            // 
            // transparentLabel3
            // 
            this.transparentLabel3.AutoSize = true;
            this.transparentLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.SetFlowBreak(this.transparentLabel3, true);
            this.transparentLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transparentLabel3.Location = new System.Drawing.Point(3, 149);
            this.transparentLabel3.Name = "transparentLabel3";
            this.transparentLabel3.Size = new System.Drawing.Size(192, 46);
            this.transparentLabel3.TabIndex = 5;
            this.transparentLabel3.Text = "Baudrate:";
            this.transparentLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaudrateBox
            // 
            this.BaudrateBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.BaudrateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudrateBox.FormattingEnabled = true;
            this.BaudrateBox.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400",
            "57600",
            "115200"});
            this.BaudrateBox.Location = new System.Drawing.Point(3, 198);
            this.BaudrateBox.Name = "BaudrateBox";
            this.BaudrateBox.Size = new System.Drawing.Size(381, 46);
            this.BaudrateBox.TabIndex = 18;
            // 
            // transparentButton2
            // 
            this.transparentButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transparentButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentButton2.Location = new System.Drawing.Point(3, 250);
            this.transparentButton2.Name = "transparentButton2";
            this.transparentButton2.Size = new System.Drawing.Size(380, 63);
            this.transparentButton2.TabIndex = 10;
            this.transparentButton2.Text = "Open Serialport";
            this.transparentButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.transparentButton2.UseVisualStyleBackColor = true;
            this.transparentButton2.Click += new System.EventHandler(this.SetupSerialport);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.SetupLabel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(779, 74);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // SetupLabel
            // 
            this.SetupLabel.AutoSize = true;
            this.SetupLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupLabel.Location = new System.Drawing.Point(3, 0);
            this.SetupLabel.Name = "SetupLabel";
            this.SetupLabel.Size = new System.Drawing.Size(617, 74);
            this.SetupLabel.TabIndex = 3;
            this.SetupLabel.Text = "Setup";
            this.SetupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(785, 404);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Setup";
            this.Opacity = 0D;
            this.Text = "Setup";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private TransparentLabel transparentLabel1;
        private System.Windows.Forms.ListBox PortListBox;
        private TransparentButton transparentButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private TransparentLabel transparentLabel2;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Panel panel1;
        private TransparentLabel transparentLabel3;
        private TransparentButton transparentButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private TransparentLabel SetupLabel;
        private System.Windows.Forms.ComboBox BaudrateBox;
    }
}