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
            this.RansomLabel = new System.Windows.Forms.Label();
            this.SkullImage = new System.Windows.Forms.PictureBox();
            this.writingTimer = new System.Windows.Forms.Timer(this.components);
            this.RefuseButton = new System.Windows.Forms.Button();
            this.PayRansomButton = new System.Windows.Forms.Button();
            this.BalanceTimerLabel = new System.Windows.Forms.Label();
            this.SecondsLeftLabel = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.hackTimer = new System.Windows.Forms.Timer(this.components);
            this.DecisionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SkullImage)).BeginInit();
            this.SuspendLayout();
            // 
            // RansomLabel
            // 
            this.RansomLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RansomLabel.AutoSize = true;
            this.RansomLabel.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RansomLabel.ForeColor = System.Drawing.Color.Lime;
            this.RansomLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RansomLabel.Location = new System.Drawing.Point(8, 6);
            this.RansomLabel.MaximumSize = new System.Drawing.Size(500, 800);
            this.RansomLabel.MinimumSize = new System.Drawing.Size(500, 700);
            this.RansomLabel.Name = "RansomLabel";
            this.RansomLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RansomLabel.Size = new System.Drawing.Size(500, 700);
            this.RansomLabel.TabIndex = 0;
            this.RansomLabel.Text = resources.GetString("RansomLabel.Text");
            this.RansomLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SkullImage
            // 
            this.SkullImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SkullImage.BackgroundImage")));
            this.SkullImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SkullImage.Location = new System.Drawing.Point(560, 20);
            this.SkullImage.Name = "SkullImage";
            this.SkullImage.Size = new System.Drawing.Size(230, 200);
            this.SkullImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SkullImage.TabIndex = 1;
            this.SkullImage.TabStop = false;
            // 
            // writingTimer
            // 
            this.writingTimer.Tick += new System.EventHandler(this.WritingTimer_Tick);
            // 
            // RefuseButton
            // 
            this.RefuseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefuseButton.Enabled = false;
            this.RefuseButton.Location = new System.Drawing.Point(680, 230);
            this.RefuseButton.Name = "RefuseButton";
            this.RefuseButton.Size = new System.Drawing.Size(110, 40);
            this.RefuseButton.TabIndex = 3;
            this.RefuseButton.Text = "Refuse to Pay";
            this.RefuseButton.UseVisualStyleBackColor = true;
            this.RefuseButton.Click += new System.EventHandler(this.RefuseButton_Click);
            // 
            // PayRansomButton
            // 
            this.PayRansomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayRansomButton.Enabled = false;
            this.PayRansomButton.Location = new System.Drawing.Point(560, 230);
            this.PayRansomButton.Name = "PayRansomButton";
            this.PayRansomButton.Size = new System.Drawing.Size(110, 40);
            this.PayRansomButton.TabIndex = 4;
            this.PayRansomButton.Text = "Pay Ransom";
            this.PayRansomButton.UseVisualStyleBackColor = true;
            this.PayRansomButton.Click += new System.EventHandler(this.PayRansomButton_Click);
            // 
            // BalanceTimerLabel
            // 
            this.BalanceTimerLabel.AutoSize = true;
            this.BalanceTimerLabel.BackColor = System.Drawing.Color.Black;
            this.BalanceTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTimerLabel.ForeColor = System.Drawing.Color.Red;
            this.BalanceTimerLabel.Location = new System.Drawing.Point(370, 550);
            this.BalanceTimerLabel.Name = "BalanceTimerLabel";
            this.BalanceTimerLabel.Size = new System.Drawing.Size(197, 26);
            this.BalanceTimerLabel.TabIndex = 5;
            this.BalanceTimerLabel.Text = "Balance deleted in:";
            // 
            // SecondsLeftLabel
            // 
            this.SecondsLeftLabel.AutoSize = true;
            this.SecondsLeftLabel.BackColor = System.Drawing.Color.Black;
            this.SecondsLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondsLeftLabel.ForeColor = System.Drawing.Color.Red;
            this.SecondsLeftLabel.Location = new System.Drawing.Point(560, 490);
            this.SecondsLeftLabel.Name = "SecondsLeftLabel";
            this.SecondsLeftLabel.Size = new System.Drawing.Size(138, 97);
            this.SecondsLeftLabel.TabIndex = 6;
            this.SecondsLeftLabel.Text = "30";
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.CountdownTimer_Tick);
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.BackColor = System.Drawing.Color.Black;
            this.SecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondsLabel.ForeColor = System.Drawing.Color.Red;
            this.SecondsLabel.Location = new System.Drawing.Point(690, 550);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(93, 26);
            this.SecondsLabel.TabIndex = 7;
            this.SecondsLabel.Text = "seconds";
            // 
            // hackTimer
            // 
            this.hackTimer.Interval = 30000;
            this.hackTimer.Tick += new System.EventHandler(this.HackTimer_Tick);
            // 
            // DecisionLabel
            // 
            this.DecisionLabel.AutoSize = true;
            this.DecisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecisionLabel.ForeColor = System.Drawing.Color.Red;
            this.DecisionLabel.Location = new System.Drawing.Point(520, 290);
            this.DecisionLabel.MaximumSize = new System.Drawing.Size(250, 150);
            this.DecisionLabel.MinimumSize = new System.Drawing.Size(250, 150);
            this.DecisionLabel.Name = "DecisionLabel";
            this.DecisionLabel.Size = new System.Drawing.Size(250, 150);
            this.DecisionLabel.TabIndex = 8;
            this.DecisionLabel.Text = "label1";
            // 
            // Virus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.DecisionLabel);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.BalanceTimerLabel);
            this.Controls.Add(this.SecondsLeftLabel);
            this.Controls.Add(this.PayRansomButton);
            this.Controls.Add(this.RefuseButton);
            this.Controls.Add(this.RansomLabel);
            this.Controls.Add(this.SkullImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Virus";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Virus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SkullImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RansomLabel;
        private System.Windows.Forms.PictureBox SkullImage;
        private System.Windows.Forms.Timer writingTimer;
        private System.Windows.Forms.Button RefuseButton;
        internal System.Windows.Forms.Button PayRansomButton;
        private System.Windows.Forms.Label BalanceTimerLabel;
        private System.Windows.Forms.Label SecondsLeftLabel;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Label DecisionLabel;
        internal System.Windows.Forms.Timer hackTimer;
    }
}