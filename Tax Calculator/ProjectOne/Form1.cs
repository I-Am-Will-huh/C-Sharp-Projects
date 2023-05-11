using System.Threading;
// Purpose: A bad federal income tax calculator using 2023 tax brackets and standard deductions
namespace ProjectOne
{
    public partial class Form1 : Form
    {
        int w2Amount;
        double income;
        double grossIncome;
        int counter;
        int deduction;
        double totalDeduction;
        double adjustedGrossIncome;
        double totalTaxes;
        double singleStandardDeduction;
        double marriedStandardDeduction;
        double userSingleDeduction;
        double userMarriedDeduction;

        public Form1()
        {
            InitializeComponent();
            income = 0;
            grossIncome = 0;
            counter = 0;
            totalDeduction = 0;
            singleStandardDeduction = 13_850;
            marriedStandardDeduction = 27_700;
            adjustedGrossIncome = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            w2Amount = Convert.ToInt32(W2Input.Text);

            grossIncomeLabel.Text = "Please enter each individual W2's income then press ok: ";
            grossIncomeInput.Visible = true;
            grossIncomeButton.Visible = true;

            label1.Visible= false;
            W2Input.Visible= false;
            W2Button.Visible= false;
            W2Button.Enabled=false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void grossIncomeButton_Click(object sender, EventArgs e)
        {
            counter++;

            income = Convert.ToInt32(grossIncomeInput.Text);
            grossIncome += income;
            grossIncomeInput.Clear();
                
            if(counter == w2Amount)
            {
                grossIncomeInput.Visible = false;
                grossIncomeButton.Visible = false;
                grossIncomeInput.Enabled = false;
                grossIncomeButton.Enabled= false;
                grossIncomeLabel.Visible= false;

                deductionButton.Visible= true;
                deductionInput.Visible= true;
                doneButton.Visible= true;
                deductionLabel.Text = "Please enter in your deduction and press done when you are done.";
            }

        }

        private void deductionButton_Click(object sender, EventArgs e)
        {
            deduction = Convert.ToInt32(deductionInput.Text);
            totalDeduction += deduction;
            deductionInput.Clear();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            deductionButton.Visible = false;
            deductionInput.Visible = false;
            doneButton.Visible = false;
            deductionLabel.Visible = false;

            if (totalDeduction < singleStandardDeduction)
            {
                userSingleDeduction = singleStandardDeduction;
            }
            else 
            {
                userSingleDeduction = totalDeduction;
            }

            if (totalDeduction < marriedStandardDeduction)
            {
                userMarriedDeduction = marriedStandardDeduction;
            }
            else
            {
                userMarriedDeduction = totalDeduction;
            }

            singleBracketRadioButton.Visible = true;
            marriedJointBracketRadioButton.Visible = true;
            selectingBracketLabel.Visible = true;
            tenPercentTaxBracketLabel.Visible = true;
            twelvePercentBracketLabel.Visible = true;
            twentyTwoTaxBracketLabel.Visible = true;
            twentyFourBracketLabel.Visible = true;
            thrityTwoPercentBracketLabel.Visible = true;
            ThrityFiveTaxBracketLabel.Visible = true;
            ThirtySevenTaxBracketLabel.Visible = true;
        }

        private void singleBracketRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(singleBracketRadioButton.Checked)
            {
                tenPercentTaxBracketLabel.Text = "";
                twelvePercentBracketLabel.Text = "";
                twentyTwoTaxBracketLabel.Text = "";
                twentyFourBracketLabel.Text = "";
                thrityTwoPercentBracketLabel.Text = "";
                ThrityFiveTaxBracketLabel.Text = "";
                ThirtySevenTaxBracketLabel.Text = "";
                totalTaxes = 0;

                // calculating adjusted gross income
                adjustedGrossIncome = (grossIncome - userSingleDeduction);

                // these are the calculated taxes for each tax bracket
                double lowestTaxBracket = 1100;
                double secondLowestTaxBracket = 4047;
                double thirdLowestTaxBracket = 11143;
                double fourthLowestTaxBracket = 20814;
                double fifthTaxBracket = 15728;
                double sixthTaxBracket = 121406.25;

                // tax bracket cap
                const int lowestTaxBracketCap = 11000;
                const int secondLowestTaxBracketCap = 44725;
                const int thirdLowestTaxBracketCap = 95375;
                const int fourthLowestTaxBracketCap = 182100;
                const int fifthTaxBracketCap = 231250;
                const int sixthTaxBracketCap = 578125;

                // tax bracket precentage
                double lowestTaxBracketPercentage = 0.1;
                double secondLowestTaxPercentage = 0.12;
                double thirdLowestTaxPercentage = 0.22;
                double fourthLowestTaxPercentage = 0.24;
                double fifthTaxPercentage = 0.32;
                double sixthTaxPercentage = 0.35;
                double seventhTaxPercentage = 0.37;

                switch (adjustedGrossIncome)
                {
                    case <= lowestTaxBracketCap:
                        totalTaxes = adjustedGrossIncome * lowestTaxBracketPercentage;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${totalTaxes}";
                        break;

                    case <= secondLowestTaxBracketCap:
                        totalTaxes = lowestTaxBracket;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${lowestTaxBracket}";
                        twelvePercentBracketLabel.Text = $"Taxes owed at 12% tax bracket: ${(adjustedGrossIncome - lowestTaxBracketCap) * secondLowestTaxPercentage}";
                        totalTaxes += (adjustedGrossIncome - lowestTaxBracketCap) * secondLowestTaxPercentage;
                        break;

                    case <= thirdLowestTaxBracketCap:
                        totalTaxes = lowestTaxBracket + secondLowestTaxBracket;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${lowestTaxBracket}";
                        twelvePercentBracketLabel.Text = $"Taxes owed at 12% tax bracket: ${secondLowestTaxBracket}";
                        twentyTwoTaxBracketLabel.Text = $"Taxes owed at 22% tax bracket: ${(adjustedGrossIncome - secondLowestTaxBracketCap) * thirdLowestTaxPercentage}";
                        totalTaxes += (adjustedGrossIncome - secondLowestTaxBracketCap) * thirdLowestTaxPercentage;
                        break;

                    case <= fourthLowestTaxBracketCap:
                        totalTaxes = lowestTaxBracket + secondLowestTaxBracket + thirdLowestTaxBracket;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${lowestTaxBracket}";
                        twelvePercentBracketLabel.Text = $"Taxes owed at 12% tax bracket: ${secondLowestTaxBracket}";
                        twentyTwoTaxBracketLabel.Text = $"Taxes owed at 22% tax bracket: ${thirdLowestTaxBracket}";
                        twentyFourBracketLabel.Text = $"Taxes owed at 24% tax bracket: ${(adjustedGrossIncome - thirdLowestTaxBracketCap) * fourthLowestTaxPercentage}";
                        totalTaxes += (adjustedGrossIncome - thirdLowestTaxBracketCap) * fourthLowestTaxPercentage;
                        break;

                    case <= fifthTaxBracketCap:
                        totalTaxes = lowestTaxBracket + secondLowestTaxBracket + thirdLowestTaxBracket + fourthLowestTaxBracket;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${lowestTaxBracket}";
                        twelvePercentBracketLabel.Text = $"Taxes owed at 12% tax bracket: ${secondLowestTaxBracket}";
                        twentyTwoTaxBracketLabel.Text = $"Taxes owed at 22% tax bracket: ${thirdLowestTaxBracket}";
                        twentyFourBracketLabel.Text = $"Taxes owed at 24% tax bracket: ${fourthLowestTaxBracket}";
                        thrityTwoPercentBracketLabel.Text = $"Taxes owed at 32% tax bracket: ${(adjustedGrossIncome - fourthLowestTaxBracketCap) * fifthTaxPercentage}";
                        totalTaxes += (adjustedGrossIncome - fourthLowestTaxBracketCap) * fifthTaxPercentage;
                        break;

                    case <= sixthTaxBracketCap:
                        totalTaxes = lowestTaxBracket + secondLowestTaxBracket + thirdLowestTaxBracket + fourthLowestTaxBracket
                            + fifthTaxBracket;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${lowestTaxBracket}";
                        twelvePercentBracketLabel.Text = $"Taxes owed at 12% tax bracket: ${secondLowestTaxBracket}";
                        twentyTwoTaxBracketLabel.Text = $"Taxes owed at 22% tax bracket: ${thirdLowestTaxBracket}";
                        twentyFourBracketLabel.Text = $"Taxes owed at 24% tax bracket: ${fourthLowestTaxBracket}";
                        thrityTwoPercentBracketLabel.Text = $"Taxes owed at 32% tax bracket: ${fifthTaxBracket}";
                        ThrityFiveTaxBracketLabel.Text = $"Taxes owed at 35% tax bracket: ${(adjustedGrossIncome - fifthTaxBracketCap) * sixthTaxPercentage}";
                        totalTaxes += (adjustedGrossIncome - fifthTaxBracketCap) * sixthTaxPercentage;
                        break;

                    default:
                        totalTaxes = lowestTaxBracket + secondLowestTaxBracket + thirdLowestTaxBracket + fourthLowestTaxBracket
                            + fifthTaxBracket + sixthTaxBracket;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${lowestTaxBracket}";
                        twelvePercentBracketLabel.Text = $"Taxes owed at 12% tax bracket: ${secondLowestTaxBracket}";
                        twentyTwoTaxBracketLabel.Text = $"Taxes owed at 22% tax bracket: ${thirdLowestTaxBracket}";
                        twentyFourBracketLabel.Text = $"Taxes owed at 24% tax bracket: ${fourthLowestTaxBracket}";
                        thrityTwoPercentBracketLabel.Text = $"Taxes owed at 32% tax bracket: ${fifthTaxBracket}";
                        ThrityFiveTaxBracketLabel.Text = $"Taxes owed at 35% tax bracket: ${sixthTaxBracket}";
                        ThirtySevenTaxBracketLabel.Text = $"Taxes owed at 37% tax bracket: ${(adjustedGrossIncome - sixthTaxBracketCap) * seventhTaxPercentage}";
                        totalTaxes += (adjustedGrossIncome - sixthTaxBracketCap) * seventhTaxPercentage;
                        break;
                }
                
                totalTaxesLabel.Text = $"Amount of total Taxes owed: ${totalTaxes}";
                percentageGrossIncome.Text = $"Taxes as percentage of gross income: {(totalTaxes / grossIncome) * 100}%";
                percentageAdjustedGrossIncome.Text = $"Taxes as percentage of adjusted gross income: {(totalTaxes / adjustedGrossIncome) * 100}%";

            }
            else
            {
                totalTaxes = 0;
                tenPercentTaxBracketLabel.Text = "";
                twelvePercentBracketLabel.Text = "";
                twentyTwoTaxBracketLabel.Text = "";
                twentyFourBracketLabel.Text = "";
                thrityTwoPercentBracketLabel.Text = "";
                ThrityFiveTaxBracketLabel.Text = "";
                ThirtySevenTaxBracketLabel.Text = "";

                // calculating adjusted gross income
                adjustedGrossIncome = (grossIncome - userMarriedDeduction);

                // these are the calculated taxes for each tax bracket
                double marriedlowestTaxBracket = 2_200;
                double marriedsecondLowestTaxBracket = 8_094;
                double marriedthirdLowestTaxBracket = 22_286;
                double marriedfourthLowestTaxBracket = 41_628;
                double marriedfifthTaxBracket = 31_456;
                double marriedsixthTaxBracket = 80_937.5;

                // tax bracket cap
                const int marriedlowestTaxBracketCap = 22_000;
                const int marriedsecondLowestTaxBracketCap = 89_450;
                const int marriedthirdLowestTaxBracketCap = 190_750;
                const int marriedfourthLowestTaxBracketCap = 364_200;
                const int marriedfifthTaxBracketCap = 462_500;
                const int marriedsixthTaxBracketCap = 693_750;

                // tax bracket precentage
                double marriedlowestTaxBracketPercentage = 0.1;
                double marriedsecondLowestTaxPercentage = 0.12;
                double marriedthirdLowestTaxPercentage = 0.22;
                double marriedfourthLowestTaxPercentage = 0.24;
                double marriedfifthTaxPercentage = 0.32;
                double marriedsixthTaxPercentage = 0.35;
                double marriedseventhTaxPercentage = 0.37;

                switch (adjustedGrossIncome)
                {
                    case <= marriedlowestTaxBracketCap:
                        totalTaxes = adjustedGrossIncome * marriedlowestTaxBracketPercentage;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${totalTaxes}";
                        break;

                    case <= marriedsecondLowestTaxBracketCap:
                        totalTaxes = marriedlowestTaxBracket;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${marriedlowestTaxBracket}";
                        twelvePercentBracketLabel.Text = $"Taxes owed at 12% tax bracket: ${(adjustedGrossIncome - marriedlowestTaxBracketCap) * marriedsecondLowestTaxPercentage}";
                        totalTaxes += (adjustedGrossIncome - marriedlowestTaxBracketCap) * marriedsecondLowestTaxPercentage;
                        break;

                    case <= marriedthirdLowestTaxBracketCap:
                        totalTaxes = marriedlowestTaxBracket + marriedsecondLowestTaxBracket;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${marriedlowestTaxBracket}";
                        twelvePercentBracketLabel.Text = $"Taxes owed at 12% tax bracket: ${marriedsecondLowestTaxBracket}";
                        twentyTwoTaxBracketLabel.Text = $"Taxes owed at 22% tax bracket: ${(adjustedGrossIncome - marriedsecondLowestTaxBracketCap) * marriedthirdLowestTaxPercentage}";
                        totalTaxes += (adjustedGrossIncome - marriedsecondLowestTaxBracketCap) * marriedthirdLowestTaxPercentage;
                        break;

                    case <= marriedfourthLowestTaxBracketCap:
                        totalTaxes = marriedlowestTaxBracket + marriedsecondLowestTaxBracket + marriedthirdLowestTaxBracket;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${marriedlowestTaxBracket}";
                        twelvePercentBracketLabel.Text = $"Taxes owed at 12% tax bracket: ${marriedsecondLowestTaxBracket}";
                        twentyTwoTaxBracketLabel.Text = $"Taxes owed at 22% tax bracket: ${marriedthirdLowestTaxBracket}";
                        twentyFourBracketLabel.Text = $"Taxes owed at 24% tax bracket: ${(adjustedGrossIncome - marriedthirdLowestTaxBracketCap) * marriedfourthLowestTaxPercentage}";
                        totalTaxes += (adjustedGrossIncome - marriedthirdLowestTaxBracketCap) * marriedfourthLowestTaxPercentage;
                        break;

                    case <= marriedfifthTaxBracketCap:
                        totalTaxes = marriedlowestTaxBracket + marriedsecondLowestTaxBracket + marriedthirdLowestTaxBracket + marriedfourthLowestTaxBracket;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${marriedlowestTaxBracket}";
                        twelvePercentBracketLabel.Text = $"Taxes owed at 12% tax bracket: ${marriedsecondLowestTaxBracket}";
                        twentyTwoTaxBracketLabel.Text = $"Taxes owed at 22% tax bracket: ${marriedthirdLowestTaxBracket}";
                        twentyFourBracketLabel.Text = $"Taxes owed at 24% tax bracket: ${marriedfourthLowestTaxBracket}";
                        thrityTwoPercentBracketLabel.Text = $"Taxes owed at 32% tax bracket: ${(adjustedGrossIncome - marriedfourthLowestTaxBracketCap) * marriedfifthTaxPercentage}";
                        totalTaxes += (adjustedGrossIncome - marriedfourthLowestTaxBracketCap) * marriedfifthTaxPercentage;
                        break;

                    case <= marriedsixthTaxBracketCap:
                        totalTaxes = marriedlowestTaxBracket + marriedsecondLowestTaxBracket + marriedthirdLowestTaxBracket + marriedfourthLowestTaxBracket
                            + marriedfifthTaxBracket;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${marriedlowestTaxBracket}";
                        twelvePercentBracketLabel.Text = $"Taxes owed at 12% tax bracket: ${marriedsecondLowestTaxBracket}";
                        twentyTwoTaxBracketLabel.Text = $"Taxes owed at 22% tax bracket: ${marriedthirdLowestTaxBracket}";
                        twentyFourBracketLabel.Text = $"Taxes owed at 24% tax bracket: ${marriedfourthLowestTaxBracket}";
                        thrityTwoPercentBracketLabel.Text = $"Taxes owed at 32% tax bracket: ${marriedfifthTaxBracket}";
                        ThrityFiveTaxBracketLabel.Text = $"Taxes owed at 35% tax bracket: ${(adjustedGrossIncome - marriedfifthTaxBracketCap) * marriedsixthTaxPercentage}";
                        totalTaxes += (adjustedGrossIncome - marriedfifthTaxBracketCap) * marriedsixthTaxPercentage;
                        break;

                    default:
                        totalTaxes = marriedlowestTaxBracket + marriedsecondLowestTaxBracket + marriedthirdLowestTaxBracket + marriedfourthLowestTaxBracket
                            + marriedfifthTaxBracket + marriedsixthTaxBracket;
                        tenPercentTaxBracketLabel.Text = $"Taxes owed at 10% tax bracket: ${marriedlowestTaxBracket}";
                        twelvePercentBracketLabel.Text = $"Taxes owed at 12% tax bracket: ${marriedsecondLowestTaxBracket}";
                        twentyTwoTaxBracketLabel.Text = $"Taxes owed at 22% tax bracket: ${marriedthirdLowestTaxBracket}";
                        twentyFourBracketLabel.Text = $"Taxes owed at 24% tax bracket: ${marriedfourthLowestTaxBracket}";
                        thrityTwoPercentBracketLabel.Text = $"Taxes owed at 32% tax bracket: ${marriedfifthTaxBracket}";
                        ThrityFiveTaxBracketLabel.Text = $"Taxes owed at 35% tax bracket: ${marriedsixthTaxBracket}";
                        ThirtySevenTaxBracketLabel.Text = $"Taxes owed at 37% tax bracket: ${(adjustedGrossIncome - marriedsixthTaxBracketCap) * marriedseventhTaxPercentage}";
                        totalTaxes += (adjustedGrossIncome - marriedsixthTaxBracketCap) * marriedseventhTaxPercentage;
                        break;
                }

                totalTaxesLabel.Text = $"Amount of total Taxes owed: ${totalTaxes}";
                percentageGrossIncome.Text = $"Taxes as percentage of gross income: {(totalTaxes / grossIncome) * 100}%";
                percentageAdjustedGrossIncome.Text = $"Taxes as percentage of adjusted gross income: {(totalTaxes / adjustedGrossIncome) * 100}%";
            }
        }
    }
}