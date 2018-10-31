using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        private double money;

        public double Money
        {
            get
            {
                return money;
            }
        }


        public Wallet()
        {
            money = 25;
        }

        public void AddMoneyWallet(double moneyToAdd)
        {
            money += moneyToAdd;
        }

        public void SubMoneyWallet(double moneyToSubtract)
        {
            money -= moneyToSubtract;
        }
    }
}
