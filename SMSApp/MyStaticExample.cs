using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp
{
    public class MyStaticExample1
    {
        public static int count = 0;

        public MyStaticExample1()
        {
            count++;
        }
    }
    internal  class MyStaticExample
    {
        public string message { get; set; }
        public static string smessage { get; set; }

        public static void PrintMessage()
        {
            Console.WriteLine("Static message : "+smessage);
           // Console.WriteLine("Non Static message : "+message);

        }
    }
}
