namespace Project3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.betButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.foldButton = new System.Windows.Forms.Button();
            this.playerOneCard1 = new System.Windows.Forms.Label();
            this.playerOneCard2 = new System.Windows.Forms.Label();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.playerTwoCard1 = new System.Windows.Forms.Label();
            this.playerTwoCard2 = new System.Windows.Forms.Label();
            this.playerOneTotalMoney = new System.Windows.Forms.Label();
            this.playerTwoTotalMoney = new System.Windows.Forms.Label();
            this.pokerHand1 = new System.Windows.Forms.Label();
            this.pokerHand4 = new System.Windows.Forms.Label();
            this.pokerHand3 = new System.Windows.Forms.Label();
            this.pokerHand2 = new System.Windows.Forms.Label();
            this.pokerHand5 = new System.Windows.Forms.Label();
            this.PlayerOneMoney = new System.Windows.Forms.Label();
            this.PlayerTwoMoney = new System.Windows.Forms.Label();
            this.PlayerTurnText = new System.Windows.Forms.Label();
            this.ActionMsg = new System.Windows.Forms.Label();
            this.potMoneyLabel = new System.Windows.Forms.Label();
            this.turnCounterLabel = new System.Windows.Forms.Label();
            this.fullResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(212, 403);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 0;
            this.betButton.Text = "Bet";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(346, 403);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // foldButton
            // 
            this.foldButton.Location = new System.Drawing.Point(479, 403);
            this.foldButton.Name = "foldButton";
            this.foldButton.Size = new System.Drawing.Size(75, 23);
            this.foldButton.TabIndex = 2;
            this.foldButton.Text = "Fold";
            this.foldButton.UseVisualStyleBackColor = true;
            this.foldButton.Click += new System.EventHandler(this.foldButton_Click);
            // 
            // playerOneCard1
            // 
            this.playerOneCard1.AutoSize = true;
            this.playerOneCard1.Location = new System.Drawing.Point(51, 318);
            this.playerOneCard1.Name = "playerOneCard1";
            this.playerOneCard1.Size = new System.Drawing.Size(38, 30);
            this.playerOneCard1.TabIndex = 3;
            this.playerOneCard1.Text = "Suit:\r\nValue:\r\n";
            // 
            // playerOneCard2
            // 
            this.playerOneCard2.AutoSize = true;
            this.playerOneCard2.Location = new System.Drawing.Point(129, 318);
            this.playerOneCard2.Name = "playerOneCard2";
            this.playerOneCard2.Size = new System.Drawing.Size(38, 30);
            this.playerOneCard2.TabIndex = 4;
            this.playerOneCard2.Text = "Suit:\r\nValue:\r\n";
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Location = new System.Drawing.Point(70, 267);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(64, 15);
            this.playerOneLabel.TabIndex = 5;
            this.playerOneLabel.Text = "Player One";
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Location = new System.Drawing.Point(641, 267);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(63, 15);
            this.playerTwoLabel.TabIndex = 6;
            this.playerTwoLabel.Text = "Player Two";
            // 
            // playerTwoCard1
            // 
            this.playerTwoCard1.AutoSize = true;
            this.playerTwoCard1.Location = new System.Drawing.Point(605, 318);
            this.playerTwoCard1.Name = "playerTwoCard1";
            this.playerTwoCard1.Size = new System.Drawing.Size(38, 30);
            this.playerTwoCard1.TabIndex = 7;
            this.playerTwoCard1.Text = "Suit:\r\nValue:\r\n";
            // 
            // playerTwoCard2
            // 
            this.playerTwoCard2.AutoSize = true;
            this.playerTwoCard2.Location = new System.Drawing.Point(687, 318);
            this.playerTwoCard2.Name = "playerTwoCard2";
            this.playerTwoCard2.Size = new System.Drawing.Size(38, 30);
            this.playerTwoCard2.TabIndex = 8;
            this.playerTwoCard2.Text = "Suit:\r\nValue:\r\n";
            // 
            // playerOneTotalMoney
            // 
            this.playerOneTotalMoney.AutoSize = true;
            this.playerOneTotalMoney.Location = new System.Drawing.Point(70, 285);
            this.playerOneTotalMoney.Name = "playerOneTotalMoney";
            this.playerOneTotalMoney.Size = new System.Drawing.Size(75, 15);
            this.playerOneTotalMoney.TabIndex = 9;
            this.playerOneTotalMoney.Text = "Total Money:";
            // 
            // playerTwoTotalMoney
            // 
            this.playerTwoTotalMoney.AutoSize = true;
            this.playerTwoTotalMoney.Location = new System.Drawing.Point(641, 282);
            this.playerTwoTotalMoney.Name = "playerTwoTotalMoney";
            this.playerTwoTotalMoney.Size = new System.Drawing.Size(75, 15);
            this.playerTwoTotalMoney.TabIndex = 10;
            this.playerTwoTotalMoney.Text = "Total Money:";
            // 
            // pokerHand1
            // 
            this.pokerHand1.AutoSize = true;
            this.pokerHand1.Location = new System.Drawing.Point(177, 145);
            this.pokerHand1.Name = "pokerHand1";
            this.pokerHand1.Size = new System.Drawing.Size(38, 30);
            this.pokerHand1.TabIndex = 11;
            this.pokerHand1.Text = "Suit:\r\nValue:\r\n";
            // 
            // pokerHand4
            // 
            this.pokerHand4.AutoSize = true;
            this.pokerHand4.Location = new System.Drawing.Point(447, 145);
            this.pokerHand4.Name = "pokerHand4";
            this.pokerHand4.Size = new System.Drawing.Size(38, 30);
            this.pokerHand4.TabIndex = 12;
            this.pokerHand4.Text = "Suit:\r\nValue:\r\n";
            // 
            // pokerHand3
            // 
            this.pokerHand3.AutoSize = true;
            this.pokerHand3.Location = new System.Drawing.Point(360, 145);
            this.pokerHand3.Name = "pokerHand3";
            this.pokerHand3.Size = new System.Drawing.Size(38, 30);
            this.pokerHand3.TabIndex = 13;
            this.pokerHand3.Text = "Suit:\r\nValue:\r\n";
            // 
            // pokerHand2
            // 
            this.pokerHand2.AutoSize = true;
            this.pokerHand2.Location = new System.Drawing.Point(270, 145);
            this.pokerHand2.Name = "pokerHand2";
            this.pokerHand2.Size = new System.Drawing.Size(38, 30);
            this.pokerHand2.TabIndex = 14;
            this.pokerHand2.Text = "Suit:\r\nValue:\r\n";
            // 
            // pokerHand5
            // 
            this.pokerHand5.AutoSize = true;
            this.pokerHand5.Location = new System.Drawing.Point(534, 145);
            this.pokerHand5.Name = "pokerHand5";
            this.pokerHand5.Size = new System.Drawing.Size(38, 30);
            this.pokerHand5.TabIndex = 15;
            this.pokerHand5.Text = "Suit:\r\nValue:\r\n";
            // 
            // PlayerOneMoney
            // 
            this.PlayerOneMoney.AutoSize = true;
            this.PlayerOneMoney.Location = new System.Drawing.Point(156, 286);
            this.PlayerOneMoney.Name = "PlayerOneMoney";
            this.PlayerOneMoney.Size = new System.Drawing.Size(38, 15);
            this.PlayerOneMoney.TabIndex = 16;
            this.PlayerOneMoney.Text = "label1";
            // 
            // PlayerTwoMoney
            // 
            this.PlayerTwoMoney.AutoSize = true;
            this.PlayerTwoMoney.Location = new System.Drawing.Point(725, 282);
            this.PlayerTwoMoney.Name = "PlayerTwoMoney";
            this.PlayerTwoMoney.Size = new System.Drawing.Size(38, 15);
            this.PlayerTwoMoney.TabIndex = 17;
            this.PlayerTwoMoney.Text = "label1";
            // 
            // PlayerTurnText
            // 
            this.PlayerTurnText.AutoSize = true;
            this.PlayerTurnText.Location = new System.Drawing.Point(358, 274);
            this.PlayerTurnText.Name = "PlayerTurnText";
            this.PlayerTurnText.Size = new System.Drawing.Size(38, 15);
            this.PlayerTurnText.TabIndex = 18;
            this.PlayerTurnText.Text = "label1";
            // 
            // ActionMsg
            // 
            this.ActionMsg.AutoSize = true;
            this.ActionMsg.Location = new System.Drawing.Point(40, 39);
            this.ActionMsg.Name = "ActionMsg";
            this.ActionMsg.Size = new System.Drawing.Size(0, 15);
            this.ActionMsg.TabIndex = 19;
            // 
            // potMoneyLabel
            // 
            this.potMoneyLabel.AutoSize = true;
            this.potMoneyLabel.Location = new System.Drawing.Point(40, 83);
            this.potMoneyLabel.Name = "potMoneyLabel";
            this.potMoneyLabel.Size = new System.Drawing.Size(83, 15);
            this.potMoneyLabel.TabIndex = 20;
            this.potMoneyLabel.Text = "Pot Money: $0";
            // 
            // turnCounterLabel
            // 
            this.turnCounterLabel.AutoSize = true;
            this.turnCounterLabel.Location = new System.Drawing.Point(358, 39);
            this.turnCounterLabel.Name = "turnCounterLabel";
            this.turnCounterLabel.Size = new System.Drawing.Size(40, 15);
            this.turnCounterLabel.TabIndex = 21;
            this.turnCounterLabel.Text = "Turn 1";
            // 
            // fullResetButton
            // 
            this.fullResetButton.Enabled = false;
            this.fullResetButton.Location = new System.Drawing.Point(713, 12);
            this.fullResetButton.Name = "fullResetButton";
            this.fullResetButton.Size = new System.Drawing.Size(75, 23);
            this.fullResetButton.TabIndex = 22;
            this.fullResetButton.Text = "Reset";
            this.fullResetButton.UseVisualStyleBackColor = true;
            this.fullResetButton.Click += new System.EventHandler(this.fullResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fullResetButton);
            this.Controls.Add(this.turnCounterLabel);
            this.Controls.Add(this.potMoneyLabel);
            this.Controls.Add(this.ActionMsg);
            this.Controls.Add(this.PlayerTurnText);
            this.Controls.Add(this.PlayerTwoMoney);
            this.Controls.Add(this.PlayerOneMoney);
            this.Controls.Add(this.pokerHand5);
            this.Controls.Add(this.pokerHand2);
            this.Controls.Add(this.pokerHand3);
            this.Controls.Add(this.pokerHand4);
            this.Controls.Add(this.pokerHand1);
            this.Controls.Add(this.playerTwoTotalMoney);
            this.Controls.Add(this.playerOneTotalMoney);
            this.Controls.Add(this.playerTwoCard2);
            this.Controls.Add(this.playerTwoCard1);
            this.Controls.Add(this.playerTwoLabel);
            this.Controls.Add(this.playerOneLabel);
            this.Controls.Add(this.playerOneCard2);
            this.Controls.Add(this.playerOneCard1);
            this.Controls.Add(this.foldButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.betButton);
            this.Name = "Form1";
            this.Text = "Texas Holdem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button betButton;
        private Button checkButton;
        private Button foldButton;
        private Label playerOneCard1;
        private Label playerOneCard2;
        private Label playerOneLabel;
        private Label playerTwoLabel;
        private Label playerTwoCard1;
        private Label playerTwoCard2;
        private Label playerOneTotalMoney;
        private Label playerTwoTotalMoney;
        private Label pokerHand1;
        private Label pokerHand4;
        private Label pokerHand3;
        private Label pokerHand2;
        private Label pokerHand5;
        private Label PlayerOneMoney;
        private Label PlayerTwoMoney;
        private Label PlayerTurnText;
        private Label ActionMsg;
        private Label potMoneyLabel;
        private Label turnCounterLabel;
        private Button fullResetButton;
    }
}