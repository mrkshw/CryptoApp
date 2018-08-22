using System;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace CryptoApplication.Objects
{
    public partial class Virus : Form
    {
        private Wallet Wallet { get; }
        public bool IsActive { get; set; }
        internal static bool IntendToPay { get; set; }

        private readonly Label _mainResourceLabel;
        private readonly TextBox _userInputTextBox;
        private readonly Timer _investmentTimer;
        private readonly bool _investUpgradeBought;

        private int _count;
        private int _hackAttempt;
        private int _hackProbability;
        private int _secondsLeft = 30;

        private string _ransomLabelText;

        public Virus(Wallet wallet, Label resourceLabel, TextBox userInput, Timer investTimer, bool investmentUpgrade)
        {
            _mainResourceLabel = resourceLabel;
            _userInputTextBox = userInput;
            _investmentTimer = investTimer;
            _investUpgradeBought = investmentUpgrade;
            Wallet = wallet;
            InitializeComponent();
            hackTimer.Start();
        }

        
       

        private bool Hack()
        {
            if (Wallet.IsEncrypted) return false;
            _hackAttempt++;

            var random = new Random();
            var randNumber = random.Next(0, 100) + 11;


            if (randNumber < _hackProbability)
            {
                Wallet.IsEncrypted = true;
                return true;
            }

            if (_hackAttempt < 5)
                _hackProbability += 1;
            else
                _hackProbability += 5;
            return false;
        }

        private void Virus_Load(object sender, EventArgs e)
        {
            //var pfc = new PrivateFontCollection();
            //pfc.AddFontFile(
            //    @"E:\Users\Shaw\Desktop\C#\CryptoApplication\CryptoApplication\Resources\earwig factory rg.ttf");
            //RansomLabel.Font = new Font(pfc.Families[0], 25, FontStyle.Regular);
            _ransomLabelText = RansomLabel.Text;
            RansomLabel.Text = "_";
            writingTimer.Start();
            DecisionLabel.Text = "";
            _mainResourceLabel.Text = "ENCRYPTED!";
        }

        private void WritingTimer_Tick(object sender, EventArgs e)
        {
            _count++;

            if (_count > _ransomLabelText.Length)
            {
                writingTimer.Stop();
                countdownTimer.Start();
                PayRansomButton.Enabled = true;
                RefuseButton.Enabled = true;
            }

            else
            {
                RansomLabel.Text = _ransomLabelText.Substring(0, _count);
            }
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            _secondsLeft--;
            SecondsLeftLabel.Text = _secondsLeft.ToString();
            if (_secondsLeft != 0) return;
            countdownTimer.Stop();
            CalculateOutcome();
        }


        private void CalculateOutcome()
        {
            if (IntendToPay)
            {
                var random = new Random();
                var randomInt = random.Next(1, 100);
                var honestHack = randomInt > 20;

                if (!honestHack)
                {
                    Wallet.Balance = 0;
                    _mainResourceLabel.Text = Wallet.Balance.ToString(CultureInfo.CurrentCulture);
                    MessageBox.Show(
                        "Sorry the hacker did not decide to refund what was stolen. You have lost everything.");
                }
                else
                {
                    Wallet.Balance -= 20;
                    _mainResourceLabel.Text = Wallet.Balance.ToString(CultureInfo.CurrentCulture);
                    MessageBox.Show(
                        "You paid the ransom, and the hacker stayed true to his word. He has only deducted 20 QuikCoin.");
                }
            }
            else if (!IntendToPay)
            {
                Wallet.Balance = 0;
                _mainResourceLabel.Text = Wallet.Balance.ToString(CultureInfo.CurrentCulture);
                MessageBox.Show("You decided to start from scratch, accepting what was stolen as a loss.");
            }

            IsActive = false;
            _userInputTextBox.Enabled = true;
            if (_investUpgradeBought)
                _investmentTimer.Start();
            Hide();
        }

        private void PayRansomButton_Click(object sender, EventArgs e)
        {
            IntendToPay = true;
            DecisionLabel.Text = DecisionLabel.Text == ""
                ? "You will pay the ransom."
                : "Instead, you will pay the ransom.";
        }

        private void RefuseButton_Click(object sender, EventArgs e)
        {
            IntendToPay = false;
            DecisionLabel.Text = DecisionLabel.Text == ""
                ? "You will not pay the ransom."
                : "Instead, you will not pay the ransom.";
        }

        private void ResetHack()
        {
            _hackAttempt = 0;
            _hackProbability = 0;
        }

        private void HackTimer_Tick(object sender, EventArgs e)
        {      
            var hackSuccessful = Hack();
            if (!hackSuccessful) return;
            ConfirmHack();
        }

        private void ConfirmHack()
        {
            if (Wallet.IsProtected)
            {
                MessageBox.Show("QuikSave has just blocked a ransomware attack. Your wallet is safe.");
                hackTimer.Stop();
                return;
            }

            if (_investmentTimer.Enabled)
            {
                _investmentTimer.Stop();
            }
            _userInputTextBox.Enabled = false;
            Wallet.HackSuccessful = true;
            IsActive = true;
            hackTimer.Stop();
            ResetHack();
            Show();
        }
    }
}