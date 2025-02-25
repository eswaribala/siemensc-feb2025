using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    [Owned]
    internal class FullName
    {
        [Column("First_Name",TypeName ="varchar(100)")]
        [Required]
        [RegularExpression("^[a-zA-Z]{3,100}$", ErrorMessage = "First name should be between 3 to 100 chars")]
        public string FirstName { get; set; }
        [Column("Last_Name", TypeName = "varchar(100)")]
        [RegularExpression("^[a-zA-Z]{3,100}$", ErrorMessage = "Last name should be between 3 to 100 chars")]
        [Required]
        public string LastName { get; set; }
        [Column("Middle_Name", TypeName = "varchar(100)")]

        public string MiddleName {  get; set; }
    }
}
