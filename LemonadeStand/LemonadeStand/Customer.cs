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
        Weather weather = new Weather();

        //member methods
        public void ChoiceToBuy()
        {
            if (weather.weatherOptions[0] == weather.ChooseWeather())
            {
                int x = RandomNumberCustomer() - 10;
            }
            if (weather.weatherOptions[1] == weather.ChooseWeather())
            {
                int x = RandomNumberCustomer() + 5;
            }
            if (weather.weatherOptions[2] == weather.ChooseWeather())
            {
                int x = RandomNumberCustomer() + 10;
            }
            if (weather.weatherOptions[3] == weather.ChooseWeather())
            {
                int x = RandomNumberCustomer() - 5;
            }
        }

        public int RandomNumberCustomer()
        {
            Random random = new Random();
            int randomCustomerNumber = random.Next(50, 70);
            return randomCustomerNumber;


            
        }

       

    }
    
}
