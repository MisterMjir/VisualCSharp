using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_List
{
    public partial class ToDoList : Form
    {
        System.Collections.Generic.LinkedList<string> todoList = new LinkedList<string>();
        public ToDoList()
        {
            InitializeComponent();
        }

        private void AddFrontButton_Click(object sender, EventArgs e)
        {
            if (ItemTextBox.Text != "")
            {
                todoList.AddFirst(ItemTextBox.Text);
            }
            DisplayList();
        }

        private void AddBackButton_Click(object sender, EventArgs e)
        {
            if (ItemTextBox.Text != "")
            {
                todoList.AddLast(ItemTextBox.Text);
            }
            DisplayList();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            /*
             * There has to be a better way than what CompuScholar has
             * because if there are two items with the same name, and the
             * user selects the second item, the first item will get deleted
             * 
             * I will still do the CompuScholar method
             */
             if (ToDoListBox.Text != "")
             {
                todoList.Remove(ToDoListBox.Text);
                DisplayList();
             }
             
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            todoList.Clear();
            DisplayList();
        }

        private void DisplayList()
        {
            ItemTextBox.Text = "";
            ToDoListBox.Items.Clear();
            foreach(string todo in todoList)
            {
                ToDoListBox.Items.Add(todo);
            }
        }
    }
}
