using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Account
    {
        #region Properties
        /// <summary>
        /// client Account Number
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// client Email Address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// client current Balance
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// Type of Client Account
        /// </summary>
        public string TypeOfAccount { get; set; }
        #endregion Properties
    }
}
