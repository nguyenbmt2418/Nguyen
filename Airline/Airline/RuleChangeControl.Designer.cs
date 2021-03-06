﻿namespace Airline
{
    partial class RuleChangeControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.listSex = new Bunifu.Framework.UI.BunifuDropdown();
            this.newValue = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose what you want to change:";
            // 
            // listSex
            // 
            this.listSex.BackColor = System.Drawing.Color.Transparent;
            this.listSex.BorderRadius = 3;
            this.listSex.DisabledColor = System.Drawing.Color.Gray;
            this.listSex.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSex.ForeColor = System.Drawing.Color.White;
            this.listSex.Items = new string[] {
        "The number of airport",
        "Minimum flying time",
        "Maximum number of intermediate airports",
        "Minimum stopping time at intermediate airport",
        "Maximum stopping time at intermediate airport",
        "The number of ticket category",
        "The slowest time when booking tickets",
        "Ticket cancellation time"};
            this.listSex.Location = new System.Drawing.Point(119, 111);
            this.listSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listSex.Name = "listSex";
            this.listSex.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.listSex.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.listSex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listSex.selectedIndex = 0;
            this.listSex.Size = new System.Drawing.Size(365, 31);
            this.listSex.TabIndex = 6;
            // 
            // newValue
            // 
            this.newValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newValue.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newValue.ForeColor = System.Drawing.Color.Black;
            this.newValue.HintForeColor = System.Drawing.Color.DimGray;
            this.newValue.HintText = "NEW VALUE";
            this.newValue.isPassword = false;
            this.newValue.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.newValue.LineIdleColor = System.Drawing.Color.Gray;
            this.newValue.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.newValue.LineThickness = 3;
            this.newValue.Location = new System.Drawing.Point(119, 150);
            this.newValue.Margin = new System.Windows.Forms.Padding(4);
            this.newValue.Name = "newValue";
            this.newValue.Size = new System.Drawing.Size(254, 33);
            this.newValue.TabIndex = 11;
            this.newValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RuleChangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newValue);
            this.Controls.Add(this.listSex);
            this.Controls.Add(this.label1);
            this.Name = "RuleChangeControl";
            this.Size = new System.Drawing.Size(599, 349);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown listSex;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newValue;
    }
}
