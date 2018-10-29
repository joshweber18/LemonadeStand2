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


        private void BuyCupsOfSugar(Player player)
        {
            Console.WriteLine("How many cups of sugar would you like to buy?");
            BoughtCupsOfSugar = double.Parse(Console.ReadLine());
            double x = BoughtCupsOfSugar * CupsOfSugar;
            if (x <= player.money)
            {
                player.money -= x;
            }
            else if () 
                {
                Console.WriteLine("You do not have enough money.");
                }

        }

        private void BuyIceCubes(Player player)
        {
            Console.WriteLine("How many ice cubes would you like to buy? ");
            BoughtIceCubes = int.Parse(Console.ReadLine());
            double x = BoughtIceCubes * IceCubes;
            if (x <= player.money)
            {
                player.money -= x;
            }
            else if ()
            {
                Console.WriteLine("You do not have enough money.");
            }
        }

        private void BuyLemons(Player player)
        {
            Console.WriteLine("How many lemons would you like to buy?");
            BoughtLemons = int.Parse(Console.ReadLine());
            double x = BoughtLemons * Lemons;
            if (x <= player.money)
            {
                player.money -= x;
            }
            else if ()
            {
                Console.WriteLine("You do not have enough money.");
            }

        }
            
        private void BuyCups(Player player)
        {
            Console.WriteLine("How many cups would you like to buy?");
            BoughtCups = int.Parse(Console.ReadLine());
            double x = BoughtCups * Cups;
            if (x <= player.money)
            {
                player.money -= x;
            }
            else if ()
            {
                Console.WriteLine("You do not have enough money.");
            }
        }

    }
}
