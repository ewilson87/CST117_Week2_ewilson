namespace Week2_Exercise4
{
    partial class TimeLapsedConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeLapsedConverter));
            this.promptLabel = new System.Windows.Forms.Label();
            this.totalSecondsTextBox = new System.Windows.Forms.TextBox();
            this.daysLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.minutesTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.BackColor = System.Drawing.Color.Transparent;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.promptLabel.Location = new System.Drawing.Point(13, 13);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(279, 20);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Enter the number of seconds elapsed:";
            // 
            // totalSecondsTextBox
            // 
            this.totalSecondsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalSecondsTextBox.Location = new System.Drawing.Point(298, 7);
            this.totalSecondsTextBox.MaxLength = 9;
            this.totalSecondsTextBox.Name = "totalSecondsTextBox";
            this.totalSecondsTextBox.Size = new System.Drawing.Size(111, 26);
            this.totalSecondsTextBox.TabIndex = 1;
            this.totalSecondsTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.BackColor = System.Drawing.Color.Transparent;
            this.daysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.daysLabel.Location = new System.Drawing.Point(12, 72);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(58, 20);
            this.daysLabel.TabIndex = 2;
            this.daysLabel.Text = "DAYS:";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.BackColor = System.Drawing.Color.Transparent;
            this.hoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hoursLabel.Location = new System.Drawing.Point(12, 103);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(72, 20);
            this.hoursLabel.TabIndex = 3;
            this.hoursLabel.Text = "HOURS:";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.BackColor = System.Drawing.Color.Transparent;
            this.minutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minutesLabel.Location = new System.Drawing.Point(12, 134);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(85, 20);
            this.minutesLabel.TabIndex = 4;
            this.minutesLabel.Text = "MINUTES:";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.BackColor = System.Drawing.Color.Transparent;
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.secondsLabel.Location = new System.Drawing.Point(12, 165);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(92, 20);
            this.secondsLabel.TabIndex = 5;
            this.secondsLabel.Text = "SECONDS:";
            // 
            // daysTextBox
            // 
            this.daysTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.daysTextBox.Location = new System.Drawing.Point(101, 69);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.ReadOnly = true;
            this.daysTextBox.Size = new System.Drawing.Size(111, 26);
            this.daysTextBox.TabIndex = 6;
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.secondsTextBox.Location = new System.Drawing.Point(101, 159);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.ReadOnly = true;
            this.secondsTextBox.Size = new System.Drawing.Size(111, 26);
            this.secondsTextBox.TabIndex = 7;
            // 
            // minutesTextBox
            // 
            this.minutesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minutesTextBox.Location = new System.Drawing.Point(101, 128);
            this.minutesTextBox.Name = "minutesTextBox";
            this.minutesTextBox.ReadOnly = true;
            this.minutesTextBox.Size = new System.Drawing.Size(111, 26);
            this.minutesTextBox.TabIndex = 8;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hoursTextBox.Location = new System.Drawing.Point(101, 100);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.ReadOnly = true;
            this.hoursTextBox.Size = new System.Drawing.Size(111, 26);
            this.hoursTextBox.TabIndex = 9;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.PaleGreen;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Firebrick;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(427, 208);
            this.bunifuGradientPanel1.TabIndex = 11;
            // 
            // TimeLapsedConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 208);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.minutesTextBox);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.totalSecondsTextBox);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TimeLapsedConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Lapsed Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox totalSecondsTextBox;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.TextBox minutesTextBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}

