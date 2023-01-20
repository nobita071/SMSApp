using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp
{
    internal class BankingCustomer
    {
        public string AcNo { get; }
        public string Name;
        private decimal _Amount;
        public BankingCustomer(string acNo, string name, decimal amount)
        {
            AcNo = acNo;
            Name = name;
            _Amount = amount;
        }

        //public string AcNo
        //{
        //    get { return _AcNo; }
        //}
        public decimal Amount {
            get { return _Amount; }
            set { 
                if(value>1000)
                _Amount = value;
            }
        }
    }
}
