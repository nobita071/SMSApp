
using BusinessLayer;
using SMSApp.CustomerServices;
using SMSApp.Inheritance;
using System.Collections;
using System.Text;
using System.IO;
namespace SMSApp
{

    internal class Practices
    {

        public static void Main()
        {
            try
            {
                string path = @"D:\\movies";

                string filename = "coretech.txt";
                string fullPath = Path.Combine(path, filename);
               
                FileStream fs = new FileStream(fullPath,FileMode.Append);

                //StreamReader streamReader = new StreamReader(fs);

                //var str = streamReader.ReadToEnd();

                //Console.WriteLine(str);
                StreamWriter streamWriter = new StreamWriter(fs);
                string content = "hello i am new content from c#" + Environment.NewLine + " and this new line";
                streamWriter.WriteLine(content);
                streamWriter.Close();
                fs.Close();



            }
            catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


               // DivideByZeroException
               //  ArithmeticException
               //data source=10.4.8.12, initiate catalog=smsdb;
               //select* from employees


                //    List<int> lst = new List<int>();
                //    lst.Add(11);
                //    lst.Add(13);
                //    lst.Add(14);


                //   //----------------------------------//

                //    List<string> lst2 = new List<string>();
                //    lst2.Add("Php");
                //    lst2.Add("Java");
                //    lst2.Add("Pytho");



                //Hashtable ht = new Hashtable();
                //ht.Add(10, "India");
                //ht.Add(11, "USA");
                //ht.Add(12, "Japan");
                //ht.Add(13, "Russiya");

                //foreach (DictionaryEntry item in ht)
                //{

                //    Console.WriteLine("Country Code: "+item.Key+", Country Name: "+item.Value);
                //}


                //Queue queue = new Queue();

                //queue.Enqueue(200);
                //queue.Enqueue(400);
                //queue.Enqueue(700);

                //queue.Dequeue();
                //foreach (var item in queue)
                //    Console.WriteLine(item);


                //Stack stk = new Stack();

                //stk.Push(100);
                //stk.Push(200);
                //stk.Push(400);

                //stk.Pop();
                //Console.WriteLine("top most item :"+stk.Peek());

                //foreach(var item in stk)
                //    Console.WriteLine(item);



                //ArrayList list = new ArrayList();
                //list.Add(100);
                //list.Add(1.00);
                //list.Add(2);
                //list.Add("two");

                //string[] str = { "One", "two", "Three" };
                //list.AddRange(str);
                //list.Remove(100);
                // list.RemoveAt(2);
                // list.RemoveRange(1, 2);

                //list.Insert(2, "i am new");

                //list.Clear();
                // Console.WriteLine(list.Contains(112));

                //object[] arr=new object[10];
                //list.CopyTo(arr);


                //foreach (var i in list)
                //{
                //    Console.WriteLine("Item: "+Convert.ToInt32(i)*10);
                //}

                // foreach (var i in arr)
                //{
                //    Console.WriteLine("Item arr: "+i);
                //}











                //ICustomerAutho autho = new CustomerService();

                //autho.Login();


                //ICustomerCrud crud = new CustomerService();
                //crud.Create();
                //crud.Delete();



                // Employees emp = new SalesEmployee();



                //CallBL o = new CallBL();
                //o.PritnMsg();

                //SampleCls obj = new SampleCls();
                //obj.PrintMessage();


                //SalesEmployee sales = new SalesEmployee();
                //sales.Fname = "Amit";
                //sales.Lname = "Kumar";
                //sales.AnualSalary = 120000;
                //sales.Commision = 12000;
                //sales.PrintDetails();
                //Console.WriteLine("Salary: "+sales.CalculatePermonthSalary());

                //Console.WriteLine("==================================");
                //DeveloperEmployee developer = new DeveloperEmployee();
                //developer.Fname = "Rakesh";
                //developer.Lname = "Kumar";
                //developer.AnualSalary = 220000;
                //developer.PrintDetails();
                //Console.WriteLine("Salary: " + developer.CalculatePermonthSalary());
                //Console.WriteLine(true);

                //var o = new Sample();
                //o.getInfo();
                //o.Sum(4.5, 3);

                // var obj = new D();
                //// obj.

                //B b1 = obj;

                //C c1 = obj;




                //var gc = new GoldCustomer(1000);
                //Console.WriteLine(gc.Amount);

                //var rc = new RegularCustomer(4000);
                //Console.WriteLine(rc.Amount);
                //MyStaticExample1 m1 = new MyStaticExample1();
                //MyStaticExample1 m2 = new MyStaticExample1();
                //MyStaticExample1 m3 = new MyStaticExample1();

                //Console.WriteLine(MyStaticExample1.count);

                //Console.WriteLine(m3.count);

                //MyStaticExample.smessage = "hello";
                //MyStaticExample.PrintMessage();

                //Products p = new Products();

                //p[0] = 101;
                //p["title"] = "Laptop";
                //p[2] = 4000;
                //p[3] = "test.jpg";

                ////p[5] = 11;
                //Console.WriteLine("Id: " + p["id"]);
                //Console.WriteLine("Title: " + p[1]);


                //var cust = new BankingCustomer("SBI00123", "Rakesh", 20000);

                //Console.WriteLine("Customer Account Number: "+cust.AcNo);
                //Console.WriteLine("Customer Name: "+cust.Name);
                //Console.WriteLine("Customer Amount: "+cust.Amount);

                //cust.AcNo = "rfgwefw";
                //cust.Amount -= 18000;
                //Console.WriteLine("========================After tansa================");
                //Console.WriteLine("Customer Account Number: " + cust.AcNo);
                //Console.WriteLine("Customer Name: " + cust.Name);
                //Console.WriteLine("Customer Amount: " + cust.Amount);

                // Y.Print();
                //var em = new Employees("Rakesh", "Kumar", 12000);
                //var emcopy =new Employees(em);
                //em.PrintMessage();
                //em.PrintDetails();
                //Console.WriteLine("----------Updated--------------");
                ////------change something----------//
                //em.Salary = 5000;
                //em.Lname = "Singh";
                //em.PrintDetails();
                ////----------------------//
                //Console.WriteLine("-----------Old Data---------------");
                //emcopy.PrintDetails();

                // ArrayUniqueChar();

                //int a = 4, b = 5;
                //// CallByValue(a, b);
                //CallByRef(ref a, ref b);
                //Console.WriteLine("Outside A: "+a);
                //Console.WriteLine("Outside B: "+b);

                //int a, d, m = 0;
                //a=Calc(5, 6, out d, out m);

                //Console.WriteLine("Addition: "+a);
                //Console.WriteLine("Division: "+d);
                //Console.WriteLine("Multiplication: "+m);

                //int r = Addition(3, 4,6,8,9);
                //Console.WriteLine("Result is : "+r);
                // Array5();
                //Test(null);

                //string p=null;
                //string p1=string.Empty;
                //string p3 = "";
                //Console.WriteLine(p3.Equals(p1));
                //Console.WriteLine(p==p3);
                //Console.WriteLine(p1==p3);

                //Console.WriteLine(x.Equals(y));

                #region
                //char c = 'a';

                //Console.WriteLine(char.IsLower(c));
                //Console.WriteLine(char.IsUpper(c));
                //Console.WriteLine(char.IsLetter(c));
                //Console.WriteLine(char.IsPunctuation(c));
                //Console.WriteLine(char.IsWhiteSpace(c));



                //var today=DateTime.Now;
                //Console.WriteLine(today.Year);
                //Console.WriteLine(today.Month);
                //Console.WriteLine(today.Day);
                //Console.WriteLine(today.DayOfYear);
                //Console.WriteLine(today.Hour);  
                //Console.WriteLine(today.Minute);
                //Console.WriteLine(today.Second);
                //Console.WriteLine(today.Millisecond);


                //string dd = "15/10/2022";
                //2022/10/15


                //Random random = new Random();
                //var otp = random.Next(111111, 999999);
                //Console.WriteLine(otp);
                //abcdef...zABCDE.Z0123456789&$@)(!


                //Console.WriteLine(Math.Round(4.6));
                //Console.WriteLine(Math.Ceiling(4.5));
                //Console.WriteLine(Math.Floor(4.5));


                //string ename = "Ramesh";
                //string empId = "EMP00912";

                //StringBuilder sb = new StringBuilder("Dear team\r\r\r\n\t<username> Hope you are doing good,\r\n\tyour employee id <employeeid> is attachaced with our system.");
                ////sb.Append(" for builing");
                ////sb.Insert(7, " a");
                //sb.Replace("<username>", ename);
                //sb.Replace("<employeeid>", empId);

                //Console.WriteLine(sb.ToString());

                //Console.WriteLine("Enter any string : ");
                //string str = Console.ReadLine();

                //Console.WriteLine("Enter word ?");
                //string word=Console.ReadLine();

                //int count = 0;
                //foreach(var s in str.Split(" "))
                //{
                //    if (s.ToLower() == word.ToLower())
                //    {
                //        count++;
                //    }
                //}
                //Console.WriteLine("Word: "+word+" found:"+count+" time." );




                //Console.WriteLine("Enter any string : ");
                //string str = Console.ReadLine();
                //string []str1 = str.Split(" ");
                //string Abbr = string.Empty;
                //for(int i=0;i<str1.Length-1;i++)
                //{
                //    Abbr += str1[i].Substring(0, 1).ToUpper()+". ";
                //}
                //Abbr += str1[str1.Length - 1].Substring(0, 1).ToUpper() + str1[str1.Length - 1].Substring(1);
                //Console.WriteLine(Abbr);

                //verma


                /// Console.WriteLine("i am new main");
                // GetDiscount();
                // GenerateFib();
                //GCD();
                // Pattern7();
                // Pattern8();
                //Array6();

                /*
                string str = "this is, message for the, c# training";
                string nstr = str.Insert(7,"newdata");
                Console.WriteLine("Original: " + str);
                Console.WriteLine("Output: " + nstr);
                */
                //string s1 = "india";

                //string s2 = "USA";

                //string s3 = "Japan";

                //string s4=string.Join(",",s1,s2,s3);
                //Console.WriteLine(s4);

                //string str = "this is, message for the, c# training";
                //string nstr = str.Replace("is","are");
                //Console.WriteLine("Original: " + str);
                //Console.WriteLine("Output: " + nstr);

                //string nstr = str.Remove(str.IndexOf("m"), 7);
                //Console.WriteLine("Original: " + str);
                //Console.WriteLine("Output: " + nstr);


                //str.MySplit()
                //string[] sArr = str.Split(",");
                //for (int i = 0; i < sArr.Length; i++)
                //{
                //    Console.WriteLine("Index: " + i + " Word: " + sArr[i]);
                //}

                //Char[] chArr = str.ToCharArray();
                //for (int i = 0; i < chArr.Length; i++)
                //{
                //    Console.WriteLine("Index: "+i+" char: " + chArr[i]);
                //}


                //Console.WriteLine(str.IndexOf("s"));
                //Console.WriteLine(str.LastIndexOf("s"));

                //Console.WriteLine(str.StartsWith("a"));
                //Console.WriteLine(str.EndsWith("p"));

                //string str2=str.Substring(3, 2);
                //Console.WriteLine("Original: "+str);
                //Console.WriteLine("Sub: "+str2);
#endregion

            }
        public static void Test(string? x)
        {
            Console.WriteLine(x);
        }
        public static int Addition(params int[]Arr)
        {
            int s = 0;
            foreach (var item in Arr)
            {
                s += item;
            }
            return s;
        }
        public static int Calc(int x, int y, out int d, out int m)
        {
            int z = x + y;
             d = x / y;
             m = x * y;
            return z;
        } 
        public static void CallByRef(ref int x,ref int y)
        {
            x += 5;
            y *= 2;
            Console.WriteLine("Inside x : " + x);
            Console.WriteLine("Inside y : " + y);

        }
        public static  void CallByValue(int x, int y)
        {
            x += 5;
            y *= 2;
            Console.WriteLine("Inside x : "+x);
            Console.WriteLine("Inside y : "+y);

        }
        #region Array Practices

