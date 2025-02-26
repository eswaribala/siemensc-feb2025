using BankingApp.Contexts;
using BankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private BankingContext _dbContext;

        public CustomerRepository(BankingContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Customer AddCustomer(Customer customer)
        {
             this._dbContext.Customers.Add(customer);
             this._dbContext.SaveChanges();
            return customer;
        }

        public bool DeleteCustomerByAccountNo(long accountNo)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            return this._dbContext.Customers.ToList();
        }

        public Customer GetCustomerByAccountNo(long accountNo)
        {
            return this._dbContext.Customers.FirstOrDefault(x=>x.AccountNo==accountNo);
        }

        public Customer UpdateCustomer(long accountNo, string email)
        {
            throw new NotImplementedException();
        }
    }
}
