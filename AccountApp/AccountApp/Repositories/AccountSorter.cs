using AccountApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Repositories
{
    internal class AccountSorter : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            if (x.AccountId == y.AccountId) 
                return 0;
            else if (x.AccountId < y.AccountId)
                return -1;
            else return 1;
             
        }
    }
}
