using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp
{
    internal class MyException:Exception
    {
       static string sms = "dfkjgsdlfks";

        public MyException():base(sms){
        
        }
    }
}
