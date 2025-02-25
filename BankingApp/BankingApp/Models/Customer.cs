using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public  class Customer
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
        public long AccountNo { get; set; }
        public FullName FullName { get; set; }
        [Column("Email")]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$",
            ErrorMessage = "Email Format Not matching")]
        [DefaultValue("")]
        public string Email {  get; set; }
        [Column("Phone_Number")]
        [RegularExpression("^([+]\\d{2}[ ])?\\d{10}$",
            ErrorMessage = "Mobile No Format Not matching")]
        public long PhoneNumber { get; set; }

        [Column("Password")]

        public string Password {  get; set; }

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
