namespace POEPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe myRecipe = new Recipe();

            // Prompt user to enter recipe details
            Console.WriteLine("Enter recipe details:");

            Console.Write("Number of ingredients: ");
            int numIngredients = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write($"Ingredient {i + 1}: ");
                string ingredient = Console.ReadLine();
                myRecipe.AddIngredient(ingredient);
            }

            Console.Write("Number of steps: ");
            int numSteps = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Step {i + 1}: ");
                string step = Console.ReadLine();
                myRecipe.AddStep(step);
            }

            // Display recipe
            Console.WriteLine("\nRecipe:");
            myRecipe.DisplayRecipe();

            // Allow user to scale recipe
            Console.Write("\nEnter scaling factor (default is 1.0): ");
            string input = Console.ReadLine();
            if (input != "")
            {
                double scalingFactor = Convert.ToDouble(input);
                myRecipe.ScaleRecipe(scalingFactor);
            }

            // Display scaled recipe
            Console.WriteLine("\nScaled Recipe:");
            myRecipe.DisplayRecipe();

            // Allow user to reset ingredient quantities
            Console.Write("\nReset ingredient quantities? (y/n): ");
            input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                myRecipe.ResetIngredients();
                Console.WriteLine("\nReset ingredient quantities to original values.");
                myRecipe.DisplayRecipe();
            }

            // Allow user to clear recipe data and start over
            Console.Write("\nClear recipe and start over? (y/n): ");
            input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                myRecipe.ClearRecipe();
                Console.WriteLine("\nRecipe data cleared. Start over.");
                Main(args); // Call Main method to start over
            }



        }
    }
}

