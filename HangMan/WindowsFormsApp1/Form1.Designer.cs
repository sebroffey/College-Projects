namespace WindowsFormsApp1
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
            this.form1Title = new System.Windows.Forms.Label();
            this.form1PlayerLabel = new System.Windows.Forms.Label();
            this.form1PlayerName = new System.Windows.Forms.TextBox();
            this.form1StartButton = new System.Windows.Forms.Button();
            this.form1Warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // form1Title
            // 
            this.form1Title.AutoSize = true;
            this.form1Title.BackColor = System.Drawing.Color.SlateGray;
            this.form1Title.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1Title.Location = new System.Drawing.Point(78, 27);
            this.form1Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.form1Title.Name = "form1Title";
            this.form1Title.Size = new System.Drawing.Size(1133, 98);
            this.form1Title.TabIndex = 0;
            this.form1Title.Text = "Hangman Supreme Edition";
            // 
            // form1PlayerLabel
            // 
            this.form1PlayerLabel.AutoSize = true;
            this.form1PlayerLabel.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1PlayerLabel.Location = new System.Drawing.Point(667, 623);
            this.form1PlayerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.form1PlayerLabel.Name = "form1PlayerLabel";
            this.form1PlayerLabel.Size = new System.Drawing.Size(172, 29);
            this.form1PlayerLabel.TabIndex = 1;
            this.form1PlayerLabel.Text = "Player name:";
            // 
            // form1PlayerName
            // 
            this.form1PlayerName.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1PlayerName.Location = new System.Drawing.Point(861, 620);
            this.form1PlayerName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.form1PlayerName.Name = "form1PlayerName";
            this.form1PlayerName.Size = new System.Drawing.Size(374, 36);
            this.form1PlayerName.TabIndex = 2;
            this.form1PlayerName.Text = "Type Here";
            this.form1PlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.form1PlayerName.TextChanged += new System.EventHandler(this.form1PlayerName_TextChanged);
            // 
            // form1StartButton
            // 
            this.form1StartButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.form1StartButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.GameBackdropHangman;
            this.form1StartButton.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1StartButton.ForeColor = System.Drawing.Color.Black;
            this.form1StartButton.Location = new System.Drawing.Point(29, 578);
            this.form1StartButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.form1StartButton.Name = "form1StartButton";
            this.form1StartButton.Size = new System.Drawing.Size(392, 78);
            this.form1StartButton.TabIndex = 3;
            this.form1StartButton.Text = "START";
            this.form1StartButton.UseVisualStyleBackColor = false;
            this.form1StartButton.Click += new System.EventHandler(this.form1StartButton_Click);
            // 
            // form1Warning
            // 
            this.form1Warning.AutoSize = true;
            this.form1Warning.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1Warning.Location = new System.Drawing.Point(22, 526);
            this.form1Warning.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.form1Warning.Name = "form1Warning";
            this.form1Warning.Size = new System.Drawing.Size(410, 38);
            this.form1Warning.TabIndex = 4;
            this.form1Warning.Text = "ENTER VALID NAME";
            this.form1Warning.Click += new System.EventHandler(this.form1Warning_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 685);
            this.Controls.Add(this.form1Warning);
            this.Controls.Add(this.form1StartButton);
            this.Controls.Add(this.form1PlayerName);
            this.Controls.Add(this.form1PlayerLabel);
            this.Controls.Add(this.form1Title);
            this.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "ENTER A NAME PLZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form1Title;
        private System.Windows.Forms.Label form1PlayerLabel;
        private System.Windows.Forms.TextBox form1PlayerName;
        private System.Windows.Forms.Button form1StartButton;
        private System.Windows.Forms.Label form1Warning;
    }
}

