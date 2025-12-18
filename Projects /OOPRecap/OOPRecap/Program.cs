// See https://aka.ms/new-console-template for more information
namespace OOPRecap
{
    class Program {

        static void Main(string[] args)
        {
            /* Main concepts --> oop
             * 1 -- Abstraction
             * 2 -- Inheritance
             * 3 -- Encapsulation
             * 4 -- Polymorphism
             * 
             */

            //get the values
            Console.WriteLine("Enter your order ID >>>");
            string orderNum = Console.ReadLine();

            Console.WriteLine("Enter yout name >>>");
            string customer = Console.ReadLine();

            Console.WriteLine("Enter the number of burgers >>>");
            int burgers = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of drinks >>>");
            int drinks = Int32.Parse(Console.ReadLine());


            //create an obj of the class
            Orders orders = new Orders(orderNum,customer,burgers,drinks);

            //orders.ToString(); output from Orders class

            Console.WriteLine(orders.ToString());


            Console.ReadLine();








        }



    }




}
