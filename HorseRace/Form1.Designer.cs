﻿namespace HorseRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.Horse1 = new System.Windows.Forms.PictureBox();
            this.Horse2 = new System.Windows.Forms.PictureBox();
            this.Horse3 = new System.Windows.Forms.PictureBox();
            this.Horse4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MeganBet = new System.Windows.Forms.Label();
            this.RockyBet = new System.Windows.Forms.Label();
            this.JassyBet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.HorseNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BettingAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.MeganButton = new System.Windows.Forms.RadioButton();
            this.RockyButton = new System.Windows.Forms.RadioButton();
            this.JassyButton = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.SystemColors.Control;
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(-1, -79);
            this.racetrack.Margin = new System.Windows.Forms.Padding(4);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1069, 527);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            // 
            // Horse1
            // 
            this.Horse1.Image = ((System.Drawing.Image)(resources.GetObject("Horse1.Image")));
            this.Horse1.Location = new System.Drawing.Point(17, 4);
            this.Horse1.Margin = new System.Windows.Forms.Padding(4);
            this.Horse1.Name = "Horse1";
            this.Horse1.Size = new System.Drawing.Size(100, 74);
            this.Horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Horse1.TabIndex = 1;
            this.Horse1.TabStop = false;
            // 
            // Horse2
            // 
            this.Horse2.Image = ((System.Drawing.Image)(resources.GetObject("Horse2.Image")));
            this.Horse2.Location = new System.Drawing.Point(18, 105);
            this.Horse2.Margin = new System.Windows.Forms.Padding(4);
            this.Horse2.Name = "Horse2";
            this.Horse2.Size = new System.Drawing.Size(100, 74);
            this.Horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Horse2.TabIndex = 2;
            this.Horse2.TabStop = false;
            // 
            // Horse3
            // 
            this.Horse3.Image = ((System.Drawing.Image)(resources.GetObject("Horse3.Image")));
            this.Horse3.Location = new System.Drawing.Point(18, 217);
            this.Horse3.Margin = new System.Windows.Forms.Padding(4);
            this.Horse3.Name = "Horse3";
            this.Horse3.Size = new System.Drawing.Size(100, 74);
            this.Horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Horse3.TabIndex = 3;
            this.Horse3.TabStop = false;
            // 
            // Horse4
            // 
            this.Horse4.Image = ((System.Drawing.Image)(resources.GetObject("Horse4.Image")));
            this.Horse4.Location = new System.Drawing.Point(18, 326);
            this.Horse4.Margin = new System.Windows.Forms.Padding(4);
            this.Horse4.Name = "Horse4";
            this.Horse4.Size = new System.Drawing.Size(100, 74);
            this.Horse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Horse4.TabIndex = 4;
            this.Horse4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.MeganBet);
            this.groupBox1.Controls.Add(this.RockyBet);
            this.groupBox1.Controls.Add(this.JassyBet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.HorseNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BettingAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.MeganButton);
            this.groupBox1.Controls.Add(this.RockyButton);
            this.groupBox1.Controls.Add(this.JassyButton);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Location = new System.Drawing.Point(-1, 455);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1069, 207);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Counter";
            // 
            // MeganBet
            // 
            this.MeganBet.BackColor = System.Drawing.SystemColors.Info;
            this.MeganBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeganBet.Location = new System.Drawing.Point(649, 110);
            this.MeganBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MeganBet.Name = "MeganBet";
            this.MeganBet.Size = new System.Drawing.Size(386, 20);
            this.MeganBet.TabIndex = 13;
            this.MeganBet.Text = "label6";
            // 
            // RockyBet
            // 
            this.RockyBet.BackColor = System.Drawing.SystemColors.Info;
            this.RockyBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RockyBet.Location = new System.Drawing.Point(649, 80);
            this.RockyBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RockyBet.Name = "RockyBet";
            this.RockyBet.Size = new System.Drawing.Size(386, 20);
            this.RockyBet.TabIndex = 12;
            this.RockyBet.Text = "label5";
            // 
            // JassyBet
            // 
            this.JassyBet.BackColor = System.Drawing.SystemColors.Info;
            this.JassyBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JassyBet.Location = new System.Drawing.Point(649, 50);
            this.JassyBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JassyBet.Name = "JassyBet";
            this.JassyBet.Size = new System.Drawing.Size(386, 20);
            this.JassyBet.TabIndex = 11;
            this.JassyBet.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // race
            // 
            this.race.BackColor = System.Drawing.Color.LightCoral;
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(856, 145);
            this.race.Margin = new System.Windows.Forms.Padding(4);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(180, 37);
            this.race.TabIndex = 9;
            this.race.Text = "START RACE";
            this.race.UseVisualStyleBackColor = false;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // HorseNumber
            // 
            this.HorseNumber.Location = new System.Drawing.Point(529, 106);
            this.HorseNumber.Margin = new System.Windows.Forms.Padding(4);
            this.HorseNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.HorseNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HorseNumber.Name = "HorseNumber";
            this.HorseNumber.Size = new System.Drawing.Size(85, 22);
            this.HorseNumber.TabIndex = 8;
            this.HorseNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Horse number";
            // 
            // BettingAmount
            // 
            this.BettingAmount.Location = new System.Drawing.Point(531, 47);
            this.BettingAmount.Margin = new System.Windows.Forms.Padding(4);
            this.BettingAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BettingAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.Name = "BettingAmount";
            this.BettingAmount.Size = new System.Drawing.Size(84, 22);
            this.BettingAmount.TabIndex = 6;
            this.BettingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bets
            // 
            this.Bets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bets.Location = new System.Drawing.Point(364, 37);
            this.Bets.Margin = new System.Windows.Forms.Padding(4);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(112, 44);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = false;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // MeganButton
            // 
            this.MeganButton.AutoSize = true;
            this.MeganButton.Checked = true;
            this.MeganButton.Location = new System.Drawing.Point(19, 119);
            this.MeganButton.Margin = new System.Windows.Forms.Padding(4);
            this.MeganButton.Name = "MeganButton";
            this.MeganButton.Size = new System.Drawing.Size(72, 21);
            this.MeganButton.TabIndex = 3;
            this.MeganButton.TabStop = true;
            this.MeganButton.Text = "Megan";
            this.MeganButton.UseVisualStyleBackColor = true;
            this.MeganButton.CheckedChanged += new System.EventHandler(this.MikeButton_CheckedChanged);
            // 
            // RockyButton
            // 
            this.RockyButton.AutoSize = true;
            this.RockyButton.Location = new System.Drawing.Point(19, 90);
            this.RockyButton.Margin = new System.Windows.Forms.Padding(4);
            this.RockyButton.Name = "RockyButton";
            this.RockyButton.Size = new System.Drawing.Size(68, 21);
            this.RockyButton.TabIndex = 2;
            this.RockyButton.Text = "Rocky";
            this.RockyButton.UseVisualStyleBackColor = true;
            this.RockyButton.CheckedChanged += new System.EventHandler(this.RogerButton_CheckedChanged);
            // 
            // JassyButton
            // 
            this.JassyButton.AutoSize = true;
            this.JassyButton.Location = new System.Drawing.Point(19, 60);
            this.JassyButton.Margin = new System.Windows.Forms.Padding(4);
            this.JassyButton.Name = "JassyButton";
            this.JassyButton.Size = new System.Drawing.Size(65, 21);
            this.JassyButton.TabIndex = 1;
            this.JassyButton.Text = "Jassy";
            this.JassyButton.UseVisualStyleBackColor = true;
            this.JassyButton.CheckedChanged += new System.EventHandler(this.JimButton_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(15, 30);
            this.MaximumBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(120, 20);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Horse4);
            this.Controls.Add(this.Horse3);
            this.Controls.Add(this.Horse2);
            this.Controls.Add(this.Horse1);
            this.Controls.Add(this.racetrack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Horse Race";
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.PictureBox Horse1;
        private System.Windows.Forms.PictureBox Horse2;
        private System.Windows.Forms.PictureBox Horse3;
        private System.Windows.Forms.PictureBox Horse4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MeganButton;
        private System.Windows.Forms.RadioButton RockyButton;
        private System.Windows.Forms.RadioButton JassyButton;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BettingAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown HorseNumber;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label JassyBet;
        private System.Windows.Forms.Label MeganBet;
        private System.Windows.Forms.Label RockyBet;
    }
}
