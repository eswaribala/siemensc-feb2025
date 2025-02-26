using AccountApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Models
{

    //without modifying existing class without doing inheritance
    // create additional method to the existing class
    //checks Running Total and gives warning if it goes below 5000
    internal  class Account
    {
        private int accountId;

        public int AccountId
        {
            get { return accountId; }
            set
            {
               //custom exception
                    if (value <= 0)
                        throw new AccountIdException("Account Id should be more than 0");

                    else 

                        accountId = value;
            }
        }

        //public int AccountId { get; set; }
        public int RunningTotal { get; set; }
        public DateTime DOP { get; set; }

       
    }
}
