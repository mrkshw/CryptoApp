using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoApplication.Objects
{
    public partial class AntiVirus : Form
    {
        private Wallet _wallet;
        private Label _mainResourceLabel;
        private int _scrollDownIndex;

        public AntiVirus(Wallet w, Label mainResourceLabel)
        {
            _wallet = w;
            _mainResourceLabel = mainResourceLabel;
            InitializeComponent();
            _scrollDownIndex = Height;
        }

        private void AntiVirus_Load(object sender, EventArgs e)
        {
            ScrollUp();
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                Screen.PrimaryScreen.WorkingArea.Height);
            scrollUpTimer.Start();
            FadeIn(this, 80);
        }

        private void ScrollUp()
        {

        }

        private async void FadeIn(Form o, int interval)
        {
            //Object is not fully invisible. Fade it in
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 1; //make fully visible       
        }

        private async void FadeOut(Form o, int interval)
        {
            //Object is fully visible. Fade it out
            while (o.Opacity > 0.0)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0; //make fully invisible       
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FadeOut(this, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScrollDownTimer.Start();
            FadeOut(this, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private int _scrollUpIndex = 0;

        

        private void scrollUpTimer_Tick(object sender, EventArgs e)
        {
            
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                                      Screen.PrimaryScreen.WorkingArea.Height - _scrollUpIndex);            
            _scrollUpIndex += 5;

            if (_scrollUpIndex < Height) return;
            scrollUpTimer.Stop();
            _scrollUpIndex = 0;
        }

        private void ScrollDownTimer_Tick(object sender, EventArgs e)
        {      
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                                      Screen.PrimaryScreen.WorkingArea.Height - _scrollDownIndex);

            _scrollDownIndex -= 5;

            if (_scrollDownIndex > 0) return;
            ScrollDownTimer.Stop();
            _scrollDownIndex = Height;
        }
    }
}
