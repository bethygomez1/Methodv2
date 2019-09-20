/*
 Author: Bethy Gomez
 Date: 9/19/2019
 Description: Deliverable 3 - Methods
 */

using System;

namespace Methodv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name...");
            GreetUser(); // GreetUser method that will display the user output
            // To pause program before closing
            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey(true);
        } // End of main

       public static void GreetUser() // Method to display "Hello users name!"
        {
            string username = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + username + "!");
            // Something extra to display the current date/time
            Console.WriteLine("It is currently: " + System.DateTime.Now);
        } // End of GreetUser

    } // End of Class
} // End of Namespace
