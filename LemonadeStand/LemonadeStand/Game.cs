using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        // member variables

        public double money;
        public int profit;
        public Player player;
        public Store store;
        public List<Day> week;
        // int currentDay;

        // constructor
        public Game()
        {
            player = new Player();
            store = new Store();
            week = new List<Day>();
            // currentDay = 1;
            money = 25;
        }

        // member methods


        public void StartGame()
        {
            for (int i = 0; i < 7; i++)
            {
                week.Add(new Day());
            }
        }
        public void MainMenu()
        { 
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("Press (1) to go to the store. Press (2) to create recipe. Press (3) to check inventory. Press (4) to start Game.");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    store.Menu(player);
                    break;
                case 2:
                    player.recipe.CreateRecipe();
                    break;
                case 3:
                    player.inventory.AmountSugar();
                    player.inventory.AmountIceCubes();
                    player.inventory.AmountLemons();
                    player.inventory.AmountCups();
                    break;
                case 4:
                    week[0].Customers();

                    break;
            }
            MainMenu();
        }









    }
}
