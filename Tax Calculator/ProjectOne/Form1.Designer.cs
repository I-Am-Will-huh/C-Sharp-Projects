namespace ProjectOne
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
            this.W2Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.W2Input = new System.Windows.Forms.TextBox();
            this.grossIncomeLabel = new System.Windows.Forms.Label();
            this.grossIncomeInput = new System.Windows.Forms.TextBox();
            this.grossIncomeButton = new System.Windows.Forms.Button();
            this.deductionLabel = new System.Windows.Forms.Label();
            this.deductionInput = new System.Windows.Forms.TextBox();
            this.deductionButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.singleBracketRadioButton = new System.Windows.Forms.RadioButton();
            this.marriedJointBracketRadioButton = new System.Windows.Forms.RadioButton();
            this.tenPercentTaxBracketLabel = new System.Windows.Forms.Label();
            this.twelvePercentBracketLabel = new System.Windows.Forms.Label();
            this.twentyTwoTaxBracketLabel = new System.Windows.Forms.Label();
            this.twentyFourBracketLabel = new System.Windows.Forms.Label();
            this.thrityTwoPercentBracketLabel = new System.Windows.Forms.Label();
            this.ThrityFiveTaxBracketLabel = new System.Windows.Forms.Label();
            this.ThirtySevenTaxBracketLabel = new System.Windows.Forms.Label();
            this.selectingBracketLabel = new System.Windows.Forms.Label();
            this.totalTaxesLabel = new System.Windows.Forms.Label();
            this.percentageGrossIncome = new System.Windows.Forms.Label();
            this.percentageAdjustedGrossIncome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // W2Button
            // 
            this.W2Button.Location = new System.Drawing.Point(111, 30);
            this.W2Button.Name = "W2Button";
            this.W2Button.Size = new System.Drawing.Size(75, 23);
            this.W2Button.TabIndex = 0;
            this.W2Button.Text = "OK";
            this.W2Button.UseVisualStyleBackColor = true;
            this.W2Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter the amount of w2\'s you have: ";
            // 
            // W2Input
            // 
            this.W2Input.Location = new System.Drawing.Point(11, 30);
            this.W2Input.Name = "W2Input";
            this.W2Input.Size = new System.Drawing.Size(76, 23);
            this.W2Input.TabIndex = 2;
            this.W2Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grossIncomeLabel
            // 
            this.grossIncomeLabel.AutoSize = true;
            this.grossIncomeLabel.Location = new System.Drawing.Point(11, 70);
            this.grossIncomeLabel.Name = "grossIncomeLabel";
            this.grossIncomeLabel.Size = new System.Drawing.Size(0, 15);
            this.grossIncomeLabel.TabIndex = 3;
            // 
            // grossIncomeInput
            // 
            this.grossIncomeInput.Location = new System.Drawing.Point(10, 94);
            this.grossIncomeInput.Name = "grossIncomeInput";
            this.grossIncomeInput.Size = new System.Drawing.Size(77, 23);
            this.grossIncomeInput.TabIndex = 4;
            this.grossIncomeInput.Visible = false;
            // 
            // grossIncomeButton
            // 
            this.grossIncomeButton.Location = new System.Drawing.Point(111, 94);
            this.grossIncomeButton.Name = "grossIncomeButton";
            this.grossIncomeButton.Size = new System.Drawing.Size(75, 23);
            this.grossIncomeButton.TabIndex = 5;
            this.grossIncomeButton.Text = "OK";
            this.grossIncomeButton.UseVisualStyleBackColor = true;
            this.grossIncomeButton.Visible = false;
            this.grossIncomeButton.Click += new System.EventHandler(this.grossIncomeButton_Click);
            // 
            // deductionLabel
            // 
            this.deductionLabel.AutoSize = true;
            this.deductionLabel.Location = new System.Drawing.Point(12, 141);
            this.deductionLabel.Name = "deductionLabel";
            this.deductionLabel.Size = new System.Drawing.Size(0, 15);
            this.deductionLabel.TabIndex = 6;
            // 
            // deductionInput
            // 
            this.deductionInput.Location = new System.Drawing.Point(12, 159);
            this.deductionInput.Name = "deductionInput";
            this.deductionInput.Size = new System.Drawing.Size(75, 23);
            this.deductionInput.TabIndex = 7;
            this.deductionInput.Visible = false;
            // 
            // deductionButton
            // 
            this.deductionButton.Location = new System.Drawing.Point(111, 159);
            this.deductionButton.Name = "deductionButton";
            this.deductionButton.Size = new System.Drawing.Size(75, 23);
            this.deductionButton.TabIndex = 8;
            this.deductionButton.Text = "OK";
            this.deductionButton.UseVisualStyleBackColor = true;
            this.deductionButton.Visible = false;
            this.deductionButton.Click += new System.EventHandler(this.deductionButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(192, 159);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 9;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Visible = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // singleBracketRadioButton
            // 
            this.singleBracketRadioButton.AutoSize = true;
            this.singleBracketRadioButton.Location = new System.Drawing.Point(362, 32);
            this.singleBracketRadioButton.Name = "singleBracketRadioButton";
            this.singleBracketRadioButton.Size = new System.Drawing.Size(99, 19);
            this.singleBracketRadioButton.TabIndex = 10;
            this.singleBracketRadioButton.TabStop = true;
            this.singleBracketRadioButton.Text = "Single Bracket";
            this.singleBracketRadioButton.UseVisualStyleBackColor = true;
            this.singleBracketRadioButton.Visible = false;
            this.singleBracketRadioButton.CheckedChanged += new System.EventHandler(this.singleBracketRadioButton_CheckedChanged);
            // 
            // marriedJointBracketRadioButton
            // 
            this.marriedJointBracketRadioButton.AutoSize = true;
            this.marriedJointBracketRadioButton.Location = new System.Drawing.Point(362, 57);
            this.marriedJointBracketRadioButton.Name = "marriedJointBracketRadioButton";
            this.marriedJointBracketRadioButton.Size = new System.Drawing.Size(136, 19);
            this.marriedJointBracketRadioButton.TabIndex = 11;
            this.marriedJointBracketRadioButton.TabStop = true;
            this.marriedJointBracketRadioButton.Text = "Married Joint Bracket";
            this.marriedJointBracketRadioButton.UseVisualStyleBackColor = true;
            this.marriedJointBracketRadioButton.Visible = false;
            // 
            // tenPercentTaxBracketLabel
            // 
            this.tenPercentTaxBracketLabel.AutoSize = true;
            this.tenPercentTaxBracketLabel.Location = new System.Drawing.Point(519, 38);
            this.tenPercentTaxBracketLabel.Name = "tenPercentTaxBracketLabel";
            this.tenPercentTaxBracketLabel.Size = new System.Drawing.Size(0, 15);
            this.tenPercentTaxBracketLabel.TabIndex = 12;
            this.tenPercentTaxBracketLabel.Visible = false;
            // 
            // twelvePercentBracketLabel
            // 
            this.twelvePercentBracketLabel.AutoSize = true;
            this.twelvePercentBracketLabel.Location = new System.Drawing.Point(519, 70);
            this.twelvePercentBracketLabel.Name = "twelvePercentBracketLabel";
            this.twelvePercentBracketLabel.Size = new System.Drawing.Size(0, 15);
            this.twelvePercentBracketLabel.TabIndex = 13;
            this.twelvePercentBracketLabel.Visible = false;
            // 
            // twentyTwoTaxBracketLabel
            // 
            this.twentyTwoTaxBracketLabel.AutoSize = true;
            this.twentyTwoTaxBracketLabel.Location = new System.Drawing.Point(519, 98);
            this.twentyTwoTaxBracketLabel.Name = "twentyTwoTaxBracketLabel";
            this.twentyTwoTaxBracketLabel.Size = new System.Drawing.Size(0, 15);
            this.twentyTwoTaxBracketLabel.TabIndex = 14;
            this.twentyTwoTaxBracketLabel.Visible = false;
            // 
            // twentyFourBracketLabel
            // 
            this.twentyFourBracketLabel.AutoSize = true;
            this.twentyFourBracketLabel.Location = new System.Drawing.Point(519, 125);
            this.twentyFourBracketLabel.Name = "twentyFourBracketLabel";
            this.twentyFourBracketLabel.Size = new System.Drawing.Size(0, 15);
            this.twentyFourBracketLabel.TabIndex = 15;
            this.twentyFourBracketLabel.Visible = false;
            // 
            // thrityTwoPercentBracketLabel
            // 
            this.thrityTwoPercentBracketLabel.AutoSize = true;
            this.thrityTwoPercentBracketLabel.Location = new System.Drawing.Point(519, 159);
            this.thrityTwoPercentBracketLabel.Name = "thrityTwoPercentBracketLabel";
            this.thrityTwoPercentBracketLabel.Size = new System.Drawing.Size(0, 15);
            this.thrityTwoPercentBracketLabel.TabIndex = 16;
            this.thrityTwoPercentBracketLabel.Visible = false;
            // 
            // ThrityFiveTaxBracketLabel
            // 
            this.ThrityFiveTaxBracketLabel.AutoSize = true;
            this.ThrityFiveTaxBracketLabel.Location = new System.Drawing.Point(519, 188);
            this.ThrityFiveTaxBracketLabel.Name = "ThrityFiveTaxBracketLabel";
            this.ThrityFiveTaxBracketLabel.Size = new System.Drawing.Size(0, 15);
            this.ThrityFiveTaxBracketLabel.TabIndex = 17;
            this.ThrityFiveTaxBracketLabel.Visible = false;
            // 
            // ThirtySevenTaxBracketLabel
            // 
            this.ThirtySevenTaxBracketLabel.AutoSize = true;
            this.ThirtySevenTaxBracketLabel.Location = new System.Drawing.Point(519, 221);
            this.ThirtySevenTaxBracketLabel.Name = "ThirtySevenTaxBracketLabel";
            this.ThirtySevenTaxBracketLabel.Size = new System.Drawing.Size(0, 15);
            this.ThirtySevenTaxBracketLabel.TabIndex = 18;
            this.ThirtySevenTaxBracketLabel.Visible = false;
            // 
            // selectingBracketLabel
            // 
            this.selectingBracketLabel.AutoSize = true;
            this.selectingBracketLabel.Location = new System.Drawing.Point(362, 9);
            this.selectingBracketLabel.Name = "selectingBracketLabel";
            this.selectingBracketLabel.Size = new System.Drawing.Size(189, 15);
            this.selectingBracketLabel.TabIndex = 19;
            this.selectingBracketLabel.Text = "Please Select a bracket to calculate";
            this.selectingBracketLabel.Visible = false;
            // 
            // totalTaxesLabel
            // 
            this.totalTaxesLabel.AutoSize = true;
            this.totalTaxesLabel.Location = new System.Drawing.Point(507, 256);
            this.totalTaxesLabel.Name = "totalTaxesLabel";
            this.totalTaxesLabel.Size = new System.Drawing.Size(0, 15);
            this.totalTaxesLabel.TabIndex = 20;
            // 
            // percentageGrossIncome
            // 
            this.percentageGrossIncome.AutoSize = true;
            this.percentageGrossIncome.Location = new System.Drawing.Point(507, 281);
            this.percentageGrossIncome.Name = "percentageGrossIncome";
            this.percentageGrossIncome.Size = new System.Drawing.Size(0, 15);
            this.percentageGrossIncome.TabIndex = 21;
            // 
            // percentageAdjustedGrossIncome
            // 
            this.percentageAdjustedGrossIncome.AutoSize = true;
            this.percentageAdjustedGrossIncome.Location = new System.Drawing.Point(507, 307);
            this.percentageAdjustedGrossIncome.Name = "percentageAdjustedGrossIncome";
            this.percentageAdjustedGrossIncome.Size = new System.Drawing.Size(0, 15);
            this.percentageAdjustedGrossIncome.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.percentageAdjustedGrossIncome);
            this.Controls.Add(this.percentageGrossIncome);
            this.Controls.Add(this.totalTaxesLabel);
            this.Controls.Add(this.selectingBracketLabel);
            this.Controls.Add(this.ThirtySevenTaxBracketLabel);
            this.Controls.Add(this.ThrityFiveTaxBracketLabel);
            this.Controls.Add(this.thrityTwoPercentBracketLabel);
            this.Controls.Add(this.twentyFourBracketLabel);
            this.Controls.Add(this.twentyTwoTaxBracketLabel);
            this.Controls.Add(this.twelvePercentBracketLabel);
            this.Controls.Add(this.tenPercentTaxBracketLabel);
            this.Controls.Add(this.marriedJointBracketRadioButton);
            this.Controls.Add(this.singleBracketRadioButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.deductionButton);
            this.Controls.Add(this.deductionInput);
            this.Controls.Add(this.deductionLabel);
            this.Controls.Add(this.grossIncomeButton);
            this.Controls.Add(this.grossIncomeInput);
            this.Controls.Add(this.grossIncomeLabel);
            this.Controls.Add(this.W2Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.W2Button);
            this.Name = "Form1";
            this.Text = "Bad Federal income tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button W2Button;
        private Label label1;
        private TextBox W2Input;
        private Label grossIncomeLabel;
        private TextBox grossIncomeInput;
        private Button grossIncomeButton;
        private Label deductionLabel;
        private TextBox deductionInput;
        private Button deductionButton;
        private Button doneButton;
        private RadioButton singleBracketRadioButton;
        private RadioButton marriedJointBracketRadioButton;
        private Label tenPercentTaxBracketLabel;
        private Label twelvePercentBracketLabel;
        private Label twentyTwoTaxBracketLabel;
        private Label twentyFourBracketLabel;
        private Label thrityTwoPercentBracketLabel;
        private Label ThrityFiveTaxBracketLabel;
        private Label ThirtySevenTaxBracketLabel;
        private Label selectingBracketLabel;
        private Label totalTaxesLabel;
        private Label percentageGrossIncome;
        private Label percentageAdjustedGrossIncome;
    }
}