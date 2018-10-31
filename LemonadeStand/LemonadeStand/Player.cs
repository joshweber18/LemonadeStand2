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
        public Inventory inventory = new Inventory();
        public Recipe recipe = new Recipe();
        public Wallet wallet = new Wallet();

        // constructor


        


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



    }
}
