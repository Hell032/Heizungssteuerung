﻿namespace diplwinform_v1_1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FunctionsButton = new System.Windows.Forms.Button();
            this.TempButton = new System.Windows.Forms.Button();
            this.SetupButton = new System.Windows.Forms.Button();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.MenuPanelWidth = new System.Windows.Forms.Label();
            this.MenuPanelHeight = new System.Windows.Forms.Label();
            this.MenuPanellabel = new System.Windows.Forms.Label();
            this.Formpanelwidth = new System.Windows.Forms.Label();
            this.Formpanelheight = new System.Windows.Forms.Label();
            this.Formpanellabel = new System.Windows.Forms.Label();
            this.gesamtwidth = new System.Windows.Forms.Label();
            this.gesamtheight = new System.Windows.Forms.Label();
            this.gesamtlabel = new System.Windows.Forms.Label();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FormPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MenuLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MenuPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.ColumnCount = 1;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonPanel.Controls.Add(this.ExitButton, 0, 3);
            this.ButtonPanel.Controls.Add(this.FunctionsButton, 0, 1);
            this.ButtonPanel.Controls.Add(this.TempButton, 0, 0);
            this.ButtonPanel.Controls.Add(this.SetupButton, 0, 2);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(3, 90);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 4;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.Size = new System.Drawing.Size(123, 357);
            this.ButtonPanel.TabIndex = 3;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(3, 270);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(117, 84);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FunctionsButton
            // 
            this.FunctionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FunctionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FunctionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FunctionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FunctionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionsButton.ForeColor = System.Drawing.Color.White;
            this.FunctionsButton.Location = new System.Drawing.Point(3, 92);
            this.FunctionsButton.Name = "FunctionsButton";
            this.FunctionsButton.Size = new System.Drawing.Size(117, 83);
            this.FunctionsButton.TabIndex = 1;
            this.FunctionsButton.Text = "Functions";
            this.FunctionsButton.UseVisualStyleBackColor = true;
            this.FunctionsButton.Click += new System.EventHandler(this.FunctionsButton_Click);
            // 
            // TempButton
            // 
            this.TempButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TempButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TempButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TempButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TempButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempButton.ForeColor = System.Drawing.Color.White;
            this.TempButton.Location = new System.Drawing.Point(3, 3);
            this.TempButton.Name = "TempButton";
            this.TempButton.Size = new System.Drawing.Size(117, 83);
            this.TempButton.TabIndex = 0;
            this.TempButton.Text = "Temps";
            this.TempButton.UseVisualStyleBackColor = true;
            this.TempButton.Click += new System.EventHandler(this.TempButton_Click);
            // 
            // SetupButton
            // 
            this.SetupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SetupButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SetupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupButton.ForeColor = System.Drawing.Color.White;
            this.SetupButton.Location = new System.Drawing.Point(3, 181);
            this.SetupButton.Name = "SetupButton";
            this.SetupButton.Size = new System.Drawing.Size(117, 83);
            this.SetupButton.TabIndex = 3;
            this.SetupButton.Text = "Setup";
            this.SetupButton.UseVisualStyleBackColor = true;
            this.SetupButton.Click += new System.EventHandler(this.SetupButton_Click);
            // 
            // FormPanel
            // 
            this.FormPanel.AutoSize = true;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(129, 90);
            this.FormPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(517, 360);
            this.FormPanel.TabIndex = 4;
            // 
            // MenuPanelWidth
            // 
            this.MenuPanelWidth.AutoSize = true;
            this.MenuPanelWidth.Location = new System.Drawing.Point(217, 28);
            this.MenuPanelWidth.Name = "MenuPanelWidth";
            this.MenuPanelWidth.Size = new System.Drawing.Size(35, 13);
            this.MenuPanelWidth.TabIndex = 8;
            this.MenuPanelWidth.Text = "label6";
            // 
            // MenuPanelHeight
            // 
            this.MenuPanelHeight.AutoSize = true;
            this.MenuPanelHeight.Location = new System.Drawing.Point(217, 15);
            this.MenuPanelHeight.Name = "MenuPanelHeight";
            this.MenuPanelHeight.Size = new System.Drawing.Size(35, 13);
            this.MenuPanelHeight.TabIndex = 7;
            this.MenuPanelHeight.Text = "label5";
            // 
            // MenuPanellabel
            // 
            this.MenuPanellabel.AutoSize = true;
            this.MenuPanellabel.Location = new System.Drawing.Point(217, 2);
            this.MenuPanellabel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanellabel.Name = "MenuPanellabel";
            this.MenuPanellabel.Size = new System.Drawing.Size(84, 13);
            this.MenuPanellabel.TabIndex = 6;
            this.MenuPanellabel.Text = "MenuPanel Size";
            // 
            // Formpanelwidth
            // 
            this.Formpanelwidth.AutoSize = true;
            this.Formpanelwidth.Location = new System.Drawing.Point(106, 28);
            this.Formpanelwidth.Name = "Formpanelwidth";
            this.Formpanelwidth.Size = new System.Drawing.Size(35, 13);
            this.Formpanelwidth.TabIndex = 5;
            this.Formpanelwidth.Text = "label6";
            // 
            // Formpanelheight
            // 
            this.Formpanelheight.AutoSize = true;
            this.Formpanelheight.Location = new System.Drawing.Point(106, 15);
            this.Formpanelheight.Name = "Formpanelheight";
            this.Formpanelheight.Size = new System.Drawing.Size(35, 13);
            this.Formpanelheight.TabIndex = 4;
            this.Formpanelheight.Text = "label5";
            // 
            // Formpanellabel
            // 
            this.Formpanellabel.AutoSize = true;
            this.Formpanellabel.Location = new System.Drawing.Point(106, 2);
            this.Formpanellabel.Margin = new System.Windows.Forms.Padding(0);
            this.Formpanellabel.Name = "Formpanellabel";
            this.Formpanellabel.Size = new System.Drawing.Size(80, 13);
            this.Formpanellabel.TabIndex = 3;
            this.Formpanellabel.Text = "FormPanel Size";
            // 
            // gesamtwidth
            // 
            this.gesamtwidth.AutoSize = true;
            this.gesamtwidth.Location = new System.Drawing.Point(3, 28);
            this.gesamtwidth.Name = "gesamtwidth";
            this.gesamtwidth.Size = new System.Drawing.Size(35, 13);
            this.gesamtwidth.TabIndex = 2;
            this.gesamtwidth.Text = "label3";
            // 
            // gesamtheight
            // 
            this.gesamtheight.AutoSize = true;
            this.gesamtheight.Location = new System.Drawing.Point(3, 15);
            this.gesamtheight.Name = "gesamtheight";
            this.gesamtheight.Size = new System.Drawing.Size(35, 13);
            this.gesamtheight.TabIndex = 1;
            this.gesamtheight.Text = "label2";
            // 
            // gesamtlabel
            // 
            this.gesamtlabel.AutoSize = true;
            this.gesamtlabel.Location = new System.Drawing.Point(3, 2);
            this.gesamtlabel.Name = "gesamtlabel";
            this.gesamtlabel.Size = new System.Drawing.Size(70, 13);
            this.gesamtlabel.TabIndex = 0;
            this.gesamtlabel.Text = "Gesamtgröße";
            // 
            // MenuLabel
            // 
            this.MenuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.ForeColor = System.Drawing.Color.White;
            this.MenuLabel.Location = new System.Drawing.Point(3, 0);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(123, 90);
            this.MenuLabel.TabIndex = 1;
            this.MenuLabel.Text = "Menu";
            this.MenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MenuLabel.DoubleClick += new System.EventHandler(this.EnterSimulation_DoubleClick);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.MenuPanelWidth);
            this.MenuPanel.Controls.Add(this.MenuPanellabel);
            this.MenuPanel.Controls.Add(this.MenuPanelHeight);
            this.MenuPanel.Controls.Add(this.gesamtlabel);
            this.MenuPanel.Controls.Add(this.gesamtheight);
            this.MenuPanel.Controls.Add(this.Formpanelwidth);
            this.MenuPanel.Controls.Add(this.gesamtwidth);
            this.MenuPanel.Controls.Add(this.Formpanelheight);
            this.MenuPanel.Controls.Add(this.Formpanellabel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(129, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(517, 90);
            this.MenuPanel.TabIndex = 5;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button TempButton;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button FunctionsButton;
        private System.Windows.Forms.Button SetupButton;
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Label Formpanelwidth;
        private System.Windows.Forms.Label Formpanelheight;
        private System.Windows.Forms.Label Formpanellabel;
        private System.Windows.Forms.Label gesamtwidth;
        private System.Windows.Forms.Label gesamtheight;
        private System.Windows.Forms.Label gesamtlabel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label MenuPanelWidth;
        private System.Windows.Forms.Label MenuPanelHeight;
        private System.Windows.Forms.Label MenuPanellabel;
    }
}