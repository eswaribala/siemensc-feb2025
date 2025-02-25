using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public class Customer
    {
        public Customer(long accountNo, FullName fullName)
        {
            AccountNo = accountNo;
            FullName = fullName;
        }

        public long AccountNo { get; }
        public FullName FullName { get; }
        public string Email {  get; set; }
        public long PhoneNumber { get; set; }

        public Address Address { get; set; }

        public string Password {  get; set; }


    }
}
