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

        public double CupsOfSugar = .10;
        public double IceCubes = .10;
        public double Cups = .2;
        public double Lemons = .10;
        public double boughtCupsOfSugar;
        public double boughtIceCubes;
        public double boughtLemons;
        public double boughtCups;


        //constructor

        // member methods

        private void BuyCupsOfSugar(Player player)
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

        private void BuyIceCubes(Player player)
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

        private void BuyLemons(Player player)
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
            
        private void BuyCups(Player player)
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
