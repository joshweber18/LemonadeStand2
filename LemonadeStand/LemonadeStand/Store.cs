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
        public double BoughtCupsOfSugar;
        public double BoughtIceCubes;
        public double BoughtLemons;
        public double BoughtCups;


        //constructor

        // member methods


        private void buycupsofsugar(Player player)
        {
            Console.WriteLine("How many cups of sugar would you like to buy?");
            BoughtCupsOfSugar = double.Parse(Console.ReadLine());
            double price = BoughtCupsOfSugar * CupsOfSugar;
            if (price <= player.money)
            {
                player.money -= price;
            }
            else 
                {
                Console.WriteLine("You do not have enough money.");
                }
        }

        private void buyicecubes(Player player)
        {
            Console.WriteLine("How many ice cubes would you like to buy? ");
            BoughtIceCubes = int.Parse(Console.ReadLine());
            double price = BoughtIceCubes * IceCubes;
            if (price <= player.money)
            {
                player.money -= price;
            }
            else
            {
                Console.WriteLine("You do not have enough money.");
            }
        }

        private void buylemons(Player player)
        {
            Console.WriteLine("How many lemons would you like to buy?");
            BoughtLemons = int.Parse(Console.ReadLine());
            double price = BoughtLemons * Lemons;
            if (price <= player.money)
            {
                player.money -= price;
            }
            else
            {
                Console.WriteLine("You do not have enough money.");
            }
        }
            
        private void buycups(Player player)
        {
            Console.WriteLine("How many cups would you like to buy?");
            BoughtCups = int.Parse(Console.ReadLine());
            double price = BoughtCups * Cups;
            if (price <= player.money)
            {
                player.money -= price;
            }
            else 
            {
                Console.WriteLine("You do not have enough money.");
            }
        }
    }
}
