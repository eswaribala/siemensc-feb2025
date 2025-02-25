using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public enum CompanyType { GOVT, PRIVATE,PUBLIC, NGO}
    [Table("Corporate")]
   public class Corporate : Customer
    {
        [Column("Company_Type")]
        [EnumDataType(typeof(CompanyType))]
        public CompanyType CompanyType { get; set; }
        
    }
}
