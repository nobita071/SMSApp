using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.CustomerServices
{
    internal class CustomerService : ICustomerAutho, ICustomerCrud
    {
        public void Login()
        {
            SendOtp();
            ValidateDbData();
            Console.WriteLine("Login Success");
        }

        public bool SendOtp()
        {
            Console.WriteLine("OTP sened");
            return true;
        }
        public bool ValidateDbData()
        {
            Console.WriteLine("Data validated");
            return true;
        }


        public void Logout()
        {
            ClearSessionInfo();
            Console.WriteLine("Logout Success");
        }

        public bool ClearSessionInfo()
        {
            Console.WriteLine("session Data cleared");
            return true;
        }
        public void ResetPassword()
        {
            Console.WriteLine("Password reset changed");
        }

        public void Create()
        {
            Console.WriteLine("Customer created");
        }

        public void Update()
        {
            Console.WriteLine("customer updated");
        }

        public void Delete()
        {
            Console.WriteLine("customer deleted");
        }

        public void GetAll()
        {
            Console.WriteLine("all customer readed");
        }
    }
}
