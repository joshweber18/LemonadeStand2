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
        public double IceCubes = .5;
        public double Cups = .2;
        public double Lemons = .10;

        public List<string> MenuOptions;

        //constructor
        public Store()
        {
            MenuOptions = new List<string>() { "Here are today's prices!",
                "Sugar: .10 per cup.",
                "Ice Cubes: .5 per ice cube.",
                "Lemons: .10 per lemon.",
                "Cups: .2 per cup."
            };
        }
        // member methods


        public void Menu(Player player)
        {
            Console.WriteLine();
            MenuOptions.ForEach(Console.WriteLine);
            BuyCupsOfSugar(player);
            BuyIceCubes(player);
            BuyLemons(player);
            BuyCups(player);
        }


        public void BuyCupsOfSugar(Player player)
        {
            Console.WriteLine("How many cups of sugar would you like to buy?");
            int boughtCupsOfSugar = int.Parse(Console.ReadLine());
            double price = boughtCupsOfSugar * CupsOfSugar;
            if (price <= player.wallet.Money)
            {
                player.inventory.CupsOfSugar += Convert.ToInt32(boughtCupsOfSugar);
                player.wallet.SubMoneyWallet(price);
                player.inventory.IncreaseItems(boughtCupsOfSugar,"Sugar");
            }
            else 
            {
                Console.WriteLine("You do not have enough money.");
            }

        }

        public void BuyIceCubes(Player player)
        {
            Console.WriteLine("How many ice cubes would you like to buy? ");
            int boughtIceCubes = int.Parse(Console.ReadLine());
            double price = boughtIceCubes * IceCubes;
            if (price <= player.wallet.Money)
            {
                player.inventory.IceCubes += Convert.ToInt32(boughtIceCubes);
                player.wallet.SubMoneyWallet(price);
                player.inventory.IncreaseItems(boughtIceCubes, "Ice Cubes");
               
            }
            else
            {
                Console.WriteLine("You do not have enough money.");
              
            }
        }

        public void BuyLemons(Player player)
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int boughtLemons = int.Parse(Console.ReadLine());
            double price = boughtLemons * Lemons;
            if (price <= player.wallet.Money)
            {
                player.inventory.Lemons += Convert.ToInt32(boughtLemons);
                player.wallet.SubMoneyWallet(price);
                player.inventory.IncreaseItems(boughtLemons, "Lemons");
            }
            else
            {
                Console.WriteLine("You do not have enough money.");
            }
        }
            
        public void BuyCups(Player player)
        {
            Console.WriteLine("How many cups would you like to buy?");
            int boughtCups = int.Parse(Console.ReadLine());
            double price = boughtCups * Cups;
            if (price <= player.wallet.Money)
            {
                player.inventory.Cups += Convert.ToInt32(boughtCups);
                player.wallet.SubMoneyWallet(price);
                player.inventory.IncreaseItems(boughtCups, "Cups");
            }
            else 
            {
                Console.WriteLine("You do not have enough money.");
            }
        }
    }
}
