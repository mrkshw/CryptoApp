using System;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CryptoApplication.Objects;

namespace CryptoApplication
{
    public partial class QuickCoinMiner : Form
    {
        static Wallet _wallet;
        private static Virus _virus;

        private static string balanceAsStaticString
        {
            get
            {
                return _wallet.Balance.ToString();

            }
            set
            {
                resourceLabel.Text 
            }
        }

        // Class Fields
        private int MinutesLeft { get; set; } = 10;
        private int SecondsLeft { get; set; }
        private static readonly Random Random = new Random();

        private bool _incomeDoubled;
        private bool _symbolsRemoved;
        private bool _lettersRemoved; 
  
        // Currently generated code
        private string _generatedCode;


        private void QuickCoinMiner_Load(object sender, EventArgs e)
        {
            _wallet = new Wallet(this);
            _virus = new Virus(_wallet);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"E:\Users\Shaw\Desktop\C#\CryptoApplication\CryptoApplication\Resources\Static-2.ttf");
            captchaTextBox.Font = new Font(pfc.Families[0], 27, FontStyle.Regular);
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
            {
                charsToUse = numbers;
            } else

            // If symbols are NOT removed and letters are NOT removed
            if (!_symbolsRemoved && !_lettersRemoved)
            {
                charsToUse = numbers + letters + symbols;
            } else

            // If symbols ARE removed and letters are NOT removed
            if (_symbolsRemoved && !_lettersRemoved)
            {
                charsToUse = numbers + letters;
            } else

            // if symbols are NOT removed and letters ARE removed
            if (!_symbolsRemoved && _lettersRemoved)
            {
                charsToUse = numbers + symbols;
            }
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
                captchaTextBox.Text = _generatedCode;
        }
    
        //Constructor
        public QuickCoinMiner()
        {
            InitializeComponent();
            cashoutTimer.Start();
        }


        // Simple 10 Minute clock method
        private void cashoutTimer_Tick(object sender, EventArgs e)
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
            {
                cashoutTimerLabel.Text = MinutesLeft + ":0" + SecondsLeft;
            }
            else
            {
                cashoutTimerLabel.Text = MinutesLeft + ":" + SecondsLeft;
            }

            if (MinutesLeft == 0 && SecondsLeft == 0)
            {
                cashoutTimer.Stop();
                MessageBox.Show("Time's up! You made " + _wallet.Balance.ToString() + " QuikCoin.");
            }            
        }

        /**
         * Method to handle the event of a the "generate" button being pressed.
         * Generates a new code.
         */
        private void generateButton_Click(object sender, EventArgs e)
        {
            GenerateCode();
        }


        private void verifyButton_Click(object sender, EventArgs e)
        {
            if (_generatedCode == null)
            {
                GenerateCode();
                captchaTextBox.Text = _generatedCode;
                MessageBox.Show("You hadn't generated a code yet, " +
                                "a new one has been generated for you.");
            }
            else
            {
                var userInput = verifyTextBox.Text;

                if (_generatedCode.Equals(userInput))
                {
                    if (_incomeDoubled)
                    {
                        _wallet.IncreaseBalance();
                        _wallet.IncreaseBalance();
                    }
                    else
                    {
                        _wallet.IncreaseBalance();
                    }

                    resourceLabel.Text = _wallet.Balance.ToString();
                    GenerateCode();
                    verifiedLabel.Visible = true;
                    warningTimer.Start();
                    verifyTextBox.Text = "";
                    return;
                }

                verificationWarningLabel.Text = "Incorrect Code";
                verifyTextBox.Text = "";
                verificationWarningLabel.Visible = true;
                warningTimer.Start();
            }
        }

        private void warningTimer_Tick(object sender, EventArgs e)
        {
            verificationWarningLabel.Visible = false;
            verifiedLabel.Visible = false;
            warningTimer.Stop();
        }

   
        private void investmentTimer_Tick(object sender, EventArgs e)
        {
            _wallet.IncreaseBalance();
            resourceLabel.Text = _wallet.Balance.ToString();
        }


        private void verifyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                verifyButton.PerformClick();
            }
        }

        private void AutoGenerateButton_Click(object sender, EventArgs e)
        {
            if (_wallet.Balance < 2)
            {
                return;
            }
            _wallet.Balance -= 2;
            resourceLabel.Text = _wallet.Balance.ToString(CultureInfo.InvariantCulture);
            autoGenerateButton.Enabled = false;
            autoGenerateButton.Text = "Generate 1 Code Every 5 Seconds\r\n\r\nPurchased!";
            investmentTimer.Start();
            MessageBox.Show("Investment Successful.");
        }

        private void IncomeDoubleButton_Click(object sender, EventArgs e)
        {
            if (_wallet.Balance < 5)
            {
                return;
            }
            _wallet.Balance -= 5;
            resourceLabel.Text = _wallet.Balance.ToString(CultureInfo.InvariantCulture);
            _incomeDoubled = true;
            incomeDoubleButton.Enabled = false;
            autoGenerateButton.Text = "Doubles Manual Income\r\n\r\nPurchased!";
            investmentTimer.Start();
            MessageBox.Show("Investment Successful.");
        }

        private void RemoveLettersButton_Click(object sender, EventArgs e)
        {
            if (_wallet.Balance == 10)
            {
                return;
            }
            _wallet.Balance -= 10;
            resourceLabel.Text = _wallet.Balance.ToString(CultureInfo.InvariantCulture);
            _lettersRemoved = true;
            removeLettersButton.Text = "Remove Letters\r\n\r\n\r\nPurchased!";
            removeLettersButton.Enabled = false;
            MessageBox.Show("Investment Successful.");

        }

        private void RemoveSymbolsButton_Click(object sender, EventArgs e)
        {
            if (_wallet.Balance < 20)
            {
                return;
            }
            _wallet.Balance -= 20;
            resourceLabel.Text = _wallet.Balance.ToString(CultureInfo.InvariantCulture);
            _symbolsRemoved = true;
            removeSymbolsButton.Text = "Remove Symbols\r\n\r\n\r\nPurchased!";
            removeSymbolsButton.Enabled = false;
            MessageBox.Show("Investment Successful.");            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _wallet.IncreaseBalance();
            resourceLabel.Text = _wallet.Balance.ToString();
        }

        internal void finalizeDecision()
        {
            if (Virus.intendToPay)
            {
                var random = new Random();
                var randomInt = random.Next(1, 100);

                var honestHack = (randomInt > 20) ? true : false;

                if (!honestHack)
                {
                    _wallet.Balance = 0;
                    resourceLabel.Text = _wallet.Balance.ToString();
                    MessageBox.Show("Sorry the hacker did not decide to refund what was stolen. You have lost everything.");
                }
                else if (honestHack)
                {
                    MessageBox.Show(
                        "You paid the ransom, and the hacker stayed true to his word. He has only deducted 20 QuikCoin.");
                }

            } else if (!Virus.intendToPay)
            {
                MessageBox.Show("You decided to start from scratch, accepting what was stolen as a loss.");
                
            }
            _virus.Hide();
        }
    }
}
