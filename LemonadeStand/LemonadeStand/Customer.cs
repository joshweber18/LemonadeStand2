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

        public int EffectingToBuy()
        {
            if (weather.weatherOptions[0] == weather.ChooseWeather())  // Rainy
            {
                
                chanceToBuy -= 10;
                return chanceToBuy;
            }

            if (weather.weatherOptions[1] == weather.ChooseWeather())  // Partially Sunny
            {
                chanceToBuy += 5;
                return chanceToBuy;
            }

            if (weather.weatherOptions[2] == weather.ChooseWeather())  // Hot
            {
                chanceToBuy += 10;
                return chanceToBuy;
            }

            if (weather.weatherOptions[3] == weather.ChooseWeather())  // Overcast
            {
                chanceToBuy -= 5;
                return chanceToBuy;
            }
            return 5;
        }


        public void TakeLemonade()
        {
            player.wallet.AddMoneyWallet(player.recipe.CostCup());

        }

       public void ChoosingToBuy()
        {
            int winningNumber = 50;
            if (winningNumber <= EffectingToBuy())
            {
                TakeLemonade();
            }
        }
    }
}
