using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class YahtzeeClass
    {
        public int onesScore { get; set; }
        public int twoScore { get; set; }
        public int threeScore { get; set; }
        public int fourScore { get; set; }
        public int fiveScore { get; set; }
        public int sixScore { get; set; }
        public int yahtzeeScore { get; set; }
        public int chanceScore { get; set; }
        public int largeStraightScore { get; set; }
        public int smallStraightScore { get; set; }
        public int fullHouseScore { get; set; }
        public int threeOfaKindScore { get; set; }
        public int fourOfaKindScore { get; set; }

        int[] diceArray = new int[5];
        public YahtzeeClass(Dice dice1, Dice dice2, Dice dice3, Dice dice4, Dice dice5) 
        { 
            onesScore= 0;
            twoScore= 0;
            threeScore= 0;
            fourScore= 0;
            fiveScore= 0;
            sixScore= 0;
            yahtzeeScore = 0;
            chanceScore = 0;
            largeStraightScore = 0;
            smallStraightScore = 0;
            fullHouseScore= 0;
            threeOfaKindScore = 0;
            fourOfaKindScore = 0;
            diceArray[0] = dice1.diceNumber;
            diceArray[1] = dice2.diceNumber;
            diceArray[2] = dice3.diceNumber;
            diceArray[3] = dice4.diceNumber;
            diceArray[4] = dice5.diceNumber;

        }

        // to have a constructor that I can control the number insider the array that usual have random number number inside it
        public YahtzeeClass(int dice1Number, int dice2Number, int dice3Number, int dice4Number, int dice5Number)
        {
            onesScore = 0;
            twoScore = 0;
            threeScore = 0;
            fourScore = 0;
            fiveScore = 0;
            sixScore = 0;
            yahtzeeScore = 0;
            chanceScore = 0;
            largeStraightScore = 0;
            smallStraightScore = 0;
            fullHouseScore = 0;
            threeOfaKindScore = 0;
            fourOfaKindScore = 0;
            diceArray[0] = dice1Number;
            diceArray[1] = dice2Number;
            diceArray[2] = dice3Number;
            diceArray[3] = dice4Number;
            diceArray[4] = dice5Number;

        }

        public void Ones()
        {
            if (diceArray[0] == 1 || diceArray[1] == 1 || diceArray[2] == 1 || diceArray[3] == 1 || diceArray[4] == 1)
            {
                for(int i = 0; i < 5; i ++)
                {
                    if (diceArray[i] == 1)
                    {
                        onesScore += diceArray[i];
                    }
                }
            }
        }

        public void Twos()
        {
            if (diceArray[0] == 2 || diceArray[1] == 2 || diceArray[2] == 2 || diceArray[3] == 2 || diceArray[4] == 2)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (diceArray[i] == 2)
                    {
                        twoScore += diceArray[i];
                    }
                }
            }
        }

        public void Threes()
        {
            if (diceArray[0] == 3 || diceArray[1] == 3 || diceArray[2] == 3 || diceArray[3] == 3 || diceArray[4] == 3)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (diceArray[i] == 3)
                    {
                        threeScore += diceArray[i];
                    }
                }
            }
        }

        public void Fours()
        {
            if (diceArray[0] == 4 || diceArray[1] == 4 || diceArray[2] == 4 || diceArray[3] == 4 || diceArray[4] == 4)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (diceArray[i] == 4)
                    {
                        fourScore += diceArray[i];
                    }
                }
            }
        }

        public void Fives()
        {
            if (diceArray[0] == 5 || diceArray[1] == 5 || diceArray[2] == 5 || diceArray[3] == 5 || diceArray[4] == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (diceArray[i] == 5)
                    {
                        fiveScore += diceArray[i];
                    }
                }
            }
        }

        public void Sixes()
        {
            if (diceArray[0] == 6 || diceArray[1] == 6 || diceArray[2] == 6 || diceArray[3] == 6 || diceArray[4] == 6)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (diceArray[i] == 6)
                    {
                        sixScore += diceArray[i];
                    }
                }
            }
        }

        public void Yahtzee()
        {
            
            if (diceArray[0] == diceArray[1] && diceArray[1] == diceArray[2] && diceArray[2] == diceArray[3] && diceArray[3] == diceArray[4] && diceArray[4] == diceArray[0])
            {
                yahtzeeScore = 50;
            }
        }

        public void Chance()
        {
            for (int i = 0; i < 5; i++)
            {
                chanceScore += diceArray[i];
            }

        }

        public void LargeStraight()
        {
            bool ifOneDice = false; ;
            bool ifTwoDice = false; ;
            bool ifThreeDice = false; ;
            bool ifFourDice = false; ;
            bool ifFiveDice = false; ;
            bool ifSixDice = false;
            
            for(int i = 0; i < 5; i++) 
            {
                if (diceArray[i] == 1)
                {
                    ifOneDice = true;
                }
                if (diceArray[i] == 2)
                {
                    ifTwoDice = true;
                }
                if (diceArray[i] == 3)
                {
                    ifThreeDice = true;
                }
                if (diceArray[i] == 4)
                {
                    ifFourDice = true;
                }
                if (diceArray[i] == 5)
                {
                    ifFiveDice = true;
                }
                if (diceArray[i] == 6)
                {
                    ifSixDice = true;
                }

            }

            if(ifOneDice && ifTwoDice && ifThreeDice && ifFourDice && ifFiveDice)
            {
                largeStraightScore = 40;
            }

            if (ifSixDice && ifTwoDice && ifThreeDice && ifFourDice && ifFiveDice)
            {
                largeStraightScore = 40;
            }
        }

        public void SmallStraight()
        {
            bool ifOneDice = false; ;
            bool ifTwoDice = false; ;
            bool ifThreeDice = false; ;
            bool ifFourDice = false; ;
            bool ifFiveDice = false; ;
            bool ifSixDice = false;

            for (int i = 0; i < 5; i++)
            {
                if (diceArray[i] == 1)
                {
                    ifOneDice = true;
                }
                if (diceArray[i] == 2)
                {
                    ifTwoDice = true;
                }
                if (diceArray[i] == 3)
                {
                    ifThreeDice = true;
                }
                if (diceArray[i] == 4)
                {
                    ifFourDice = true;
                }
                if (diceArray[i] == 5)
                {
                    ifFiveDice = true;
                }
                if (diceArray[i] == 6)
                {
                    ifSixDice = true;
                }

            }

            if (ifOneDice && ifTwoDice && ifThreeDice && ifFourDice)
            {
                smallStraightScore = 30;
            }

            if (ifTwoDice && ifThreeDice && ifFourDice && ifFiveDice) 
            {
                smallStraightScore = 30;
            }

            if (ifThreeDice && ifFourDice && ifFiveDice && ifSixDice)
            {
                smallStraightScore = 30;
            }
        }

        public void FullHouse()
        {
            int[] count = new int[7];

            // int die is just a variable that hold the value of the next element 
            // in the dice array
            foreach (int die in diceArray)
            {
                count[die]++;
            }

            bool hasThreeOfAKind = false;
            bool hasTwoOfAKind = false;

            // int dieCount is just a variable that hold the value of the next element 
            // in the count array
            foreach (int dieCount in count)
            {
                if (dieCount >= 3)
                {
                    hasThreeOfAKind = true;
                }
                else if (dieCount >= 2)
                {
                    hasTwoOfAKind = true;
                }
            }
            // the code above is from https://chat.openai.com/chat when asked "To create a full house yahtzee function in C#"

            if (hasThreeOfAKind && hasTwoOfAKind)
            {
                fullHouseScore = 25;
            }

        }

        public void ThreeOfAKind()
        {
            int[] count = new int[7];
            bool isThereThreeOfaKind = false;

            // int die is just a variable that hold the value of the next element 
            // in the dice array
            foreach (int die in diceArray)
            {
                count[die]++;
            }

            // int dieCount is just a variable that hold the value of the next element 
            // in the count array
            foreach (int dieCount in count)
            {
                if (dieCount >= 3)
                {
                   isThereThreeOfaKind = true;
                }
            }
            //the code above is from https://chat.openai.com/chat when asked "Create a three of kind yahtzee function in C#"


            if (isThereThreeOfaKind)
            {
                for(int i = 0; i < 5; i++)
                {
                    threeOfaKindScore += diceArray[i];
                } 
            }

        }

        public void FourOfAKind()
        {
            int[] count = new int[7];
            bool isThereFourOfaKind = false;

            // int die is just a variable that hold the value of the next element 
            // in the dice array
            foreach (int die in diceArray)
            {
                count[die]++;
            }

            // int dieCount is just a variable that hold the value of the next element 
            // in the count array
            foreach (int dieCount in count)
            {
                if (dieCount >= 4)
                {
                    isThereFourOfaKind = true;
                }
            }
            //the code above is from https://chat.openai.com/chat when asked "Create a four of kind yahtzee function in C#"


            if (isThereFourOfaKind)
            {
                for (int i = 0; i < 5; i++)
                {
                    fourOfaKindScore += diceArray[i];
                }
            }

        }
    }
}
