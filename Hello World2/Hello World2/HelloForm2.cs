using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World2
{
    public partial class HelloForm2 : Form
    {
        public HelloForm2()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
            MessageBox.Show("Hi Mr. Musgrave");
        }

        private void HelloForm2_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("m_man.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
