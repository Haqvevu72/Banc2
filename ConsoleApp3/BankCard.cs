using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class bankcard
    {
        private string? pan;
        public DateTime expiredate { get; set; }
        public string? PAN
        {
            get { return pan; }
            set
            {
                if (value.Length == 16)
                {
                    pan = value;
                }
            }
        }

        private string? pin;


        public string? PIN
        {
            get { return pin; }
            set
            {
                if (value.Length == 4)
                {
                    pin = value;
                }
            }

        }
        public string? CVC { get; set; }

        public double Balance { get; set; }
        // => Constructor for `bankcard` class
        public bankcard(DateTime expiredate, string? pAN, string? pIN, string? cVC, double balance)
        {
            this.expiredate = expiredate;
            PAN = pAN;
            PIN = pIN;
            CVC = cVC;
            Balance = balance;
        }


        // => Overriding ToString() method
        public override string ToString()
        {
            return $"\nBank Account\nPAN: {PAN}\nPIN: {PIN}\nExpire Date:{expiredate.ToShortDateString()}\nCVC: {CVC}\nBalance: {Balance}";
        }
    }
}
