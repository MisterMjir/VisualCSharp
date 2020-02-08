using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Success_Predicter
{
    public partial class SuccessPredicter : Form
    {
        bool firstTime;
        public SuccessPredicter()
        {
            InitializeComponent();
        }

        private void Predict_Click(object sender, EventArgs e)
        {
            /*
             * Using returns instead of if else so in case I need a new
             * check in the future, I won't have to the copying and pasting
             */
             
            // Check if a gender is selected
            if (Male.Checked == false && Female.Checked == false)
            {
                MessageBox.Show("Please select a gender");
                return;
            }

            // Check if NumericUpDowns were selected, but only the first time
            if (firstTime)
            {
                if (Reading.Value == 1 && Science.Value == 1 && Writing.Value == 1 && Memory.Value == 1 && Math.Value == 1 && Logic.Value == 1)
                {
                    MessageBox.Show("Hey, all of your skills are set to one. If you believe that you are better than that, please select skill values that reflect your strength in those skills.");
                    firstTime = false;
                    return;
                }
            }
            
            // Call the function with the "mathematically-derived" (arbitrary) parameters for the course
            string courseName = Courses.Text;
            if (courseName.Equals("AP World History"))
            {
                CreatePrediction(3, 0, 1, 3, 0, 2, true);
            }
            else if (courseName.Equals("AP Physics"))
            {
                CreatePrediction(1, 4, 1, 1, 3, 2, true);
            }
            else if (courseName.Equals("AP Calculus"))
            {
                CreatePrediction(0, 0, 0, 1, 5, 1, true);
            }
            else if (courseName.Equals("AP English III"))
            {
                CreatePrediction(4, 0, 5, 1, 0, 1, false); // Haha, prediction not found
            }
            else if (courseName.Equals("AP Computer Science A"))
            {
                CreatePrediction(10, 10, 10, 10, 10, 10, true);
            }
            else if (courseName.Equals("AP Music Theory"))
            {
                CreatePrediction(0, 2, 1, 0, 1, 3, false);
            }
            else if (courseName.Equals("AP Political Science"))
            {
                CreatePrediction(3, 0, 0, 3, 0, 3, false);
            }
            else // If no course is selected tell the user to select a course
            {
                MessageBox.Show("Please select a course");
            }
        }

        private void CreatePrediction(int minReading, int minScience, int minWriting, int minMemory, int minMath, int minLogic, bool male)
        {
            // Initialize string output
            string output = "";
            int totalSkill = 0; // Figure out overall how well you will do in a class

            output += "Prediction for " + Courses.Text + "\n\nFor this class, you are,\n";

            // Add the string prediction and numeric predictions for every skill
            output += getStrSkillPrediction("Reading", minReading, (int) Reading.Value) + "\n";
            totalSkill += getIntSkillPrediction(minReading, (int)Reading.Value);

            output += getStrSkillPrediction("Science", minScience, (int) Science.Value) + "\n";
            totalSkill += getIntSkillPrediction(minScience, (int)Science.Value);

            output += getStrSkillPrediction("Writing", minWriting, (int) Writing.Value) + "\n";
            totalSkill += getIntSkillPrediction(minWriting, (int)Writing.Value);

            output += getStrSkillPrediction("Memory", minMemory, (int) Memory.Value) + "\n";
            totalSkill += getIntSkillPrediction(minMemory, (int)Memory.Value);

            output += getStrSkillPrediction("Math", minMath, (int) Math.Value) + "\n";
            totalSkill += getIntSkillPrediction(minMath, (int)Math.Value);

            output += getStrSkillPrediction("Logic", minLogic, (int) Logic.Value) + "\n";
            totalSkill += getIntSkillPrediction(minLogic, (int)Logic.Value);

            output += "\nWith a total skill score of: " + totalSkill.ToString() + ",\n" + getTotalSkillPrediction(totalSkill);

            // Figure out if majority of class is not the selected gender, send message only if that's true
            if (Male.Checked != male)
            {
                if (Male.Checked)
                {
                    output += "\n\nAlso note that most of your class will not be boys";
                }
                else
                {
                    output += "\n\nAlso note that most of your class will not be girls.";
                }
            }

            MessageBox.Show(output);
        }

        private string getStrSkillPrediction(string skillName, int minSkillVal, int skillVal)
        {
            if (skillVal < minSkillVal) // User skill is less than minimum Skill
            {
                return "You need to be better at: " + skillName;
            }
            else if (skillVal > minSkillVal) // User skill is greater than minimum Skill
            {
                return "You are exceptional at: " + skillName;
            }
            else // User skill is equal to minimum Skill
            {
                return "You are good at: " + skillName;
            }
        }

        private int getIntSkillPrediction(int minSkillVal, int skillVal)
        {
            if (skillVal < minSkillVal) // User skill is less than minimum Skill
            {
                return -1;
            }
            else if (skillVal > minSkillVal) // User skill is greater than minimum Skill
            {
                return 2;
            }
            else // User skill is equal to minimum Skill
            {
                return 1;
            }
        }

        private string getTotalSkillPrediction(int totalSkill)
        {
            // Ratings: -6 - -1, 0 - 5, 6 - 11, and 12 - 18
            if (totalSkill >= 12)
            {
                return "You will do really well in this class";
            }
            else if (totalSkill >= 6)
            {
                return "You will do ok in this class";
            }
            else if (totalSkill >= 0)
            {
                return "You will do pretty bad in this class";
            }
            else
            {
                return "You will barely survive in this class";
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Steps\n" +
                "1. Select your gender\n" +
                "2. Select the value you think you have in each skill. 1 is the worst and 5 is the best\n" +
                "3. Select a course you want to take\n" +
                "4. Click the predict button\n\n" +
                "Your output will tell you what skills you need to improve and how good you will do in the class, " +
                "your total skill value is on a scale from -6 to 12 and determines how good you will do in a class" +
                "\n\nFor further questions please email help@companysupport.com"
                );
        }

        private void SuccessPredicter_Load(object sender, EventArgs e)
        {
            // Initialize variables
            firstTime = true;
        }
    }
}
