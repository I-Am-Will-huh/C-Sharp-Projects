using System.Numerics;

namespace Project2
{
    public partial class Form1 : Form
    {
        Dice dice1;
        Dice dice2;
        Dice dice3;
        Dice dice4;
        Dice dice5;
        Dice dice6;
        Dice dice7;
        Dice dice8;
        Dice dice9;
        Dice dice10;
        YahtzeeClass playerOneScoreBoard;
        YahtzeeClass playerTwoScoreBoard;
        playerClass player1;
        playerClass player2;
        int player1TurnCount = 0;
        int player2TurnCount = 0;
        public Form1()
        {
            InitializeComponent();

            MessageBox.Show(" Note: To save your points, press the points you score on the right. \n \n Press Okay to Load Yahtzee.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            dice1 = new Dice();
            dice1.rollDice();

            dice2 = new Dice();
            dice2.rollDice();

            dice3 = new Dice();
            dice3.rollDice();

            dice4 = new Dice();
            dice4.rollDice();

            dice5 = new Dice();
            dice5.rollDice();

            Dice1Label.Text = $"{dice1.diceNumber} ";
            Dice2Label.Text = $"{dice2.diceNumber} ";
            Dice3Label.Text = $"{dice3.diceNumber} ";
            Dice4Label.Text = $"{dice4.diceNumber} ";
            Dice5Label.Text = $"{dice5.diceNumber} ";

            playerOneScoreBoard = new YahtzeeClass(dice1, dice2,dice3, dice4, dice5);

            playerOneScoreBoard.Ones();
            Player1Ones.Text = $"{playerOneScoreBoard.onesScore}";

            playerOneScoreBoard.Twos();
            Player1Twos.Text = $"{playerOneScoreBoard.twoScore}";

            playerOneScoreBoard.Threes();
            Player1Threes.Text = $"{playerOneScoreBoard.threeScore}";

            playerOneScoreBoard.Fours();
            Player1Fours.Text = $"{playerOneScoreBoard.fourScore}";

            playerOneScoreBoard.Fives();
            Player1Fives.Text = $"{playerOneScoreBoard.fiveScore}";

            playerOneScoreBoard.Sixes();
            Player1Sixes.Text = $"{playerOneScoreBoard.sixScore}";

            playerOneScoreBoard.Yahtzee();
            PlayerOneYahtzee.Text = $"{playerOneScoreBoard.yahtzeeScore}";

            playerOneScoreBoard.Chance();
            PlayerOneChance.Text = $"{playerOneScoreBoard.chanceScore}";

            playerOneScoreBoard.SmallStraight();
            PlayerOneSmallStraight.Text = $"{playerOneScoreBoard.smallStraightScore}";

            playerOneScoreBoard.LargeStraight();
            PlayerOneLargeStraight.Text = $"{playerOneScoreBoard.largeStraightScore}";

            playerOneScoreBoard.ThreeOfAKind();
            PlayerOneThreeOfaKind.Text = $"{playerOneScoreBoard.threeOfaKindScore}";

            playerOneScoreBoard.FourOfAKind();
            PlayerOneFourOfaKind.Text = $"{playerOneScoreBoard.fourOfaKindScore}";

            playerOneScoreBoard.FullHouse();
            PlayerOneFullHouse.Text = $"{playerOneScoreBoard.fullHouseScore}";


            player1TurnCount++;
            if (player1TurnCount == 13)
            {
                rollDiceButton.Enabled = false;
            }

            if (player1TurnCount == 13 && player2TurnCount == 13)
            {
                resetButton.Enabled = true;
                resetButton.Visible = true;
                int player1TotalScore = player1.score;
                int player2TotalScore = player2.score;

                if(player1TotalScore > player2TotalScore)
                {
                    MessageBox.Show("Player 1 Won! \n you can reset or exit.");
                }
                else if (player1TotalScore == player2TotalScore)
                {
                    MessageBox.Show("DRAW! \n you can reset or exit.");
                }
                else
                {
                    MessageBox.Show("Player 2 Won! \n you can reset or exit.");
                }
 
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Player1Ones_Click(object sender, EventArgs e)
        {
            player1.score += playerOneScoreBoard.onesScore;
            PlayerOneScore.Text = $"{player1.score}";
            Player1Ones.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player1 = new playerClass();
            label17.Visible= false;
            label16.Visible = true;
            PlayerOneScore.Visible = true;

            Player1Ones.Enabled = true;
            Player1Twos.Enabled = true;
            Player1Threes.Enabled = true;
            Player1Fours.Enabled = true;
            Player1Fives.Enabled = true;
            Player1Sixes.Enabled = true;
            PlayerOneThreeOfaKind.Enabled = true;
            PlayerOneFourOfaKind.Enabled = true;
            PlayerOneFullHouse.Enabled = true;
            PlayerOneSmallStraight.Enabled = true;
            PlayerOneLargeStraight.Enabled = true;
            PlayerOneChance.Enabled = true;
            PlayerOneYahtzee.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player2 = new playerClass();
            label17.Visible = false;
            PlayerTwoScore.Visible = true;
            label19.Visible = true;

            Player2Ones.Enabled = true;
            Player2Twos.Enabled = true;
            Player2Threes.Enabled = true;
            Player2Fours.Enabled = true;
            Player2Fives.Enabled = true;
            Player2Sixes.Enabled = true;
            PlayerTwoThreeOfaKind.Enabled = true;
            PlayerTwoFourOfaKind.Enabled = true;
            PlayerTwoFullHouse.Enabled = true;
            PlayerTwoSmallStraight.Enabled = true;
            PlayerTwoLargeStraight.Enabled = true;
            PlayerTwoChance.Enabled = true;
            PlayerTwoYahtzee.Enabled = true;
        }

        private void Player1Twos_Click(object sender, EventArgs e)
        {
            player1.score += playerOneScoreBoard.twoScore;
            PlayerOneScore.Text = $"{player1.score}";
            Player1Twos.Enabled = false;
        }

        private void Player1Threes_Click(object sender, EventArgs e)
        {
            player1.score += playerOneScoreBoard.threeScore;
            PlayerOneScore.Text = $"{player1.score}";
            Player1Threes.Enabled = false;
        }

        private void Player1Fours_Click(object sender, EventArgs e)
        {
            player1.score += playerOneScoreBoard.fourScore;
            PlayerOneScore.Text = $"{player1.score}";
            Player1Fours.Enabled = false;
        }

        private void Player1Fives_Click(object sender, EventArgs e)
        {
            player1.score += playerOneScoreBoard.fiveScore;
            PlayerOneScore.Text = $"{player1.score}";
            Player1Fives.Enabled = false;
        }

        private void Player1Sixes_Click(object sender, EventArgs e)
        {
            player1.score += playerOneScoreBoard.sixScore;
            PlayerOneScore.Text = $"{player1.score}";
            Player1Sixes.Enabled = false;
        }

        private void PlayerOneThreeOfaKind_Click(object sender, EventArgs e)
        {
            player1.score += playerOneScoreBoard.threeOfaKindScore;
            PlayerOneScore.Text = $"{player1.score}";
            PlayerOneThreeOfaKind.Enabled = false;
        }

        private void PlayerOneFourOfaKind_Click(object sender, EventArgs e)
        {
            player1.score += playerOneScoreBoard.fourOfaKindScore;
            PlayerOneScore.Text = $"{player1.score}";
            PlayerOneFourOfaKind.Enabled = false;
        }

        private void PlayerOneFullHouse_Click(object sender, EventArgs e)
        {
            player1.score += playerOneScoreBoard.fullHouseScore;
            PlayerOneScore.Text = $"{player1.score}";
            PlayerOneFullHouse.Enabled = false;
        }

        private void PlayerOneSmallStraight_Click(object sender, EventArgs e)
        {
            player1.score += playerOneScoreBoard.smallStraightScore;
            PlayerOneScore.Text = $"{player1.score}";
            PlayerOneSmallStraight.Enabled = false;
        }

        private void PlayerOneLargeStraight_Click(object sender, EventArgs e)
        {
            player1.score += playerOneScoreBoard.largeStraightScore;
            PlayerOneScore.Text = $"{player1.score}";
            PlayerOneLargeStraight.Enabled = false;
        }

        private void PlayerOneChance_Click(object sender, EventArgs e)
        {
            player1.score += playerOneScoreBoard.chanceScore;
            PlayerOneScore.Text = $"{player1.score}";
            PlayerOneChance.Enabled = false;
        }

        private void PlayerOneYahtzee_Click(object sender, EventArgs e)
        {
            player1.score += playerOneScoreBoard.yahtzeeScore;
            PlayerOneScore.Text = $"{player1.score}";
            PlayerOneYahtzee.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dice6 = new Dice();
            dice6.rollDice();

            dice7 = new Dice();
            dice7.rollDice();

            dice8 = new Dice();
            dice8.rollDice();

            dice9 = new Dice();
            dice9.rollDice();

            dice10 = new Dice();
            dice10.rollDice();

            playerTwoScoreBoard = new YahtzeeClass(dice6,dice7,dice8,dice9,dice10);

            playerTwoDice1.Text = $"{dice6.diceNumber} ";
            playerTwoDice2.Text = $"{dice7.diceNumber} ";
            playerTwoDice3.Text = $"{dice8.diceNumber} ";
            playerTwoDice4.Text = $"{dice9.diceNumber} ";
            playerTwoDice5.Text = $"{dice10.diceNumber} ";

            playerTwoScoreBoard.Ones();
            Player2Ones.Text = $"{playerTwoScoreBoard.onesScore}";

            playerTwoScoreBoard.Twos();
            Player2Twos.Text = $"{playerTwoScoreBoard.twoScore}";

            playerTwoScoreBoard.Threes();
            Player2Threes.Text = $"{playerTwoScoreBoard.threeScore}";

            playerTwoScoreBoard.Fours();
            Player2Fours.Text = $"{playerTwoScoreBoard.fourScore}";

            playerTwoScoreBoard.Fives();
            Player2Fives.Text = $"{playerTwoScoreBoard.fiveScore}";

            playerTwoScoreBoard.Sixes();
            Player2Sixes.Text = $"{playerTwoScoreBoard.sixScore}";

            playerTwoScoreBoard.Yahtzee();
            PlayerTwoYahtzee.Text = $"{playerTwoScoreBoard.yahtzeeScore}";

            playerTwoScoreBoard.Chance();
            PlayerTwoChance.Text = $"{playerTwoScoreBoard.chanceScore}";

            playerTwoScoreBoard.SmallStraight();
            PlayerTwoSmallStraight.Text = $"{playerTwoScoreBoard.smallStraightScore}";

            playerTwoScoreBoard.LargeStraight();
            PlayerTwoLargeStraight.Text = $"{playerTwoScoreBoard.largeStraightScore}";

            playerTwoScoreBoard.ThreeOfAKind();
            PlayerTwoThreeOfaKind.Text = $"{playerTwoScoreBoard.threeOfaKindScore}";

            playerTwoScoreBoard.FourOfAKind();
            PlayerTwoFourOfaKind.Text = $"{playerTwoScoreBoard.fourOfaKindScore}";

            playerTwoScoreBoard.FullHouse();
            PlayerTwoFullHouse.Text = $"{playerTwoScoreBoard.fullHouseScore}";

            player2TurnCount++;

            if (player2TurnCount == 13)
            {
                button3.Enabled = false;
            }

            if (player1TurnCount == 13 && player2TurnCount == 13)
            {
                resetButton.Enabled = true;
                resetButton.Visible = true;
                int player1TotalScore = player1.score;
                int player2TotalScore = player2.score;

                if (player1TotalScore > player2TotalScore)
                {
                    MessageBox.Show("Player 1 Won! \n you can reset or exit.");
                }
                else if(player1TotalScore == player2TotalScore)
                {
                    MessageBox.Show("DRAW! \n you can reset or exit.");
                }
                else
                {
                    MessageBox.Show("Player 2 Won! \n you can reset or exit.");
                }

            }
        }

        private void Player2Ones_Click(object sender, EventArgs e)
        {
            player2.score += playerTwoScoreBoard.onesScore;
            PlayerTwoScore.Text = $"{player2.score}";
            Player2Ones.Enabled = false;
        }

        private void Player2Twos_Click(object sender, EventArgs e)
        {
            player2.score += playerTwoScoreBoard.twoScore;
            PlayerTwoScore.Text = $"{player2.score}";
            Player2Twos.Enabled = false;
        }

        private void Player2Threes_Click(object sender, EventArgs e)
        {
            player2.score += playerTwoScoreBoard.threeScore;
            PlayerTwoScore.Text = $"{player2.score}";
            Player2Threes.Enabled = false;
        }

        private void Player2Fours_Click(object sender, EventArgs e)
        {
            player2.score += playerTwoScoreBoard.fourScore;
            PlayerTwoScore.Text = $"{player2.score}";
            Player2Fours.Enabled = false;
        }

        private void Player2Fives_Click(object sender, EventArgs e)
        {
            player2.score += playerTwoScoreBoard.fiveScore;
            PlayerTwoScore.Text = $"{player2.score}";
            Player2Fives.Enabled = false;
        }

        private void Player2Sixes_Click(object sender, EventArgs e)
        {
            player2.score += playerTwoScoreBoard.sixScore;
            PlayerTwoScore.Text = $"{player2.score}";
            Player2Sixes.Enabled = false;
        }

        private void PlayerTwoThreeOfaKind_Click(object sender, EventArgs e)
        {
            player2.score += playerTwoScoreBoard.threeOfaKindScore;
            PlayerTwoScore.Text = $"{player2.score}";
            PlayerTwoThreeOfaKind.Enabled = false;
        }

        private void PlayerTwoFourOfaKind_Click(object sender, EventArgs e)
        {
            player2.score += playerTwoScoreBoard.fourOfaKindScore;
            PlayerTwoScore.Text = $"{player2.score}";
            PlayerTwoFourOfaKind.Enabled = false;
        }

        private void PlayerTwoFullHouse_Click(object sender, EventArgs e)
        {
            player2.score += playerTwoScoreBoard.fullHouseScore;
            PlayerTwoScore.Text = $"{player2.score}";
            PlayerTwoFullHouse.Enabled = false;
        }

        private void PlayerTwoSmallStraight_Click(object sender, EventArgs e)
        {
            player2.score += playerTwoScoreBoard.smallStraightScore;
            PlayerTwoScore.Text = $"{player2.score}";
            PlayerTwoSmallStraight.Enabled = false;
        }

        private void PlayerTwoLargeStraight_Click(object sender, EventArgs e)
        {
            player2.score += playerTwoScoreBoard.largeStraightScore;
            PlayerTwoScore.Text = $"{player2.score}";
            PlayerTwoLargeStraight.Enabled = false;
        }

        private void PlayerTwoChance_Click(object sender, EventArgs e)
        {
            player2.score += playerTwoScoreBoard.chanceScore;
            PlayerTwoScore.Text = $"{player2.score}";
            PlayerTwoChance.Enabled = false;
        }

        private void PlayerTwoYahtzee_Click(object sender, EventArgs e)
        {
            player2.score += playerTwoScoreBoard.yahtzeeScore;
            PlayerTwoScore.Text = $"{player2.score}";
            PlayerTwoYahtzee.Enabled = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            player1.score= 0 ;
            player2.score= 0 ;
            PlayerOneScore.Text = $"{player1.score}";
            PlayerTwoScore.Text = $"{player2.score}";
            player1TurnCount = 0;
            player2TurnCount = 0;


            playerOneScoreBoard.onesScore = 0;
            playerOneScoreBoard.twoScore = 0;
            playerOneScoreBoard.threeScore = 0;
            playerOneScoreBoard.fourScore = 0;
            playerOneScoreBoard.fiveScore = 0;
            playerOneScoreBoard.sixScore = 0;
            playerOneScoreBoard.yahtzeeScore = 0;
            playerOneScoreBoard.chanceScore = 0;
            playerOneScoreBoard.largeStraightScore = 0;
            playerOneScoreBoard.smallStraightScore = 0;
            playerOneScoreBoard.fullHouseScore = 0;
            playerOneScoreBoard.threeOfaKindScore = 0;
            playerOneScoreBoard.fourOfaKindScore = 0;

            Player1Ones.Text = $"{playerOneScoreBoard.onesScore}";
            Player1Twos.Text = $"{playerOneScoreBoard.twoScore}";
            Player1Threes.Text = $"{playerOneScoreBoard.threeScore}";
            Player1Fours.Text = $"{playerOneScoreBoard.fourScore}";
            Player1Fives.Text = $"{playerOneScoreBoard.fiveScore}";
            Player1Sixes.Text = $"{playerOneScoreBoard.sixScore}";
            PlayerOneYahtzee.Text = $"{playerOneScoreBoard.yahtzeeScore}";
            PlayerOneChance.Text = $"{playerOneScoreBoard.chanceScore}";
            PlayerOneLargeStraight.Text = $"{playerOneScoreBoard.largeStraightScore}";
            PlayerOneSmallStraight.Text = $"{playerOneScoreBoard.smallStraightScore}";
            PlayerOneFullHouse.Text = $"{playerOneScoreBoard.fullHouseScore}";
            PlayerOneThreeOfaKind.Text = $"{playerOneScoreBoard.threeOfaKindScore}";
            PlayerOneFourOfaKind.Text = $"{playerOneScoreBoard.fourOfaKindScore}";

            playerTwoScoreBoard.onesScore = 0;
            playerTwoScoreBoard.twoScore = 0;
            playerTwoScoreBoard.threeScore = 0;
            playerTwoScoreBoard.fourScore = 0;
            playerTwoScoreBoard.fiveScore = 0;
            playerTwoScoreBoard.sixScore = 0;
            playerTwoScoreBoard.yahtzeeScore = 0;
            playerTwoScoreBoard.chanceScore = 0;
            playerTwoScoreBoard.largeStraightScore = 0;
            playerTwoScoreBoard.smallStraightScore = 0;
            playerTwoScoreBoard.fullHouseScore = 0;
            playerTwoScoreBoard.threeOfaKindScore = 0;
            playerTwoScoreBoard.fourOfaKindScore = 0;

            Player2Ones.Text = $"{playerTwoScoreBoard.onesScore}";
            Player2Twos.Text = $"{playerTwoScoreBoard.twoScore}";
            Player2Threes.Text = $"{playerTwoScoreBoard.threeScore}";
            Player2Fours.Text = $"{playerTwoScoreBoard.fourScore}";
            Player2Fives.Text = $"{playerTwoScoreBoard.fiveScore}";
            Player2Sixes.Text = $"{playerTwoScoreBoard.sixScore}";
            PlayerTwoYahtzee.Text = $"{playerTwoScoreBoard.yahtzeeScore}";
            PlayerTwoChance.Text = $"{playerTwoScoreBoard.chanceScore}";
            PlayerTwoLargeStraight.Text = $"{playerTwoScoreBoard.largeStraightScore}";
            PlayerTwoSmallStraight.Text = $"{playerTwoScoreBoard.smallStraightScore}";
            PlayerTwoFullHouse.Text = $"{playerTwoScoreBoard.fullHouseScore}";
            PlayerTwoThreeOfaKind.Text = $"{playerTwoScoreBoard.threeOfaKindScore}";
            PlayerTwoFourOfaKind.Text = $"{playerTwoScoreBoard.fourOfaKindScore}";

            Player1Ones.Enabled = true;
            Player1Twos.Enabled = true;
            Player1Threes.Enabled = true;
            Player1Fours.Enabled = true;
            Player1Fives.Enabled = true;
            Player1Sixes.Enabled = true;
            PlayerOneThreeOfaKind.Enabled = true;
            PlayerOneFourOfaKind.Enabled = true;
            PlayerOneFullHouse.Enabled = true;
            PlayerOneSmallStraight.Enabled= true;
            PlayerOneLargeStraight.Enabled= true;
            PlayerOneChance.Enabled = true;
            PlayerOneYahtzee.Enabled= true;

            Player2Ones.Enabled = true;
            Player2Twos.Enabled = true;
            Player2Threes.Enabled = true;
            Player2Fours.Enabled = true;
            Player2Fives.Enabled = true;
            Player2Sixes.Enabled = true;
            PlayerTwoThreeOfaKind.Enabled = true;
            PlayerTwoFourOfaKind.Enabled = true;
            PlayerTwoFullHouse.Enabled = true;
            PlayerTwoSmallStraight.Enabled = true;
            PlayerTwoLargeStraight.Enabled = true;
            PlayerTwoChance.Enabled = true;
            PlayerTwoYahtzee.Enabled = true;

            button3.Enabled= true;
            rollDiceButton.Enabled= true;
        }
    }
}