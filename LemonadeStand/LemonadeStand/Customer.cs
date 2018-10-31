using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    public class Customer
    {


        //constructor
        Player player = new Player();
        Weather weather = new Weather();
        public int BuyCondition;

        //member methods

        public int RandomNumberCustomer()
        {
            Random random = new Random();
            int randomCustomerNumber = random.Next(50, 70);
            return randomCustomerNumber;
        }

        public int EffectingToBuy()
        {
            if (weather.weatherOptions[0] == weather.ChooseWeather())  // Rainy
            {
                int Rainy = RandomNumberCustomer() - 10;
                return Rainy;
            }

            if (weather.weatherOptions[1] == weather.ChooseWeather())  // Partially Sunny
            {
                int Sunny = RandomNumberCustomer() + 5;
                return Sunny;
            }

            if (weather.weatherOptions[2] == weather.ChooseWeather())  // Hot
            {
                int Hot = RandomNumberCustomer() + 10;
                return Hot;
            }

            if (weather.weatherOptions[3] == weather.ChooseWeather())  // Overcast
            {
                int Overcast = RandomNumberCustomer() - 5;
                return Overcast;
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
