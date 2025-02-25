using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public struct Transaction
    {
        public Transaction(long transactionId) : this()
        {
            TransactionId = transactionId;
        }

        public readonly long TransactionId { get; }
        public long Amount {  get; set; }
    }
}
