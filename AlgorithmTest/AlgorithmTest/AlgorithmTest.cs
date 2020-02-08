using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* TeenCoder: Windows Programming
   
   Algorithm Test Application

   Copyright 2013 CompuScholar, Inc.
*/

namespace AlgorithmTest
{
    public partial class AlgorithmTest : Form
    {
        public AlgorithmTest()
        {
            InitializeComponent();
        }

        // TODO BY STUDENT
        // The student will add code to this method in the Chapter Activity.
        private int findMagicNumber(int myNumber)
        {
            /*
             * Flow chart
             * -----------
             * 
             * [ Create Number Variable = input ]
             * v
             * [ Multiply by 3]
             * v
             * [ Add 6 ]
             * v
             * [ Divide by 3 ]
             * v
             * [ Subtract by input ]
             */
            int magicNumber = myNumber;
            magicNumber *= 3;
            magicNumber += 6;
            magicNumber /= 3;
            magicNumber -= myNumber;

            return magicNumber;
        }

        // TODO BY STUDENT
        // The student will add code to this method in the Chapter Activity.
        private char convertToLetterGrade(int numberGrade)
        {
            /*
             * Flowchart
             * ---------
             * (diamond) if grade >= 90
             * yes                      no
             * [ A ]                    (diamond) if grade >=80
             *                          yes                     no
             *                          [ B ]                   (diamond) if grade >= 70
             *                                                  yes                      no
             *                                                  [ C ]                    (diamond) if grade >= 60
             *                                                                           yes                      no
             *                                                                           [ D ]                    [ F ]
             */

            // Since the function solely returns the letter, no need for braces
            if (numberGrade >= 90 && numberGrade <= 100) // Overachievers will fail
                return 'A';
            else if (numberGrade >= 80)
                return 'B';
            else if (numberGrade >= 70)
                return 'C';
            else if (numberGrade >= 60)
                return 'D';
            else
                return 'F';
        }

        // This code is provided complete in the Activity Starter
        private void MagicNumberButton_Click(object sender, EventArgs e)
        {
            // The result of this line should be a MessageBox with the value 2
            MessageBox.Show("Starting number = 16, ending number = " + findMagicNumber(16).ToString());

            // The result of this line should be a MessageBox with the value 2
            MessageBox.Show("Starting number = 5, ending number = " + findMagicNumber(5).ToString());
        }

        private void ConvertGradeButton_Click(object sender, EventArgs e)
        {
            // get numeric input from the user
            int numberGrade = Convert.ToInt32(userTextBox.Text);

            // call funciton to convert to a letter
            char letterGrade = convertToLetterGrade(numberGrade);

            // display the results
            MessageBox.Show("The number grade " + numberGrade + " has a letter grade of " + letterGrade);

        }

      
    }
}
