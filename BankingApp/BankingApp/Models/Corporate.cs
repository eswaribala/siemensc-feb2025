using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    internal enum CompanyType { GOVT, PRIVATE,PUBLIC, NGO}
    internal class Corporate : Customer
    {
        public CompanyType CompanyType { get; set; }
        public Corporate(long accountNo, FullName fullName) : base(accountNo, fullName)
        {
        }

        protected override float ComputeInterest()
        {
            throw new NotImplementedException();
        }
    }
}
