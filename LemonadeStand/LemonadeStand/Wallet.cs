using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double money;



        public Wallet()
        {
            money = 50;
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
