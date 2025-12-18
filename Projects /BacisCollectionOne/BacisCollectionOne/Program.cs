// See https://aka.ms/new-console-template for more information
namespace BasicCollectionOne {

    class Program {


        static void Main(string[]args) {

            //Generic
            //recap of arrays with old ++ new rules
            string[] someCars = {"Merc","Audi","Chev","Golf","BMW","Pony"};
            int[] someValues = {34,76,-9,124,56,3,1092};

            //iteration of items in the collection
            Console.WriteLine("The string of array items >>>");
            for (int i = 0; i < someCars.Length; i++) {

                Console.WriteLine(someCars[i]); //vertical output
                //Console.Write(someCars[i]+" "); //horizontal output

            }

            Console.WriteLine("\n\n\nPrinting out the int array items >>>");

            for (int i = 0; i < someValues.Length; i++)
            {
                Console.WriteLine(someValues[i]); //vertical length
                //Console.WriteLine(someValues[i]+" "); //horizontal length

            }

            //foreach
            Console.WriteLine("\n\n\n*****Printing with new rules*****");
            Console.WriteLine("\n\n\nPrinting out the string array in ascending order");
            foreach (string i in someCars)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n\nPrinting out the int array");
            foreach (int item in someValues)
            {
                Console.WriteLine(item);
            }

            //sorting
            Console.WriteLine("<<<<<<<<<< sorted arrays >>>>>>>>>>");
            Array.Sort(someCars); // sorts in ascending order
            Array.Sort(someValues);// sorts in ascending order


            Console.WriteLine("\n\n\nPrinting out the string array in ascending order");
            foreach (string i in someCars)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n\nPrinting out the int array in ascending order");
            foreach (int item in someValues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\nFlipped");
            Array.Reverse(someValues);
            foreach (var i in someValues)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();//open console
            }



        }
    }




