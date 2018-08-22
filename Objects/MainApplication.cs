using System;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CryptoApplication.Objects
{
    public partial class QuickCoinMiner : Form
    {
        private static Wallet _wallet;
        private static Virus _virus;
        private static AntiVirus _antiVirus;
        private static readonly Random Random = new Random();

        // Statistics for end screen
        private int _codeCount;
        private int _upgradeCount;

        // Currently generated code
        private string _generatedCode;

        // Upgrade booleans
        private bool _investmentBought;
        private bool _incomeDoubled;
        private bool _lettersRemoved;
        private bool _symbolsRemoved;

        // Timer booleans
        private int MinutesLeft { get; set; } = 10;
        private int SecondsLeft { get; set; }

        /**
         * Constructor
         */
        public QuickCoinMiner()
        {
            InitializeComponent();
            CashoutTimer.Start();
        }




        private void QuickCoinMiner_Load(object sender, EventArgs e)
        {
            _wallet = new Wallet();
            _virus = new Virus(_wallet, ResourceLabel, VerifyTextBox, InvestmentTimer, _investmentBought);
            _antiVirus = new AntiVirus(_wallet, ResourceLabel, _virus);
            _upgradeCount = 0;
            //var pfc = new PrivateFontCollection();
            //pfc.AddFontFile(@"E:\Users\Shaw\Desktop\C#\CryptoApplication\CryptoApplication\Resources\Static-2.ttf");
            //CaptchaTextBox.Font = new Font(pfc.Families[0], 27, FontStyle.Regular);
            AntiVirusTimer.Start();
        }

        /**
         * Method to generate random alphanumeric string with symbols.
         */
        public string BuildCode(int length)
        {
            const string letters = "ACDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "012346789";
            const string symbols = "!$&()+=[]?/";

            var charsToUse = "";

            // If symbols ARE removed and letters ARE removed
            if (_symbolsRemoved && _lettersRemoved)
                charsToUse = numbers;
            else
                // If symbols are NOT removed and letters are NOT removed
            if (!_symbolsRemoved && !_lettersRemoved)
                charsToUse = numbers + letters + symbols;
            else
                // If symbols ARE removed and letters are NOT removed
            if (_symbolsRemoved && !_lettersRemoved)
                charsToUse = numbers + letters;
            else

                // if symbols are NOT removed and letters ARE removed
            if (!_symbolsRemoved && _lettersRemoved) charsToUse = numbers + symbols;
            return new string(Enumerable.Repeat(charsToUse, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        /**
         * Method to generate a code for the user to verify.
         *
         * Format of the code is as follows:
         *
         * XXXX-XXXX
         *
         * Where X's are numbers, symbols, or letters, depending on unlocks.
         */
        private void GenerateCode()
        {
            var newCode = BuildCode(5) + "-" + BuildCode(5);
            _generatedCode = newCode;
            CaptchaTextBox.Text = _generatedCode;
        }


        // Simple 10 Minute clock method
        private void CashoutTimer_Tick(object sender, EventArgs e)
        {
            if (SecondsLeft == 0)
            {
                MinutesLeft--;
                SecondsLeft = 59;
            }
            else
            {
                SecondsLeft--;
            }

            if (SecondsLeft < 10)
                CashoutTimerLabel.Text = MinutesLeft + ":0" + SecondsLeft;
            else
                CashoutTimerLabel.Text = MinutesLeft + ":" + SecondsLeft;

            if (MinutesLeft != 0 || SecondsLeft != 0) return;
            CashoutTimer.Stop();
            InvestmentTimer.Stop();
            VerifyTextBox.Enabled = false;
            CashoutButton.Visible = true;
        }

        /**
         * Method to handle the event of a the "generate" button being pressed.
         * Generates a new code.
         */
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateCode();
        }

        /**
         * Method to handle the event the "verify" button being pressed.
         *
         * Verifies the user entered code against the pre-generated one.
         * If the codes match, the user is rewarded with some cryptocurrency.
         * This reward is dependent on certain upgrades.
         */
        private void VerifyButton_Click(object sender, EventArgs e)
        {
            if (_generatedCode == null)
            {
                GenerateCode();
                CaptchaTextBox.Text = _generatedCode;
                MessageBox.Show("You hadn't generated a code yet, " +
                                "a new one has been generated for you.");
            }
            else
            {
                var userInput = VerifyTextBox.Text;

                if (_generatedCode.Equals(userInput.ToUpper()))
                {
                    // If upgrade purchased, increase balance twice.
                    if (_incomeDoubled)
                    {
                        _wallet.IncreaseBalance();
                        _wallet.IncreaseBalance();
                    }
                    else
                    {
                        _wallet.IncreaseBalance();
                    }

                    _codeCount++;
                    ResourceLabel.Text = _wallet.Balance.ToString(CultureInfo.InvariantCulture);
                    GenerateCode();
                    VerifiedLabel.Visible = true;
                    WarningTimer.Start();
                    VerifyTextBox.Text = "";
                    return;
                }

                //If the code is incorrect, generate a new one.
                VerificationWarningLabel.Text = "Incorrect Code";
                VerifyTextBox.Text = "";
                VerificationWarningLabel.Visible = true;
                WarningTimer.Start();
            }
        }

       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WarningTimer_Tick(object sender, EventArgs e)
        {
            VerificationWarningLabel.Visible = false;
            VerifiedLabel.Visible = false;
            WarningTimer.Stop();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvestmentTimer_Tick(object sender, EventArgs e)
        {
            _wallet.IncreaseBalance();
            ResourceLabel.Text = _wallet.Balance.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerifyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) VerifyButton.PerformClick();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoGenerateButton_Click(object sender, EventArgs e)
        {
            if (_wallet.Balance < 2) return;
            _upgradeCount++;
            _wallet.Balance -= 2;
            ResourceLabel.Text = _wallet.Balance.ToString(CultureInfo.InvariantCulture);
            AutoGenerateButton.Enabled = false;
            AutoGenerateButton.Text = "Generate 1 Code Every 5 Seconds\r\n\r\nPurchased!";
            InvestmentTimer.Start();
            _investmentBought = true;
            MessageBox.Show("Investment Successful.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IncomeDoubleButton_Click(object sender, EventArgs e)
        {
            if (_wallet.Balance < 5) return;
            _upgradeCount++;
            _wallet.Balance -= 5;
            ResourceLabel.Text = _wallet.Balance.ToString(CultureInfo.InvariantCulture);
            _incomeDoubled = true;
            IncomeDoubleButton.Enabled = false;
            AutoGenerateButton.Text = "Doubles Manual Income\r\n\r\nPurchased!";
            InvestmentTimer.Start();
            MessageBox.Show("Investment Successful.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveLettersButton_Click(object sender, EventArgs e)
        {
            if (_wallet.Balance == 10) return;
            _upgradeCount++;
            _wallet.Balance -= 10;
            ResourceLabel.Text = _wallet.Balance.ToString(CultureInfo.InvariantCulture);
            _lettersRemoved = true;
            RemoveLettersButton.Text = "Remove Letters\r\n\r\n\r\nPurchased!";
            RemoveLettersButton.Enabled = false;
            MessageBox.Show("Investment Successful.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveSymbolsButton_Click(object sender, EventArgs e)
        {
            if (_wallet.Balance < 20) return;
            _upgradeCount++;
            _wallet.Balance -= 20;
            ResourceLabel.Text = _wallet.Balance.ToString(CultureInfo.InvariantCulture);
            _symbolsRemoved = true;
            RemoveSymbolsButton.Text = "Remove Symbols\r\n\r\n\r\nPurchased!";
            RemoveSymbolsButton.Enabled = false;
            MessageBox.Show("Investment Successful.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            _wallet.IncreaseBalance();
            ResourceLabel.Text = _wallet.Balance.ToString(CultureInfo.CurrentCulture);
            CashoutButton.Visible = true;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AntiVirusTimer_Tick(object sender, EventArgs e)
        {
            if (_virus.IsActive) return;
            _antiVirus.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashoutButton_Click(object sender, EventArgs e)
        {

            Hide();
            var postGameWindow = new PostGameWindow(_wallet, _codeCount, _upgradeCount);
            postGameWindow.Closed += (s, args) => this.Close();
            _virus.hackTimer.Stop();
            AntiVirusTimer.Stop();
            postGameWindow.Show();                 
        }
    }
}