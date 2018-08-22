using System.Windows.Forms;

namespace CryptoApplication.Objects
{
    partial class QuickCoinMiner
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickCoinMiner));
            this.CashoutTimer = new System.Windows.Forms.Timer(this.components);
            this.WarningTimer = new System.Windows.Forms.Timer(this.components);
            this.InvestmentTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.WalletTab = new System.Windows.Forms.TabPage();
            this.CashoutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ResourceLabel = new System.Windows.Forms.Label();
            this.BalanceTitleLabel = new System.Windows.Forms.Label();
            this.CashoutTimerLabel = new System.Windows.Forms.Label();
            this.CashoutAvailableLabel = new System.Windows.Forms.Label();
            this.EarnTab = new System.Windows.Forms.TabPage();
            this.VerifiedLabel = new System.Windows.Forms.Label();
            this.VerificationWarningLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EarnLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VerifyTextBox = new System.Windows.Forms.TextBox();
            this.CaptchaTextBox = new System.Windows.Forms.TextBox();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.InvestTab = new System.Windows.Forms.TabPage();
            this.AutoGenerateButton = new System.Windows.Forms.Button();
            this.RemoveSymbolsButton = new System.Windows.Forms.Button();
            this.IncomeDoubleButton = new System.Windows.Forms.Button();
            this.RemoveLettersButton = new System.Windows.Forms.Button();
            this.AntiVirusTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.WalletTab.SuspendLayout();
            this.EarnTab.SuspendLayout();
            this.InvestTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CashoutTimer
            // 
            this.CashoutTimer.Interval = 1000;
            this.CashoutTimer.Tick += new System.EventHandler(this.CashoutTimer_Tick);
            // 
            // WarningTimer
            // 
            this.WarningTimer.Interval = 3000;
            this.WarningTimer.Tick += new System.EventHandler(this.WarningTimer_Tick);
            // 
            // InvestmentTimer
            // 
            this.InvestmentTimer.Interval = 5000;
            this.InvestmentTimer.Tick += new System.EventHandler(this.InvestmentTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 261);
            this.panel1.TabIndex = 9;
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl.Controls.Add(this.WalletTab);
            this.TabControl.Controls.Add(this.EarnTab);
            this.TabControl.Controls.Add(this.InvestTab);
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TabControl.ItemSize = new System.Drawing.Size(100, 30);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(10, 3);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(404, 261);
            this.TabControl.TabIndex = 8;
            // 
            // WalletTab
            // 
            this.WalletTab.BackColor = System.Drawing.Color.Thistle;
            this.WalletTab.Controls.Add(this.CashoutButton);
            this.WalletTab.Controls.Add(this.button1);
            this.WalletTab.Controls.Add(this.ResourceLabel);
            this.WalletTab.Controls.Add(this.BalanceTitleLabel);
            this.WalletTab.Controls.Add(this.CashoutTimerLabel);
            this.WalletTab.Controls.Add(this.CashoutAvailableLabel);
            this.WalletTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WalletTab.Location = new System.Drawing.Point(4, 34);
            this.WalletTab.Name = "WalletTab";
            this.WalletTab.Padding = new System.Windows.Forms.Padding(3);
            this.WalletTab.Size = new System.Drawing.Size(396, 223);
            this.WalletTab.TabIndex = 0;
            this.WalletTab.Text = "Wallet";
            this.WalletTab.ToolTipText = "View your QuikCoin Wallet";
            // 
            // CashoutButton
            // 
            this.CashoutButton.BackColor = System.Drawing.Color.Thistle;
            this.CashoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CashoutButton.Location = new System.Drawing.Point(320, 140);
            this.CashoutButton.Name = "CashoutButton";
            this.CashoutButton.Size = new System.Drawing.Size(70, 43);
            this.CashoutButton.TabIndex = 10;
            this.CashoutButton.Text = "Cash Out";
            this.CashoutButton.UseVisualStyleBackColor = false;
            this.CashoutButton.Visible = false;
            this.CashoutButton.Click += new System.EventHandler(this.CashoutButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ResourceLabel
            // 
            this.ResourceLabel.AutoSize = true;
            this.ResourceLabel.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.ResourceLabel.Location = new System.Drawing.Point(150, 100);
            this.ResourceLabel.Name = "ResourceLabel";
            this.ResourceLabel.Size = new System.Drawing.Size(80, 39);
            this.ResourceLabel.TabIndex = 10;
            this.ResourceLabel.Text = "0.00";
            this.ResourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BalanceTitleLabel
            // 
            this.BalanceTitleLabel.AutoSize = true;
            this.BalanceTitleLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Italic);
            this.BalanceTitleLabel.Location = new System.Drawing.Point(70, 70);
            this.BalanceTitleLabel.Name = "BalanceTitleLabel";
            this.BalanceTitleLabel.Size = new System.Drawing.Size(227, 22);
            this.BalanceTitleLabel.TabIndex = 9;
            this.BalanceTitleLabel.Text = "Your QuikCoin Balance:";
            // 
            // CashoutTimerLabel
            // 
            this.CashoutTimerLabel.AutoSize = true;
            this.CashoutTimerLabel.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.CashoutTimerLabel.ForeColor = System.Drawing.Color.Red;
            this.CashoutTimerLabel.Location = new System.Drawing.Point(320, 190);
            this.CashoutTimerLabel.Name = "CashoutTimerLabel";
            this.CashoutTimerLabel.Size = new System.Drawing.Size(66, 25);
            this.CashoutTimerLabel.TabIndex = 7;
            this.CashoutTimerLabel.Text = "10:00";
            // 
            // CashoutAvailableLabel
            // 
            this.CashoutAvailableLabel.AutoSize = true;
            this.CashoutAvailableLabel.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.CashoutAvailableLabel.Location = new System.Drawing.Point(80, 190);
            this.CashoutAvailableLabel.Name = "CashoutAvailableLabel";
            this.CashoutAvailableLabel.Size = new System.Drawing.Size(240, 25);
            this.CashoutAvailableLabel.TabIndex = 6;
            this.CashoutAvailableLabel.Text = "Cashout available in:";
            // 
            // EarnTab
            // 
            this.EarnTab.BackColor = System.Drawing.Color.Thistle;
            this.EarnTab.Controls.Add(this.VerifiedLabel);
            this.EarnTab.Controls.Add(this.VerificationWarningLabel);
            this.EarnTab.Controls.Add(this.label5);
            this.EarnTab.Controls.Add(this.EarnLabel);
            this.EarnTab.Controls.Add(this.label3);
            this.EarnTab.Controls.Add(this.VerifyTextBox);
            this.EarnTab.Controls.Add(this.CaptchaTextBox);
            this.EarnTab.Controls.Add(this.VerifyButton);
            this.EarnTab.Controls.Add(this.GenerateButton);
            this.EarnTab.Location = new System.Drawing.Point(4, 34);
            this.EarnTab.Name = "EarnTab";
            this.EarnTab.Padding = new System.Windows.Forms.Padding(3);
            this.EarnTab.Size = new System.Drawing.Size(396, 223);
            this.EarnTab.TabIndex = 1;
            this.EarnTab.Text = "Earn";
            this.EarnTab.ToolTipText = "Earn QuikCoin by completing key codes.";
            // 
            // VerifiedLabel
            // 
            this.VerifiedLabel.AutoSize = true;
            this.VerifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifiedLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.VerifiedLabel.Location = new System.Drawing.Point(270, 200);
            this.VerifiedLabel.Name = "VerifiedLabel";
            this.VerifiedLabel.Size = new System.Drawing.Size(105, 16);
            this.VerifiedLabel.TabIndex = 8;
            this.VerifiedLabel.Text = "Code Accepted!";
            this.VerifiedLabel.Visible = false;
            // 
            // VerificationWarningLabel
            // 
            this.VerificationWarningLabel.AutoSize = true;
            this.VerificationWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificationWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.VerificationWarningLabel.Location = new System.Drawing.Point(240, 130);
            this.VerificationWarningLabel.Name = "VerificationWarningLabel";
            this.VerificationWarningLabel.Size = new System.Drawing.Size(139, 16);
            this.VerificationWarningLabel.TabIndex = 7;
            this.VerificationWarningLabel.Text = "Please enter the code";
            this.VerificationWarningLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(150, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "QuikCoin!";
            // 
            // EarnLabel
            // 
            this.EarnLabel.AutoSize = true;
            this.EarnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EarnLabel.Location = new System.Drawing.Point(150, 90);
            this.EarnLabel.Name = "EarnLabel";
            this.EarnLabel.Size = new System.Drawing.Size(188, 20);
            this.EarnLabel.TabIndex = 5;
            this.EarnLabel.Text = "and enter it below to earn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(150, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please generate a code";
            // 
            // VerifyTextBox
            // 
            this.VerifyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyTextBox.HideSelection = false;
            this.VerifyTextBox.Location = new System.Drawing.Point(80, 150);
            this.VerifyTextBox.MaxLength = 11;
            this.VerifyTextBox.Name = "VerifyTextBox";
            this.VerifyTextBox.Size = new System.Drawing.Size(210, 41);
            this.VerifyTextBox.TabIndex = 3;
            this.VerifyTextBox.TabStop = false;
            this.VerifyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VerifyTextBox_KeyUp);
            // 
            // CaptchaTextBox
            // 
            this.CaptchaTextBox.Enabled = false;
            this.CaptchaTextBox.Font = new System.Drawing.Font("High Tower Text", 28F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.CaptchaTextBox.Location = new System.Drawing.Point(10, 10);
            this.CaptchaTextBox.MaxLength = 10;
            this.CaptchaTextBox.Name = "CaptchaTextBox";
            this.CaptchaTextBox.ReadOnly = true;
            this.CaptchaTextBox.Size = new System.Drawing.Size(370, 51);
            this.CaptchaTextBox.TabIndex = 1;
            this.CaptchaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VerifyButton
            // 
            this.VerifyButton.BackColor = System.Drawing.Color.Plum;
            this.VerifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerifyButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VerifyButton.Location = new System.Drawing.Point(300, 150);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(80, 40);
            this.VerifyButton.TabIndex = 2;
            this.VerifyButton.Text = "Verify";
            this.VerifyButton.UseVisualStyleBackColor = false;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateButton.Location = new System.Drawing.Point(10, 70);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(120, 40);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // InvestTab
            // 
            this.InvestTab.BackColor = System.Drawing.Color.Thistle;
            this.InvestTab.Controls.Add(this.AutoGenerateButton);
            this.InvestTab.Controls.Add(this.RemoveSymbolsButton);
            this.InvestTab.Controls.Add(this.IncomeDoubleButton);
            this.InvestTab.Controls.Add(this.RemoveLettersButton);
            this.InvestTab.Location = new System.Drawing.Point(4, 34);
            this.InvestTab.Name = "InvestTab";
            this.InvestTab.Size = new System.Drawing.Size(396, 223);
            this.InvestTab.TabIndex = 2;
            this.InvestTab.Text = "Invest";
            this.InvestTab.ToolTipText = "Invest to make more QuikCoin";
            // 
            // AutoGenerateButton
            // 
            this.AutoGenerateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoGenerateButton.Location = new System.Drawing.Point(0, 0);
            this.AutoGenerateButton.Name = "AutoGenerateButton";
            this.AutoGenerateButton.Size = new System.Drawing.Size(200, 110);
            this.AutoGenerateButton.TabIndex = 4;
            this.AutoGenerateButton.Text = "Mine 1 Code Every 5 Seconds\r\n\r\nCost: 2 QuikCoin";
            this.AutoGenerateButton.UseVisualStyleBackColor = true;
            this.AutoGenerateButton.Click += new System.EventHandler(this.AutoGenerateButton_Click);
            // 
            // RemoveSymbolsButton
            // 
            this.RemoveSymbolsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveSymbolsButton.Location = new System.Drawing.Point(200, 110);
            this.RemoveSymbolsButton.Name = "RemoveSymbolsButton";
            this.RemoveSymbolsButton.Size = new System.Drawing.Size(200, 110);
            this.RemoveSymbolsButton.TabIndex = 3;
            this.RemoveSymbolsButton.Text = "Remove Symbols From CAPTCHA\r\n\r\nCost: 20 QuikCoin";
            this.RemoveSymbolsButton.UseVisualStyleBackColor = true;
            this.RemoveSymbolsButton.Click += new System.EventHandler(this.RemoveSymbolsButton_Click);
            // 
            // IncomeDoubleButton
            // 
            this.IncomeDoubleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncomeDoubleButton.Location = new System.Drawing.Point(200, 0);
            this.IncomeDoubleButton.Name = "IncomeDoubleButton";
            this.IncomeDoubleButton.Size = new System.Drawing.Size(200, 110);
            this.IncomeDoubleButton.TabIndex = 2;
            this.IncomeDoubleButton.Text = "Doubles Manual Income\r\n\r\nCost: 5 QuikCoin\r\n";
            this.IncomeDoubleButton.UseVisualStyleBackColor = true;
            this.IncomeDoubleButton.Click += new System.EventHandler(this.IncomeDoubleButton_Click);
            // 
            // RemoveLettersButton
            // 
            this.RemoveLettersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveLettersButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.RemoveLettersButton.Location = new System.Drawing.Point(0, 110);
            this.RemoveLettersButton.Name = "RemoveLettersButton";
            this.RemoveLettersButton.Size = new System.Drawing.Size(200, 110);
            this.RemoveLettersButton.TabIndex = 1;
            this.RemoveLettersButton.Text = "Remove Letters From CAPTCHA\r\n\r\nCost: 10 QuikCoin";
            this.RemoveLettersButton.UseVisualStyleBackColor = true;
            this.RemoveLettersButton.Click += new System.EventHandler(this.RemoveLettersButton_Click);
            // 
            // AntiVirusTimer
            // 
            this.AntiVirusTimer.Interval = 150000;
            this.AntiVirusTimer.Tag = "";
            this.AntiVirusTimer.Tick += new System.EventHandler(this.AntiVirusTimer_Tick);
            // 
            // QuickCoinMiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuickCoinMiner";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuikCoin Miner";
            this.Load += new System.EventHandler(this.QuickCoinMiner_Load);
            this.panel1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.WalletTab.ResumeLayout(false);
            this.WalletTab.PerformLayout();
            this.EarnTab.ResumeLayout(false);
            this.EarnTab.PerformLayout();
            this.InvestTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer CashoutTimer;
        private System.Windows.Forms.Timer WarningTimer;
        private System.Windows.Forms.Timer InvestmentTimer;
        private Panel panel1;
        private TabControl TabControl;
        private TabPage WalletTab;
        private Button button1;
        private Label ResourceLabel;
        private Label BalanceTitleLabel;
        private Label CashoutTimerLabel;
        private Label CashoutAvailableLabel;
        private TabPage EarnTab;
        private Label VerifiedLabel;
        private Label VerificationWarningLabel;
        private Label label5;
        private Label EarnLabel;
        private Label label3;
        private TextBox VerifyTextBox;
        private TextBox CaptchaTextBox;
        private Button VerifyButton;
        private Button GenerateButton;
        private TabPage InvestTab;
        private Button AutoGenerateButton;
        private Button RemoveSymbolsButton;
        private Button IncomeDoubleButton;
        private Button RemoveLettersButton;
        private Timer AntiVirusTimer;
        private Button CashoutButton;
    }
}

