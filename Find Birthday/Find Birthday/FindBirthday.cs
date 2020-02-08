using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_Birthday
{
    public partial class FindBirthday : Form
    {
        public FindBirthday()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private string FindDay(int year, int month, int day)
        {
            // Finds the day of the week the person was born on
            DateTime birthdayDate = new DateTime(year, month, day);
            string dayOfWeek = birthdayDate.DayOfWeek.ToString();

            return dayOfWeek;
        }

        private string FindMonth(int month)
        {
            // Extra function I added to find the name of the month given the numerical month number
            DateTime dtMonth = new DateTime(1, month, 1); 
            return dtMonth.ToString("MMM"); // See https://docs.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=netframework-4.8 for formatting
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            // Initialize variables
            int year, month, day;

            year = (int) numericYear.Value;
            month = (int) numericMonth.Value;
            day = (int) numericDay.Value;

            int maxDays = DateTime.DaysInMonth(year, month);
            // Check if the date is valid
            if (day > maxDays) // Date is invalid
            {
                // Tell user that they were not born on that date
                string monthString = FindMonth(month);
                MessageBox.Show("Sorry Sir/Ma'am, you were not born on " + monthString + ". " + numericDay.Value); ;
            }
            else // Date is valid
            {
                // Tell user the day of week that they were born
                string dayString = FindDay(year, month, day);
                MessageBox.Show("You were born on a " + dayString);
            } 
        }
    }
}
