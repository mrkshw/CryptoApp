namespace CryptoApplication.Objects
{
    partial class Virus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Virus));
            this.firstLineLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.writingTimer = new System.Windows.Forms.Timer(this.components);
            this.refuseButton = new System.Windows.Forms.Button();
            this.payRansomButton = new System.Windows.Forms.Button();
            this.balanceTimerLabel = new System.Windows.Forms.Label();
            this.secondsLeftLabel = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.hackTimer = new System.Windows.Forms.Timer(this.components);
            this.decisionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstLineLabel
            // 
            this.firstLineLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstLineLabel.AutoSize = true;
            this.firstLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLineLabel.ForeColor = System.Drawing.Color.White;
            this.firstLineLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.firstLineLabel.Location = new System.Drawing.Point(8, 6);
            this.firstLineLabel.MaximumSize = new System.Drawing.Size(500, 800);
            this.firstLineLabel.MinimumSize = new System.Drawing.Size(500, 700);
            this.firstLineLabel.Name = "firstLineLabel";
            this.firstLineLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firstLineLabel.Size = new System.Drawing.Size(500, 700);
            this.firstLineLabel.TabIndex = 0;
            this.firstLineLabel.Text = resources.GetString("firstLineLabel.Text");
            this.firstLineLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(560, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // writingTimer
            // 
            this.writingTimer.Tick += new System.EventHandler(this.writingTimer_Tick);
            // 
            // refuseButton
            // 
            this.refuseButton.Location = new System.Drawing.Point(680, 230);
            this.refuseButton.Name = "refuseButton";
            this.refuseButton.Size = new System.Drawing.Size(110, 40);
            this.refuseButton.TabIndex = 3;
            this.refuseButton.Text = "Refuse to Pay";
            this.refuseButton.UseVisualStyleBackColor = true;
            this.refuseButton.Click += new System.EventHandler(this.refuseButton_Click);
            // 
            // payRansomButton
            // 
            this.payRansomButton.Location = new System.Drawing.Point(560, 230);
            this.payRansomButton.Name = "payRansomButton";
            this.payRansomButton.Size = new System.Drawing.Size(110, 40);
            this.payRansomButton.TabIndex = 4;
            this.payRansomButton.Text = "Pay Ransom";
            this.payRansomButton.UseVisualStyleBackColor = true;
            this.payRansomButton.Click += new System.EventHandler(this.payRansomButton_Click);
            // 
            // balanceTimerLabel
            // 
            this.balanceTimerLabel.AutoSize = true;
            this.balanceTimerLabel.BackColor = System.Drawing.Color.Black;
            this.balanceTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTimerLabel.ForeColor = System.Drawing.Color.Red;
            this.balanceTimerLabel.Location = new System.Drawing.Point(370, 550);
            this.balanceTimerLabel.Name = "balanceTimerLabel";
            this.balanceTimerLabel.Size = new System.Drawing.Size(197, 26);
            this.balanceTimerLabel.TabIndex = 5;
            this.balanceTimerLabel.Text = "Balance deleted in:";
            // 
            // secondsLeftLabel
            // 
            this.secondsLeftLabel.AutoSize = true;
            this.secondsLeftLabel.BackColor = System.Drawing.Color.Black;
            this.secondsLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLeftLabel.ForeColor = System.Drawing.Color.Red;
            this.secondsLeftLabel.Location = new System.Drawing.Point(560, 490);
            this.secondsLeftLabel.Name = "secondsLeftLabel";
            this.secondsLeftLabel.Size = new System.Drawing.Size(138, 97);
            this.secondsLeftLabel.TabIndex = 6;
            this.secondsLeftLabel.Text = "30";
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(690, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "seconds";
            // 
            // hackTimer
            // 
            this.hackTimer.Interval = 30000;
            this.hackTimer.Tick += new System.EventHandler(this.hackTimer_Tick);
            // 
            // decisionLabel
            // 
            this.decisionLabel.AutoSize = true;
            this.decisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decisionLabel.ForeColor = System.Drawing.Color.Red;
            this.decisionLabel.Location = new System.Drawing.Point(510, 290);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new System.Drawing.Size(70, 25);
            this.decisionLabel.TabIndex = 8;
            this.decisionLabel.Text = "label1";
            // 
            // Virus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.decisionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.balanceTimerLabel);
            this.Controls.Add(this.secondsLeftLabel);
            this.Controls.Add(this.payRansomButton);
            this.Controls.Add(this.refuseButton);
            this.Controls.Add(this.firstLineLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Virus";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Virus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstLineLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer writingTimer;
        private System.Windows.Forms.Button refuseButton;
        internal System.Windows.Forms.Button payRansomButton;
        private System.Windows.Forms.Label balanceTimerLabel;
        private System.Windows.Forms.Label secondsLeftLabel;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer hackTimer;
        private System.Windows.Forms.Label decisionLabel;
    }
}