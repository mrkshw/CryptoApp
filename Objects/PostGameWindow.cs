using System;
using System.Windows.Forms;

namespace CryptoApplication.Objects
{
    public partial class PostGameWindow : Form
    {
        private readonly Wallet _wallet;
        private readonly int _codeCount;
        private readonly int _upgradeCount;

        public PostGameWindow(Wallet wallet, int codeCount, int upgradeCount)
        {
            _codeCount = codeCount;
            _wallet = wallet;
            _upgradeCount = upgradeCount;
            InitializeComponent();
        }

        private void PostGameWindow_Load(object sender, EventArgs e)
        {

            var ransomText = _wallet.HackSuccessful
                ? "You fell victim to a ransomware attack."
                : "You managed to evade all ransomware attacks.";
            var protectionText = _wallet.IsProtected
                ? "You decided to buy ransomware protection."
                : "You did not decide to buy ransomware protection.";




            GameSummaryLabel.Text = "You were able to make \n" +
                                    _wallet.Balance + " QuikCoin, by entering " + _codeCount + " codes. \n" +
                                    "\n" + ransomText + "\n" +
                                    "\n" + protectionText + "\n" +
                                    "\nYou purchased " + _upgradeCount + " upgrade(s)."
                                    ;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/windows/security/threat-protection/windows-defender-exploit-guard/enable-controlled-folders-exploit-guard");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://us.norton.com/internetsecurity-malware-ransomware.html");
        }
    }
}
