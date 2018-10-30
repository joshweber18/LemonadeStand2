using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public double money = 50;
        public int profit;
        public Player player = new Player();
        public Store store = new Store();
       
        public Game()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("Press (1) to go to the store. Press (2) to create recipe. Press (3) to check inventory.");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    store.Menu();
                    break;
                case 2:
                    player.recipe.createRecipe();
                    break;
                case 3:
                    player.inventory.AmountSugar();
                    player.inventory.AmountIceCubes();
                    player.inventory.AmountLemons();
                    player.inventory.AmountCups();
                    break;
            }
        }













    }
}
