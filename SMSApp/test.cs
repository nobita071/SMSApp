using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp
{
    internal class test
    {
        public static int x = 100;
        public int y = 50;
    }

    internal class Sample : test
    {
         public static int x = 500;

        public void getInfo()
        {
            Console.WriteLine($"Parent x : {test.x}, Child : x {x}");
        }

        public double Sum(int x, double y)
        {
            return x + y;
        }

        public double Sum(double x, int y)
        {
            return x + y;
        }
    }
}
