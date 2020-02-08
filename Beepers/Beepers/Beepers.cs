/*
 * NOTE
 * The Console.Beep() function doesn't work in a loop unless there is something
 * pausing the loop, such as an alert from MessageBox.Show(). You will get the correct
 * amount of beeps if you uncomment the MessageBox.Show() that is showing "i" (iterator),
 * but then you will have to always confirm before hearing the next beep.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beepers
{
    public partial class Beepers : Form
    {
        public Beepers()
        {
            InitializeComponent();
        }

        private void ForButton_Click(object sender, EventArgs e)
        {
            // Initialize Num Beeps to the number in the text box
            try
            {
                int numBeeps = int.Parse(numBeepsText.Text);
                // MessageBox.Show(numBeeps.ToString());

                if (numBeeps >= 0)
                {
                    for (int i = 0; i < numBeeps; i++)
                    {
                        Console.Beep(); // Beep the computer
                        // MessageBox.Show(i.ToString());
                    }
                    // Loop as many times as numBeeps
                    /* Testing for loops
                    int i = 0;
                    for (; i < numBeeps; Console.Beep())
                    {
                        MessageBox.Show(i.ToString());
                        {
                            {
                                {
                                    i++;
                                }
                            }
                        }
                    }
                    */
                    /*
                    for (int i = 0; i++ < numBeeps; ({Console.Beep(); MessageBox.Show(i.toString())})) {}
                    */
                }
                else
                {
                    MessageBox.Show("You can't beep negative times");
                    numBeepsText.Text = "";
                }
            }
            catch // Sorry, I forgot the name of the exception
            {
                MessageBox.Show("Input is not formatted correctly");
                numBeepsText.Text = "";
            }
        }

        private void WhileButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize variables
                int i = 0;
                int numBeeps = int.Parse(numBeepsText.Text);
                // MessageBox.Show(numBeeps.ToString());

                if (numBeeps >= 0)
                {
                    // Loop as many times as numBeeps
                    while (i++ < numBeeps)
                    {
                        Console.Beep();
                        // MessageBox.Show(i.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("You can't beep negative times");
                    numBeepsText.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Input is not formatted correctly");
                numBeepsText.Text = "";
            }
        }

        private void DoButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize variables
                int i = 0;
                int numBeeps = int.Parse(numBeepsText.Text);
                // MessageBox.Show(numBeeps.ToString());

                if (numBeeps >= 0)
                {
                    // Loop as many times as numBeeps
                    do
                    {
                        Console.Beep();
                         MessageBox.Show(i.ToString());
                    } while (++i < numBeeps);
                }
                else
                {
                    MessageBox.Show("You can't beep negative times");
                    numBeepsText.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Input is not formatted correctly");
                numBeepsText.Text = "";
            }
        }
    }
}
