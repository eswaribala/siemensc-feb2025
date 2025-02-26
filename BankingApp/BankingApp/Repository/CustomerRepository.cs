using BankingApp.Contexts;
using BankingApp.Models;
using Microsoft.EntityFrameworkCore;
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
            bool result = false;
            Customer customer = this._dbContext.Customers.FirstOrDefault(x => x.AccountNo == accountNo);
            if (customer != null)
            {
                this._dbContext.Customers.Remove(customer);
                this._dbContext.SaveChanges();
                result = true;
            }
            return result;
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
            Customer customer=this._dbContext.Customers.FirstOrDefault(x=>x.AccountNo==accountNo);
            if(customer!=null)
            {
                customer.Email = email;
                this._dbContext.Customers.Update(customer);
                this._dbContext.SaveChanges();
            }
            return customer;
        }
    }
}
