using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diceware_Password_Generator
{
    internal class Dice
    {
        Random random = new Random();


        int diceCount = 5;


        public int GetDice1()
        {
            return random.Next(0, 4);
        }

        public int GetDice2()
        {
            return random.Next(0, 4);
        }

        public int GetDice3()
        {
            return random.Next(0, 4);
        }

        public int GetDice4()
        {
            return random.Next(0, 4);
        }

        public int GetDice5()
        {
            return random.Next(0, 4);
        }
         
        public int GetDiceCount()
        {
            return diceCount;
        }
    }
}
