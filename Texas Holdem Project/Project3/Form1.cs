namespace Project3
{
    public partial class Form1 : Form
    {
        Player playerOne;
        Player playerTwo;
        List<PokerHand> pokerHandsForPlayer1;
        List<PokerHand> pokerHandsForPlayer2;
        Player CurrentPlayer;
        Deck CardDeck;
        Card pokerHandOne;
        Card pokerHandTwo;
        Card pokerHandThree;
        Card pokerHandFour;
        Card pokerHandFive;
        HoldemCards PlayerOneHoldemCards;
        HoldemCards PlayerTwoHoldemCards;

        List<int> ScoreListPlayer1= new List<int>();
        List<int> ScoreListPlayer2= new List<int>();
        int potMoney = 0;
        int turnCounter = 1;

        bool isFirstThreeCardsDrawn = false;
        Card PlayerOneCardOne;
        Card PlayerOneCardTwo;
        Card PlayerTwoCardOne;
        Card PlayerTwoCardTwo;
        public Form1()
        {
            InitializeComponent();
            
            CardDeck= new Deck();
            CardDeck.GetDeck();
            PlayerOneCardOne= new Card();
            PlayerOneCardTwo= new Card();
            PlayerTwoCardOne= new Card();
            PlayerTwoCardTwo= new Card();

            PlayerOneCardOne = CardDeck.callRandomCard();
            PlayerOneCardTwo=CardDeck.callRandomCard();
            PlayerTwoCardTwo=CardDeck.callRandomCard();
            PlayerTwoCardOne=CardDeck.callRandomCard();

            PlayerOneHoldemCards=new HoldemCards(PlayerOneCardOne,PlayerOneCardTwo);
            PlayerTwoHoldemCards=new HoldemCards(PlayerTwoCardOne,PlayerTwoCardTwo);
            playerOne = new Player(100, PlayerOneHoldemCards);
            playerTwo = new Player(100, PlayerTwoHoldemCards);
            playerOneCard1.Text = playerOne.holdemCards.getFirstCardSuit() + "\n" + playerOne.holdemCards.getFirstCardValue();
            playerOneCard2.Text = playerOne.holdemCards.getSecondCardSuit() + "\n" + playerOne.holdemCards.getSecondCardValue();

            playerTwoCard1.Text = playerTwo.holdemCards.getFirstCardSuit() + "\n" + playerTwo.holdemCards.getFirstCardValue();
            playerTwoCard2.Text=playerTwo.holdemCards.getSecondCardSuit()+"\n"+playerTwo.holdemCards.getSecondCardValue();

            PlayerOneMoney.Text = $"${playerOne.init_Money}";
            PlayerTwoMoney.Text = $"${playerTwo.init_Money}";
            CurrentPlayer= playerOne;
            PlayerTurnText.Text = "Player 1 Turn!";
            pokerHandOne = new Card();
            pokerHandTwo = new Card();
            pokerHandThree = new Card();
            pokerHandFour = new Card();
            pokerHandFive = new Card();
            pokerHandsForPlayer1 = new List<PokerHand>();
            pokerHandsForPlayer2= new List<PokerHand>();

            checkButton.Enabled = false;

        }
        public void DrawThreePokerHand()
        {
            if (playerOne.isPlayerOnBet && playerTwo.isPlayerOnBet && isFirstThreeCardsDrawn == false) 
            {
                pokerHandOne = CardDeck.callRandomCard();
                pokerHandTwo=CardDeck.callRandomCard();
                pokerHandThree=CardDeck.callRandomCard();

                pokerHand1.Text=pokerHandOne.getSuit()+"\n"+pokerHandOne.getValue();
                pokerHand2.Text=pokerHandTwo.getSuit()+"\n"+pokerHandTwo.getValue();
                pokerHand3.Text=pokerHandThree.getSuit()+"\n"+pokerHandThree.getValue();

                isFirstThreeCardsDrawn= true;
                playerOne.isPlayerOnBet = playerTwo.isPlayerOnBet = false;
            }
           
        }

        public void DrawnextPokerHand()
        {
            if (playerOne.isPlayerChecked && playerTwo.isPlayerChecked && pokerHandFour.getSuit()==string.Empty||(playerOne.isPlayerOnBet&&playerTwo.isPlayerOnBet&&pokerHandFour.getSuit()==string.Empty))
            {
                pokerHandFour = CardDeck.callRandomCard();
                pokerHand4.Text = pokerHandFour.getSuit() + "\n" + pokerHandFour.getValue();
                playerOne.isPlayerChecked = playerTwo.isPlayerChecked = false;
                playerOne.isPlayerOnBet = playerTwo.isPlayerOnBet = false;
            }
            else if(playerOne.isPlayerChecked && playerTwo.isPlayerChecked && pokerHandFive.getSuit() == string.Empty || (playerOne.isPlayerOnBet && playerTwo.isPlayerOnBet && pokerHandFive.getSuit() == string.Empty))
            {
                pokerHandFive= CardDeck.callRandomCard();
                pokerHand5.Text = pokerHandFive.getSuit()+"\n"+pokerHandFive.getValue();
                playerOne.isPlayerChecked = playerTwo.isPlayerChecked = false;
                playerOne.isPlayerOnBet = playerTwo.isPlayerOnBet = false;
            }
        }
        public void CombinationUtil(List<Card> cards, List<Card>temp,int start, int end, int index, int r, List<PokerHand>handsP) {
            //Base case
            if (index == r)
            {
                pokerHandOne = temp[0];
                pokerHandTwo= temp[1];
                pokerHandThree= temp[2];
                pokerHandFour= temp[3];
                pokerHandFive= temp[4];
                PokerHand newPokerHand=new PokerHand(pokerHandOne,pokerHandTwo,pokerHandThree,pokerHandFour,pokerHandFive);
                handsP.Add(newPokerHand);

                return;
            }

            for (int i = start; i <= end &&
                end - i + 1 >= r - index; i++)
            {
                 temp[index] = cards[i];
                 CombinationUtil(cards, temp, i + 1, end, index + 1, r,handsP);
                 
            }
            
           


        }
        public void generate21PokerHandsForpPlayer(Player  playerRef)
        {
            List<Card> sevenCards = new List<Card>();
            List<PokerHand>listPokerHand=new List<PokerHand>();
            List<Card> TempCards= new List<Card>() {new Card(), new Card(), new Card(), new Card(), new Card() };
            if (pokerHandFive.getSuit()!=string.Empty) {
               
                sevenCards.Add(playerRef.holdemCards.firstCard);
                sevenCards.Add(playerRef.holdemCards.secondCard);
                sevenCards.Add(pokerHandOne);
                sevenCards.Add(pokerHandTwo);
                sevenCards.Add(pokerHandThree);
                sevenCards.Add(pokerHandFour);
                sevenCards.Add(pokerHandFive);
                if (CurrentPlayer == playerOne)
                {
                    CombinationUtil(sevenCards, TempCards, 0, 6, 0, 5,pokerHandsForPlayer1);
                    for(int i = 0; i < pokerHandsForPlayer1.Count; i++)
                    {
                        ScoreListPlayer1.Add(pokerHandsForPlayer1[i].getBestValue());
                    }
                }
                else
                {
                    CombinationUtil(sevenCards, TempCards, 0, 6, 0, 5, pokerHandsForPlayer2);
                    for(int i=0;i<pokerHandsForPlayer2.Count;i++) {
                        ScoreListPlayer2.Add(pokerHandsForPlayer2[i].getBestValue());
                    }
                }
                
            }
           

            
        }
        public void nextPlayerTurn()
        {
            if (CurrentPlayer == playerOne)
            {
                
                PlayerTurnText.Text = "Player 2 Turn!";
                CurrentPlayer = playerTwo;
            }
            else
            {
                PlayerTurnText.Text = "Player 1 Turn!";
                CurrentPlayer = playerOne;
            }
        }
        private void betButton_Click(object sender, EventArgs e)
        {
            if(CurrentPlayer== playerOne)
            {
                playerOne.Bet(1);
                potMoney += 1;
                PlayerOneMoney.Text = "$"+playerOne.init_Money.ToString();
                ActionMsg.Text = "Player 1 Bets $1";
                checkButton.Enabled = false;

                if(playerOne.init_Money <= 0)
                {
                    MessageBox.Show("Player Two wins the pot");
                    playerTwo.init_Money += potMoney;

                    isGameWinner();
                }
                
            }
            else if(CurrentPlayer== playerTwo)
            {
                playerTwo.Bet(1);
                potMoney += 1;
                PlayerTwoMoney.Text="$"+playerTwo.init_Money.ToString();
                ActionMsg.Text = "Player 2 Bets $1";
                turnCounter++;
                turnCounterLabel.Text = $"Turn {turnCounter}";
                checkButton.Enabled = true;

                if (playerTwo.init_Money <= 0)
                {
                    MessageBox.Show("Player One wins the pot");
                    playerOne.init_Money += potMoney;

                    isGameWinner();
                }

            }
            potMoneyLabel.Text = "Pot Money: $ "+potMoney.ToString();
            nextPlayerTurn();
            DrawThreePokerHand();
            DrawnextPokerHand();
            generate21PokerHandsForpPlayer(CurrentPlayer);
            if (turnCounter == 5)
            {
                
                if (playerOneMaxHand > playerTwoMaxHand)
                {
                    FindWinner(ScoreListPlayer1, ScoreListPlayer2);
                    isGameWinner();
                    reset();
                    nextPlayerTurn();
                }
                else
                {
                    FindWinner(ScoreListPlayer1, ScoreListPlayer2);
                    isGameWinner();
                    reset();
                    nextPlayerTurn();
                }
                is5thRound();
            }

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if(CurrentPlayer== playerOne)
            {
                playerOne.Check();
                betButton.Enabled = false;
            }
            else if(CurrentPlayer== playerTwo)
            {
                playerTwo.Check();
                turnCounter++;
                turnCounterLabel.Text = $"Turn {turnCounter}";
                betButton.Enabled = true;
            }
            nextPlayerTurn();
            DrawThreePokerHand();
            DrawnextPokerHand();
            generate21PokerHandsForpPlayer(CurrentPlayer);
            if (turnCounter == 5)
            {
               
                if(playerOneMaxHand > playerTwoMaxHand)
                {
                    FindWinner(ScoreListPlayer1, ScoreListPlayer2);
                    isGameWinner();
                    reset();
                    nextPlayerTurn();
                }
                else
                {
                    FindWinner(ScoreListPlayer1, ScoreListPlayer2);


                    isGameWinner();
                    reset();
                    nextPlayerTurn();
                }
            }
        }

        private void foldButton_Click(object sender, EventArgs e)
        {
            if (CurrentPlayer == playerOne)
            {
                playerOne.Fold();
                MessageBox.Show("Player Two wins the pot");
                playerTwo.init_Money += potMoney;

                isGameWinner();
                reset();
                

            }
            else if (CurrentPlayer == playerTwo)
            {
                playerTwo.Fold();
                MessageBox.Show("Player One wins the pot");
                playerOne.init_Money += potMoney;

                isGameWinner();
                reset();
            }
            nextPlayerTurn();
            DrawThreePokerHand();
            DrawnextPokerHand();

        }

        int playerOneMaxHand = 0;
        int playerTwoMaxHand = 0;

        private void reset()
        {
            
            pokerHandsForPlayer1.Clear();
            pokerHandsForPlayer2.Clear();
            ScoreListPlayer1.Clear();
            ScoreListPlayer2.Clear();
            pokerHandOne = new Card();
            pokerHandTwo = new Card();
            pokerHandThree = new Card();
            pokerHandFour = new Card();
            pokerHandFive = new Card();


            pokerHand1.Text = string.Empty;
            pokerHand2.Text = string.Empty;
            pokerHand3.Text = string.Empty;
            pokerHand4.Text = string.Empty;
            pokerHand5.Text = string.Empty;

            playerOneCard1.Text = string.Empty;
            playerOneCard2.Text = string.Empty;

            playerTwoCard1.Text = string.Empty;
            playerTwoCard2.Text = string.Empty;

            isFirstThreeCardsDrawn = false;
            playerOne.isPlayerOnBet = false;
            playerTwo.isPlayerOnBet = false;
            playerOne.isPlayerChecked = false;
            playerTwo.isPlayerChecked = false;
            turnCounter = 1;
            potMoney = 0;
            potMoneyLabel.Text = "Pot Money: $ " + potMoney.ToString();

            CurrentPlayer = playerOne;

            turnCounterLabel.Text = $"Turn {turnCounter}";

            nextPlayerTurn();

            checkButton.Enabled = false;
            

           

            CardDeck = new Deck();
            CardDeck.GetDeck();
            PlayerOneCardOne = CardDeck.callRandomCard();
            PlayerTwoCardOne = CardDeck.callRandomCard();
            PlayerOneCardTwo = CardDeck.callRandomCard();
            PlayerTwoCardTwo = CardDeck.callRandomCard();
            PlayerOneHoldemCards = new HoldemCards(PlayerOneCardOne, PlayerOneCardTwo);
            PlayerTwoHoldemCards=new HoldemCards(PlayerTwoCardOne, PlayerTwoCardTwo);

            playerOne = new Player(playerOne.init_Money, PlayerOneHoldemCards);
            playerTwo = new Player(playerTwo.init_Money, PlayerTwoHoldemCards);
            playerOneCard1.Text = playerOne.holdemCards.getFirstCardSuit() + "\n" + playerOne.holdemCards.getFirstCardValue();
            playerOneCard2.Text = playerOne.holdemCards.getSecondCardSuit() + "\n" + playerOne.holdemCards.getSecondCardValue();

            playerTwoCard1.Text = playerTwo.holdemCards.getFirstCardSuit() + "\n" + playerTwo.holdemCards.getFirstCardValue();
            playerTwoCard2.Text = playerTwo.holdemCards.getSecondCardSuit() + "\n" + playerTwo.holdemCards.getSecondCardValue();

            PlayerOneMoney.Text = "$" + playerOne.init_Money.ToString();
            PlayerTwoMoney.Text = "$" + playerTwo.init_Money.ToString();
        }

        public void FindWinner(List<int> ScoreList1, List<int> ScoreList2)
        {
            Dictionary<int, string> map = new Dictionary<int, string>() { { 2, "High Card" }, { 3, "One Pair" }, { 4, "Two Pair" }, { 5, "Three of Kind" }, { 6, "Straight" }, { 7, "Flush" }, { 8, "Full House" }, { 9, "Four of Kind" }, { 10, "Straight&Flush" } };
            int maxScorePlayer1 = findMax(ScoreList1);
            int maxScorePlayer2 = findMax(ScoreList2);

            if (maxScorePlayer1 > maxScorePlayer2)
            {
                MessageBox.Show($"Player 1 wins by {map[maxScorePlayer1]}-----Money won ${potMoney}");
                playerOne.init_Money += potMoney;

            }
            else if (maxScorePlayer1 < maxScorePlayer2)
            {
                MessageBox.Show($"Player 2 wins by {map[maxScorePlayer2]}-----Money won ${potMoney}");
                playerTwo.init_Money += potMoney;
            }
            else
            {
                MessageBox.Show("Its Draw!");
                int moneyShared = potMoney / 2;
                playerOne.init_Money += moneyShared;
                playerTwo.init_Money += moneyShared;
            }
        }

        public int findMax(List<int> score)
        {
            int currentMax = score[0];
            for (int i = 1; i < score.Count; i++)
            {
                if (score[i] > currentMax)
                {
                    currentMax = score[i];
                }
            }
            return currentMax;
        }

       public void isGameWinner()
        {
            if (playerOne.init_Money == 0)
            {
                MessageBox.Show("Player One went bankrupt! \n Player Two Won! \n Press reset to reset the game or exit");
                reset();
                betButton.Enabled = false;
                foldButton.Enabled = false;
                fullResetButton.Enabled = true;
            }
            else if(playerTwo.init_Money == 0)
            {
                MessageBox.Show("Player Two went bankrupt! \n Player One Won! \n Press reset to reset the game or exit");
                reset();
                betButton.Enabled = false;
                foldButton.Enabled = false;
                fullResetButton.Enabled = true;
            }
            else
            {
                return;
            }
        }

        private void fullResetButton_Click(object sender, EventArgs e)
        {
            pokerHandsForPlayer1.Clear();
            pokerHandsForPlayer2.Clear();
            ScoreListPlayer1.Clear();
            ScoreListPlayer2.Clear();
            pokerHandOne = new Card();
            pokerHandTwo = new Card();
            pokerHandThree = new Card();
            pokerHandFour = new Card();
            pokerHandFive = new Card();


            pokerHand1.Text = string.Empty;
            pokerHand2.Text = string.Empty;
            pokerHand3.Text = string.Empty;
            pokerHand4.Text = string.Empty;
            pokerHand5.Text = string.Empty;

            playerOneCard1.Text = string.Empty;
            playerOneCard2.Text = string.Empty;

            playerTwoCard1.Text = string.Empty;
            playerTwoCard2.Text = string.Empty;

            isFirstThreeCardsDrawn = false;
            playerOne.isPlayerOnBet = false;
            playerTwo.isPlayerOnBet = false;
            playerOne.isPlayerChecked = false;
            playerTwo.isPlayerChecked = false;
            turnCounter = 1;
            potMoney = 0;
            potMoneyLabel.Text = "Pot Money: $ " + potMoney.ToString();

            CurrentPlayer = playerOne;

            turnCounterLabel.Text = $"Turn {turnCounter}";

            nextPlayerTurn();

            checkButton.Enabled = false;
            foldButton.Enabled = true;
            betButton.Enabled = true;


            

            CardDeck = new Deck();
            CardDeck.GetDeck();
            PlayerOneCardOne = CardDeck.callRandomCard();
            PlayerTwoCardOne = CardDeck.callRandomCard();
            PlayerOneCardTwo = CardDeck.callRandomCard();
            PlayerTwoCardTwo = CardDeck.callRandomCard();
            playerOne = new Player(100, PlayerOneHoldemCards);
            playerTwo = new Player(100, PlayerTwoHoldemCards);
            
            
            playerOneCard1.Text = playerOne.holdemCards.getFirstCardSuit() + "\n" + playerOne.holdemCards.getFirstCardValue();
            playerOneCard2.Text = playerOne.holdemCards.getSecondCardSuit() + "\n" + playerOne.holdemCards.getSecondCardValue();

            playerTwoCard1.Text = playerTwo.holdemCards.getFirstCardSuit() + "\n" + playerTwo.holdemCards.getFirstCardValue();
            playerTwoCard2.Text = playerTwo.holdemCards.getSecondCardSuit() + "\n" + playerTwo.holdemCards.getSecondCardValue();

            PlayerOneMoney.Text = "$" + playerOne.init_Money.ToString();
            PlayerTwoMoney.Text = "$" + playerTwo.init_Money.ToString();
        }

        private void is5thRound()
        {
            if(CurrentPlayer == playerOne && playerOne.isPlayerOnBet)
            {
                if(playerTwo.init_Money <= 0)
                {
                
                    isGameWinner();
                }
            }
            else if(CurrentPlayer == playerTwo && playerTwo.isPlayerOnBet)
            {

                if (playerOne.init_Money <= 0)
                {

                    isGameWinner();
                }
            }
        }
    }
}