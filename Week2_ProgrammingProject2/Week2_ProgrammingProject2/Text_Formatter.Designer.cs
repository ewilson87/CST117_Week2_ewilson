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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Text_Formatter));
            this.fontListBox = new System.Windows.Forms.ListBox();
            this.fontSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.strikeThroughCheckBox = new System.Windows.Forms.CheckBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.formattedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.greenColorRB = new System.Windows.Forms.RadioButton();
            this.blueColorRB = new System.Windows.Forms.RadioButton();
            this.redColorRB = new System.Windows.Forms.RadioButton();
            this.blackColorRB = new System.Windows.Forms.RadioButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.otherColorRB = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fontSizeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // fontListBox
            // 
            this.fontListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fontListBox.FormattingEnabled = true;
            this.fontListBox.ItemHeight = 15;
            this.fontListBox.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Comic Sans MS",
            "Times New Roman",
            "Jokerman",
            "Lucida Handwriting",
            "Magneto",
            "Other"});
            this.fontListBox.Location = new System.Drawing.Point(3, 22);
            this.fontListBox.Name = "fontListBox";
            this.fontListBox.Size = new System.Drawing.Size(138, 111);
            this.fontListBox.TabIndex = 0;
            this.fontListBox.SelectedIndexChanged += new System.EventHandler(this.fontListBox_SelectedIndexChanged);
            // 
            // fontSizeGroupBox
            // 
            this.fontSizeGroupBox.Controls.Add(this.sizeLabel);
            this.fontSizeGroupBox.Controls.Add(this.sizeSlider);
            this.fontSizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fontSizeGroupBox.Location = new System.Drawing.Point(224, 51);
            this.fontSizeGroupBox.Name = "fontSizeGroupBox";
            this.fontSizeGroupBox.Size = new System.Drawing.Size(144, 135);
            this.fontSizeGroupBox.TabIndex = 2;
            this.fontSizeGroupBox.TabStop = false;
            this.fontSizeGroupBox.Text = "Select a size";
            this.fontSizeGroupBox.Enter += new System.EventHandler(this.fontSizeGroupBox_Enter);
            // 
            // sizeLabel
            // 
            this.sizeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.Location = new System.Drawing.Point(3, 74);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(138, 58);
            this.sizeLabel.TabIndex = 11;
            this.sizeLabel.Text = "12";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sizeSlider
            // 
            this.sizeSlider.BackColor = System.Drawing.Color.Transparent;
            this.sizeSlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.sizeSlider.BorderRadius = 0;
            this.sizeSlider.IndicatorColor = System.Drawing.SystemColors.Highlight;
            this.sizeSlider.Location = new System.Drawing.Point(0, 27);
            this.sizeSlider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sizeSlider.MaximumValue = 47;
            this.sizeSlider.Name = "sizeSlider";
            this.sizeSlider.Size = new System.Drawing.Size(144, 30);
            this.sizeSlider.TabIndex = 10;
            this.sizeSlider.Value = 11;
            this.sizeSlider.ValueChanged += new System.EventHandler(this.sizeSlider_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.underlineCheckBox);
            this.groupBox1.Controls.Add(this.strikeThroughCheckBox);
            this.groupBox1.Controls.Add(this.italicCheckBox);
            this.groupBox1.Controls.Add(this.boldCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(433, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineCheckBox.Location = new System.Drawing.Point(7, 113);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(71, 17);
            this.underlineCheckBox.TabIndex = 3;
            this.underlineCheckBox.Text = "Underline";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            this.underlineCheckBox.CheckedChanged += new System.EventHandler(this.underlineCheckBox_CheckedChanged);
            // 
            // strikeThroughCheckBox
            // 
            this.strikeThroughCheckBox.AutoSize = true;
            this.strikeThroughCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strikeThroughCheckBox.Location = new System.Drawing.Point(7, 84);
            this.strikeThroughCheckBox.Name = "strikeThroughCheckBox";
            this.strikeThroughCheckBox.Size = new System.Drawing.Size(68, 17);
            this.strikeThroughCheckBox.TabIndex = 2;
            this.strikeThroughCheckBox.Text = "Strikeout";
            this.strikeThroughCheckBox.UseVisualStyleBackColor = true;
            this.strikeThroughCheckBox.CheckedChanged += new System.EventHandler(this.strikeThroughCheckBox_CheckedChanged);
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicCheckBox.Location = new System.Drawing.Point(7, 55);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(48, 17);
            this.italicCheckBox.TabIndex = 1;
            this.italicCheckBox.Text = "Italic";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.italicCheckBox_CheckedChanged);
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
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.boldCheckBox_CheckedChanged);
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.textBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLabel.Location = new System.Drawing.Point(12, 16);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(266, 26);
            this.textBoxLabel.TabIndex = 5;
            this.textBoxLabel.Text = "Enter characters you want to format:";
            this.textBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox.Location = new System.Drawing.Point(283, 16);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(504, 26);
            this.textBox.TabIndex = 6;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // formattedRichTextBox
            // 
            this.formattedRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formattedRichTextBox.Location = new System.Drawing.Point(15, 193);
            this.formattedRichTextBox.Name = "formattedRichTextBox";
            this.formattedRichTextBox.ReadOnly = true;
            this.formattedRichTextBox.Size = new System.Drawing.Size(771, 96);
            this.formattedRichTextBox.TabIndex = 9;
            this.formattedRichTextBox.Text = "";
            this.formattedRichTextBox.TextChanged += new System.EventHandler(this.formattedRichTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.otherColorRB);
            this.groupBox2.Controls.Add(this.greenColorRB);
            this.groupBox2.Controls.Add(this.blueColorRB);
            this.groupBox2.Controls.Add(this.redColorRB);
            this.groupBox2.Controls.Add(this.blackColorRB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(642, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 135);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a color";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // greenColorRB
            // 
            this.greenColorRB.AutoSize = true;
            this.greenColorRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.greenColorRB.Location = new System.Drawing.Point(5, 89);
            this.greenColorRB.Name = "greenColorRB";
            this.greenColorRB.Size = new System.Drawing.Size(54, 17);
            this.greenColorRB.TabIndex = 3;
            this.greenColorRB.TabStop = true;
            this.greenColorRB.Text = "Green";
            this.greenColorRB.UseVisualStyleBackColor = true;
            this.greenColorRB.CheckedChanged += new System.EventHandler(this.greenColorRB_CheckedChanged);
            // 
            // blueColorRB
            // 
            this.blueColorRB.AutoSize = true;
            this.blueColorRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.blueColorRB.Location = new System.Drawing.Point(5, 68);
            this.blueColorRB.Name = "blueColorRB";
            this.blueColorRB.Size = new System.Drawing.Size(46, 17);
            this.blueColorRB.TabIndex = 2;
            this.blueColorRB.TabStop = true;
            this.blueColorRB.Text = "Blue";
            this.blueColorRB.UseVisualStyleBackColor = true;
            this.blueColorRB.CheckedChanged += new System.EventHandler(this.blueColorRB_CheckedChanged);
            // 
            // redColorRB
            // 
            this.redColorRB.AutoSize = true;
            this.redColorRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.redColorRB.Location = new System.Drawing.Point(6, 47);
            this.redColorRB.Name = "redColorRB";
            this.redColorRB.Size = new System.Drawing.Size(45, 17);
            this.redColorRB.TabIndex = 1;
            this.redColorRB.TabStop = true;
            this.redColorRB.Text = "Red";
            this.redColorRB.UseVisualStyleBackColor = true;
            this.redColorRB.CheckedChanged += new System.EventHandler(this.redColorRB_CheckedChanged);
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
            this.blackColorRB.CheckedChanged += new System.EventHandler(this.blackColorRB_CheckedChanged);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.groupBox3);
            this.bunifuGradientPanel1.Controls.Add(this.formattedRichTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.textBoxLabel);
            this.bunifuGradientPanel1.Controls.Add(this.textBox);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.MediumSeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.Highlight;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Aquamarine;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 298);
            this.bunifuGradientPanel1.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fontListBox);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(15, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 136);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select a font";
            // 
            // otherColorRB
            // 
            this.otherColorRB.AutoSize = true;
            this.otherColorRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.otherColorRB.Location = new System.Drawing.Point(5, 110);
            this.otherColorRB.Name = "otherColorRB";
            this.otherColorRB.Size = new System.Drawing.Size(51, 17);
            this.otherColorRB.TabIndex = 4;
            this.otherColorRB.TabStop = true;
            this.otherColorRB.Text = "Other";
            this.otherColorRB.UseVisualStyleBackColor = true;
            this.otherColorRB.CheckedChanged += new System.EventHandler(this.otherColorRB_CheckedChanged);
            // 
            // Text_Formatter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fontSizeGroupBox);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Text_Formatter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Formatter";
            this.Load += new System.EventHandler(this.Text_Formatter_Load);
            this.fontSizeGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox fontListBox;
        private System.Windows.Forms.GroupBox fontSizeGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox underlineCheckBox;
        private System.Windows.Forms.CheckBox strikeThroughCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.Label textBoxLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RichTextBox formattedRichTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton greenColorRB;
        private System.Windows.Forms.RadioButton blueColorRB;
        private System.Windows.Forms.RadioButton redColorRB;
        private System.Windows.Forms.RadioButton blackColorRB;
        private Bunifu.Framework.UI.BunifuSlider sizeSlider;
        private System.Windows.Forms.Label sizeLabel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton otherColorRB;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

