using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Tests
{
    [TestClass()]
    public class YahtzeeClassTests
    {
        [TestMethod()]
        public void YahtzeeClassTest()
        {
            //arrange
            int expectedDice1 = 1;
            int expectedDice2 = 2;
            int expectedDice3 = 3;
            int expectedDice4 = 4;
            int expectedDice5 = 5;

            //Act
            YahtzeeClass scoreBoard1 = new YahtzeeClass(1,2,3,4,5);
            int actualDice1 = scoreBoard1.diceArray[0];
            int actualDice2 = scoreBoard1.diceArray[1];
            int actualDice3 = scoreBoard1.diceArray[2];
            int actualDice4 = scoreBoard1.diceArray[3];
            int actualDice5 = scoreBoard1.diceArray[4];

            //Assert
            Assert.AreEqual(expectedDice1, actualDice1);
            Assert.AreEqual(expectedDice2, actualDice2);
            Assert.AreEqual(expectedDice3, actualDice3);
            Assert.AreEqual(expectedDice4, actualDice4);
            Assert.AreEqual(expectedDice5, actualDice5);

        }

        [TestMethod()]
        public void OnesTest()
        {
            //arrange
            YahtzeeClass scoreBoard1 = new YahtzeeClass(1, 2, 3, 4, 5);
            int expectedScore = 1;
            int expectedScore2 = 0;

            YahtzeeClass scoreBoard2 = new YahtzeeClass(2, 2, 3, 4, 5);

            //Act
            scoreBoard1.Ones();
            scoreBoard2.Ones();
            //Assert
            Assert.AreEqual(expectedScore, scoreBoard1.onesScore);
            Assert.AreEqual(expectedScore2, scoreBoard2.onesScore);
        }

        [TestMethod()]
        public void TwosTest()
        {
            //arrange
            YahtzeeClass scoreBoard1 = new YahtzeeClass(1, 2, 3, 4, 5);
            int expectedScore = 2;
            int expectedScore2 = 0;

            YahtzeeClass scoreBoard2 = new YahtzeeClass(1, 1, 3, 4, 5);

            //Act
            scoreBoard1.Twos();
            scoreBoard2.Twos();
            //Assert
            Assert.AreEqual(expectedScore, scoreBoard1.twoScore);
            Assert.AreEqual(expectedScore2, scoreBoard2.twoScore);
        }

        [TestMethod()]
        public void ThreesTest()
        {
            //arrange
            YahtzeeClass scoreBoard1 = new YahtzeeClass(1, 3, 3, 4, 5);
            int expectedScore = 6;
            int expectedScore2 = 0;

            YahtzeeClass scoreBoard2 = new YahtzeeClass(2, 2, 5, 4, 5);

            //Act
            scoreBoard1.Threes();
            scoreBoard2.Threes();
            //Assert
            Assert.AreEqual(expectedScore, scoreBoard1.threeScore);
            Assert.AreEqual(expectedScore2, scoreBoard2.threeScore);
        }

        [TestMethod()]
        public void FoursTest()
        {
            //arrange
            YahtzeeClass scoreBoard1 = new YahtzeeClass(1, 2, 3, 4, 5);
            int expectedScore = 4;
            int expectedScore2 = 0;

            YahtzeeClass scoreBoard2 = new YahtzeeClass(2, 2, 3, 1, 5);

            //Act
            scoreBoard1.Fours();
            scoreBoard2.Fours();
            //Assert
            Assert.AreEqual(expectedScore, scoreBoard1.fourScore);
            Assert.AreEqual(expectedScore2, scoreBoard2.fourScore);
        }

        [TestMethod()]
        public void FivesTest()
        {
            //arrange
            YahtzeeClass scoreBoard1 = new YahtzeeClass(1, 2, 3, 4, 5);
            int expectedScore = 5;
            int expectedScore2 = 0;

            YahtzeeClass scoreBoard2 = new YahtzeeClass(2, 2, 3, 4, 1);

            //Act
            scoreBoard1.Fives();
            scoreBoard2.Fives();
            //Assert
            Assert.AreEqual(expectedScore, scoreBoard1.fiveScore);
            Assert.AreEqual(expectedScore2, scoreBoard2.fiveScore);
        }

        [TestMethod()]
        public void SixesTest()
        {
            //arrange
            YahtzeeClass scoreBoard1 = new YahtzeeClass(1, 2, 6, 4, 5);
            int expectedScore = 6;
            int expectedScore2 = 0;

            YahtzeeClass scoreBoard2 = new YahtzeeClass(2, 2, 3, 4, 5);

            //Act
            scoreBoard1.Sixes();
            scoreBoard2.Sixes();
            //Assert
            Assert.AreEqual(expectedScore, scoreBoard1.sixScore);
            Assert.AreEqual(expectedScore2, scoreBoard2.sixScore);
        }

        [TestMethod()]
        public void YahtzeeTest()
        {
            //arrange
            YahtzeeClass scoreBoard1 = new YahtzeeClass(5, 5, 5, 5, 5);
            int expectedScore = 50;
            int expectedScore2 = 0;

            YahtzeeClass scoreBoard2 = new YahtzeeClass(2, 2, 3, 4, 5);

            //Act
            scoreBoard1.Yahtzee();
            scoreBoard2.Yahtzee();
            //Assert
            Assert.AreEqual(expectedScore, scoreBoard1.yahtzeeScore);
            Assert.AreEqual(expectedScore2, scoreBoard2.yahtzeeScore);
        }

        [TestMethod()]
        public void ChanceTest()
        {
            //arrange
            YahtzeeClass scoreBoard1 = new YahtzeeClass(5, 1, 2, 6, 5);
            int expectedScore = 19;
            int expectedScore2 = 5;

            YahtzeeClass scoreBoard2 = new YahtzeeClass(1, 1, 1, 1, 1);

            //Act
            scoreBoard1.Chance();
            scoreBoard2.Chance();
            //Assert
            Assert.AreEqual(expectedScore, scoreBoard1.chanceScore);
            Assert.AreEqual(expectedScore2, scoreBoard2.chanceScore);
        }

        [TestMethod()]
        public void LargeStraightTest()
        {
            //arrange
            YahtzeeClass scoreBoard1 = new YahtzeeClass(1, 2, 3, 4, 5);
            int expectedScore = 40;
            int expectedScore2 = 40;
            int expectedScore3 = 40;
            int expectedScore4 = 0;

            YahtzeeClass scoreBoard2 = new YahtzeeClass(2, 3, 4, 5, 6);

            YahtzeeClass scoreBoard3 = new YahtzeeClass(3, 2, 4, 5, 6);
            
            YahtzeeClass scoreBoard4 = new YahtzeeClass(1, 2, 4, 5, 6);

            //Act
            scoreBoard1.LargeStraight();
            scoreBoard2.LargeStraight();
            scoreBoard3.LargeStraight();
            scoreBoard4.LargeStraight();

            //Assert
            Assert.AreEqual(expectedScore, scoreBoard1.largeStraightScore);
            Assert.AreEqual(expectedScore2, scoreBoard2.largeStraightScore);
            Assert.AreEqual(expectedScore3, scoreBoard3.largeStraightScore);
            Assert.AreEqual(expectedScore4, scoreBoard4.largeStraightScore);
        }

        [TestMethod()]
        public void SmallStraightTest()
        {
            //arrange
            YahtzeeClass scoreBoard1 = new YahtzeeClass(1, 2, 3, 4, 6);
            int expectedScore = 30;
            int expectedScore2 = 30;
            int expectedScore3 = 30;
            int expectedScore4 = 0;

            YahtzeeClass scoreBoard2 = new YahtzeeClass(2, 3, 4, 5, 2);

            YahtzeeClass scoreBoard3 = new YahtzeeClass(3, 1, 4, 5, 6);

            YahtzeeClass scoreBoard4 = new YahtzeeClass(1, 1, 1, 2, 6);

            //Act
            scoreBoard1.SmallStraight();
            scoreBoard2.SmallStraight();
            scoreBoard3.SmallStraight();
            scoreBoard4.SmallStraight();

            //Assert
            Assert.AreEqual(expectedScore, scoreBoard1.smallStraightScore);
            Assert.AreEqual(expectedScore2, scoreBoard2.smallStraightScore);
            Assert.AreEqual(expectedScore3, scoreBoard3.smallStraightScore);
            Assert.AreEqual(expectedScore4, scoreBoard4.smallStraightScore);
        }

        [TestMethod()]
        public void FullHouseTest()
        {
            //arrange
            YahtzeeClass scoreBoard1 = new YahtzeeClass(3, 3, 3, 2, 2);
            int expectedScore = 25;
            int expectedScore2 = 0;
            

            YahtzeeClass scoreBoard2 = new YahtzeeClass(2, 3, 4, 5, 2);

           

            //Act
            scoreBoard1.FullHouse();
            scoreBoard2.FullHouse();
           

            //Assert
            Assert.AreEqual(expectedScore, scoreBoard1.fullHouseScore);
            Assert.AreEqual(expectedScore2, scoreBoard2.fullHouseScore);
            
        }

        [TestMethod()]
        public void ThreeOfAKindTest()
        {
            //arrange
            YahtzeeClass scoreBoard1 = new YahtzeeClass(3, 3, 3, 1, 2);
            int expectedScore = 12;
            int expectedScore2 = 0;


            YahtzeeClass scoreBoard2 = new YahtzeeClass(2, 3, 4, 5, 2);



            //Act
            scoreBoard1.ThreeOfAKind();
            scoreBoard2.ThreeOfAKind();


            //Assert
            Assert.AreEqual(expectedScore, scoreBoard1.threeOfaKindScore);
            Assert.AreEqual(expectedScore2, scoreBoard2.threeOfaKindScore);
        }

        [TestMethod()]
        public void FourOfAKindTest()
        {
            //arrange
            YahtzeeClass scoreBoard1 = new YahtzeeClass(3, 3, 3, 3, 2);
            int expectedScore = 14;
            int expectedScore2 = 0;
            int expectedScore3 = 14;

            YahtzeeClass scoreBoard2 = new YahtzeeClass(3, 3, 3, 5, 2);

            YahtzeeClass scoreBoard3 = new YahtzeeClass(3, 2, 3, 3, 3);

            //Act
            scoreBoard1.FourOfAKind();
            scoreBoard2.FourOfAKind();
            scoreBoard3.FourOfAKind();

            //Assert
            Assert.AreEqual(expectedScore, scoreBoard1.fourOfaKindScore);
            Assert.AreEqual(expectedScore2, scoreBoard2.fourOfaKindScore);
            Assert.AreEqual(expectedScore3, scoreBoard3.fourOfaKindScore);
        }
    }
}