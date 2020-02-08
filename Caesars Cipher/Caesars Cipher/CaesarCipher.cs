using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesars_Cipher
{
    public partial class CaesarCipher : Form
    {
        public CaesarCipher()
        {
            InitializeComponent();
        }

        private void EnocdeButton_Click(object sender, EventArgs e)
        {
            string decodedString = StringTextBox.Text;
            string encodedString = "";

            for (int i = 0; i < decodedString.Length; i++)
            {
                char thisChar = decodedString[i];
                int encodedValue = (int) thisChar;
                encodedString += encodedValue.ToString("D3");
                if (i < decodedString.Length)
                    encodedString += ", ";
            }

            StringTextBox.Text = encodedString;
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            string encodedString = StringTextBox.Text;
            string decodedString = "";

            for (int i = 0; i < encodedString.Length; i += 5)
            {
                string digits = encodedString.Substring(i, 3);
                int numericValue = int.Parse(digits);
                char decodedValue = (char) numericValue;
                decodedString += decodedValue;
            }

            StringTextBox.Text = decodedString;
        }
    }
}
