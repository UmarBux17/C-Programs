//ST10028265
namespace IceTaskOne {
    class Program {

        static void Main(string[]args) {

            //Array
            int[] num = new int[10];

            //Loop to retrieve input
            for (int i = 0; i < num.Length; i++){

                Console.WriteLine("Enter a number");
                num[i] = Int32.Parse(Console.ReadLine());
            }


            //checking and printing list of EVEN integers
            Console.WriteLine("List of even numbers : ");
            for (int i = 0; i < num.Length; i++)
            {
                //condition for EVEN number
                if (num[i] % 2 == 0)
                    Console.Write(num[i] + " ");
            }


            Console.ReadLine();//displays output
        }

    }



}

