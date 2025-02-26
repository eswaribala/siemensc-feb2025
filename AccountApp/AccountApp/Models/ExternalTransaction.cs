using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Models
{
    internal class ExternalTransaction:Transaction
    {

        public string BranchCode { get; set; }
        public string BranchAddress { get; set; }
        public long BranchPostalCode { get; set; }
    }

}
