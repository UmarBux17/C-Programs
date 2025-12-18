namespace BasicCollectionTwo {

    class Program {

        static void Main(string[]args) {
            //program to show use of List<T>
            //imports -- how you declare the List T
            //dynamic reszieability --> on the fly
            //number of items not needed upon declartion

            //create a list of Int's
            List<int> someList = new List<int>();
            //add items onto the  list
            someList.Add(34);
            someList.Add(567);
            someList.Add(100);
            someList.Add(-5);
            someList.Add(88);

            //output
            Console.WriteLine("Iterations through basic list's\n");
            foreach (var item in someList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\n");

            //declare a List of T holding some string values
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Sue");
            names.Add("Jake");
            names.Add("Henry");

            //output
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }








            Console.ReadLine();
        }


    }


}
