using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    public class Customer
    {
        Weather weather;
        public int chanceToBuy;
        public int cupAmount;

        //constructor
        public Customer()
        {
            weather = new Weather();
            Random random = new Random();
            chanceToBuy = random.Next(50, 70);
            cupAmount = 0;
        }

        //member methods

        public int EffectingToBuy(Weather todayWeather)
        {
            
            if (weather.weatherOptions[0] == todayWeather.todayWeather) // Rainy
            {
                
                chanceToBuy -= 10;
                return chanceToBuy;
            }

            if (weather.weatherOptions[1] == todayWeather.todayWeather)  // Partially Sunny
            {
                chanceToBuy += 5;
                return chanceToBuy;
            }

            if (weather.weatherOptions[2] == todayWeather.todayWeather)  // Hot
            {
                chanceToBuy += 10;
                return chanceToBuy;
            }

            if (weather.weatherOptions[3] == todayWeather.todayWeather)  // Overcast
            {
                chanceToBuy -= 5;
                return chanceToBuy;
            }
            return 5;
        }


        public void TakeLemonade(Player player)
        {
            if (player.inventory.pitcherOfLemonade == 1)
            {
                player.wallet.AddMoneyWallet(player.recipe.cup);
                player.inventory.DecreaseItems(cupAmount, "Cups");
            }
            else if (player.inventory.pitcherOfLemonade == 0)
            {
                if (player.recipe.CanCreatePitcher(player.inventory))
                {
                    player.recipe.CreatePitcher(player.inventory);
                    player.wallet.AddMoneyWallet(player.recipe.cup);
                    player.inventory.DecreaseItems(cupAmount, "Cups");
                }
                else 
                {
                    Console.WriteLine("Not enough stuff dummy");
                }
            }
        }
            
           

       public void ChoosingToBuy(Player player, Weather weather)
        {
            int winningNumber = 50;
            if (winningNumber <= EffectingToBuy(weather))
            {
                TakeLemonade(player);
            }
        }
    }
}
