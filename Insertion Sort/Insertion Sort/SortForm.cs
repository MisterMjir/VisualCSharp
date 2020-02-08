using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* TeenCoder: Windows Programming
   
   ToDo List Application

   Copyright 2013 CompuScholar, Inc.
*/

namespace Insertion_Sort
{
    public partial class SortForm : Form
    {
        // Create and initialize the linked list of integers
        LinkedList<int> numericList = new LinkedList<int>();

        public SortForm()
        {
            InitializeComponent();
        }

        // This code is provided for the student in the Activity Starter
        private void displayList()
        {
            // Clear the listbox 
            NumberList.Items.Clear();

            // Iterate over each item in the list
            foreach (int item in numericList)
            {
                // Add the item to the text box
                NumberList.Items.Add(item);
            }
        }

        // This code is provided for the student in the Activity Starter
        private void AddFrontButton_Click(object sender, EventArgs e)
        {
            // Get the text from the item text box
            int newItem = (int)UpDownList.Value;

            // Add to the front of the list
            numericList.AddFirst(newItem);

            // Display the new list
            displayList();
        }

        // This code is provided for the student in the Activity Starter
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Remove all items from the list
            numericList.Clear();

            // Display the new list
            displayList();
        }

        // This code is provided for the student in the Activity Starter
        private void RemoveButton_Click(object sender, EventArgs e)
        {
        	  if ((NumberList.Text == null) || ( NumberList.Text.Length == 0))
        	  	return;
        	  	
            // Get the text from the item text box
            int removeItem = int.Parse(NumberList.Text);

            // Iterate over the list looking for a matching string
            LinkedListNode<int> node = numericList.First;
            while (node != null)
            {
                if (node.Value == removeItem)
                {
                    // Remove this node from the list
                    numericList.Remove(node);
                    break;  // end of search
                }
                
                // Move to the next entry in the list
                node = node.Next;   
            }

            // Display the new list
            displayList();
        }

        // This code is ADDED FOR ACTIVITY by the student
        private void SortButton_Click(object sender, EventArgs e)
        {
            // There are one or less items so the list is already sorted
            if (numericList.Count < 2)
                return;

            LinkedListNode<int> currentNode = numericList.First.Next;

            while (currentNode != null)
            {
                LinkedListNode<int> nextNode = currentNode.Next;
                numericList.Remove(currentNode);
                LinkedListNode<int> searchNode = numericList.First;
                while (searchNode != null && (int) searchNode.Value < (int) currentNode.Value)
                {
                    searchNode = searchNode.Next;
                }

                if (searchNode != null)
                {
                    numericList.AddBefore(searchNode, currentNode);
                }
                else
                {
                    numericList.AddLast(currentNode);
                }

                currentNode = nextNode;
            }

            displayList();
        }
    }
}
