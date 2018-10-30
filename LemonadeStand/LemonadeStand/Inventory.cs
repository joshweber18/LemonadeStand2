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
            














    }
}
