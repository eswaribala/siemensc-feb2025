using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public enum CompanyType { GOVT, PRIVATE,PUBLIC, NGO}
    public class Corporate : Customer
    {
        public CompanyType CompanyType { get; set; }
        public Corporate(long accountNo, FullName fullName) : base(accountNo, fullName)
        {
        }
    }
}
