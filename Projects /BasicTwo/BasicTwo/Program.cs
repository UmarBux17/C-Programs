// See https://aka.ms/new-console-template for more information
namespace BasicTwo
{

    class Program {

        static void Main(string[] args)
        {
            /* -- var data types
             * -- used to type implicity typed local vcariables
             * -- must be initalized at decalartion
             * Once it sets the data type it CANNOT BE CHANGED
             */

            var age = 30;
            age = "six";
            Console.WriteLine(age);
            Console.WriteLine(age.GetType());

            var ageText ="Five";
            Console.WriteLine(ageText);
            Console.WriteLine(ageText.GetType());

            //limitations


            Console.ReadLine();

        }
    }

}
