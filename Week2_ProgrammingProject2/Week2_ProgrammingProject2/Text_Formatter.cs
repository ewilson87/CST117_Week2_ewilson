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

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
                formattedRichTextBox.Text = "";
            else
            {
                try
                {
                    //sets font
                    if (fontListBox.SelectedItem.ToString().Equals("Microsoft Sans Serif"))
                    {
                        formattedRichTextBox.Font = new Font("Microsoft Sans Serif", formattedRichTextBox.Font.Size);
                    }
                    else if (fontListBox.SelectedItem.ToString().Equals("Comic Sans MS"))
                    {
                        formattedRichTextBox.Font = new Font("Comic Sans MS", formattedRichTextBox.Font.Size);
                    }
                    else if (fontListBox.SelectedItem.ToString().Equals("Times New Roman"))
                    {
                        formattedRichTextBox.Font = new Font("Times New Roman", formattedRichTextBox.Font.Size);
                    }
                    else if (fontListBox.SelectedItem.ToString().Equals("Jokerman"))
                    {
                        formattedRichTextBox.Font = new Font("Jokerman", formattedRichTextBox.Font.Size);
                    }
                    else if (fontListBox.SelectedItem.ToString().Equals("Lucida Handwriting"))
                    {
                        formattedRichTextBox.Font = new Font("Lucida Handwriting", formattedRichTextBox.Font.Size);
                    }
                    else if (fontListBox.SelectedItem.ToString().Equals("Magneto"))
                    {
                        formattedRichTextBox.Font = new Font("Magneto", formattedRichTextBox.Font.Size);
                    }
                    else if (fontListBox.SelectedItem.ToString().Equals("Other"))
                    {
                        FontDialog fontDialog = new FontDialog();
                        if (fontDialog.ShowDialog() == DialogResult.OK && !String.IsNullOrWhiteSpace(textBox.Text))
                        {
                            formattedRichTextBox.Font = fontDialog.Font;

                            formattedRichTextBox.Text = textBox.Text;
                        }
                    }

                    //sets font size
                    if (size12RB.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, 12);
                    }
                    else if (size18RB.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, 18);
                    }
                    else if (size24RB.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, 24);
                    }
                    else if (size30RB.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, 30);
                    }

                    //sets details
                    if (boldCheckBox.Checked && italicCheckBox.Checked && strikeThroughCheckBox.Checked && underlineCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline);

                    }

                    else if (boldCheckBox.Checked && italicCheckBox.Checked && strikeThroughCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout);
                    }

                    else if (boldCheckBox.Checked && italicCheckBox.Checked && underlineCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    }

                    else if (boldCheckBox.Checked && strikeThroughCheckBox.Checked && underlineCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Bold | FontStyle.Strikeout | FontStyle.Underline);
                    }

                    else if (italicCheckBox.Checked && strikeThroughCheckBox.Checked && underlineCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline);
                    }

                    else if (boldCheckBox.Checked && italicCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Bold | FontStyle.Italic);

                    }

                    else if (boldCheckBox.Checked && strikeThroughCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Bold | FontStyle.Strikeout);

                    }

                    else if (boldCheckBox.Checked && underlineCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Bold | FontStyle.Underline);

                    }

                    else if (italicCheckBox.Checked && strikeThroughCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Italic | FontStyle.Strikeout);

                    }

                    else if (italicCheckBox.Checked && underlineCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Italic | FontStyle.Underline);

                    }

                    else if (strikeThroughCheckBox.Checked && underlineCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Strikeout | FontStyle.Underline);

                    }

                    else if (boldCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Bold);
                    }

                    else if (italicCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Italic);
                    }

                    else if (strikeThroughCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Strikeout);
                    }

                    else if (underlineCheckBox.Checked)
                    {
                        formattedRichTextBox.Font = new Font(formattedRichTextBox.Font.FontFamily, formattedRichTextBox.Font.Size,
                            FontStyle.Underline);
                    }

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


                    formattedRichTextBox.Text = textBox.Text;
                }
                catch
                {
                    MessageBox.Show("something went wrong");
                }
            }
        }

        private void fontListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fontLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
