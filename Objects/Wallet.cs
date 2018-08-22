using System;

namespace CryptoApplication.Objects
{
    /// <summary>
    /// Basic Wallet class used to manage a player's resource.
    /// </summary>
    public class Wallet
    {
        //Instance variables
        internal decimal Balance { get; set; }         
        internal bool IsEncrypted { get; set; }
        internal bool IsProtected { get; set; }
        public bool HackSuccessful { get; set; }

        /// <summary>
        /// Constructor for the wallet object. Initializes the Wallet's Balance to 0, and declares
        /// that the wallet is neither Encrypted nor protected.
        /// </summary>
        public Wallet()
        {
            Balance = 0;
            IsEncrypted = false;
            IsProtected = false;
        }

        /// <summary>
        /// Method to increase the balance of the wallet. The method generates a 9 character string
        /// of numbers, and concatenates a "0." at the beginning of the string to create a decimal
        /// string. This string is then parsed into a Double, and then added onto the balance. 
        /// </summary>
        public void IncreaseBalance()
        {
            var random = new Random();
            var r = "0.";
            int i;
            for (i = 1; i < 11; i++) r += random.Next(0, 9).ToString();
            var crypto = double.Parse(r);
            Balance += (decimal) crypto;
        }
    }
}