using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // member variables 

        public int CupsOfSugar;
        public int IceCubes;
        public int Cups;
        public int Lemons;
        


        //constructor

        public Inventory()
        {
            CupsOfSugar = 0;
            IceCubes = 0;
            Cups = 0;
            Lemons = 0;
        }
        // member methods


        public int AmountSugar()
        {
            Console.WriteLine("You have " + CupsOfSugar + " cups of sugar.");
            return CupsOfSugar;
        }

        public int AmountIceCubes()
        {
            Console.WriteLine("You have " + IceCubes + " ice cubes.");
            return IceCubes;
        }

        public int AmountLemons()
        {
            Console.WriteLine("You have " + Lemons + " lemons.");
            return Lemons;
        }

        public int AmountCups()
        {
            Console.WriteLine("You have " + Cups + " cups.");
            return Cups;
        }


        public void DecreaseItems(int amountToDecreaseBy, string itemToDecrease)
        {
            if (itemToDecrease == "Sugar")
            {
                CupsOfSugar -= amountToDecreaseBy;
            }
            else if (itemToDecrease == "Ice Cubes")
            {
                IceCubes -= amountToDecreaseBy;
            }
            else if (itemToDecrease == "Lemons")
            {
                Lemons -= amountToDecreaseBy;
            }
            else if (itemToDecrease == "Cups")
            {
                Cups -= amountToDecreaseBy;
            }
        }

        public void IncreaseItems(int amountToIncreaseBy, string itemToIncrease)
        {
            if(itemToIncrease == "Sugar")
            {
                CupsOfSugar += amountToIncreaseBy;
            }
            else if (itemToIncrease == "Ice Cubes")
            {
                IceCubes += amountToIncreaseBy;
            }
            else if (itemToIncrease == "Lemons")
            {
                Lemons += amountToIncreaseBy;
            }
            else if (itemToIncrease == "Cups")
            {
                Cups += amountToIncreaseBy;
            }
        }












    }
}
