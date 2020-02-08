/*
 * Echo Echo
 * ----------
 * Author: Mihir Chaudhari
 * Date: August 27, 2019
 */

// .NET framework imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo_Echo
{
    class Program
    {
        static void Main(string[] args) // Main function
        {
            Console.Write("What is your name? "); // Print the question
            string name = Console.ReadLine(); // Assign the value of the input to string vairable name
            Console.WriteLine("What's up " + name); // Print a greeting and the variable name
            Console.WriteLine("\nPress any key to quit the program"); // Inform the user that the program is ready to close
            Console.ReadKey(); // Wait for user to press anything to end the program
        }
    }
}
