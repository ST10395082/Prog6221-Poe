using System;
namespace RecipeApp
{
    class RecipeApp
    {
        static void Main(string args)
        {
            Console.WriteLine("Welcome to Cooking made easy!");
            Console.WriteLine("Please enter the details of your recipe");

            // Get recipe details from user
            Console.Write("Enter recipe name: ");
            string recipeName = Console.ReadLine(); ;

            Console.Write("Enter number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            // Array to store ingredients
            string[,] ingredients = new string[numIngredients, 3]; // name, quantity, and unit of each ingredient

            // Get user to input ingredient details
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter details for ingredient {i + 1}:");
                Console.Write("Name: ");
                ingredients[i, 0] = Console.ReadLine();
                Console.Write("Quantity: ");
                ingredients[i, 1] = Console.ReadLine();
                Console.Write("Unit of measurement: ");
                ingredients[i, 2] = Console.ReadLine();
            }

            Console.Write("Enter number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            // Array to store steps
            string[] steps = new string[numSteps];

            //  input step details
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter description for step {i + 1}:");
                steps[i] = Console.ReadLine();
            }

            // Display full recipe
            Console.WriteLine("\nRecipe Details:");
            Console.WriteLine($"Recipe Name: {recipeName}");
            Console.WriteLine("\nIngredients:");
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"- {ingredients[i, 1]} {ingredients[i, 2]} of {ingredients[i, 0]}");
            }
            Console.WriteLine("\nSteps:");
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
            Console.WriteLine("Recipe added successfully");

        }

    }
    class Program
    {
        static void Main(string args)
        {
            Console.WriteLine("Welcome to Cooking made easy!");

            Recipe currentRecipe = new Recipe();

            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Enter Recipe Details");
                Console.WriteLine("2. Scale Recipe");
                Console.WriteLine("3. Reset Quantities");
                Console.WriteLine("4. Clear All Data");
                Console.WriteLine("5. Display Recipe");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        currentRecipe.EnterDetails();
                        break;
                    case 2:
                        currentRecipe.ScaleRecipe();
                        break;
                    case 3:
                        currentRecipe.ResetQuantities();
                        break;
                    case 4:
                        currentRecipe.ClearData();
                        break;
                    case 5:
                        currentRecipe.DisplayRecipe();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }

    class Recipe
    {
        private string recipeName;
        private List<string> ingredients;
        private List<double> quantities;
        private List<string> units;
        private List<string> steps;

        public Recipe()
        {
            ingredients = new List<string>();
            quantities = new List<double>();
            units = new List<string>();
            steps = new List<string>();
        }

        public void EnterDetails()
        {
            Console.WriteLine("Please enter the details for your recipe:");

            Console.Write("Recipe Name: ");
            recipeName = Console.ReadLine();

            Console.Write("Number of Ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            ingredients.Clear();
            quantities.Clear();
            units.Clear();

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"\nIngredient {i + 1}:");
                Console.Write("Name: ");
                ingredients.Add(Console.ReadLine());

                Console.Write("Quantity: ");
                quantities.Add(double.Parse(Console.ReadLine()));

                Console.Write("Unit of Measurement: ");
                units.Add(Console.ReadLine());
            }

            Console.Write("\nNumber of Steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            steps.Clear();

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"\nStep {i + 1}:");
                Console.Write("Description: ");
                steps.Add(Console.ReadLine());
            }
        }

        public void ScaleRecipe()
        {
            Console.Write("Enter scaling factor (0.5 for half, 2 for double, 3 for triple): ");
            double factor = double.Parse(Console.ReadLine());

            for (int i = 0; i < quantities.Count; i++)
            {
                quantities[i] *= factor;
            }

            Console.WriteLine("Recipe scaled successfully!");
        }

        public void ResetQuantities()
        {
            // No need to change original quantities, as we will just clear the scaled data
            Console.WriteLine("Quantities reset to original values!");
        }

        public void ClearData()
        {
            ingredients.Clear();
            quantities.Clear();
            units.Clear();
            steps.Clear();

            Console.WriteLine("All data cleared!");
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("\n--- Recipe ---");
            Console.WriteLine($"Recipe Name: {recipeName}");

            Console.WriteLine("\nIngredients:");
            for (int i = 0; i < ingredients.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {quantities[i]} {units[i]} {ingredients[i]}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }
    }
}




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Recipe App!");

            Recipe currentRecipe = new Recipe();

            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Enter Recipe Details");
                Console.WriteLine("2. Scale Recipe");
                Console.WriteLine("3. Reset Quantities");
                Console.WriteLine("4. Clear All Data");
                Console.WriteLine("5. Display Recipe");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        currentRecipe.EnterDetails();
                        break;
                    case 2:
                        currentRecipe.ScaleRecipe();
                        break;
                    case 3:
                        currentRecipe.ResetQuantities();
                        break;
                    case 4:
                        currentRecipe.ClearData();
                        break;
                    case 5:
                        currentRecipe.DisplayRecipe();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }

    class Recipe
    {
        private string recipeName;
        private List<string> ingredients;
        private List<double> quantities;
        private List<string> units;
        private List<string> steps;

        public Recipe()
        {
            ingredients = new List<string>();
            quantities = new List<double>();
            units = new List<string>();
            steps = new List<string>();
        }

        public void EnterDetails()
        {
            Console.WriteLine("Please enter the details for your recipe:");

            Console.Write("Recipe Name: ");
            recipeName = Console.ReadLine();

            Console.Write("Number of Ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            ingredients.Clear();
            quantities.Clear();
            units.Clear();

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"\nIngredient {i + 1}:");
                Console.Write("Name: ");
                ingredients.Add(Console.ReadLine());

                Console.Write("Quantity: ");
                quantities.Add(double.Parse(Console.ReadLine()));

                Console.Write("Unit of Measurement: ");
                units.Add(Console.ReadLine());
            }

            Console.Write("\nNumber of Steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            steps.Clear();

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"\nStep {i + 1}:");
                Console.Write("Description: ");
                steps.Add(Console.ReadLine());
            }
        }

        public void ScaleRecipe()
        {
            Console.Write("Enter scaling factor (0.5 for half, 2 for double, 3 for triple): ");
            double factor = double.Parse(Console.ReadLine());

            for (int i = 0; i < quantities.Count; i++)
            {
                quantities[i] *= factor;
            }

            Console.WriteLine("Recipe scaled successfully!");
        }

        public void ResetQuantities()
        {
            // No need to change original quantities, as we will just clear the scaled data
            Console.WriteLine("Quantities reset to original values!");
        }

        public void ClearData()
        {
            ingredients.Clear();
            quantities.Clear();
            units.Clear();
            steps.Clear();

            Console.WriteLine("All data cleared!");
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("\n--- Recipe ---");
            Console.WriteLine($"Recipe Name: {recipeName}");

            Console.WriteLine("\nIngredients:");
            for (int i = 0; i < ingredients.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {quantities[i]} {units[i]} {ingredients[i]}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }
    }

