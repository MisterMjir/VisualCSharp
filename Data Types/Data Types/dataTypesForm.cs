using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Types
{
    public partial class dataTypesForm : Form
    {
        public dataTypesForm()
        {
            InitializeComponent();
        }

        private void NumericButton_Click(object sender, EventArgs e)
        {
            // Initialize numeric variables
            int myInt = 54;
            double myDouble = 21.624;
            decimal myDecimal = 7.2934780235M;
            float myFloat = 45.3F;

            // Display the numbers
            MessageBox.Show("The integer is: " + myInt.ToString());
            MessageBox.Show("The double is: " + myDouble.ToString());
            MessageBox.Show("The decimal is: " + myDecimal.ToString());
            MessageBox.Show("The float is: " + myFloat.ToString());
        }

        private void BoolButton_Click(object sender, EventArgs e)
        {
            // Initialize boolean variables
            bool myBool = true;

            // Display the boolean
            MessageBox.Show("The boolean is: " + myBool.ToString());
        }

        private void ConstantButton_Click(object sender, EventArgs e)
        {
            // Initialize the constants
            const double pi = 3.14159;
            const int myInt = 62;

            // Display the constants
            MessageBox.Show("The constant double is: " + pi.ToString());
            MessageBox.Show("The constant int is: " + myInt.ToString());
        }

        private void StringButton_Click(object sender, EventArgs e)
        {
            // Initialize text variables
            char myChar = '^';
            string myString = "_^ Wait, where's the left side of my face?";

            // Display text values
            MessageBox.Show("The character is: " + myChar);
            MessageBox.Show("The string is: " + myString);
        }
    }
}
