using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        private int sugar;
        private int lemons;
        private int ice;
        private int cup;

        public Recipe()
        {
            createRecipe();
        }



        public void createRecipe()
        {
            Console.WriteLine("Ready to create your recipe? Let's begin.");
            Lemons();
        }

        private void Lemons()
        {
            Console.WriteLine("How many lemons would you like in one pitcher?");
            lemons = Convert.ToInt32(Console.ReadLine());
            Sugar();
        }

        private void Sugar()
        {
            Console.WriteLine("How many cups of sugar would you like in one pitcher?");
            sugar = Convert.ToInt32(Console.ReadLine());
            Ice();
        }

        private void Ice()
        {
            Console.WriteLine("How many ice cubes would you like to put in one cup? One pitcher takes 15 cups.");
            ice = Convert.ToInt32(Console.ReadLine());
        }

        private void CostCup()
        {
            Console.WriteLine("Please set amount for one cup of lemonade.");
            cup = Convert.ToInt32(Console.ReadLine());
        }
        private void ShowRecipe()
        {
            Console.WriteLine("Let's take a look at your recipe! You have lemons: " + lemons + " cups of sugar: " + sugar +" and " + ice +" ice cubes per pitcher.");
        }


    }
}
