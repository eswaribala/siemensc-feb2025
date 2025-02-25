using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace BankingApp.Models
{
    /*
     * Abstract class object cannot be created
     * But We can inherit
     */
    internal abstract class Customer
    {
        //sttaic variable
        //Field
        public static string BankName;

        internal bool IsActive {  get; set; }

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

        protected abstract float ComputeInterest();
        //Basic implementation
        protected virtual float OTP() {

            return Faker.RandomNumber.Next(1000,9999);
        
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this,Formatting.Indented);
        }
    }
}
