namespace Prototype1
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
            this.components = new System.ComponentModel.Container();
            this.Landscape = new System.Windows.Forms.Button();
            this.lanscapeBounds = new System.Windows.Forms.Panel();
            this.Background = new System.Windows.Forms.Panel();
            this.WinLoose = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SpawnTank = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SpawnGunCar = new System.Windows.Forms.Button();
            this.SpawnRocketTruck = new System.Windows.Forms.Button();
            this.SpawnFreindlyHumvee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.TankHover = new System.Windows.Forms.Button();
            this.GunCarHover = new System.Windows.Forms.Button();
            this.RocketTruckHover = new System.Windows.Forms.Button();
            this.HumveeHover = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lanscapeBounds.SuspendLayout();
            this.SuspendLayout();
            // 
            // Landscape
            // 
            this.Landscape.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Landscape.Location = new System.Drawing.Point(58, 300);
            this.Landscape.Name = "Landscape";
            this.Landscape.Size = new System.Drawing.Size(93, 80);
            this.Landscape.TabIndex = 0;
            this.Landscape.Text = "Restart";
            this.Landscape.UseVisualStyleBackColor = false;
            this.Landscape.Click += new System.EventHandler(this.button1_Click);
            // 
            // lanscapeBounds
            // 
            this.lanscapeBounds.BackColor = System.Drawing.Color.Transparent;
            this.lanscapeBounds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lanscapeBounds.Controls.Add(this.Background);
            this.lanscapeBounds.Location = new System.Drawing.Point(50, 50);
            this.lanscapeBounds.Name = "lanscapeBounds";
            this.lanscapeBounds.Size = new System.Drawing.Size(1633, 200);
            this.lanscapeBounds.TabIndex = 1;
            this.lanscapeBounds.Paint += new System.Windows.Forms.PaintEventHandler(this.lanscapeBounds_Paint);
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.DimGray;
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Background.CausesValidation = false;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1450, 200);
            this.Background.TabIndex = 0;
            this.Background.Paint += new System.Windows.Forms.PaintEventHandler(this.Background_Paint);
            this.Background.MouseHover += new System.EventHandler(this.Form1_Load);
            // 
            // WinLoose
            // 
            this.WinLoose.AutoSize = true;
            this.WinLoose.Font = new System.Drawing.Font("Onyx", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinLoose.ForeColor = System.Drawing.Color.Black;
            this.WinLoose.Location = new System.Drawing.Point(1045, 297);
            this.WinLoose.Name = "WinLoose";
            this.WinLoose.Size = new System.Drawing.Size(238, 107);
            this.WinLoose.TabIndex = 0;
            this.WinLoose.Text = "You Win";
            this.WinLoose.Click += new System.EventHandler(this.WinLoose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SpawnTank
            // 
            this.SpawnTank.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SpawnTank.CausesValidation = false;
            this.SpawnTank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SpawnTank.Image = global::Prototype1.Properties.Resources.FreindlyTankImage;
            this.SpawnTank.Location = new System.Drawing.Point(175, 300);
            this.SpawnTank.Name = "SpawnTank";
            this.SpawnTank.Size = new System.Drawing.Size(93, 80);
            this.SpawnTank.TabIndex = 3;
            this.SpawnTank.Text = "\r\n\r\n\r\n\r\n(£5000)";
            this.SpawnTank.UseVisualStyleBackColor = false;
            this.SpawnTank.Click += new System.EventHandler(this.spawnUnitButton_Click);
            this.SpawnTank.MouseHover += new System.EventHandler(this.TankHover_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1450, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 300);
            this.panel1.TabIndex = 6;
            // 
            // SpawnGunCar
            // 
            this.SpawnGunCar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SpawnGunCar.Image = global::Prototype1.Properties.Resources.GunCarFreindly;
            this.SpawnGunCar.Location = new System.Drawing.Point(292, 300);
            this.SpawnGunCar.Name = "SpawnGunCar";
            this.SpawnGunCar.Size = new System.Drawing.Size(93, 80);
            this.SpawnGunCar.TabIndex = 7;
            this.SpawnGunCar.Text = "\r\n\r\n\r\n\r\n(£2500)";
            this.SpawnGunCar.UseVisualStyleBackColor = false;
            this.SpawnGunCar.Click += new System.EventHandler(this.spawnEnemyTank_Click);
            this.SpawnGunCar.MouseHover += new System.EventHandler(this.GunCarHover_Click);
            // 
            // SpawnRocketTruck
            // 
            this.SpawnRocketTruck.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SpawnRocketTruck.Image = global::Prototype1.Properties.Resources.FreindlyRocketTruck;
            this.SpawnRocketTruck.Location = new System.Drawing.Point(408, 300);
            this.SpawnRocketTruck.Name = "SpawnRocketTruck";
            this.SpawnRocketTruck.Size = new System.Drawing.Size(93, 80);
            this.SpawnRocketTruck.TabIndex = 8;
            this.SpawnRocketTruck.Text = "\r\n\r\n\r\n\r\n(£2500)";
            this.SpawnRocketTruck.UseVisualStyleBackColor = false;
            this.SpawnRocketTruck.Click += new System.EventHandler(this.SpawnRocketTruck_Click);
            this.SpawnRocketTruck.MouseHover += new System.EventHandler(this.RocketTruckHover_Click);
            // 
            // SpawnFreindlyHumvee
            // 
            this.SpawnFreindlyHumvee.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SpawnFreindlyHumvee.Image = global::Prototype1.Properties.Resources.FreindlyHumvee;
            this.SpawnFreindlyHumvee.Location = new System.Drawing.Point(529, 300);
            this.SpawnFreindlyHumvee.Name = "SpawnFreindlyHumvee";
            this.SpawnFreindlyHumvee.Size = new System.Drawing.Size(93, 80);
            this.SpawnFreindlyHumvee.TabIndex = 13;
            this.SpawnFreindlyHumvee.Text = "\r\n\r\n\r\n\r\n(£1500)";
            this.SpawnFreindlyHumvee.UseVisualStyleBackColor = false;
            this.SpawnFreindlyHumvee.Click += new System.EventHandler(this.SpawnFreindlyHumvee_Click);
            this.SpawnFreindlyHumvee.MouseHover += new System.EventHandler(this.HumveeHover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1283, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Funds: 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Base Health: 100";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 250);
            this.panel2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(950, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Enemy Base Health: 100";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(64, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "| |";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pause (Includes Instructions)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(801, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Information";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(745, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Buy units by clicking the buttons here.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(998, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "make sure to check your funds\r\nas some units are more expensive than others. ->";
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Play.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Play.Location = new System.Drawing.Point(64, 5);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(40, 40);
            this.Play.TabIndex = 21;
            this.Play.Text = ">";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            this.Play.MouseHover += new System.EventHandler(this.button1_Click_2);
            // 
            // TankHover
            // 
            this.TankHover.Location = new System.Drawing.Point(670, 381);
            this.TankHover.Name = "TankHover";
            this.TankHover.Size = new System.Drawing.Size(75, 23);
            this.TankHover.TabIndex = 22;
            this.TankHover.Text = "button2";
            this.TankHover.UseVisualStyleBackColor = true;
            this.TankHover.Visible = false;
            this.TankHover.Click += new System.EventHandler(this.TankHover_Click);
            // 
            // GunCarHover
            // 
            this.GunCarHover.Location = new System.Drawing.Point(670, 352);
            this.GunCarHover.Name = "GunCarHover";
            this.GunCarHover.Size = new System.Drawing.Size(75, 23);
            this.GunCarHover.TabIndex = 23;
            this.GunCarHover.Text = "button3";
            this.GunCarHover.UseVisualStyleBackColor = true;
            this.GunCarHover.Visible = false;
            this.GunCarHover.Click += new System.EventHandler(this.GunCarHover_Click);
            // 
            // RocketTruckHover
            // 
            this.RocketTruckHover.Location = new System.Drawing.Point(670, 323);
            this.RocketTruckHover.Name = "RocketTruckHover";
            this.RocketTruckHover.Size = new System.Drawing.Size(75, 23);
            this.RocketTruckHover.TabIndex = 24;
            this.RocketTruckHover.Text = "button4";
            this.RocketTruckHover.UseVisualStyleBackColor = true;
            this.RocketTruckHover.Visible = false;
            this.RocketTruckHover.Click += new System.EventHandler(this.RocketTruckHover_Click);
            // 
            // HumveeHover
            // 
            this.HumveeHover.Location = new System.Drawing.Point(670, 293);
            this.HumveeHover.Name = "HumveeHover";
            this.HumveeHover.Size = new System.Drawing.Size(75, 23);
            this.HumveeHover.TabIndex = 25;
            this.HumveeHover.Text = "button5";
            this.HumveeHover.UseVisualStyleBackColor = true;
            this.HumveeHover.Visible = false;
            this.HumveeHover.Click += new System.EventHandler(this.HumveeHover_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(998, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Killing enemy units grants funds.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1584, 422);
            this.Controls.Add(this.WinLoose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HumveeHover);
            this.Controls.Add(this.RocketTruckHover);
            this.Controls.Add(this.GunCarHover);
            this.Controls.Add(this.TankHover);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpawnFreindlyHumvee);
            this.Controls.Add(this.SpawnRocketTruck);
            this.Controls.Add(this.SpawnGunCar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SpawnTank);
            this.Controls.Add(this.Landscape);
            this.Controls.Add(this.lanscapeBounds);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_Load);
            this.lanscapeBounds.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Landscape;
        public System.Windows.Forms.Panel lanscapeBounds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SpawnTank;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SpawnGunCar;
        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.Button SpawnRocketTruck;
        private System.Windows.Forms.Button SpawnFreindlyHumvee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WinLoose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button TankHover;
        private System.Windows.Forms.Button GunCarHover;
        private System.Windows.Forms.Button RocketTruckHover;
        private System.Windows.Forms.Button HumveeHover;
        private System.Windows.Forms.Label label9;
    }
}

