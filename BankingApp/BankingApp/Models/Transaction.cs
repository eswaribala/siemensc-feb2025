using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public struct Transaction
    {
        public long TransactionId {  get; set; }
        public long Amount {  get; set; }
    }
}
