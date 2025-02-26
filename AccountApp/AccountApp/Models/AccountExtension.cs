using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Models
{
    //Extensions
    internal static class AccountExtension
    {
        public static bool IsRunningTotalBelowMinimum(this Account account)
        {
            return account.RunningTotal < 5000;
        }
    }
}
