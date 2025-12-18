namespace DelsAdavanced {
    class Program {

        //global delegate
        public delegate void someMethodDel(string msgDel);
        public delegate void valueOneDel(int aDel, int bDel);


        static void Main(string[] args) {

            //someMethodDel smd = new someMethodDel(someMethod);
            //smd("Testing consuming a method");
            //smd.Invoke("Alternatve");

           /* someMethodDel smd = delegate (string msg)
            {
                //At this point its anonymous method
                Console.WriteLine(msg);
            };

            smd("Testing anonymous method");
            smd.Invoke("Alternative");

            valueOneDel vod = delegate (int aDel, int bDel)
            {
                //At this point its anonymous method
                int sum = aDel + bDel;
                Console.WriteLine(sum);
            };

            vod(5,5);
            vod.Invoke(2,2);
           */

            someMethodDel smd = msgDel => 
            {
                //At this point its anonymous method
                Console.WriteLine(msgDel);
            };

            smd("Testing anonymous method");
            smd.Invoke("Alternative");

            valueOneDel vod = (aDel, bDel) =>
            {
                //At this point its anonymous method
                int sum = aDel + bDel;
                Console.WriteLine(sum);
            };

            vod(5, 5);
            vod.Invoke(2, 2);

            Console.ReadLine();
        }

        /* Delegates --> encompasses 3 elements
         * 1 --> delegate --> 3 steps
         * 2 --> Anonymous methods
         *       - Is a method without a NAME
         *       - Only has a body 
         *       - Doesn't need a return type
         *       - Used as a delegate parameter
         * 3 --> Lambda expressions
         *       => notation
         *       - To go to
         * Situtaion --> anonymous method ++ del ++ lambda
         *           --> further reduce code
         *           -- Delegate drops
         *           -- return type drops
         */

        //public static void someMethod (string msg)
        //{
        //  Console.WriteLine(msg);
        //}

        //public static void valueOne(int a, int b)
        //{
        //    int sum = a + b;
        //    Console.WriteLine(sum);
        //}



    }
}

