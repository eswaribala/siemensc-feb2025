using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Models
{
    internal class DirectDebit:Transaction
    {
        public DateTime PaymentDate { get; set; }   
    }
}
