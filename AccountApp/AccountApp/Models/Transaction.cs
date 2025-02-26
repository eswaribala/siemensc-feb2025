using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Models
{
    internal class Transaction
    {
        public long Amount { get; set; }
        public string TimeStamp {  get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
    }
}
