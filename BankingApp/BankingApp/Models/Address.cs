using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    [Table("Address")]
    public class Address
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Address_Id")]
        public long AddressId { get; set; }
        [Column("Door_No")]
        public string DoorNo { get; set; }
        [Column("Street_Name")]
        public string StreetName { get; set; }
        [Column("City")]
        public string City { get; set; }
        [Column("State")]
        public string State { get; set; }
        [Column("Country")]
        public string Country { get; set; }
        [Column("Postal_Code")]
        public long PostalCode { get; set; }


        [ForeignKey("Customer")]
        [Column("Account_No_FK")]
        public long AccountNo { get; set; }

        public Customer Customer { get; set; }
    }
}
