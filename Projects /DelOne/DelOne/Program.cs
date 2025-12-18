namespace DelOne {
    class Program
    {
        // step one --> Global declration of a delegate
        // must match the signature
        // public delegate void someTextDel(string msgDel);
        // public static void someText(string msg)

        public delegate void someTextDel(string msgDel);

        static void Main(string[]args) {

            /* Delegates
             * -- they are function pointers
             * -- NB function is a method
             * Rules for using a delegate
             * -- keyword delegate
             * -- global declaration
             * -- has to have the SAME SIGNATURE of the function it points to
             * -- create an object of the delegate
             * -- pass the function AS A PARAMETER
             * -- Invoke the delegate
             *     -- using the delegate object
             *     -- Invoke method - built in
             */

            //someText("Old method call"); // NA
            // step 2 --> create an object of the delegate
            someTextDel std = new someTextDel(someText);

            // step 3 --> Invoke
            std("Delegate consuming a function >>>");
            std.Invoke("Alternative to invoking a delegate");

            Console.ReadLine();
        }

        public static void someText(string msg)
        {
            Console.WriteLine(msg);
        }


    }


}