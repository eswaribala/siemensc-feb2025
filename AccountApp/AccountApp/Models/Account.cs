using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Models
{
    internal class Account
    {
        public int AccountId { get; set; }
        public int RunningTotal { get; set; }
        public DateTime DOP { get; set; }
    }
}
