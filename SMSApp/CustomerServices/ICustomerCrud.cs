using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.CustomerServices
{
    internal interface ICustomerCrud
    {
        public void Create();
        public void Update();
        public void Delete();
        public void GetAll();
    }
}
