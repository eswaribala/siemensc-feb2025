using BankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Repository
{
    public interface ICustomerRepository
    {
        Customer AddCustomer(Customer customer);
        Customer GetCustomerByAccountNo(long accountNo);

        List<Customer> GetAllCustomers();

        bool DeleteCustomerByAccountNo(long  accountNo);

        Customer UpdateCustomer(long accountNo, string email);


    }
}
