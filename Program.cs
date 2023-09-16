﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create variables and store data
            string myName = "Alex Ward";
            string myLocation = "Utah";

            // Print variables using string interpolation
            Console.WriteLine($"My name is {myName}");
            Console.WriteLine($"I am from {myLocation}");

            // Print current date
            Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));

            // Print number of days until next Christmas
            DateTime christmasDay = new DateTime(2023, 12, 25);
            Console.WriteLine($"Days until Christmas: {Math.Truncate((christmasDay - DateTime.Now).TotalDays)}");

            // Program example from textbook
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");


            // Used to prevent the application from immediately terminating
            Console.ReadKey();
        }
    }
}
