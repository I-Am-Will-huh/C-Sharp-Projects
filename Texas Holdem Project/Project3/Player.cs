using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project3
{
    public class Player
    {
        //Take Holdem Hands(Cards of two), Add function fold, Bet and Call
        public HoldemCards holdemCards { get; }
        public bool isPlayerOnFold { get;  set; }
        public bool isPlayerOnBet { get;  set; }
        public bool isPlayerOnCall { get;  set; }
        public bool isPlayerChecked { get;  set; }
        private PokerHand sharedCards { get; }
        public int init_Money { get; set; }
        public Player(int money,HoldemCards holdemCards)
        {
            this.holdemCards = holdemCards;
            this.init_Money= money;
            isPlayerChecked= false;
            isPlayerOnBet= false;
            isPlayerOnCall= false;
            isPlayerOnFold= false;
        }


       


        public void Bet(int money)
        {
            init_Money-=money;
            isPlayerOnBet=true;
        }

        public void Call(int money)
        {
            init_Money-=money;
            isPlayerOnCall=true;
        }

        public void Fold()
        {
            isPlayerOnFold=true;
        }

        public void Check()
        {
            isPlayerChecked= true;
        }


    }
}
