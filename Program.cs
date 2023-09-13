using System;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Aaron Fox";
            var location = "Colorado";
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");
            Console.WriteLine(DateTime.Today.ToShortDateString());

            // Days until Christmas
            var christmas = new DateTime(DateTime.Now.Year, 12, 25);
            var difference = christmas - DateTime.Today;
            Console.WriteLine($"Days until Christmas: {difference.Days}");

            // Example 2.1
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
                woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                glassArea + " square metres");

            // Pause console to prevent auto-termination.
            Console.ReadKey();
        }
    }
}
