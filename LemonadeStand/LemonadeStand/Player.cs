using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
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

        public void StartEndMoneyDifference(double startMoney)
        {
            double difference = wallet.money - startMoney;
            Console.WriteLine("Your end of day profit is " + difference);
        }

        public void ProfitTotal(double profit)
        {
            totalProfit = -profit;
        }
        
    }
}
