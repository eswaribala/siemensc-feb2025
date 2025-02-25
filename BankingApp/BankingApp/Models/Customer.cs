using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    [Table("Customer")]
    internal abstract class Customer
    {
        //sttaic variable
        //Field
        //public static string BankName;

       // internal bool IsActive {  get; set; }

        //public Customer(long accountNo, FullName fullName)
        //{
        //    AccountNo = accountNo;
        //    FullName = fullName;
        //}
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Account_No")]
        protected long AccountNo { get; set; }
        protected FullName FullName { get; set; }
        protected string Email {  get; set; }
        protected long PhoneNumber { get; set; }

        protected Address Address { get; set; }

        protected string Password {  get; set; }

        //protected abstract float ComputeInterest();
        ////Basic implementation
        //protected virtual float OTP() {

        //    return Faker.RandomNumber.Next(1000,9999);
        
        //}

        //public override string ToString()
        //{
        //    return JsonConvert.SerializeObject(this,Formatting.Indented);
        //}
    }
}