        public static void ArrayUniqueChar()
        {
            string str = "csharpcorener";
            char[] arr = str.ToCharArray();
            char[] Temp = new char[arr.Length];
            int index = 0;
            foreach (var item in arr)
            {
                if (CheckExistChar(Temp, item) < 1)
                {
                    Console.WriteLine("Char is : "+item);
                    Temp[index] = item;
                    index++;

                }
            }
        }
        public static int CheckExistChar(char[] Arr, char n)
        {
            int count = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == n)
                {
                    count++;
                }

            }
            return count;
        }
        public static void Array6()
        {
            int[] nums = { 33, 44, 5, 2, 3, 5, 67, 3, 4, 2, 1, 2, 1 };
            int[]Temp=new int[nums.Length];
            int num = 5;
            int row = 0;
            for(int i=0; i<nums.Length; i++)
            {
                if (nums[i] != num)
                {
                    Temp[row] = nums[i];
                    row++;
                }
            }
            //print array   
            foreach (var item in Temp)
            {
                Console.Write(item+", ");
            }
         
        }
        public static void Array5()
        {
            int[] nums = { 33, 44, 5, 2, 3, 5, 67, 3, 4, 2, 1, 2, 1 };
            int[]Temp=new int[nums.Length];
            int index = 0;
            foreach (var item in nums)
            {

                if (CheckExist(Temp, item) < 1)
                {
  Console.WriteLine("Occurance: of "+item+": " + CheckExist(nums,item));
                 Temp[index] = item;
                 index++;
                    
                }
            }
        }
        public static int CheckExist(int[]Arr, int n)
        {
            int count=0;
            for(int i = 0; i < Arr.Length; i++)
            {
                if(Arr[i] == n) { 
                    count++;
                }
                   
            }
            return count;
        }
        public static void Array4()
        {
            int[][] Arr = new int[3][];
            int[] tem = new int[3];
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("Please enter size of {0} row column size", i);
                int s = int.Parse(Console.ReadLine());
                Arr[i] = new int[s];
                tem[i] = s;
                Console.WriteLine();
            }
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j < tem[i]; j++)
                {
                    Console.WriteLine("Enter num for {0} row and{1} col",i,j);
                    int n = int.Parse(Console.ReadLine());
                    Arr[i][j] = n;
                }
            }

            //print array
            Console.WriteLine("==========================");
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j < tem[i]; j++)
                {
                    Console.Write(" {0} ", Arr[i][j]);
                 
                }
                Console.WriteLine();
            }

        }
        public static void Array3()
        {
            int[,] nums = new int[3, 4];
            nums[0,0] = 10;
            nums[0,1] = 20;
            nums[0,2] = 30;
            nums[0,3] = 31;

            nums[1, 0] = 40;
            nums[1, 1] = 50;
            //nums[1, 2] = 70;
            //nums[1, 3] = 91;

            nums[2, 0] = 40;
            //nums[2, 1] = 60;
            //nums[2, 2] = 40;
            //nums[2, 3] = 14;

            for(int i=0; i<3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0}", nums[i,j]);
                }
                Console.WriteLine();
            }

        }
        public static void Array2()
        {
            string[] names = { "abhay","amit","suraj","rohit","rajat" };
            for (int i=0; i<names.Length; i++)
            {
                if (names[i][0].ToString()=="r")
                {
                    Console.WriteLine(names[i]);
                }
            }

            //foreach(string name in names)
            //{
            //    if (name.Contains("r"))
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
        }
        public static void Array1()
        {
         int[]nums;
            Console.WriteLine("Enter size ?");
            int size = int.Parse(Console.ReadLine());
            nums = new int[size];
         
            for(int i=0; i<nums.Length; i++)
            {
                Console.WriteLine("Please enter number on {0} index",i);
                int n = int.Parse(Console.ReadLine());
                nums[i] = n;
            }
            //print numbers
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("Index: {0}, Number: {1}", i, nums[i]);
            //}

           
            foreach(var n in nums)
            {             
                Console.WriteLine("Number: {0}", n);
            }

        }
        #endregion

        #region Loop Practices
        public static void Pattern8()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if ((i<=5 && j<=6)  ||(i==6 && j==7))
                    {
                        Console.Write(" *");
                    }
                    else {
                       
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void ContinueTest()
        {
            for (int i = 1; i < 10; i++)
            {
                if (i == 5 || i == 7)
                    continue;
                else
                    Console.WriteLine(i);
            }
        }
        public static void Pattern7()
        {
            int n = 4;//n=5   i=6            sp=1  j=1
            for (int i = 1; i <= 9; i+=2)
            {
                for (int sp =1; sp <=n; sp++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + j%2);
                }
                n--;
                Console.WriteLine();
            }

        }

        public static void Pattern6()
        {
            // int k = 4;
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= 6; j++)
                {
                    if ((i == 1 && j >= 1) || ((i == 2 && j == 1) || (i ==2&& j==6)) || (i == 3 && j >= 1) || (i==4 && j==1)|| (i == 5 && j == 1) )
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                //k--;
                Console.WriteLine();
            }
        }
        public static void Pattern5()
        {
           // int k = 4;
            for (int i = 1; i <= 4; i++)
            {
                for(int sp=4-i; sp>0; sp--)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <=i; j++)
                {
                    Console.Write(" "+j);
                }
                for (int k = i-1; k >=1; k--)
                {
                    Console.Write(" " + k);
                }

                //k--;
                Console.WriteLine();
            }
        }
        public static void Pattern4()
        {
           // int k = 4;
            for (int i = 1; i <= 5; i++)
            {
                for(int sp=5-i; sp>0; sp--)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <=i; j++)
                {
                    Console.Write(" *");
                }
                //k--;
                Console.WriteLine();
            }
        }
        public static void Pattern3()
        {
           
            for (int i = 1; i <=5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" " + j);
                }
               
                Console.WriteLine();
            }
        }

        public static void Pattern2()
        {
            //int p = 5;
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j >=1; j--)
                {
                    Console.Write(" " + j);
                }
                //  p--;
                Console.WriteLine();
            }
        }
        public static void Pattern1()
        {
            //int p = 5;
            for(int i=5; i>=1; i--)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(" "+j);
                }
              //  p--;
                Console.WriteLine();
            }
        }

        public static void GCD()
        {
            Console.WriteLine("Enter first number ?");
            int n1=Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter second number ?");
            int n2=Int32.Parse(Console.ReadLine());

            int gcd = 1;
            if (n1 == n2)
            {
                gcd = n1;
            }
            if (n1 > n2)
            {
                int temp = n1;
                n1 = n2;
                n2 = temp;
            }
            int i = 1;
            while (i <= n1)
            {
                if (n1 % i == 0 && n2 % i == 0)
                    gcd = i;
                i++;
            }
            Console.WriteLine("Greatest Comman Dvisior : "+gcd);
        }
        public static void GenerateFib()
        {
            Console.WriteLine("Enter terms ?");
            short t = Int16.Parse(Console.ReadLine());
            int a = 0, b = 1;
            string series = a.ToString() + ',' + b.ToString();
            int i=1;
            while (i <= t - 2)
            {
                int c = a + b;
                series += "," + c;
                a = b;
                b = c;
                i++;
            }
            Console.WriteLine(series);
        }
        public static void GetDiscount()
        {
            Console.WriteLine("Enter Amount ?");
            decimal amount = decimal.Parse(Console.ReadLine());
            decimal discount = 0, resetamount = 0;
            if (amount >= 10000)
            {
                discount = amount * 25 / 100;
                resetamount = amount - discount;
            }
            else if (amount >= 5000)
            {
                discount = amount * 15 / 100;
                resetamount = amount - discount;
            }
            else if (amount >= 1000)
            {
                discount = amount * 10 / 100;
                resetamount = amount - discount;
            }
            else
            {
                discount = amount * 3 / 100;
                resetamount = amount - discount;
            }

            Console.WriteLine("-------------------------------\n");
            Console.WriteLine("Your total amount= "+amount);
            Console.WriteLine("Your total discount= "+discount);
            Console.WriteLine("Your total payable amount= "+resetamount);
          

        }
        public static void GetSorted()
        {
            Console.WriteLine("Enter first number ?");
            int n1 = Int32.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter second number ?");
            int n2 = Int32.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter third number ?");
            int n3 = Int32.Parse(Console.ReadLine());
            if(n1<n2 && n1 < n3)
            {
                if (n2 < n3)
                {
                    Console.WriteLine($"{n1},{n2},{n3}");
                }
                else
                {
                    Console.WriteLine($"{n1},{n3},{n2}");
                }
            }
            else if(n2<n1&& n2 < n3)
            {
                if (n1 < n3)
                {
                    Console.WriteLine($"{n2},{n1},{n3}");
                }
                else
                {
                    Console.WriteLine($"{n2},{n3},{n1}");
                }
            }
            else
            {
                if (n1 < n2)
                {
                    Console.WriteLine($"{n3},{n1},{n2}");
                }
                else
                {
                    Console.WriteLine($"{n3},{n2},{n1}");
                }
            }

        }
        public static void Product()
        {
            ArrayList arrayList = new ArrayList();

            Console.WriteLine("Enter first number ?");
            int n1;
            bool s1= Int32.TryParse(Console.ReadLine(), out n1);
            Console.WriteLine(s1);

            Console.WriteLine("Enter second number ?");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int n3 = n1 * n2;
            Console.WriteLine("Product is : "+n3);
        }

        #endregion
    }
}
