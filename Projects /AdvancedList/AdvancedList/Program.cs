using System.Collections.Generic;


namespace AdvancedList{
    class Program {
        static void Main(string[] args) {

            // create an obj of List T
            // using System.Collections.Generic;
            List<string> itemList = new List<string>();

            Console.WriteLine("Add items into the list >>>");
            //logical problem --> restrict the input -- only 5 entries
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i+1+":");
                var listInput = Console.ReadLine();
                itemList.Add(listInput);
            }

            Console.WriteLine("End of input >>>");
            Console.WriteLine("\n");
            //output --> print out all current ingredients
            Console.WriteLine("Items currently in stock >>>");

            foreach (var i in itemList)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("\n");

            Console.WriteLine("Output wth for loop >>>");
            for (int i = 0; i < 5; i++)
            {
                var item = itemList[i];
                Console.WriteLine($"{i+1} : {item}");
            }



            Console.ReadLine();//open console
        }

    }

}