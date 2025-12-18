namespace POEPart1
{
    class Recipe
    {
        // Fields to store recipe details
        private List<string> ingredients = new List<string>();
        private List<string> steps = new List<string>();
        private int numIngredients;
        private int numSteps;
        private double scalingFactor = 1.0;

        // Method to add ingredients
        public void AddIngredient(string ingredient)
        {
            ingredients.Add(ingredient);
            numIngredients++;
        }

        // Method to add steps
        public void AddStep(string step)
        {
            steps.Add(step);
            numSteps++;
        }

        // Method to display recipe
        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"{ingredients[i]}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }

        // Method to scale recipe
        public void ScaleRecipe(double factor)
        {
            scalingFactor = factor;
            for (int i = 0; i < numIngredients; i++)
            {
                // Multiply ingredient quantity by scaling factor
                string[] parts = ingredients[i].Split(' ');
                double quantity = Convert.ToDouble(parts[0]);
                string unit = parts[1];
                quantity *= scalingFactor;
                ingredients[i] = $"{quantity} {unit}";
            }
        }

        // Method to reset ingredient quantities
        public void ResetIngredients()
        {
            scalingFactor = 1.0;
        }

        // Method to clear recipe data
        public void ClearRecipe()
        {
            ingredients.Clear();
            steps.Clear();
            numIngredients = 0;
            numSteps = 0;
            scalingFactor = 1.0;
        }
    }
}
 

