using System;

namespace RestaurantTipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double restaurantCharge = GetDoubleInput("Enter the restaurant charge before taxes: ");
            double taxRate = 0.09;
            double taxAmount = CalculateTax(restaurantCharge, taxRate);
            double subtotal = restaurantCharge + taxAmount;
            double tipRate1 = 0.15;
            double tipRate2 = 0.20;
            double tipAmount1 = CalculateTip(subtotal, tipRate1);
            double tipAmount2 = CalculateTip(subtotal, tipRate2);
            double total1 = subtotal + tipAmount1;
            double total2 = subtotal + tipAmount2;

            Console.WriteLine("Restaurant Charge: {0, 15:C}", restaurantCharge);
            Console.WriteLine("Tax ({0:P}): {1, 20:C}", taxRate, taxAmount);
            Console.WriteLine("Subtotal: {0, 23:C}", subtotal);
            Console.WriteLine("Tip ({0:P}): {1, 21:C}", tipRate1, tipAmount1);
            Console.WriteLine("Total ({0:P}): {1, 19:C}", tipRate1, total1);
            Console.WriteLine("Tip ({0:P}): {1, 21:C}", tipRate2, tipAmount2);
            Console.WriteLine("Total ({0:P}): {1, 19:C}", tipRate2, total2);

            Console.ReadLine();
        }

        static double GetDoubleInput(string message)
        {
            double input;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out input) || input < 0)
            {
                Console.Write("Invalid input. Please enter a non-negative number: ");
            }
            return input;
        }

        static double CalculateTax(double amount, double rate)
        {
            return amount * rate;
        }

        static double CalculateTip(double amount, double rate)
        {
            return amount * rate;
        }
    }
}


