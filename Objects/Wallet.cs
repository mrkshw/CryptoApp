using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoApplication.Objects
{
    public class Wallet
    {
        internal bool IsEncrypted { get; set; } = false;
        internal decimal Balance { get; set; }

        private Form MainApplication { get; set; }

        public Wallet(Form mainApplication)
        {
            Balance = 0;
            MainApplication = mainApplication;
        }



        public void IncreaseBalance()
        {
            
            Random random = new Random();
            string r = "0.";
            int i;
            for (i = 1; i < 11; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            var crypto = double.Parse(r);
            Balance += (decimal)crypto;
        }

        public void EncryptBalance()
        {
            IsEncrypted = true;
        }

        public void payRansom()
        {
            
        }
    }
}
