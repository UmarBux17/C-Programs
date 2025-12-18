namespace MethodsRecapOne{
    class Program {

        static void Main(string[] args) {
            /* Static --> 2 ways
             *        --> 1 classname.methodname
             *        --> 2 mathodname();
             * Non static
             *          --> create an object of the class
             * Returning --> takes and returns values
             * 
             * 
             */
            firstMethod();
            Program.firstMethod();//alternative

            Program prog = new Program();
            prog.secondMethod();

            addValues(100,450);

            Console.ReadLine();
        }

        //static method
        public static void firstMethod()
        {
            Console.WriteLine("From method one >>>");
        }

        //non static method
        public void secondMethod()
        {
            Console.WriteLine("From method two >>>");
        }

        //returning method
        public static int addValues(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Values added: "+sum);

            return sum;
        }

    }

}