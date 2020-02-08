/*
 * This is a lot like the first coding project I made in Scratch
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

namespace Tall_Tales
{
    public partial class tallTales : Form
    {
        public tallTales()
        {
            InitializeComponent();
        }

        private void CreateStory_Click(object sender, EventArgs e)
        {
            finalStoryText.Text = ""; // Reset the story
            string myStoryText = "In the beginning, there was a(n) ";
            myStoryText += speciesComboBox.Text;
            myStoryText += " who was known to his comrades as ";
            myStoryText += NameTextBox.Text;
            myStoryText += ". This dood was always ";
            myStoryText += activityList.Text;
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                if (checkBox1.Checked)
                {
                    myStoryText += " and ";
                    myStoryText += checkBox1.Text;
                }
                if (checkBox2.Checked)
                {
                    myStoryText += " and ";
                    myStoryText += checkBox2.Text;
                }
                if (checkBox3.Checked)
                {
                    myStoryText += " and ";
                    myStoryText += checkBox3.Text;
                }
                myStoryText += ".";
            }
            else
            {
                myStoryText += " and nothing.";
            }
            myStoryText += " One eventful day, a day that would shake the world, this epic thing encountered a(n) ";
            if (radioButton1.Checked)
            {
                myStoryText += radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                myStoryText += radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                myStoryText += radioButton3.Text;
            }
            else
            {
                myStoryText += " hold up. You weren't supposed to get here";
            }
            myStoryText += ". This was a ";
            myStoryText += goodBadList.Text;
            myStoryText += " dawn.";
            finalStoryText.Text = myStoryText;
        }
    }
}
