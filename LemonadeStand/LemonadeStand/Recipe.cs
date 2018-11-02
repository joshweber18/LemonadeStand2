using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        public int sugar;
        public int lemons;
        public int ice;
        public double cup;
        public int cupsPerPitcher;
        public int pitcherOfLemonade;
       

        public Recipe()
        {
            cupsPerPitcher = 12;
            pitcherOfLemonade = 0;
            cup = 0;
        }



        public void CreateRecipe()
        {
            Console.WriteLine("Ready to create your recipe? Let's begin.");
            DetermineNumberOfLemons();
            DetermineNumberOfSugar();
            DetermineNumberOfIce();
            CostCup();
            ShowRecipe();
        }

        public void DetermineNumberOfLemons()
        {
            Console.WriteLine("How many lemons would you like in one pitcher?");
            lemons = Convert.ToInt32(Console.ReadLine());
           
        }

        public void DetermineNumberOfSugar()
        {
            Console.WriteLine("How many cups of sugar would you like in one pitcher?");
            sugar = Convert.ToInt32(Console.ReadLine());
          
        }

        public void DetermineNumberOfIce()
        {
            Console.WriteLine("How many ice cubes would you like to put in one cup? One pitcher takes 12 cups.");
            ice = Convert.ToInt32(Console.ReadLine());
          
        }

        public double CostCup()
        {
            Console.WriteLine("Please set amount for one cup of lemonade.");
            cup = double.Parse(Console.ReadLine());
            if (cup >= 0.01 && cup <= 1.00)
            { 
                return cup;
            }

            else
            {
                Console.WriteLine("Invalid input, please enter amount between 0.01 and $1.00");
                return CostCup();
            }
        }


        public void ShowRecipe()
        {
            Console.WriteLine("Let's take a look at your recipe! You have lemons: " + lemons + " cups of sugar: " + sugar +" and " + ice +" ice cubes per pitcher.");
        }


        public void CreatePitcher(Inventory inventory)
        {
            if (inventory.CheckValidAmountCups(cup) && inventory.CheckValidAmountIce(ice) && inventory.CheckValidAmountLemons(lemons) && inventory.CheckValidAmountSugar(sugar))
            {
                inventory.Lemons -= lemons;
                inventory.Cups -= cupsPerPitcher;
                inventory.CupsOfSugar -= sugar;
                inventory.IceCubes -= ice;
                pitcherOfLemonade++;
            }
        }
    }
}
