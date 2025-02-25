using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public class Transaction
    {
 
        public Transaction(long transactionId) 
        {
            TransactionId = transactionId;
        }

        public readonly long TransactionId;
        public const float ROI = 0.7F;
        public long Amount {  get; set; }
    }
}
