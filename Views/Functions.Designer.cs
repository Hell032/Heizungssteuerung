﻿namespace Heizungsregelung.Views
{
    partial class Functions
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
            this.Function_Panel = new System.Windows.Forms.Panel();
            this.Function_ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Tag_Nacht_Button = new Heizungsregelung.TransparentButton();
            this.Sommer_Winter_Button = new Heizungsregelung.TransparentButton();
            this.AntiFreeze_Button = new Heizungsregelung.TransparentButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Functions_Back_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedFunctionLabel = new System.Windows.Forms.Label();
            this.Boiler_Button = new System.Windows.Forms.Button();
            this.Function_Panel.SuspendLayout();
            this.Function_ButtonPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Function_Panel
            // 
            this.Function_Panel.Controls.Add(this.Function_ButtonPanel);
            this.Function_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Function_Panel.Location = new System.Drawing.Point(0, 89);
            this.Function_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Function_Panel.Name = "Function_Panel";
            this.Function_Panel.Size = new System.Drawing.Size(514, 269);
            this.Function_Panel.TabIndex = 24;
            // 
            // Function_ButtonPanel
            // 
            this.Function_ButtonPanel.ColumnCount = 2;
            this.Function_ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Function_ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Function_ButtonPanel.Controls.Add(this.Tag_Nacht_Button, 1, 1);
            this.Function_ButtonPanel.Controls.Add(this.Sommer_Winter_Button, 1, 0);
            this.Function_ButtonPanel.Controls.Add(this.AntiFreeze_Button, 0, 1);
            this.Function_ButtonPanel.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.Function_ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Function_ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.Function_ButtonPanel.Name = "Function_ButtonPanel";
            this.Function_ButtonPanel.RowCount = 2;
            this.Function_ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Function_ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Function_ButtonPanel.Size = new System.Drawing.Size(514, 269);
            this.Function_ButtonPanel.TabIndex = 0;
            // 
            // Tag_Nacht_Button
            // 
            this.Tag_Nacht_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tag_Nacht_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Tag_Nacht_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Tag_Nacht_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tag_Nacht_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tag_Nacht_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Tag_Nacht_Button.Location = new System.Drawing.Point(260, 137);
            this.Tag_Nacht_Button.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.Tag_Nacht_Button.Name = "Tag_Nacht_Button";
            this.Tag_Nacht_Button.Size = new System.Drawing.Size(254, 132);
            this.Tag_Nacht_Button.TabIndex = 19;
            this.Tag_Nacht_Button.Text = "Tag\r\nNacht";
            this.Tag_Nacht_Button.UseVisualStyleBackColor = true;
            this.Tag_Nacht_Button.Click += new System.EventHandler(this.Tag_Nacht_Click);
            // 
            // Sommer_Winter_Button
            // 
            this.Sommer_Winter_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sommer_Winter_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sommer_Winter_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Sommer_Winter_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sommer_Winter_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sommer_Winter_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Sommer_Winter_Button.Location = new System.Drawing.Point(260, 0);
            this.Sommer_Winter_Button.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.Sommer_Winter_Button.Name = "Sommer_Winter_Button";
            this.Sommer_Winter_Button.Size = new System.Drawing.Size(254, 131);
            this.Sommer_Winter_Button.TabIndex = 23;
            this.Sommer_Winter_Button.Text = "Sommer\r\nWinter";
            this.Sommer_Winter_Button.UseVisualStyleBackColor = true;
            this.Sommer_Winter_Button.Click += new System.EventHandler(this.Sommer_Winter_Click);
            // 
            // AntiFreeze_Button
            // 
            this.AntiFreeze_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AntiFreeze_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AntiFreeze_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AntiFreeze_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AntiFreeze_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntiFreeze_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AntiFreeze_Button.Location = new System.Drawing.Point(0, 137);
            this.AntiFreeze_Button.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.AntiFreeze_Button.Name = "AntiFreeze_Button";
            this.AntiFreeze_Button.Size = new System.Drawing.Size(254, 132);
            this.AntiFreeze_Button.TabIndex = 18;
            this.AntiFreeze_Button.Text = "Anti-\r\nFreeze";
            this.AntiFreeze_Button.UseVisualStyleBackColor = true;
            this.AntiFreeze_Button.Click += new System.EventHandler(this.AntiFreeze_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.Boiler_Button, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(257, 134);
            this.tableLayoutPanel5.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Function_Panel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 358);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(514, 89);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.Functions_Back_Button, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(257, 89);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // Functions_Back_Button
            // 
            this.Functions_Back_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Functions_Back_Button.FlatAppearance.BorderSize = 0;
            this.Functions_Back_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Functions_Back_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Functions_Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Functions_Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Functions_Back_Button.ForeColor = System.Drawing.Color.White;
            this.Functions_Back_Button.Location = new System.Drawing.Point(3, 3);
            this.Functions_Back_Button.Name = "Functions_Back_Button";
            this.Functions_Back_Button.Size = new System.Drawing.Size(251, 83);
            this.Functions_Back_Button.TabIndex = 2;
            this.Functions_Back_Button.Text = "Functions";
            this.Functions_Back_Button.UseVisualStyleBackColor = true;
            this.Functions_Back_Button.Click += new System.EventHandler(this.Back_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.SelectedFunctionLabel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(257, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(257, 89);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // SelectedFunctionLabel
            // 
            this.SelectedFunctionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedFunctionLabel.AutoSize = true;
            this.SelectedFunctionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFunctionLabel.ForeColor = System.Drawing.Color.White;
            this.SelectedFunctionLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedFunctionLabel.Name = "SelectedFunctionLabel";
            this.SelectedFunctionLabel.Size = new System.Drawing.Size(251, 89);
            this.SelectedFunctionLabel.TabIndex = 3;
            this.SelectedFunctionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Boiler_Button
            // 
            this.Boiler_Button.BackColor = System.Drawing.Color.Transparent;
            this.Boiler_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Boiler_Button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Boiler_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Boiler_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boiler_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boiler_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Boiler_Button.Location = new System.Drawing.Point(0, 0);
            this.Boiler_Button.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.Boiler_Button.Name = "Boiler_Button";
            this.Boiler_Button.Size = new System.Drawing.Size(254, 131);
            this.Boiler_Button.TabIndex = 0;
            this.Boiler_Button.Text = "Boiler";
            this.Boiler_Button.UseVisualStyleBackColor = false;
            this.Boiler_Button.Click += new System.EventHandler(this.Boiler_Click);
            // 
            // Functions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Functions";
            this.Size = new System.Drawing.Size(514, 358);
            this.Function_Panel.ResumeLayout(false);
            this.Function_ButtonPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Function_Panel;
        private System.Windows.Forms.TableLayoutPanel Function_ButtonPanel;
        private TransparentButton Tag_Nacht_Button;
        private TransparentButton Sommer_Winter_Button;
        private TransparentButton AntiFreeze_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label SelectedFunctionLabel;
        private System.Windows.Forms.Button Functions_Back_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button Boiler_Button;
    }
}
