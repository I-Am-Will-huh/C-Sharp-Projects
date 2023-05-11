using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Dice
    {
        public int diceNumber { get; private set; }

        public Dice()
        {
            diceNumber = 1;
        }
        public void rollDice()
        {
            Random rnd = new Random();
            diceNumber = rnd.Next(1, 7);
        }
    }
}
