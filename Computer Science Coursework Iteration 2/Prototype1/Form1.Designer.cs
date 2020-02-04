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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.spawnUnitButton = new System.Windows.Forms.Button();
            this.stopUnit = new System.Windows.Forms.Button();
            this.moveUnit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spawnEnemyTank = new System.Windows.Forms.Button();
            this.lanscapeBounds.SuspendLayout();
            this.SuspendLayout();
            // 
            // Landscape
            // 
            this.Landscape.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Landscape.Location = new System.Drawing.Point(50, 300);
            this.Landscape.Name = "Landscape";
            this.Landscape.Size = new System.Drawing.Size(80, 80);
            this.Landscape.TabIndex = 0;
            this.Landscape.Text = "Generate Landscape and reset units";
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
            this.lanscapeBounds.Size = new System.Drawing.Size(1400, 200);
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
            this.Background.Size = new System.Drawing.Size(1400, 200);
            this.Background.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // spawnUnitButton
            // 
            this.spawnUnitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.spawnUnitButton.Location = new System.Drawing.Point(150, 300);
            this.spawnUnitButton.Name = "spawnUnitButton";
            this.spawnUnitButton.Size = new System.Drawing.Size(80, 80);
            this.spawnUnitButton.TabIndex = 3;
            this.spawnUnitButton.Text = "Spawn New Tank";
            this.spawnUnitButton.UseVisualStyleBackColor = false;
            this.spawnUnitButton.Click += new System.EventHandler(this.spawnUnitButton_Click);
            // 
            // stopUnit
            // 
            this.stopUnit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.stopUnit.Location = new System.Drawing.Point(250, 408);
            this.stopUnit.Name = "stopUnit";
            this.stopUnit.Size = new System.Drawing.Size(150, 23);
            this.stopUnit.TabIndex = 4;
            this.stopUnit.Text = "Stop Unit";
            this.stopUnit.UseVisualStyleBackColor = false;
            this.stopUnit.Click += new System.EventHandler(this.stopUnit_Click);
            // 
            // moveUnit
            // 
            this.moveUnit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.moveUnit.Location = new System.Drawing.Point(50, 408);
            this.moveUnit.Name = "moveUnit";
            this.moveUnit.Size = new System.Drawing.Size(150, 23);
            this.moveUnit.TabIndex = 5;
            this.moveUnit.Text = "Move Unit";
            this.moveUnit.UseVisualStyleBackColor = false;
            this.moveUnit.Click += new System.EventHandler(this.moveUnit_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1450, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 300);
            this.panel1.TabIndex = 6;
            // 
            // spawnEnemyTank
            // 
            this.spawnEnemyTank.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.spawnEnemyTank.Location = new System.Drawing.Point(250, 300);
            this.spawnEnemyTank.Name = "spawnEnemyTank";
            this.spawnEnemyTank.Size = new System.Drawing.Size(80, 80);
            this.spawnEnemyTank.TabIndex = 7;
            this.spawnEnemyTank.Text = "Spawn Enemy Tank";
            this.spawnEnemyTank.UseVisualStyleBackColor = false;
            this.spawnEnemyTank.Click += new System.EventHandler(this.spawnEnemyTank_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1484, 461);
            this.Controls.Add(this.spawnEnemyTank);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.moveUnit);
            this.Controls.Add(this.stopUnit);
            this.Controls.Add(this.spawnUnitButton);
            this.Controls.Add(this.Landscape);
            this.Controls.Add(this.lanscapeBounds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.lanscapeBounds.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Landscape;
        public System.Windows.Forms.Panel lanscapeBounds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button spawnUnitButton;
        private System.Windows.Forms.Button stopUnit;
        private System.Windows.Forms.Button moveUnit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button spawnEnemyTank;
        private System.Windows.Forms.Panel Background;
    }
}

