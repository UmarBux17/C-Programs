namespace PointerOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pint();

            Console.ReadLine();
        }

        public static unsafe void Pint()
        {
            int a = 5;
            int b = 8;

            //create pointer that points to the variables
            int* pointerA = &a;
            int* pointerB = &b;

            //pull 2 things -- value ---address
            Console.WriteLine(*pointerA);
            Console.WriteLine((int)*pointerA);
            Console.WriteLine(*pointerB);
            Console.WriteLine((int)*pointerB);
        }
    }
}