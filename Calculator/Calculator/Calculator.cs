using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        int firstNum = 0;
        int result = 0;
        bool addButtonFlag = false;
        bool subtractButtonFlag = false;
        bool multiplyButtonFlag = false;
        bool divisionButtonFlag = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "9";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "0";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Change operation if needed
            if (subtractButtonFlag != true && multiplyButtonFlag != true && divisionButtonFlag != true)
            {
                // Check if there are numbers
                if (NumberLabel.Text != "")
                {
                    firstNum = int.Parse(NumberLabel.Text); // Store the first number in a variable
                    NumberLabel.Text = ""; // Clear the label
                    addButtonFlag = true; //
                }
                else
                {
                    MessageBox.Show("Please enter a number");
                }
            }
            else
            {
                subtractButtonFlag = false;
                multiplyButtonFlag = false;
                divisionButtonFlag = false;
                addButtonFlag = true;
            }
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            // Change operation if needed
            if (addButtonFlag != true && multiplyButtonFlag != true && divisionButtonFlag != true)
            {
                // Check if there are numbers
                if (NumberLabel.Text != "")
                {
                    firstNum = int.Parse(NumberLabel.Text); // Store the first number in a variable
                    NumberLabel.Text = ""; // Clear the label
                    subtractButtonFlag = true; //
                }
                else
                {
                    MessageBox.Show("Please enter a number");
                }
            }
            else
            {
                addButtonFlag = false;
                multiplyButtonFlag = false;
                divisionButtonFlag = false;
                subtractButtonFlag = true;
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (NumberLabel.Text != "")
            {
                int secondNum = int.Parse(NumberLabel.Text);
                if (addButtonFlag == true)
                {
                    result = firstNum + secondNum;
                }
                else if (subtractButtonFlag == true)
                {
                    result = firstNum - secondNum;
                }
                else if (multiplyButtonFlag == true)
                {
                    result = firstNum * secondNum;
                }
                else if (divisionButtonFlag == true)
                {
                    // Chapter 10 Code
                    try
                    {
                        result = firstNum / secondNum;
                    }
                    catch (System.DivideByZeroException ex)
                    {
                        MessageBox.Show("You goofed: " + ex.Message);
                        result = firstNum;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please perform an operation");
                }
                addButtonFlag = false;
                subtractButtonFlag = false;
                multiplyButtonFlag = false;
                divisionButtonFlag = false;
                NumberLabel.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Reset all variables to their initial values
            addButtonFlag = false;
            subtractButtonFlag = false;
            multiplyButtonFlag = false;
            divisionButtonFlag = false;
            firstNum = 0;
            result = 0;
            NumberLabel.Text = "";
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            // Change operation if needed
            if (addButtonFlag != true && subtractButtonFlag != true && divisionButtonFlag != true)
            {
                // Check if there are numbers
                if (NumberLabel.Text != "")
                {
                    firstNum = int.Parse(NumberLabel.Text); // Store the first number in a variable
                    NumberLabel.Text = ""; // Clear the label
                    multiplyButtonFlag = true; //
                }
                else
                {
                    MessageBox.Show("Please enter a number");
                }
            }
            else
            {
                addButtonFlag = false;
                subtractButtonFlag = false;
                divisionButtonFlag = false;
                multiplyButtonFlag = true;
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            // Change operation if needed
            if (addButtonFlag != true && subtractButtonFlag != true && multiplyButtonFlag != true)
            {
                // Check if there are numbers
                if (NumberLabel.Text != "")
                {
                    firstNum = int.Parse(NumberLabel.Text); // Store the first number in a variable
                    NumberLabel.Text = ""; // Clear the label
                    divisionButtonFlag = true; //
                }
                else
                {
                    MessageBox.Show("Please enter a number");
                }
            }
            else
            {
                addButtonFlag = false;
                subtractButtonFlag = false;
                multiplyButtonFlag = false;
                divisionButtonFlag = true;
            }
        }
    }
}
