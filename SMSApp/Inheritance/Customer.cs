using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.Inheritance
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public decimal  Amount { get; set; }

        public Customer(decimal Amount) { 
        this.Amount = Amount;
        }
        public string GetFullName()
        {
            return Fname+" "+Lname;
        }
    }

    class A
    {
        public string M1 { get; set; } = "I am A class";
    }
    class B:A
    {
        public string M2 { get; set; } = "I am B class";
    }
    class C:B
    {
        public string M3 { get; set; } = "I am C class";
    }
    class D:C
    {
        public string M4 { get; set; } = "I am D class";
    }
}
