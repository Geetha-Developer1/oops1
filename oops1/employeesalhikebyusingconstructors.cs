using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class employee1
    {
        int eid;
        public string ename;
        double sal;
        static string company;
        public employee1()
        {
            eid = 101;
            ename = "Rama";
            sal = 50000;
            company = "ABC company";
        }
        public void getdetails()
        {
            Console.WriteLine("Enter emplyee ID:");
            eid=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee Name:");
            ename=Console.ReadLine();
            Console.WriteLine("Enter employee salary:");
            sal=double.Parse(Console.ReadLine());
        }
        public void displaydetails()
        {
            Console.WriteLine("Employee ID:" + eid);
            Console.WriteLine("Employee Name:" + ename);
            Console.WriteLine("Employee Salary:" + sal);
            Console.WriteLine("Employee Company:" + company);
        }
        public void salhike()
        {
            double hike = sal * 0.1;
            sal = sal + hike;
           // Console.WriteLine("10% Hike in salary:" + hike);
             Console.WriteLine("After 10% hike salary is: " + sal);
        }
        public void meth()
        {
            Console.WriteLine("How many employees you want to enter:");
            int num = int.Parse(Console.ReadLine());
            employee1[] emp = new employee1[num];
            for (int i = 0; i < num; i++)
            {
                emp[i] = new employee1();
                emp[i].getdetails();
            }
            Console.WriteLine("------------------------");
            //Display for all employee
            //for (int i = 0; i < num; i++)
            //{
            //    emp[i].displaydetails();
            //    emp[i].salhike();
            //}

            //display for one particular employee
            Console.WriteLine("Enter name for search:");
            string search = Console.ReadLine();
            for (int i = 0; i < num; i++)
            {
                if (search == emp[i].ename)
                {
                    emp[i].displaydetails();
                    emp[i].salhike();
                }
            }
        }
    }

    internal class employeesalhikebyusingconstructors
    {
        //static void Main(string[] args)
        //{
        //    employee1 empobj = new employee1();
        //    empobj.displaydetails();
        //    empobj.salhike();
        //    empobj.meth();


        //}
    }
}
