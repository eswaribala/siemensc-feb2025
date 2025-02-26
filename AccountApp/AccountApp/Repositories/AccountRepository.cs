using AccountApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Repositories
{
    internal class AccountRepository : IAccountRepository
    {
        private SortedList<Account, List<Transaction>> accountStatement;

        public AccountRepository() { 
          accountStatement=new SortedList<Account, List<Transaction>>(new AccountSorter());
        }
        public void AddAccount(Account account, List<Transaction> transactions)
        {
            accountStatement.Add(account, transactions);
        }

        public SortedList<Account, List<Transaction>> GetAllTransactions()
        {
            return accountStatement;
        }
    }
}
