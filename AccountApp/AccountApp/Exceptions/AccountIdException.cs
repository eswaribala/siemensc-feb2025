using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Exceptions
{
    internal class AccountIdException : ApplicationException
    {
        public AccountIdException(string message) : base(message)
        {
        }
    }
}
