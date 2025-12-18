using System.Collections.Generic;

namespace ConversionTestOne {
    class Program {

        static void Main(string[] args)
        {
            // Task 1 --> Task 2
            // Delegates
            // array arrayList --> List<T>

            // basic array
            var someArray = new int[] {234,4564,789 };

            // Version 1 --> ToList Method
            var someList = someArray.ToList();
            // foreach
            Console.WriteLine("List using ToList Method\n\n");
            foreach (var item in someList)
            {
                Console.WriteLine(item);
            }

            // version 2 --> conversions
            // array is passed as a parameter
            var someArrayTwo = new int[] {345, 678, 45 };

            var someListTwo = new List<int>();
            someListTwo.AddRange(someArrayTwo);

            Console.WriteLine("\n'\nConversions using Add range");
            foreach (var item in someListTwo)
            {
                Console.WriteLine(item);
            }

            // version 3 --> create a new object of List<T>
            int[] arrayThree = { 234,456,678 };
            List<int> newListThree = new List<int>();
            newListThree.AddRange(arrayThree);

            Console.WriteLine("\n\nConverion using a new List object");
            foreach (var item in newListThree)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

}