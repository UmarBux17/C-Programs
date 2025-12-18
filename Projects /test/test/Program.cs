namespace test
{
    class Program {
        static void Main(string [] args)
        {
            string selectedMeasurement = SelectMeasurement();
            string output = selectedMeasurement;

            Console.WriteLine("You selected: " + output);



            Console.ReadLine();

        }

        private static string SelectMeasurement()
        {
            Console.WriteLine("Select a measurement:");
            Console.WriteLine("1. Teaspoon");
            Console.WriteLine("2. Tablespoon");
            Console.WriteLine("3. Cup");
            Console.WriteLine("4. Ounce");
            Console.WriteLine("5. Gram");

            while (true)
            {
                Console.Write("Enter the number of your choice: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            return "teaspoon";
                        case 2:
                            return "tablespoon";
                        case 3:
                            return "cup";
                        case 4:
                            return "ounce";
                        case 5:
                            return "gram";
                    }
                }

                Console.WriteLine("Invalid input. Please try again.");
            }

            
        }


    }
}


