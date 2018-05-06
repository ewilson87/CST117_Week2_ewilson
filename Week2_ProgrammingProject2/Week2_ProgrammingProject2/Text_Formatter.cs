/**
 * Program: Programming Project 2: Text Formatter
 * File: Text_Formatter.cs
 * Summary: Basic windows form that allows user to input a string and change the font in different ways
 * Author: Evan Wilson
 * Date: May 2nd, 2018
 **/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week2_ProgrammingProject2
{
    public partial class Text_Formatter : Form
    {
        public Text_Formatter()
        {
            InitializeComponent();

            //sets default value for fontListBox
            fontListBox.SelectedIndex = 0;
            formattedRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void fontListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sets font
            if (fontListBox.SelectedItem.ToString().Equals("Microsoft Sans Serif"))
            {
                formattedRichTextBox.Font = new Font("Microsoft Sans Serif", sizeSlider.Value + 1);
                changeFontDetails();
                changeColor();
                changeSize();
            }
            else if (fontListBox.SelectedItem.ToString().Equals("Comic Sans MS"))
            {
                formattedRichTextBox.Font = new Font("Comic Sans MS", sizeSlider.Value + 1);
                changeFontDetails();
                changeColor();
                changeSize();
            }
            else if (fontListBox.SelectedItem.ToString().Equals("Times New Roman"))
            {
                formattedRichTextBox.Font = new Font("Times New Roman", sizeSlider.Value + 1);
                changeFontDetails();
                changeColor();
                changeSize();
            }
            else if (fontListBox.SelectedItem.ToString().Equals("Jokerman"))
            {
                formattedRichTextBox.Font = new Font("Jokerman", sizeSlider.Value + 1);
                changeFontDetails();
                changeColor();
                changeSize();
            }
            else if (fontListBox.SelectedItem.ToString().Equals("Lucida Handwriting"))
            {
                formattedRichTextBox.Font = new Font("Lucida Handwriting", sizeSlider.Value + 1);
                changeFontDetails();
                changeColor();
                changeSize();
            }
            else if (fontListBox.SelectedItem.ToString().Equals("Magneto"))
            {
                formattedRichTextBox.Font = new Font("Magneto", sizeSlider.Value + 1);
                changeFontDetails();
                changeColor();
                changeSize();
            }
            else if (fontListBox.SelectedItem.ToString().Equals("Other"))
            {
                FontDialog fontDialog = new FontDialog();
                if (fontDialog.ShowDialog() == DialogResult.OK && !String.IsNullOrWhiteSpace(textBox.Text))
                {
                    formattedRichTextBox.Font = fontDialog.Font;
                    changeFontDetails();
                    changeColor();
                    changeSize();
                    formattedRichTextBox.Text = textBox.Text;
                }
            }
        }

        private void formattedRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontSizeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void changeFontDetails()
        {
            //sets details
            if (boldCheckBox.Checked && italicCheckBox.Checked && strikeThroughCheckBox.Checked && underlineCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline);

            }
            else if (boldCheckBox.Checked && italicCheckBox.Checked && strikeThroughCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout);
            }
            else if (boldCheckBox.Checked && italicCheckBox.Checked && underlineCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
            else if (boldCheckBox.Checked && strikeThroughCheckBox.Checked && underlineCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Bold | FontStyle.Strikeout | FontStyle.Underline);
            }
            else if (italicCheckBox.Checked && strikeThroughCheckBox.Checked && underlineCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline);
            }
            else if (boldCheckBox.Checked && italicCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Bold | FontStyle.Italic);

            }
            else if (boldCheckBox.Checked && strikeThroughCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Bold | FontStyle.Strikeout);

            }
            else if (boldCheckBox.Checked && underlineCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Bold | FontStyle.Underline);

            }
            else if (italicCheckBox.Checked && strikeThroughCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Italic | FontStyle.Strikeout);

            }
            else if (italicCheckBox.Checked && underlineCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Italic | FontStyle.Underline);

            }
            else if (strikeThroughCheckBox.Checked && underlineCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Strikeout | FontStyle.Underline);

            }
            else if (boldCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Bold);
            }
            else if (italicCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Italic);
            }
            else if (strikeThroughCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Strikeout);
            }
            else if (underlineCheckBox.Checked)
            {
                formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1,
                    FontStyle.Underline);
            }
        }

        private void changeColor()
        {
            //sets font color
            if (blackColorRB.Checked)
            {
                formattedRichTextBox.ForeColor = Color.Black;
            }
            else if (redColorRB.Checked)
            {
                formattedRichTextBox.ForeColor = Color.Red;
            }
            else if (blueColorRB.Checked)
            {
                formattedRichTextBox.ForeColor = Color.Blue;
            }
            else if (greenColorRB.Checked)
            {
                formattedRichTextBox.ForeColor = Color.Green;
            }           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            changeFontDetails();
        }

        private void italicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            changeFontDetails();
        }

        private void strikeThroughCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            changeFontDetails();
        }

        private void underlineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            changeFontDetails();
        }

        //sets colors
        private void blackColorRB_CheckedChanged(object sender, EventArgs e)
        {
            changeColor();
            blackColorRB.Checked = !blackColorRB.Checked;
        }

        private void redColorRB_CheckedChanged(object sender, EventArgs e)
        {
            changeColor();
        }

        private void blueColorRB_CheckedChanged(object sender, EventArgs e)
        {
            changeColor();
        }

        private void greenColorRB_CheckedChanged(object sender, EventArgs e)
        {
            changeColor();
        }

        private void otherColorRB_CheckedChanged(object sender, EventArgs e)
        {
            if (otherColorRB.Checked)
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    formattedRichTextBox.ForeColor = colorDialog.Color;
                }
            }
        }

        //updates formattedRichTextBox every time a character changes in textbox
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text == "")
                formattedRichTextBox.Text = "";
            else
            {
                try
                {
                    formattedRichTextBox.Text = textBox.Text;
                }
                catch
                {
                    MessageBox.Show("something went wrong");
                }
            }
        }

        private void Text_Formatter_Load(object sender, EventArgs e)
        {

        }

        private void changeSize()
        {
            formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, sizeSlider.Value + 1);
            sizeLabel.Text = (sizeSlider.Value + 1).ToString();
            changeFontDetails();
        }

        private void sizeSlider_ValueChanged(object sender, EventArgs e)
        {
            changeSize();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
