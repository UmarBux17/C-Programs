using System.Collections;

namespace BasicCollectionsFour {

    class Program {


        static void Main(string[] args) {

            //Stack
            //create an object of stack
            //imports from the collections class
            Stack stack = new Stack();

            /* -- Push --> inserts an object into the stack
             * -- Pop --> Removes & returns an item at the top
             * -- Clear --> Removes all items from stack
             * -- Clone --> Creates a shallow copy of the stack
             * -- Contains --> checks if an item exists in the stack
             *             --> returns a bool --> T/F
             * -- Peek --> returns the top item in the stack
             * -- -- -- -- -- LIFO -- -- -- -- -- 
             *  
             */

            stack.Push("First item");
            stack.Push("Second item");
            stack.Push(1000);
            stack.Push(null);
            stack.Push(3.1414159);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }

}