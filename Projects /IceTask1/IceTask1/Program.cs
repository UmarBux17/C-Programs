//ST10028265
namespace IceTask1 {

    class Program {

        static void Main(string[] args) {

            //aray
            int[] num = new int[5];

            //loop to retrieve input from user
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                num[i]=Int32.Parse(Console.ReadLine());
            }

            //sorting array in descending numbers
            Array.Reverse(num);

            //display loop for aray
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();//open display
        }

    }

}

