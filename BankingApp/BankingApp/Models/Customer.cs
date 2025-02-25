using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public class Customer
    {
        //sttaic variable
        //Field
        public static string BankName;

        public Customer(long accountNo, FullName fullName)
        {
            AccountNo = accountNo;
            FullName = fullName;
        }

        protected long AccountNo { get; }
        protected FullName FullName { get; }
        protected string Email {  get; set; }
        protected long PhoneNumber { get; set; }

        protected Address Address { get; set; }

        protected string Password {  get; set; }


    }
}
