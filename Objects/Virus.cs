using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace CryptoApplication.Objects
{
    public partial class Virus : Form
    {


        private int HackAttempt = 0;
        private int HackProbability = 0;
        private Wallet Wallet { get; }

        private Label mainResourceLabel;

        private int secondsLeft = 30;
        internal static bool intendToPay = false;

        public Virus(Wallet wallet, Label resourceLabel)
        {
            mainResourceLabel = resourceLabel;
          
            Wallet = wallet;
            InitializeComponent();
            hackTimer.Start();
        }


        private string _ransomLabelText;

        private int count = 0;

        private bool Hack()
        {
            if (Wallet.IsEncrypted) return false;
            HackAttempt++;

            Random random = new Random();
            int randNumber = random.Next(0, 100) + 11;


            if (randNumber < HackProbability)
            {
                Wallet.IsEncrypted = true;
                return true;

            }
            else
            {
                if (HackAttempt < 5)
                {
                    HackProbability += 1;
                }
                else
                {
                    HackProbability += 5;
                }
            }
            return false;
        }

        private void Virus_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"E:\Users\Shaw\Desktop\C#\CryptoApplication\CryptoApplication\Resources\earwig factory rg.ttf");
            firstLineLabel.Font = new Font(pfc.Families[0], 25, FontStyle.Regular);
            _ransomLabelText = firstLineLabel.Text;
            firstLineLabel.Text = "_";
            writingTimer.Start();
            decisionLabel.Text = "";
            mainResourceLabel.Text = "ENCRYPTED!";
        }

        private void writingTimer_Tick(object sender, EventArgs e)
        {
            count++;

            if (count > _ransomLabelText.Length)
            {
                writingTimer.Stop();
                countdownTimer.Start();
            }

            else
                firstLineLabel.Text = _ransomLabelText.Substring(0, count);
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            secondsLeft--;
            secondsLeftLabel.Text = secondsLeft.ToString();
            if (secondsLeft == 0)
            {
                countdownTimer.Stop();
                CalculateOutcome();
            }
        }

        private void CalculateOutcome()
        {
            if (intendToPay)
            {
                var random = new Random();
                var randomInt = random.Next(1, 100);
                var honestHack = (randomInt > 20) ? true : false;

                if (!honestHack)
                {
                    Wallet.Balance = 0;
                    mainResourceLabel.Text = Wallet.Balance.ToString();
                    MessageBox.Show("Sorry the hacker did not decide to refund what was stolen. You have lost everything.");
                }
                else if (honestHack)
                {
                    Wallet.Balance -= 20;
                    mainResourceLabel.Text = Wallet.Balance.ToString();
                    MessageBox.Show(
                        "You paid the ransom, and the hacker stayed true to his word. He has only deducted 20 QuikCoin.");
                }

            }
            else if (!intendToPay)
            {
                Wallet.Balance = 0;
                mainResourceLabel.Text = Wallet.Balance.ToString();
                MessageBox.Show("You decided to start from scratch, accepting what was stolen as a loss.");

            }
            Hide();
        }

        private void payRansomButton_Click(object sender, EventArgs e)
        {
            intendToPay = true;
            decisionLabel.Text = decisionLabel.Text == "" ? "You will pay the ransom."
                                                          : "Instead, you will pay the ransom.";
        }

        private void refuseButton_Click(object sender, EventArgs e)
        {
            intendToPay = false;
            decisionLabel.Text = decisionLabel.Text == "" ? "You will not pay the ransom."
                                                          : "Instead, you will not pay the ransom.";
        }

        private void ResetHack()
        {
            HackAttempt = 0;
            HackProbability = 0;
        }

        private void hackTimer_Tick(object sender, EventArgs e)
        {
            var hackSuccessful = Hack();
            if (!hackSuccessful) return;
            hackTimer.Stop();
            ResetHack();
            this.Show();
        }
    }
}
