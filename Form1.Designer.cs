﻿namespace KesselRun
{
    partial class Race
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
            this.components = new System.ComponentModel.Container();
            this.UdBet = new System.Windows.Forms.NumericUpDown();
            this.UdShip = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnWager = new System.Windows.Forms.Button();
            this.RbWatto = new System.Windows.Forms.RadioButton();
            this.RbSnoke = new System.Windows.Forms.RadioButton();
            this.RbJubba = new System.Windows.Forms.RadioButton();
            this.RbCreedo = new System.Windows.Forms.RadioButton();
            this.lblWagerName = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.Pb4 = new System.Windows.Forms.PictureBox();
            this.Pb2 = new System.Windows.Forms.PictureBox();
            this.Pb3 = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWattoCash = new System.Windows.Forms.Label();
            this.lblSnokeCash = new System.Windows.Forms.Label();
            this.lblJubbaCash = new System.Windows.Forms.Label();
            this.lblCreedoCash = new System.Windows.Forms.Label();
            this.lblShipNumber = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UdBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // UdBet
            // 
            this.UdBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UdBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UdBet.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UdBet.Location = new System.Drawing.Point(460, 98);
            this.UdBet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UdBet.Name = "UdBet";
            this.UdBet.Size = new System.Drawing.Size(160, 30);
            this.UdBet.TabIndex = 4;
            this.UdBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // UdShip
            // 
            this.UdShip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UdShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UdShip.Location = new System.Drawing.Point(460, 194);
            this.UdShip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UdShip.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.UdShip.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UdShip.Name = "UdShip";
            this.UdShip.Size = new System.Drawing.Size(160, 30);
            this.UdShip.TabIndex = 5;
            this.UdShip.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1329, 53);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 44);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            this.btnStart.MouseHover += new System.EventHandler(this.BtnStart_MouseHover);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1329, 171);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 44);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "New Race";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnWager
            // 
            this.btnWager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnWager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWager.Location = new System.Drawing.Point(1329, 106);
            this.btnWager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWager.Name = "btnWager";
            this.btnWager.Size = new System.Drawing.Size(133, 44);
            this.btnWager.TabIndex = 8;
            this.btnWager.Text = "Place Bet";
            this.btnWager.UseVisualStyleBackColor = false;
            this.btnWager.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // RbWatto
            // 
            this.RbWatto.AutoSize = true;
            this.RbWatto.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.RbWatto.FlatAppearance.BorderSize = 4;
            this.RbWatto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.RbWatto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.RbWatto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.RbWatto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbWatto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbWatto.Location = new System.Drawing.Point(23, 213);
            this.RbWatto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RbWatto.Name = "RbWatto";
            this.RbWatto.Size = new System.Drawing.Size(85, 29);
            this.RbWatto.TabIndex = 9;
            this.RbWatto.TabStop = true;
            this.RbWatto.Text = "Watto";
            this.RbWatto.UseVisualStyleBackColor = true;
            this.RbWatto.CheckedChanged += new System.EventHandler(this.RbWatto_CheckedChanged);
            // 
            // RbSnoke
            // 
            this.RbSnoke.AutoSize = true;
            this.RbSnoke.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.RbSnoke.FlatAppearance.BorderSize = 4;
            this.RbSnoke.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.RbSnoke.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.RbSnoke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.RbSnoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbSnoke.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbSnoke.Location = new System.Drawing.Point(20, 156);
            this.RbSnoke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RbSnoke.Name = "RbSnoke";
            this.RbSnoke.Size = new System.Drawing.Size(90, 29);
            this.RbSnoke.TabIndex = 10;
            this.RbSnoke.TabStop = true;
            this.RbSnoke.Text = "Snoke";
            this.RbSnoke.UseVisualStyleBackColor = true;
            this.RbSnoke.CheckedChanged += new System.EventHandler(this.RbWatto_CheckedChanged);
            // 
            // RbJubba
            // 
            this.RbJubba.AutoSize = true;
            this.RbJubba.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.RbJubba.FlatAppearance.BorderSize = 4;
            this.RbJubba.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.RbJubba.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.RbJubba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.RbJubba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbJubba.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbJubba.Location = new System.Drawing.Point(20, 106);
            this.RbJubba.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RbJubba.Name = "RbJubba";
            this.RbJubba.Size = new System.Drawing.Size(88, 29);
            this.RbJubba.TabIndex = 11;
            this.RbJubba.TabStop = true;
            this.RbJubba.Text = "Jubba";
            this.RbJubba.UseVisualStyleBackColor = true;
            this.RbJubba.CheckedChanged += new System.EventHandler(this.RbWatto_CheckedChanged);
            // 
            // RbCreedo
            // 
            this.RbCreedo.AutoSize = true;
            this.RbCreedo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.RbCreedo.FlatAppearance.BorderSize = 4;
            this.RbCreedo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.RbCreedo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.RbCreedo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.RbCreedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbCreedo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbCreedo.Location = new System.Drawing.Point(16, 60);
            this.RbCreedo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RbCreedo.Name = "RbCreedo";
            this.RbCreedo.Size = new System.Drawing.Size(98, 29);
            this.RbCreedo.TabIndex = 12;
            this.RbCreedo.TabStop = true;
            this.RbCreedo.Text = "Creedo";
            this.RbCreedo.UseVisualStyleBackColor = true;
            this.RbCreedo.CheckedChanged += new System.EventHandler(this.RbWatto_CheckedChanged);
            // 
            // lblWagerName
            // 
            this.lblWagerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblWagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWagerName.Location = new System.Drawing.Point(647, 38);
            this.lblWagerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWagerName.Name = "lblWagerName";
            this.lblWagerName.Size = new System.Drawing.Size(576, 274);
            this.lblWagerName.TabIndex = 13;
            this.lblWagerName.Click += new System.EventHandler(this.LblWagerName_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(1487, 71);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(255, 188);
            this.lblWinner.TabIndex = 14;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.BackgroundImage = global::KesselRun.Resource1.starry_sky_night_stars_115042_1920x1080;
            this.splitContainer1.Panel1.Controls.Add(this.Pb1);
            this.splitContainer1.Panel1.Controls.Add(this.Pb4);
            this.splitContainer1.Panel1.Controls.Add(this.Pb2);
            this.splitContainer1.Panel1.Controls.Add(this.Pb3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.BackgroundImage = global::KesselRun.Resource1.starry_sky_night_stars_115042_1920x1080;
            this.splitContainer1.Panel2.Controls.Add(this.btnNewGame);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lblWattoCash);
            this.splitContainer1.Panel2.Controls.Add(this.lblSnokeCash);
            this.splitContainer1.Panel2.Controls.Add(this.lblJubbaCash);
            this.splitContainer1.Panel2.Controls.Add(this.lblCreedoCash);
            this.splitContainer1.Panel2.Controls.Add(this.lblShipNumber);
            this.splitContainer1.Panel2.Controls.Add(this.lblCredits);
            this.splitContainer1.Panel2.Controls.Add(this.UdBet);
            this.splitContainer1.Panel2.Controls.Add(this.lblWinner);
            this.splitContainer1.Panel2.Controls.Add(this.btnWager);
            this.splitContainer1.Panel2.Controls.Add(this.UdShip);
            this.splitContainer1.Panel2.Controls.Add(this.btnReset);
            this.splitContainer1.Panel2.Controls.Add(this.lblWagerName);
            this.splitContainer1.Panel2.Controls.Add(this.btnStart);
            this.splitContainer1.Panel2.Controls.Add(this.RbCreedo);
            this.splitContainer1.Panel2.Controls.Add(this.RbWatto);
            this.splitContainer1.Panel2.Controls.Add(this.RbJubba);
            this.splitContainer1.Panel2.Controls.Add(this.RbSnoke);
            this.splitContainer1.Size = new System.Drawing.Size(1782, 903);
            this.splitContainer1.SplitterDistance = 531;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 15;
            // 
            // Pb1
            // 
            this.Pb1.BackColor = System.Drawing.Color.Black;
            this.Pb1.BackgroundImage = global::KesselRun.Resource1.Millenium_Falcon_920x518;
            this.Pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb1.Location = new System.Drawing.Point(8, 4);
            this.Pb1.Margin = new System.Windows.Forms.Padding(0);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(133, 97);
            this.Pb1.TabIndex = 0;
            this.Pb1.TabStop = false;
            // 
            // Pb4
            // 
            this.Pb4.BackgroundImage = global::KesselRun.Resource1._68_960x600f;
            this.Pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb4.Location = new System.Drawing.Point(8, 335);
            this.Pb4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pb4.Name = "Pb4";
            this.Pb4.Size = new System.Drawing.Size(133, 97);
            this.Pb4.TabIndex = 3;
            this.Pb4.TabStop = false;
            // 
            // Pb2
            // 
            this.Pb2.BackgroundImage = global::KesselRun.Resource1.Scimitar_BF2;
            this.Pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb2.Location = new System.Drawing.Point(8, 108);
            this.Pb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pb2.Name = "Pb2";
            this.Pb2.Size = new System.Drawing.Size(133, 97);
            this.Pb2.TabIndex = 1;
            this.Pb2.TabStop = false;
            // 
            // Pb3
            // 
            this.Pb3.BackgroundImage = global::KesselRun.Resource1.Slave_1;
            this.Pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb3.Location = new System.Drawing.Point(8, 213);
            this.Pb3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pb3.Name = "Pb3";
            this.Pb3.Size = new System.Drawing.Size(133, 97);
            this.Pb3.TabIndex = 2;
            this.Pb3.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(1329, 230);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(133, 44);
            this.btnNewGame.TabIndex = 22;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1488, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Winning Punters";
            // 
            // lblWattoCash
            // 
            this.lblWattoCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblWattoCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWattoCash.Location = new System.Drawing.Point(215, 215);
            this.lblWattoCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWattoCash.Name = "lblWattoCash";
            this.lblWattoCash.Size = new System.Drawing.Size(213, 28);
            this.lblWattoCash.TabIndex = 20;
            // 
            // lblSnokeCash
            // 
            this.lblSnokeCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSnokeCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnokeCash.Location = new System.Drawing.Point(215, 171);
            this.lblSnokeCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnokeCash.Name = "lblSnokeCash";
            this.lblSnokeCash.Size = new System.Drawing.Size(213, 28);
            this.lblSnokeCash.TabIndex = 19;
            // 
            // lblJubbaCash
            // 
            this.lblJubbaCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblJubbaCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJubbaCash.Location = new System.Drawing.Point(215, 108);
            this.lblJubbaCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJubbaCash.Name = "lblJubbaCash";
            this.lblJubbaCash.Size = new System.Drawing.Size(213, 28);
            this.lblJubbaCash.TabIndex = 18;
            // 
            // lblCreedoCash
            // 
            this.lblCreedoCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblCreedoCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreedoCash.Location = new System.Drawing.Point(215, 63);
            this.lblCreedoCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreedoCash.Name = "lblCreedoCash";
            this.lblCreedoCash.Size = new System.Drawing.Size(213, 28);
            this.lblCreedoCash.TabIndex = 17;
            // 
            // lblShipNumber
            // 
            this.lblShipNumber.AutoSize = true;
            this.lblShipNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipNumber.ForeColor = System.Drawing.Color.White;
            this.lblShipNumber.Location = new System.Drawing.Point(460, 148);
            this.lblShipNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShipNumber.Name = "lblShipNumber";
            this.lblShipNumber.Size = new System.Drawing.Size(121, 25);
            this.lblShipNumber.TabIndex = 16;
            this.lblShipNumber.Text = "ShipNumber";
            // 
            // lblCredits
            // 
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.ForeColor = System.Drawing.Color.White;
            this.lblCredits.Location = new System.Drawing.Point(456, 63);
            this.lblCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(164, 28);
            this.lblCredits.TabIndex = 15;
            this.lblCredits.Text = "Galactic Credits";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Yellow;
            this.toolTip1.IsBalloon = true;
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1782, 903);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Race";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UdBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UdShip)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.PictureBox Pb2;
        private System.Windows.Forms.PictureBox Pb3;
        private System.Windows.Forms.PictureBox Pb4;
        private System.Windows.Forms.NumericUpDown UdBet;
        private System.Windows.Forms.NumericUpDown UdShip;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnWager;
        private System.Windows.Forms.RadioButton RbWatto;
        private System.Windows.Forms.RadioButton RbSnoke;
        private System.Windows.Forms.RadioButton RbJubba;
        private System.Windows.Forms.RadioButton RbCreedo;
        private System.Windows.Forms.Label lblWagerName;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblShipNumber;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblWattoCash;
        private System.Windows.Forms.Label lblSnokeCash;
        private System.Windows.Forms.Label lblJubbaCash;
        private System.Windows.Forms.Label lblCreedoCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

