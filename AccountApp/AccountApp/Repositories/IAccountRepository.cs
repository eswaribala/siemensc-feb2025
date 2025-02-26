using AccountApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Repositories
{
    internal interface IAccountRepository
    {

        void AddAccount(Account account,List<Transaction> transactions);
        SortedList<Account, List<Transaction>> GetAllTransactions();



    }
}
