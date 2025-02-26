using AccountApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccountApp.Repositories
{
    internal class TransactionRepository : ITransactionRepository
    {

        private List<Transaction> _transactions;

        public TransactionRepository()
        {
            _transactions = new List<Transaction>();
        }
        public Transaction AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
            return transaction;
        }

        public bool DeleteTransaction(long id)
        {
            bool status = false;
            Transaction transaction=_transactions.FirstOrDefault(t => t.Id == id);
             if(transaction != null)
            {
                _transactions.Remove(transaction);
                status = true;
            }
             return status;
        }

        public List<Transaction> GetSortedTransactions()
        {
            _transactions.Sort(new TransactionSorter());
            return _transactions;
        }

        public Transaction GetTransactionById(int id)
        {
            return _transactions.FirstOrDefault(t => t.Id==id);
        }

        public List<Transaction> GetTransactions()
        {
            return _transactions;
        }

      
    }
}
