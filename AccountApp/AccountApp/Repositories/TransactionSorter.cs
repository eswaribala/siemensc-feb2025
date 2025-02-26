using AccountApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccountApp.Repositories
{
    internal class TransactionSorter : IComparer<Transaction>
    {
        public int Compare(Transaction x, Transaction y)
        {
            if(x.Amount < y.Amount) return -1;
            else if(x.Amount > y.Amount)
            return 1; 
            else
             return 0;
        }
    }
}
