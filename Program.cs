using System;

namespace CGSummer2018_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // First we have to gather the information from the user and store it in variables
            Console.WriteLine("This program will calculate the area of a rectangle for you.");
            Console.Write("Enter the length of side A: ");
            string sideA = Console.ReadLine();
            Console.Write("Enter the length of the side B: ");
            string sideB = Console.ReadLine();

            // There's a chance that they might not enter numbers. What should we do then?
            // We'll assume for now that they did. But you'll learn in a later class how to handle
            // if they didn't.
            int sideAnumber = int.Parse(sideA); // this will error if they pass in hello
            int sideBnumber = int.Parse(sideB); // this will error if they pass in hello

            // Now, calculate the area of the sides they passed in and give them their answer
            int area = sideAnumber * sideBnumber;

            Console.WriteLine("The area of your rectangle is: " + area);
            Console.ReadLine();

        }
    }
}
