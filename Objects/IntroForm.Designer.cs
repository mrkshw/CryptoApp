namespace CryptoApplication.Objects
{
    partial class IntroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainTextLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(60, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(526, 39);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Welcome to the QuikCoin Miner!";
            // 
            // MainTextLabel
            // 
            this.MainTextLabel.AutoSize = true;
            this.MainTextLabel.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.MainTextLabel.Location = new System.Drawing.Point(80, 70);
            this.MainTextLabel.MaximumSize = new System.Drawing.Size(500, 300);
            this.MainTextLabel.MinimumSize = new System.Drawing.Size(300, 300);
            this.MainTextLabel.Name = "MainTextLabel";
            this.MainTextLabel.Size = new System.Drawing.Size(494, 300);
            this.MainTextLabel.TabIndex = 1;
            this.MainTextLabel.Text = resources.GetString("MainTextLabel.Text");
            this.MainTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(235, 340);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(180, 50);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start Mining!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MainTextLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntroForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label MainTextLabel;
        private System.Windows.Forms.Button StartButton;
    }
}