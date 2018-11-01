using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        // member variables 

        Random random;
        Customer customer;
        Weather weather;
        int randomCustomerNumber;

        // constructor
        public Day()
        {
            random = new Random();
            weather = new Weather();
        }

        // member methods
        public int RandomNumberCustomer()
        {
            Random random = new Random();
            randomCustomerNumber = random.Next(60, 110);
            return randomCustomerNumber;
        }

        public void Customers()
        {
            RandomNumberCustomer();
            for (int i = 0; i < randomCustomerNumber; i++)
            {
                customer = new Customer();
                customer.ChoosingToBuy();
            }
            
           
        }
    }
}
