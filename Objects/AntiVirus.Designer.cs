using System.Drawing;

namespace CryptoApplication.Objects
{
    partial class AntiVirus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntiVirus));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AccceptButton = new System.Windows.Forms.Button();
            this.DeclineButton = new System.Windows.Forms.Button();
            this.scrollUpTimer = new System.Windows.Forms.Timer(this.components);
            this.ScrollDownTimer = new System.Windows.Forms.Timer(this.components);
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.QuikSaveLabel = new System.Windows.Forms.Label();
            this.ReminderTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // AccceptButton
            // 
            this.AccceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(213)))), ((int)(((byte)(112)))));
            this.AccceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccceptButton.FlatAppearance.BorderSize = 0;
            this.AccceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccceptButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AccceptButton.Location = new System.Drawing.Point(10, 370);
            this.AccceptButton.Margin = new System.Windows.Forms.Padding(0);
            this.AccceptButton.Name = "AccceptButton";
            this.AccceptButton.Size = new System.Drawing.Size(160, 80);
            this.AccceptButton.TabIndex = 1;
            this.AccceptButton.Text = "Yes Please";
            this.AccceptButton.UseVisualStyleBackColor = false;
            this.AccceptButton.Click += new System.EventHandler(this.AcceptButtonClick);
            // 
            // DeclineButton
            // 
            this.DeclineButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DeclineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(213)))), ((int)(((byte)(112)))));
            this.DeclineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeclineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeclineButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeclineButton.Location = new System.Drawing.Point(180, 370);
            this.DeclineButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(160, 80);
            this.DeclineButton.TabIndex = 2;
            this.DeclineButton.Text = "Ask Me Later";
            this.DeclineButton.UseVisualStyleBackColor = false;
            this.DeclineButton.Click += new System.EventHandler(this.DeclineButtonClick);
            // 
            // scrollUpTimer
            // 
            this.scrollUpTimer.Interval = 10;
            this.scrollUpTimer.Tick += new System.EventHandler(this.ScrollUpTimer_Tick);
            // 
            // ScrollDownTimer
            // 
            this.ScrollDownTimer.Interval = 10;
            this.ScrollDownTimer.Tick += new System.EventHandler(this.ScrollDownTimer_Tick);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InfoLabel.Image = ((System.Drawing.Image)(resources.GetObject("InfoLabel.Image")));
            this.InfoLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.InfoLabel.Location = new System.Drawing.Point(20, 60);
            this.InfoLabel.MaximumSize = new System.Drawing.Size(310, 300);
            this.InfoLabel.MinimumSize = new System.Drawing.Size(310, 300);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(310, 300);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = resources.GetString("InfoLabel.Text");
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ExitLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitLabel.Location = new System.Drawing.Point(310, 10);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(30, 29);
            this.ExitLabel.TabIndex = 5;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPicture.BackgroundImage")));
            this.LogoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPicture.Location = new System.Drawing.Point(0, 0);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(50, 50);
            this.LogoPicture.TabIndex = 7;
            this.LogoPicture.TabStop = false;
            // 
            // QuikSaveLabel
            // 
            this.QuikSaveLabel.AutoSize = true;
            this.QuikSaveLabel.Font = new System.Drawing.Font("Lucida Console", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuikSaveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuikSaveLabel.Location = new System.Drawing.Point(50, 15);
            this.QuikSaveLabel.Name = "QuikSaveLabel";
            this.QuikSaveLabel.Size = new System.Drawing.Size(148, 27);
            this.QuikSaveLabel.TabIndex = 8;
            this.QuikSaveLabel.Text = "QuikSave";
            // 
            // ReminderTimer
            // 
            this.ReminderTimer.Interval = 60000;
            this.ReminderTimer.Tick += new System.EventHandler(this.ReminderTimer_Tick);
            // 
            // AntiVirus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(155)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(350, 464);
            this.Controls.Add(this.QuikSaveLabel);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.AccceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AntiVirus";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AntiVirus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button DeclineButton;
        private System.Windows.Forms.Timer scrollUpTimer;
        private System.Windows.Forms.Timer ScrollDownTimer;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label ExitLabel;
        public System.Windows.Forms.Button AccceptButton;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Label QuikSaveLabel;
        private System.Windows.Forms.Timer ReminderTimer;
    }
}