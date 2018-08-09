using System.Drawing;
using System.Windows.Forms;
using CryptoApplication.Objects;

namespace CryptoApplication
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
            this.cashoutTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.warningTimer = new System.Windows.Forms.Timer(this.components);
            this.investmentTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.walletTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.resourceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cashoutTimerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.earnTab = new System.Windows.Forms.TabPage();
            this.verifiedLabel = new System.Windows.Forms.Label();
            this.verificationWarningLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.verifyTextBox = new System.Windows.Forms.TextBox();
            this.captchaTextBox = new System.Windows.Forms.TextBox();
            this.verifyButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.investTab = new System.Windows.Forms.TabPage();
            this.autoGenerateButton = new System.Windows.Forms.Button();
            this.removeSymbolsButton = new System.Windows.Forms.Button();
            this.incomeDoubleButton = new System.Windows.Forms.Button();
            this.removeLettersButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.walletTab.SuspendLayout();
            this.earnTab.SuspendLayout();
            this.investTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // cashoutTimer
            // 
            this.cashoutTimer.Interval = 1000;
            this.cashoutTimer.Tick += new System.EventHandler(this.cashoutTimer_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Generate a code";
            // 
            // warningTimer
            // 
            this.warningTimer.Interval = 3000;
            this.warningTimer.Tick += new System.EventHandler(this.warningTimer_Tick);
            // 
            // investmentTimer
            // 
            this.investmentTimer.Interval = 5000;
            this.investmentTimer.Tick += new System.EventHandler(this.investmentTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 261);
            this.panel1.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.walletTab);
            this.tabControl1.Controls.Add(this.earnTab);
            this.tabControl1.Controls.Add(this.investTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 261);
            this.tabControl1.TabIndex = 8;
            // 
            // walletTab
            // 
            this.walletTab.BackColor = System.Drawing.SystemColors.Control;
            this.walletTab.Controls.Add(this.button1);
            this.walletTab.Controls.Add(this.resourceLabel);
            this.walletTab.Controls.Add(this.label2);
            this.walletTab.Controls.Add(this.cashoutTimerLabel);
            this.walletTab.Controls.Add(this.label1);
            this.walletTab.Location = new System.Drawing.Point(4, 34);
            this.walletTab.Name = "walletTab";
            this.walletTab.Padding = new System.Windows.Forms.Padding(3);
            this.walletTab.Size = new System.Drawing.Size(396, 223);
            this.walletTab.TabIndex = 0;
            this.walletTab.Text = "Wallet";
            this.walletTab.ToolTipText = "View your QuikCoin Wallet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resourceLabel
            // 
            this.resourceLabel.AutoSize = true;
            this.resourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.resourceLabel.Location = new System.Drawing.Point(150, 100);
            this.resourceLabel.Name = "resourceLabel";
            this.resourceLabel.Size = new System.Drawing.Size(80, 37);
            this.resourceLabel.TabIndex = 10;
            this.resourceLabel.Text = "0.00";
            this.resourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(70, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Your QuikCoin Balance:";
            // 
            // cashoutTimerLabel
            // 
            this.cashoutTimerLabel.AutoSize = true;
            this.cashoutTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cashoutTimerLabel.ForeColor = System.Drawing.Color.Red;
            this.cashoutTimerLabel.Location = new System.Drawing.Point(320, 190);
            this.cashoutTimerLabel.Name = "cashoutTimerLabel";
            this.cashoutTimerLabel.Size = new System.Drawing.Size(66, 26);
            this.cashoutTimerLabel.TabIndex = 7;
            this.cashoutTimerLabel.Text = "10:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(110, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cashout available in:";
            // 
            // earnTab
            // 
            this.earnTab.Controls.Add(this.verifiedLabel);
            this.earnTab.Controls.Add(this.verificationWarningLabel);
            this.earnTab.Controls.Add(this.label5);
            this.earnTab.Controls.Add(this.label4);
            this.earnTab.Controls.Add(this.label3);
            this.earnTab.Controls.Add(this.verifyTextBox);
            this.earnTab.Controls.Add(this.captchaTextBox);
            this.earnTab.Controls.Add(this.verifyButton);
            this.earnTab.Controls.Add(this.generateButton);
            this.earnTab.Location = new System.Drawing.Point(4, 34);
            this.earnTab.Name = "earnTab";
            this.earnTab.Padding = new System.Windows.Forms.Padding(3);
            this.earnTab.Size = new System.Drawing.Size(396, 223);
            this.earnTab.TabIndex = 1;
            this.earnTab.Text = "Earn";
            this.earnTab.ToolTipText = "Earn QuikCoin by completing key codes.";
            this.earnTab.UseVisualStyleBackColor = true;
            // 
            // verifiedLabel
            // 
            this.verifiedLabel.AutoSize = true;
            this.verifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifiedLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.verifiedLabel.Location = new System.Drawing.Point(270, 200);
            this.verifiedLabel.Name = "verifiedLabel";
            this.verifiedLabel.Size = new System.Drawing.Size(105, 16);
            this.verifiedLabel.TabIndex = 8;
            this.verifiedLabel.Text = "Code Accepted!";
            this.verifiedLabel.Visible = false;
            // 
            // verificationWarningLabel
            // 
            this.verificationWarningLabel.AutoSize = true;
            this.verificationWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificationWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.verificationWarningLabel.Location = new System.Drawing.Point(240, 130);
            this.verificationWarningLabel.Name = "verificationWarningLabel";
            this.verificationWarningLabel.Size = new System.Drawing.Size(139, 16);
            this.verificationWarningLabel.TabIndex = 7;
            this.verificationWarningLabel.Text = "Please enter the code";
            this.verificationWarningLabel.Visible = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(150, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "and enter it below to earn";
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
            // verifyTextBox
            // 
            this.verifyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyTextBox.HideSelection = false;
            this.verifyTextBox.Location = new System.Drawing.Point(90, 150);
            this.verifyTextBox.MaxLength = 11;
            this.verifyTextBox.Name = "verifyTextBox";
            this.verifyTextBox.Size = new System.Drawing.Size(210, 41);
            this.verifyTextBox.TabIndex = 3;
            this.verifyTextBox.TabStop = false;
            this.verifyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.verifyTextBox_KeyUp);
            // 
            // captchaTextBox
            // 
            this.captchaTextBox.Enabled = false;
            this.captchaTextBox.Font = new System.Drawing.Font("High Tower Text", 28F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.captchaTextBox.Location = new System.Drawing.Point(10, 10);
            this.captchaTextBox.MaxLength = 10;
            this.captchaTextBox.Name = "captchaTextBox";
            this.captchaTextBox.ReadOnly = true;
            this.captchaTextBox.Size = new System.Drawing.Size(370, 51);
            this.captchaTextBox.TabIndex = 1;
            this.captchaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(310, 150);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(70, 40);
            this.verifyButton.TabIndex = 2;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(10, 70);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(120, 40);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // investTab
            // 
            this.investTab.Controls.Add(this.autoGenerateButton);
            this.investTab.Controls.Add(this.removeSymbolsButton);
            this.investTab.Controls.Add(this.incomeDoubleButton);
            this.investTab.Controls.Add(this.removeLettersButton);
            this.investTab.Location = new System.Drawing.Point(4, 34);
            this.investTab.Name = "investTab";
            this.investTab.Size = new System.Drawing.Size(396, 223);
            this.investTab.TabIndex = 2;
            this.investTab.Text = "Invest";
            this.investTab.ToolTipText = "Invest to make more QuikCoin";
            this.investTab.UseVisualStyleBackColor = true;
            // 
            // autoGenerateButton
            // 
            this.autoGenerateButton.Location = new System.Drawing.Point(0, 0);
            this.autoGenerateButton.Name = "autoGenerateButton";
            this.autoGenerateButton.Size = new System.Drawing.Size(200, 110);
            this.autoGenerateButton.TabIndex = 4;
            this.autoGenerateButton.Text = "Generate 1 Code Every 5 Seconds\r\n\r\nCost: 2 QuikCoin";
            this.autoGenerateButton.UseVisualStyleBackColor = true;
            this.autoGenerateButton.Click += new System.EventHandler(this.AutoGenerateButton_Click);
            // 
            // removeSymbolsButton
            // 
            this.removeSymbolsButton.Location = new System.Drawing.Point(200, 110);
            this.removeSymbolsButton.Name = "removeSymbolsButton";
            this.removeSymbolsButton.Size = new System.Drawing.Size(200, 110);
            this.removeSymbolsButton.TabIndex = 3;
            this.removeSymbolsButton.Text = "Remove Symbols\r\n\r\n\r\nCost: 20 QuikCoin";
            this.removeSymbolsButton.UseVisualStyleBackColor = true;
            this.removeSymbolsButton.Click += new System.EventHandler(this.RemoveSymbolsButton_Click);
            // 
            // incomeDoubleButton
            // 
            this.incomeDoubleButton.Location = new System.Drawing.Point(200, 0);
            this.incomeDoubleButton.Name = "incomeDoubleButton";
            this.incomeDoubleButton.Size = new System.Drawing.Size(200, 110);
            this.incomeDoubleButton.TabIndex = 2;
            this.incomeDoubleButton.Text = "Doubles Manual Income\r\n\r\nCost: 5 QuikCoin\r\n";
            this.incomeDoubleButton.UseVisualStyleBackColor = true;
            this.incomeDoubleButton.Click += new System.EventHandler(this.IncomeDoubleButton_Click);
            // 
            // removeLettersButton
            // 
            this.removeLettersButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.removeLettersButton.Location = new System.Drawing.Point(0, 110);
            this.removeLettersButton.Name = "removeLettersButton";
            this.removeLettersButton.Size = new System.Drawing.Size(200, 110);
            this.removeLettersButton.TabIndex = 1;
            this.removeLettersButton.Text = "Remove Letters\r\n\r\n\r\nCost: 10 QuikCoin";
            this.removeLettersButton.UseVisualStyleBackColor = true;
            this.removeLettersButton.Click += new System.EventHandler(this.RemoveLettersButton_Click);
            // 
            // QuickCoinMiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuickCoinMiner";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "QuikCoin Miner";
            this.Load += new System.EventHandler(this.QuickCoinMiner_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.walletTab.ResumeLayout(false);
            this.walletTab.PerformLayout();
            this.earnTab.ResumeLayout(false);
            this.earnTab.PerformLayout();
            this.investTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer cashoutTimer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer warningTimer;
        private System.Windows.Forms.Timer investmentTimer;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage walletTab;
        private Button button1;
        private Label resourceLabel;
        private Label label2;
        private Label cashoutTimerLabel;
        private Label label1;
        private TabPage earnTab;
        private Label verifiedLabel;
        private Label verificationWarningLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox verifyTextBox;
        private TextBox captchaTextBox;
        private Button verifyButton;
        private Button generateButton;
        private TabPage investTab;
        private Button autoGenerateButton;
        private Button removeSymbolsButton;
        private Button incomeDoubleButton;
        private Button removeLettersButton;
    }
}

