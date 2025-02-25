using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public enum Gender { MALE,FEMALE,TRANSGENDER}
    [Table("Individual")]
    public class Individual : Customer
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM dd yyyy}")]
        [Column("DOB")]
        public DateTime DOB {  get; set; }
        [Column("Gender")]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }       

        



       
    }
}
