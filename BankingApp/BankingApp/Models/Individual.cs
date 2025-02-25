using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public enum Gender { MALE,FEMALE,TRANSGENDER}
    internal class Individual : Customer, IComparable<Individual>
    {
        public DateTime DOB {  get; set; }
        public Gender Gender { get; set; }
        public Individual(long accountNo, FullName fullName) : base(accountNo, fullName)
        {
        }

        public void SetValues(string Email,string Password, long PhoneNo,Address Address)
        {
            this.Email = Email;
            this.Password = Password;
            this.Address= Address;
            this.PhoneNumber = PhoneNo;
        }

        public override string ToString()
        {
            return this.AccountNo+","+this.FullName.FirstName+"," +
                this.PhoneNumber+","  + this.Gender.ToString()+","+this.DOB.ToString();
        }




        //mandatory
        protected override float ComputeInterest()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Individual other)
        {
            return this.FullName.FirstName.CompareTo(other.FullName.FirstName);
        }
    }
}
