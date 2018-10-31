using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {

        // member variables 
        public Game game;
        public double CupsOfSugar = .10;
        public double IceCubes = .5;
        public double Cups = .2;
        public double Lemons = .10;
        private double boughtCupsOfSugar;
        private double boughtIceCubes;
        private double boughtLemons;
        private double boughtCups;

        public List<string> MenuOptions = new List<string>();

        //constructor

        // member methods


        public void Menu(Game game)
        {
            this.game = game;
            Console.WriteLine("Here are today's prices!");
            MenuOptions.Add("Sugar: .10 per cup.");
            MenuOptions.Add("Ice Cubes: .5 per ice cube.");
            MenuOptions.Add("Lemons: .10 per lemon.");
            MenuOptions.Add("Cups: .2 per cup.");
            BuyCupsOfSugar(player);
        }


        public void BuyCupsOfSugar(Player player)
        {
            Console.WriteLine("How many cups of sugar would you like to buy?");
            boughtCupsOfSugar = double.Parse(Console.ReadLine());
            double price = boughtCupsOfSugar * CupsOfSugar;
            if (price <= player.money)
            {
                player.inventory.CupsOfSugar += Convert.ToInt32(boughtCupsOfSugar);
                player.money -= price;
            }
            else 
            {
                Console.WriteLine("You do not have enough money.");
            }

            if (boughtCupsOfSugar == 0)
            {
                BuyIceCubes(player);
            }
        }

        public void BuyIceCubes(Player player)
        {
            Console.WriteLine("How many ice cubes would you like to buy? ");
            boughtIceCubes = int.Parse(Console.ReadLine());
            double price = boughtIceCubes * IceCubes;
            if (price <= player.money)
            {
                player.inventory.IceCubes += Convert.ToInt32(boughtIceCubes);
                player.money -= price;
            }
            else
            {
                Console.WriteLine("You do not have enough money.");
            }

            if (boughtIceCubes == 0)
            {
                BuyLemons(player);
            }
        }

        public void BuyLemons(Player player)
        {
            Console.WriteLine("How many lemons would you like to buy?");
            boughtLemons = int.Parse(Console.ReadLine());
            double price = boughtLemons * Lemons;
            if (price <= player.money)
            {
                player.inventory.Lemons += Convert.ToInt32(boughtLemons);
                player.money -= price;
            }
            else
            {
                Console.WriteLine("You do not have enough money.");
            }

            if (boughtLemons == 0)
            {
                BuyCups(player);
            }
        }
            
        public void BuyCups(Player player)
        {
            Console.WriteLine("How many cups would you like to buy?");
            boughtCups = int.Parse(Console.ReadLine());
            double price = boughtCups * Cups;
            if (price <= player.money)
            {
                player.inventory.Cups += Convert.ToInt32(boughtCups);
                player.money -= price;
            }
            else 
            {
                Console.WriteLine("You do not have enough money.");
            }

            if (boughtCups == 0)
            {
                
              
            }
        }
    }
}
