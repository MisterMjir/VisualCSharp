using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This function is provided complete as part of the activity starter
        private void buttonFind_Click(object sender, EventArgs e)
        {
            // get the user's N value from the control
            int n = (int)numericUpDown1.Value;

            // call the recursive findFib() function to 
            // calculate the result
            int result = findFib(n);

            // display the answer
            MessageBox.Show("The Fibonacci result is " + result);
        }


        // The student will complete this recursive function
        private int findFib(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return findFib(n - 1) + findFib(n - 2);
        }

    }
}
