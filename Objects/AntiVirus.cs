using System;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoApplication.Objects
{
    /// <summary>
    /// Partial class that contains the user-generated code for the AntiVirus Windows Form.
    /// 
    ///
    /// </summary>
    public partial class AntiVirus : Form
    {
        // Instance variables that are to be used to regulate payment of the AntiVirus Service.
        private readonly Label _mainResourceLabel;
        private readonly Virus _virus;
        private readonly Wallet _wallet;

        // Fields to control the scrolling of the form.
        private int _scrollDownIndex;
        private int _scrollUpIndex;

        /// <summary>
        /// Constructor for the AntiVirus Object. 
        /// </summary>
        /// <param name="w">Wallet - The wallet to be used by the antivirus program to take payment.</param>
        /// <param name="mainResourceLabel"></param>
        /// <param name="virus"></param>
        public AntiVirus(Wallet w, Label mainResourceLabel, Virus virus)
        {
            _wallet = w;
            _mainResourceLabel = mainResourceLabel;
            _virus = virus;
            InitializeComponent();
            _scrollDownIndex = Height;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AntiVirus_Load(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width,
                Screen.PrimaryScreen.WorkingArea.Height);
            scrollUpTimer.Start();
            FadeIn(this, 50);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="o"></param>
        /// <param name="interval"></param>
        private static async void FadeIn(Form o, int interval)
        {
            //Object is not fully invisible. Fade it in
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }

            o.Opacity = 1; //make fully visible       
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="o"></param>
        /// <param name="interval"></param>
        private static async void FadeOut(Form o, int interval)
        {
            //Object is fully visible. Fade it out
            while (o.Opacity > 0.0)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }

            o.Opacity = 0; //make fully invisible       
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcceptButtonClick(object sender, EventArgs e)
        {
            if (_virus.IsActive)
            {
            }
            else
            {
                if (MessageBox.Show(
                        "This protection will cost you 15 QuikCoin. If you accept, it will be deducted automatically. Are you sure?",
                        "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (_wallet.Balance < 15)
                {
                    MessageBox.Show("Sorry, you do not have enough QuikCoin for this purchase.");
                    return;
                }
                _wallet.IsProtected = true;
                _wallet.Balance -= 15;
                _mainResourceLabel.Text = _wallet.Balance.ToString(CultureInfo.InvariantCulture);
                ScrollDownTimer.Start();
                FadeOut(this, 100);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeclineButtonClick(object sender, EventArgs e)
        {
            ScrollDownTimer.Start();
            FadeOut(this, 100);
            ReminderTimer.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollUpTimer_Tick(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width,
                Screen.PrimaryScreen.WorkingArea.Height - _scrollUpIndex);
            _scrollUpIndex += 5;

            if (_scrollUpIndex < Height) return;
            scrollUpTimer.Stop();
            _scrollUpIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollDownTimer_Tick(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width,
                Screen.PrimaryScreen.WorkingArea.Height - _scrollDownIndex);

            _scrollDownIndex -= 5;

            if (_scrollDownIndex > 0) return;
            ScrollDownTimer.Stop();
            _scrollDownIndex = Height;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("By closing this window, will not be offered security again. Are you sure?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            ScrollDownTimer.Start();
            FadeOut(this, 50);
            Hide();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            if (_virus.IsActive) return;
            FadeIn(this, 100);
            scrollUpTimer.Start();
            ReminderTimer.Stop();
        }
    }
}