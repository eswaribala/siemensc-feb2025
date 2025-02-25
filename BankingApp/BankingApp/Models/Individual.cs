using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public enum Gender { MALE,FEMALE,TRANSGENDER}
    public class Individual : Customer
    {
        public DateTime DOB {  get; set; }
        public Gender Gender { get; set; }
        public Individual(long accountNo, FullName fullName) : base(accountNo, fullName)
        {
        }
    }
}
