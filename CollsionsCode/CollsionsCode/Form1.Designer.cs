namespace CollsionsCode
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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Distance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trophy = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Explosion = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.road2 = new System.Windows.Forms.PictureBox();
            this.road1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trophy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(131, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distance.Location = new System.Drawing.Point(223, 447);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(38, 25);
            this.Distance.TabIndex = 2;
            this.Distance.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 72);
            this.label3.TabIndex = 3;
            this.label3.Text = "Avoid other cars and get points\r\n\r\nUse Left and Right Key to Move the car";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.trophy);
            this.panel1.Controls.Add(this.Player);
            this.panel1.Controls.Add(this.Explosion);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.road2);
            this.panel1.Controls.Add(this.road1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 424);
            this.panel1.TabIndex = 4;
            // 
            // trophy
            // 
            this.trophy.BackColor = System.Drawing.Color.Transparent;
            this.trophy.Image = global::CollsionsCode.Properties.Resources.bronze;
            this.trophy.Location = new System.Drawing.Point(66, 157);
            this.trophy.Name = "trophy";
            this.trophy.Size = new System.Drawing.Size(250, 100);
            this.trophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trophy.TabIndex = 6;
            this.trophy.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImage = global::CollsionsCode.Properties.Resources.carOrange;
            this.Player.Image = global::CollsionsCode.Properties.Resources.carOrange;
            this.Player.Location = new System.Drawing.Point(161, 286);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 101);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 5;
            this.Player.TabStop = false;
            // 
            // Explosion
            // 
            this.Explosion.BackColor = System.Drawing.Color.Transparent;
            this.Explosion.BackgroundImage = global::CollsionsCode.Properties.Resources.explosion;
            this.Explosion.Image = global::CollsionsCode.Properties.Resources.explosion;
            this.Explosion.Location = new System.Drawing.Point(153, 234);
            this.Explosion.Name = "Explosion";
            this.Explosion.Size = new System.Drawing.Size(64, 64);
            this.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Explosion.TabIndex = 4;
            this.Explosion.TabStop = false;
            this.Explosion.Click += new System.EventHandler(this.Explosion_Click);
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.Transparent;
            this.AI2.Image = global::CollsionsCode.Properties.Resources.carGreen;
            this.AI2.Location = new System.Drawing.Point(294, 85);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 101);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI2.TabIndex = 3;
            this.AI2.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.Transparent;
            this.AI1.Image = global::CollsionsCode.Properties.Resources.carGrey;
            this.AI1.Location = new System.Drawing.Point(66, 19);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI1.TabIndex = 2;
            this.AI1.TabStop = false;
            // 
            // road2
            // 
            this.road2.Image = global::CollsionsCode.Properties.Resources.roadTrack;
            this.road2.Location = new System.Drawing.Point(-3, -222);
            this.road2.Name = "road2";
            this.road2.Size = new System.Drawing.Size(385, 632);
            this.road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road2.TabIndex = 1;
            this.road2.TabStop = false;
            // 
            // road1
            // 
            this.road1.Image = global::CollsionsCode.Properties.Resources.roadTrack;
            this.road1.Location = new System.Drawing.Point(-2, -638);
            this.road1.Name = "road1";
            this.road1.Size = new System.Drawing.Size(385, 632);
            this.road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road1.TabIndex = 0;
            this.road1.TabStop = false;
            this.road1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moveCar);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stopCar);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trophy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox road2;
        private System.Windows.Forms.PictureBox road1;
        private System.Windows.Forms.PictureBox Explosion;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox trophy;
    }
}

