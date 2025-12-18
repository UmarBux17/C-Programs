using System;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = GetDoubleInput("Enter the height of the rectangle: ");
            double width = GetDoubleInput("Enter the width of the rectangle: ");

            double area = CalculateArea(height, width);
            double perimeter = CalculatePerimeter(height, width);

            Console.WriteLine("Results:");
            Console.WriteLine("--------");
            Console.WriteLine($"Area:\t\t{area,0:F1}");
            Console.WriteLine($"Perimeter:\t{perimeter,0:F1}");

            Console.ReadLine();
        }

        static double GetDoubleInput(string message)
        {
            double input;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out input) || input <= 0)
            {
                Console.Write("Invalid input. Please enter a positive number: ");
            }
            return input;
        }

        static double CalculateArea(double height, double width)
        {
            return height * width;
        }

        static double CalculatePerimeter(double height, double width)
        {
            return 2 * (height + width);
        }
    }
}

