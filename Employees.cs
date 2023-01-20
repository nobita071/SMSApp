using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp
{


    //public static class Y{
      
    //    public static object o;
    //   static Y()
    //    {
    //        o = new X();
    //        Console.WriteLine("I am static constructor!");
    //    }
    //    public static void Print()
    //    {
    //        Console.WriteLine("I am print ");
    //    }
    //}

    //class X
    //{
    //    public string Message = "I am from base class";
    //    public int MyProperty { get; set; }
    //}
    public abstract class Employees
    {
        public string Fname;
        public string Lname;
        public decimal AnualSalary;

        public Employees(string fname)
        {
            this.Fname = fname;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Employee First Name: " + Fname);
            Console.WriteLine("Employee Last Name: " + Lname);
            Console.WriteLine("Employee Salary: " + AnualSalary);

        }

        public abstract decimal CalculatePermonthSalary();
    }

    public class SalesEmployee:Employees
    {
        public decimal Commision { get; set; }

        public SalesEmployee(string fname) : base(fname)
        {

        }
        public override decimal CalculatePermonthSalary()
        {
            return AnualSalary / 12 + Commision;
        }

        public void PrintChild()
        {
            Console.WriteLine("Hello child");
        }
    }
    //public class DeveloperEmployee : Employees
    //{
    //    // public decimal VariablePay { get; set; }
    //    public override decimal CalculatePermonthSalary()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
