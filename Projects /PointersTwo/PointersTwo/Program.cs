namespace PointersTwo
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            //create an array of items
            int[] someArray = {100,55,78,36,14,9,-5,25};

            // it can change during garbage collection
            //ensures the memory location remains constant
            fixed(int* pointerA = someArray)

                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine("Values [{0}] = {1}",i,*(pointerA + i));
                    Console.WriteLine("Address [{0}] = {1}",i,(int)(pointerA + i));
                }
            Console.ReadLine();
        }
    }
}