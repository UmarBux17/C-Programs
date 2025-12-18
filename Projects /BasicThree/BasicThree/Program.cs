// See https://aka.ms/new-console-template for more information
namespace BasicThree
{

    class Program {

        static void Main(string[] args)
        {
            /*
             * -- dynamic data type
             * -- static type
             * -- figures it out LATE
             * -- wont suggest methods
             * -- CAN CHANGE THE DATA TYPE
             * -- it will change at RUNTIME
             */

            dynamic age = 15;

            Console.WriteLine(age);
            Console.WriteLine(age.GetType());

            age = "Seven";
            Console.WriteLine(age);
            Console.WriteLine(age.GetType());

            Console.ReadLine();

             




        }




    }




}
