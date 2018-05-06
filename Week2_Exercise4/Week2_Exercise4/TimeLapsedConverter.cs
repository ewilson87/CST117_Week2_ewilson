/**
 * Program: Exercise 4: Time Lapsed Converter
 * File: TimeLapsedConverter.cs
 * Summary: Basic windows form that allows user to input a string and change the font in different ways
 * Author: Evan Wilson
 * Date: May 2nd, 2018
 **/

using System;
using System.Windows.Forms;

namespace Week2_Exercise4
{
    public partial class TimeLapsedConverter : Form
    {
        //declare variables
        private int totalSeconds = 0;
        private int days;
        private int hours;
        private int minutes;
        private int seconds;

        public TimeLapsedConverter()
        {
            InitializeComponent();

            promptLabel.Parent = bunifuGradientPanel1;
            daysLabel.Parent = bunifuGradientPanel1;
            hoursLabel.Parent = bunifuGradientPanel1;
            minutesLabel.Parent = bunifuGradientPanel1;
            secondsLabel.Parent = bunifuGradientPanel1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //checks if textbox is empty, and assigns 0 to all other textboxes
            if (totalSecondsTextBox.TextLength == 0)
            {
                daysTextBox.Text = "0";
                hoursTextBox.Text = "0";
                minutesTextBox.Text = "0";
                secondsTextBox.Text = "0";
            }

            try
            {
                //parse textbox into _totalSeconds
                totalSeconds = int.Parse(totalSecondsTextBox.Text);

                //TryParse method works to avoid errors, but bypasses message box and auto deletion of invalid character code
                //int.TryParse(totalSecondsTextBox.Text, out totalSeconds);

                //converts seconds to days, hours, minutes and remaing seconds, and assigns leftover value to _totalSeconds to use in next calculation
                if (totalSeconds >= 86400)
                {
                    days = totalSeconds / 86400;
                    totalSeconds = totalSeconds % 86400;
                }
                else days = 0;

                if (totalSeconds >= 3600)
                {
                    hours = totalSeconds / 3600;
                    totalSeconds = totalSeconds % 3600;
                }
                else hours = 0;

                if (totalSeconds >= 60)
                {
                    minutes = totalSeconds / 60;
                    totalSeconds = totalSeconds % 60;
                }
                else minutes = 0;

                seconds = totalSeconds;

                //sets textbox text to value of days, hours, minutes and seconds
                daysTextBox.Text = days.ToString("n0");
                hoursTextBox.Text = hours.ToString();
                minutesTextBox.Text = minutes.ToString();
                secondsTextBox.Text = seconds.ToString();

            }
            catch
            {
                //gives message box if anything besides a whole number is entered, and then deletes the last character entered from string
                if (totalSecondsTextBox.TextLength >= 1)
                {
                    MessageBox.Show("You can only enter whole numbers!");
                    totalSecondsTextBox.Text = totalSecondsTextBox.Text.Remove(totalSecondsTextBox.TextLength - 1);
                    totalSecondsTextBox.SelectionStart = totalSecondsTextBox.TextLength;
                    totalSecondsTextBox.SelectionLength = 0;
                }
            }

        }

        private void hourglassPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
