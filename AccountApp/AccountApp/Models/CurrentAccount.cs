using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Models
{
    internal class CurrentAccount:Account
    {
        public long OverDraft {  get; set; }
    }
}
