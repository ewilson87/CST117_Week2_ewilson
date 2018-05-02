namespace Week2_ProgrammingProject2
{
    partial class Text_Formatter
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
            this.fontListBox = new System.Windows.Forms.ListBox();
            this.fontLabel = new System.Windows.Forms.Label();
            this.fontSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.size30RB = new System.Windows.Forms.RadioButton();
            this.size24RB = new System.Windows.Forms.RadioButton();
            this.size18RB = new System.Windows.Forms.RadioButton();
            this.size12RB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.strikeThroughCheckBox = new System.Windows.Forms.CheckBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.formattedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.greenColorRB = new System.Windows.Forms.RadioButton();
            this.blueColorRB = new System.Windows.Forms.RadioButton();
            this.redColorRB = new System.Windows.Forms.RadioButton();
            this.blackColorRB = new System.Windows.Forms.RadioButton();
            this.fontSizeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontListBox
            // 
            this.fontListBox.FormattingEnabled = true;
            this.fontListBox.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Comic Sans MS",
            "Times New Roman",
            "Jokerman",
            "Lucida Handwriting",
            "Magneto",
            "Other"});
            this.fontListBox.Location = new System.Drawing.Point(16, 91);
            this.fontListBox.Name = "fontListBox";
            this.fontListBox.Size = new System.Drawing.Size(144, 95);
            this.fontListBox.TabIndex = 0;
            this.fontListBox.SelectedIndexChanged += new System.EventHandler(this.fontListBox_SelectedIndexChanged);
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fontLabel.Location = new System.Drawing.Point(12, 68);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(99, 20);
            this.fontLabel.TabIndex = 1;
            this.fontLabel.Text = "Select a font";
            this.fontLabel.Click += new System.EventHandler(this.fontLabel_Click);
            // 
            // fontSizeGroupBox
            // 
            this.fontSizeGroupBox.Controls.Add(this.size30RB);
            this.fontSizeGroupBox.Controls.Add(this.size24RB);
            this.fontSizeGroupBox.Controls.Add(this.size18RB);
            this.fontSizeGroupBox.Controls.Add(this.size12RB);
            this.fontSizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fontSizeGroupBox.Location = new System.Drawing.Point(225, 68);
            this.fontSizeGroupBox.Name = "fontSizeGroupBox";
            this.fontSizeGroupBox.Size = new System.Drawing.Size(144, 118);
            this.fontSizeGroupBox.TabIndex = 2;
            this.fontSizeGroupBox.TabStop = false;
            this.fontSizeGroupBox.Text = "Select a size";
            // 
            // size30RB
            // 
            this.size30RB.AutoSize = true;
            this.size30RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.size30RB.Location = new System.Drawing.Point(6, 98);
            this.size30RB.Name = "size30RB";
            this.size30RB.Size = new System.Drawing.Size(37, 17);
            this.size30RB.TabIndex = 3;
            this.size30RB.TabStop = true;
            this.size30RB.Text = "30";
            this.size30RB.UseVisualStyleBackColor = true;
            // 
            // size24RB
            // 
            this.size24RB.AutoSize = true;
            this.size24RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.size24RB.Location = new System.Drawing.Point(7, 74);
            this.size24RB.Name = "size24RB";
            this.size24RB.Size = new System.Drawing.Size(37, 17);
            this.size24RB.TabIndex = 2;
            this.size24RB.TabStop = true;
            this.size24RB.Text = "24";
            this.size24RB.UseVisualStyleBackColor = true;
            // 
            // size18RB
            // 
            this.size18RB.AutoSize = true;
            this.size18RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.size18RB.Location = new System.Drawing.Point(7, 50);
            this.size18RB.Name = "size18RB";
            this.size18RB.Size = new System.Drawing.Size(37, 17);
            this.size18RB.TabIndex = 1;
            this.size18RB.TabStop = true;
            this.size18RB.Text = "18";
            this.size18RB.UseVisualStyleBackColor = true;
            // 
            // size12RB
            // 
            this.size12RB.AutoSize = true;
            this.size12RB.Checked = true;
            this.size12RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.size12RB.Location = new System.Drawing.Point(7, 26);
            this.size12RB.Name = "size12RB";
            this.size12RB.Size = new System.Drawing.Size(37, 17);
            this.size12RB.TabIndex = 0;
            this.size12RB.TabStop = true;
            this.size12RB.Text = "12";
            this.size12RB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.underlineCheckBox);
            this.groupBox1.Controls.Add(this.strikeThroughCheckBox);
            this.groupBox1.Controls.Add(this.italicCheckBox);
            this.groupBox1.Controls.Add(this.boldCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(434, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select details";
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineCheckBox.Location = new System.Drawing.Point(6, 93);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(71, 17);
            this.underlineCheckBox.TabIndex = 3;
            this.underlineCheckBox.Text = "Underline";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // strikeThroughCheckBox
            // 
            this.strikeThroughCheckBox.AutoSize = true;
            this.strikeThroughCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strikeThroughCheckBox.Location = new System.Drawing.Point(7, 72);
            this.strikeThroughCheckBox.Name = "strikeThroughCheckBox";
            this.strikeThroughCheckBox.Size = new System.Drawing.Size(68, 17);
            this.strikeThroughCheckBox.TabIndex = 2;
            this.strikeThroughCheckBox.Text = "Strikeout";
            this.strikeThroughCheckBox.UseVisualStyleBackColor = true;
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicCheckBox.Location = new System.Drawing.Point(7, 49);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(48, 17);
            this.italicCheckBox.TabIndex = 1;
            this.italicCheckBox.Text = "Italic";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldCheckBox.Location = new System.Drawing.Point(7, 26);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(51, 17);
            this.boldCheckBox.TabIndex = 0;
            this.boldCheckBox.Text = "Bold";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.AutoSize = true;
            this.textBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLabel.Location = new System.Drawing.Point(12, 22);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(266, 20);
            this.textBoxLabel.TabIndex = 5;
            this.textBoxLabel.Text = "Enter characters you want to format:";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox.Location = new System.Drawing.Point(276, 16);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(511, 26);
            this.textBox.TabIndex = 6;
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.viewButton.Location = new System.Drawing.Point(326, 354);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(148, 63);
            this.viewButton.TabIndex = 7;
            this.viewButton.Text = "CHANGE FONT";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // formattedRichTextBox
            // 
            this.formattedRichTextBox.Location = new System.Drawing.Point(16, 230);
            this.formattedRichTextBox.Name = "formattedRichTextBox";
            this.formattedRichTextBox.ReadOnly = true;
            this.formattedRichTextBox.Size = new System.Drawing.Size(771, 96);
            this.formattedRichTextBox.TabIndex = 9;
            this.formattedRichTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.greenColorRB);
            this.groupBox2.Controls.Add(this.blueColorRB);
            this.groupBox2.Controls.Add(this.redColorRB);
            this.groupBox2.Controls.Add(this.blackColorRB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(643, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 118);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a color";
            // 
            // greenColorRB
            // 
            this.greenColorRB.AutoSize = true;
            this.greenColorRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.greenColorRB.Location = new System.Drawing.Point(6, 98);
            this.greenColorRB.Name = "greenColorRB";
            this.greenColorRB.Size = new System.Drawing.Size(54, 17);
            this.greenColorRB.TabIndex = 3;
            this.greenColorRB.TabStop = true;
            this.greenColorRB.Text = "Green";
            this.greenColorRB.UseVisualStyleBackColor = true;
            // 
            // blueColorRB
            // 
            this.blueColorRB.AutoSize = true;
            this.blueColorRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.blueColorRB.Location = new System.Drawing.Point(7, 74);
            this.blueColorRB.Name = "blueColorRB";
            this.blueColorRB.Size = new System.Drawing.Size(46, 17);
            this.blueColorRB.TabIndex = 2;
            this.blueColorRB.TabStop = true;
            this.blueColorRB.Text = "Blue";
            this.blueColorRB.UseVisualStyleBackColor = true;
            // 
            // redColorRB
            // 
            this.redColorRB.AutoSize = true;
            this.redColorRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.redColorRB.Location = new System.Drawing.Point(7, 50);
            this.redColorRB.Name = "redColorRB";
            this.redColorRB.Size = new System.Drawing.Size(45, 17);
            this.redColorRB.TabIndex = 1;
            this.redColorRB.TabStop = true;
            this.redColorRB.Text = "Red";
            this.redColorRB.UseVisualStyleBackColor = true;
            // 
            // blackColorRB
            // 
            this.blackColorRB.AutoSize = true;
            this.blackColorRB.Checked = true;
            this.blackColorRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.blackColorRB.Location = new System.Drawing.Point(7, 26);
            this.blackColorRB.Name = "blackColorRB";
            this.blackColorRB.Size = new System.Drawing.Size(52, 17);
            this.blackColorRB.TabIndex = 0;
            this.blackColorRB.TabStop = true;
            this.blackColorRB.Text = "Black";
            this.blackColorRB.UseVisualStyleBackColor = true;
            // 
            // Text_Formatter
            // 
            this.AcceptButton = this.viewButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.formattedRichTextBox);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fontSizeGroupBox);
            this.Controls.Add(this.fontLabel);
            this.Controls.Add(this.fontListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Text_Formatter";
            this.Text = "Text Formatter";
            this.fontSizeGroupBox.ResumeLayout(false);
            this.fontSizeGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fontListBox;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.GroupBox fontSizeGroupBox;
        private System.Windows.Forms.RadioButton size30RB;
        private System.Windows.Forms.RadioButton size24RB;
        private System.Windows.Forms.RadioButton size18RB;
        private System.Windows.Forms.RadioButton size12RB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox underlineCheckBox;
        private System.Windows.Forms.CheckBox strikeThroughCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.Label textBoxLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.RichTextBox formattedRichTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton greenColorRB;
        private System.Windows.Forms.RadioButton blueColorRB;
        private System.Windows.Forms.RadioButton redColorRB;
        private System.Windows.Forms.RadioButton blackColorRB;
    }
}

