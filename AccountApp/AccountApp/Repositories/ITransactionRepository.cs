using AccountApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccountApp.Repositories
{
    internal interface ITransactionRepository
    {
        Transaction AddTransaction(Transaction transaction);
       
        bool DeleteTransaction(long id);
        List<Transaction> GetTransactions();
        Transaction GetTransactionById(int id);
        List<Transaction> GetSortedTransactions();

    }
}
