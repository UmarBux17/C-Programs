using System.Diagnostics;

namespace DSBasicOne
{
   class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //array
            int[] newArray = new int[1000];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = 1;
                Console.Write(i + "|");
            }
            sw.Stop();
            Console.WriteLine("\nTime taken for array: ");
            Console.WriteLine(sw.Elapsed);

            Console.WriteLine("\n\n");

            //list
            sw.Restart();
            List<int> newList = new List<int>(100);

            for (int i = 0; i < 1000; i++)
            {
                newList.Add(i);
                Console.Write(i + "|");
            }
            sw.Stop();
            Console.WriteLine("\nTime taken for list: ");
            Console.WriteLine(sw.Elapsed);


            Console.ReadLine();
        }
    }
}
