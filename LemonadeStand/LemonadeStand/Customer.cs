using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    public class Customer
    {
        Player player;
        Weather weather;
        public int chanceToBuy;

        //constructor
        public Customer()
        {
            player = new Player();
            weather = new Weather();
            Random random = new Random();
            chanceToBuy = random.Next(50, 70);
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


        public void TakeLemonade()
        {
            player.wallet.AddMoneyWallet(player.recipe.cup);

        }

       public void ChoosingToBuy(Weather weather)
        {
            int winningNumber = 50;
            if (winningNumber <= EffectingToBuy(weather))
            {
                TakeLemonade();
            }
        }
    }
}
