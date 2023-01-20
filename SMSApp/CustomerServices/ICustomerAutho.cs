using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.CustomerServices
{
    internal interface ICustomerAutho
    {
        public void Login();
        public void Logout();
        public void ResetPassword();
    }
}
