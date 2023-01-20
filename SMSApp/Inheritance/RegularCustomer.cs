using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.Inheritance
{
    internal class RegularCustomer : Customer
    {
        public RegularCustomer(decimal Amount) : base(Amount)
        {
        }
    }
}
