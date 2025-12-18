namespace DelTwo {
    class Program {

        public delegate void someTextDel(string textDel);
        public delegate void someMatchDel(int a,int b);

        static void Main(string[]args) {

            // del 1
            someTextDel std = new someTextDel(someText);
            std.Invoke("Static method");

            // del 2
            Program p = new Program();
            someMatchDel smd = new someMatchDel(p.someMatch);
            smd(120,65);


            Console.ReadLine();
        }

        //method 1
        public static void someText(string text)
        {
            Console.WriteLine(text);
        }

        //method 2
        public void someMatch(int a, int b)
        {
            Console.WriteLine("The values added; " + (a+b));
        }
    }

}

