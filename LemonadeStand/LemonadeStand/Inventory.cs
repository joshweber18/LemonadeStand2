using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        // member variables 

        public int CupsOfSugar;
        public int IceCubes;
        public int Cups;
        public int Lemons;
        public int pitcherOfLemonade;
        


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
                CupsOfSugar = amountToIncreaseBy;
            }
            else if (itemToIncrease == "Ice Cubes")
            {
                IceCubes = amountToIncreaseBy;
            }
            else if (itemToIncrease == "Lemons")
            {
                Lemons = amountToIncreaseBy;
            }
            else if (itemToIncrease == "Cups")
            {
                Cups = amountToIncreaseBy;
            }
        }


        public bool CheckValidAmountSugar(int sugar)
        {
            if (CupsOfSugar <= sugar)
            {
                Console.WriteLine("You do not have enough sugar to make lemonade.");
                return false;
            }

            else 
            {
                return true;
            }
        }

        public bool CheckValidAmountLemons(int lemons)
        {
            if (Lemons <= lemons)
            {
                Console.WriteLine("You do not have enough lemons to make lemonade.");
                return false;
            }

            else
            {
                return true;
            }
        }

        public bool CheckValidAmountIce(int iceCubes)
        {
            if (IceCubes <= iceCubes)
            {
                Console.WriteLine("You do not have enough ice to make lemonade.");
                return false;
            }

            else
            {
                return true;
            }
        }

        public bool CheckValidAmountCups(double cup)
        {
            if (Cups <= cup)
            {
                Console.WriteLine("You do not have enough cups to make lemonade.");
                return false;
            }

            else
            {
                return true;
            }
        }
           








    }
}
