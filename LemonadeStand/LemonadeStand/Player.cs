using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables
        public Inventory inventory;
        public Recipe recipe;
        public Wallet wallet;
        public double totalProfit;

        // constructor

        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
            wallet = new Wallet();
        }
        


        // memeber methods 
        public int GetCupsofSugar()
        { 
            return inventory.AmountSugar();
        }

        public int GetIceCubes()
        {
            return inventory.AmountIceCubes();
        }

        public int GetLemons()
        {
            return inventory.AmountLemons();
        }

        public int GetCups()
        {
            return inventory.AmountCups();
        }

        public double StartEndMoneyDifference(double startmoney, double endmoney)
        {
            double difference = startmoney - endmoney;
            difference = (startmoney / difference) * 100;
            return difference;
        }

        public void ProfitTotal(double profit)
        {
            totalProfit = -profit;
        }
    }
}
