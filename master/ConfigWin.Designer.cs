using System;

namespace StandUp
{
    partial class ConfigWin
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
            this.labelMaxTime = new System.Windows.Forms.Label();
            this.maxtimeH = new System.Windows.Forms.NumericUpDown();
            this.maxtimeM = new System.Windows.Forms.NumericUpDown();
            this.hours1 = new System.Windows.Forms.Label();
            this.minutes1 = new System.Windows.Forms.Label();
            this.labelMinTime = new System.Windows.Forms.Label();
            this.minutes2 = new System.Windows.Forms.Label();
            this.hours2 = new System.Windows.Forms.Label();
            this.mintimeM = new System.Windows.Forms.NumericUpDown();
            this.mintimeH = new System.Windows.Forms.NumericUpDown();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNag = new System.Windows.Forms.Label();
            this.nagCheck = new System.Windows.Forms.CheckBox();
            this.minutes3 = new System.Windows.Forms.Label();
            this.hours3 = new System.Windows.Forms.Label();
            this.nagtimeM = new System.Windows.Forms.NumericUpDown();
            this.nagtimeH = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.configErrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maxtimeH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxtimeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mintimeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mintimeH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagtimeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagtimeH)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaxTime
            // 
            this.labelMaxTime.AutoSize = true;
            this.labelMaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxTime.Location = new System.Drawing.Point(25, 59);
            this.labelMaxTime.Name = "labelMaxTime";
            this.labelMaxTime.Size = new System.Drawing.Size(139, 13);
            this.labelMaxTime.TabIndex = 0;
            this.labelMaxTime.Text = "Maximum Activity Time:";
            // 
            // maxtimeH
            // 
            this.maxtimeH.Location = new System.Drawing.Point(170, 57);
            this.maxtimeH.Name = "maxtimeH";
            this.maxtimeH.Size = new System.Drawing.Size(39, 20);
            this.maxtimeH.TabIndex = 1;
            // 
            // maxtimeM
            // 
            this.maxtimeM.Location = new System.Drawing.Point(256, 57);
            this.maxtimeM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.maxtimeM.Name = "maxtimeM";
            this.maxtimeM.Size = new System.Drawing.Size(39, 20);
            this.maxtimeM.TabIndex = 2;
            // 
            // hours1
            // 
            this.hours1.AutoSize = true;
            this.hours1.Location = new System.Drawing.Point(215, 64);
            this.hours1.Name = "hours1";
            this.hours1.Size = new System.Drawing.Size(35, 13);
            this.hours1.TabIndex = 3;
            this.hours1.Text = "Hours";
            // 
            // minutes1
            // 
            this.minutes1.AutoSize = true;
            this.minutes1.Location = new System.Drawing.Point(302, 64);
            this.minutes1.Name = "minutes1";
            this.minutes1.Size = new System.Drawing.Size(44, 13);
            this.minutes1.TabIndex = 4;
            this.minutes1.Text = "Minutes";
            // 
            // labelMinTime
            // 
            this.labelMinTime.AutoSize = true;
            this.labelMinTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinTime.Location = new System.Drawing.Point(25, 96);
            this.labelMinTime.Name = "labelMinTime";
            this.labelMinTime.Size = new System.Drawing.Size(127, 13);
            this.labelMinTime.TabIndex = 5;
            this.labelMinTime.Text = "Minimum Break Time:";
            // 
            // minutes2
            // 
            this.minutes2.AutoSize = true;
            this.minutes2.Location = new System.Drawing.Point(302, 101);
            this.minutes2.Name = "minutes2";
            this.minutes2.Size = new System.Drawing.Size(44, 13);
            this.minutes2.TabIndex = 9;
            this.minutes2.Text = "Minutes";
            // 
            // hours2
            // 
            this.hours2.AutoSize = true;
            this.hours2.Location = new System.Drawing.Point(215, 101);
            this.hours2.Name = "hours2";
            this.hours2.Size = new System.Drawing.Size(35, 13);
            this.hours2.TabIndex = 8;
            this.hours2.Text = "Hours";
            // 
            // mintimeM
            // 
            this.mintimeM.Location = new System.Drawing.Point(256, 94);
            this.mintimeM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.mintimeM.Name = "mintimeM";
            this.mintimeM.Size = new System.Drawing.Size(39, 20);
            this.mintimeM.TabIndex = 7;
            // 
            // mintimeH
            // 
            this.mintimeH.Location = new System.Drawing.Point(170, 94);
            this.mintimeH.Name = "mintimeH";
            this.mintimeH.Size = new System.Drawing.Size(39, 20);
            this.mintimeH.TabIndex = 6;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(118, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(152, 20);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "StandUp Settings";
            // 
            // labelNag
            // 
            this.labelNag.AutoSize = true;
            this.labelNag.Enabled = false;
            this.labelNag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNag.Location = new System.Drawing.Point(47, 174);
            this.labelNag.Name = "labelNag";
            this.labelNag.Size = new System.Drawing.Size(85, 13);
            this.labelNag.TabIndex = 11;
            this.labelNag.Text = "Nag Interval: ";
            // 
            // nagCheck
            // 
            this.nagCheck.AutoSize = true;
            this.nagCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nagCheck.Location = new System.Drawing.Point(28, 144);
            this.nagCheck.Name = "nagCheck";
            this.nagCheck.Size = new System.Drawing.Size(118, 17);
            this.nagCheck.TabIndex = 12;
            this.nagCheck.Text = "Notification Nag";
            this.nagCheck.UseVisualStyleBackColor = true;
            this.nagCheck.CheckedChanged += new System.EventHandler(this.nagcheck_CheckedChanged);
            // 
            // minutes3
            // 
            this.minutes3.AutoSize = true;
            this.minutes3.Enabled = false;
            this.minutes3.Location = new System.Drawing.Point(264, 179);
            this.minutes3.Name = "minutes3";
            this.minutes3.Size = new System.Drawing.Size(44, 13);
            this.minutes3.TabIndex = 16;
            this.minutes3.Text = "Minutes";
            // 
            // hours3
            // 
            this.hours3.AutoSize = true;
            this.hours3.Enabled = false;
            this.hours3.Location = new System.Drawing.Point(177, 179);
            this.hours3.Name = "hours3";
            this.hours3.Size = new System.Drawing.Size(35, 13);
            this.hours3.TabIndex = 15;
            this.hours3.Text = "Hours";
            // 
            // nagtimeM
            // 
            this.nagtimeM.Enabled = false;
            this.nagtimeM.Location = new System.Drawing.Point(218, 172);
            this.nagtimeM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nagtimeM.Name = "nagtimeM";
            this.nagtimeM.Size = new System.Drawing.Size(39, 20);
            this.nagtimeM.TabIndex = 14;
            // 
            // nagtimeH
            // 
            this.nagtimeH.Enabled = false;
            this.nagtimeH.Location = new System.Drawing.Point(132, 172);
            this.nagtimeH.Name = "nagtimeH";
            this.nagtimeH.Size = new System.Drawing.Size(39, 20);
            this.nagtimeH.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(94, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(210, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // configErrLabel
            // 
            this.configErrLabel.AutoSize = true;
            this.configErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configErrLabel.ForeColor = System.Drawing.Color.Crimson;
            this.configErrLabel.Location = new System.Drawing.Point(102, 213);
            this.configErrLabel.Name = "configErrLabel";
            this.configErrLabel.Size = new System.Drawing.Size(169, 13);
            this.configErrLabel.TabIndex = 19;
            this.configErrLabel.Text = "Configuration File Not Found";
            this.configErrLabel.Visible = false;
            // 
            // ConfigWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 273);
            this.Controls.Add(this.configErrLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.minutes3);
            this.Controls.Add(this.hours3);
            this.Controls.Add(this.nagtimeM);
            this.Controls.Add(this.nagtimeH);
            this.Controls.Add(this.nagCheck);
            this.Controls.Add(this.labelNag);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.minutes2);
            this.Controls.Add(this.hours2);
            this.Controls.Add(this.mintimeM);
            this.Controls.Add(this.mintimeH);
            this.Controls.Add(this.labelMinTime);
            this.Controls.Add(this.minutes1);
            this.Controls.Add(this.hours1);
            this.Controls.Add(this.maxtimeM);
            this.Controls.Add(this.maxtimeH);
            this.Controls.Add(this.labelMaxTime);
            this.Name = "ConfigWin";
            this.Text = "StandUp Settings";
            ((System.ComponentModel.ISupportInitialize)(this.maxtimeH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxtimeM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mintimeM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mintimeH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagtimeM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagtimeH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaxTime;
        private System.Windows.Forms.NumericUpDown maxtimeH;
        private System.Windows.Forms.NumericUpDown maxtimeM;
        private System.Windows.Forms.Label hours1;
        private System.Windows.Forms.Label minutes1;
        private System.Windows.Forms.Label labelMinTime;
        private System.Windows.Forms.Label minutes2;
        private System.Windows.Forms.Label hours2;
        private System.Windows.Forms.NumericUpDown mintimeM;
        private System.Windows.Forms.NumericUpDown mintimeH;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNag;
        private System.Windows.Forms.CheckBox nagCheck;
        private System.Windows.Forms.Label minutes3;
        private System.Windows.Forms.Label hours3;
        private System.Windows.Forms.NumericUpDown nagtimeM;
        private System.Windows.Forms.NumericUpDown nagtimeH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label configErrLabel;
    }
}