
using System;

namespace GranolaSales
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal BAR_PRICE = 1.50M;
            const decimal CASE_PRICE = 100.00M;
            const decimal SGA_PERCENTAGE = 0.10M;

            int casesSold = 29;
            int barsSold = casesSold * 100;
            decimal totalRevenue = barsSold * BAR_PRICE;
            decimal sgaContribution = totalRevenue * SGA_PERCENTAGE;
            decimal netRevenue = totalRevenue - sgaContribution;

            Console.WriteLine($"Total bars sold: {barsSold}");
            Console.WriteLine($"Total revenue: {totalRevenue:C}");
            Console.WriteLine($"SGA contribution: {sgaContribution:C}");
            Console.WriteLine($"Net revenue: {netRevenue:C}");

            Console.ReadLine();
        }
    }
}
