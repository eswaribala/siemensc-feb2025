using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Models
{
    internal static class StringExtension
    {

        public static int WordCount(this string str)
        {
            {
                if (string.IsNullOrWhiteSpace(str)) return 0;
                return str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;

            }
        }
    }
}
