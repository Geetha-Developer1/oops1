using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class employee5
    {
        int Eid;
        string Ename;
        double Esal;
        public employee5()
        {
            Eid = 101;
            Ename = "XYZ";
            Esal = 200000;
        }
        public employee5(int eid,string ename,double esal)
        {
            Eid = eid;
            Ename= ename;
            Esal= esal;

        }
        public void displayemp()
        {
            Console.WriteLine("Employee ID:" + Eid);
            Console.WriteLine("Employee Name:" + Ename);
            Console.WriteLine("Employee Salary:" + Esal);
        }
    }
    class student3
    {
        int sid;
        string sname;
        int fee;
        public student3()
        {
            sid = 1;
            sname = "abc";
            fee = 5000;
        }
        public student3(int Sid,string Sname,int Fee)
        {
            sid = Sid;
            sname = Sname;
            fee = Fee;
        }
        public void display()
        {
            Console.WriteLine("Student ID:" + sid);
            Console.WriteLine("Student Name:" + sname);
            Console.WriteLine("Student fee:" + fee);
        }
    }
    internal class parameterizedconstructor
    {
        //static void Main(string[] args)
        //{
        //    student3 obj1 = new student3(101, "Rama", 25000);
        //    Console.WriteLine("---------------------------Parameterized Constructor student details");

        //    obj1.display();
        //    student3 obj2 = new student3();
        //    Console.WriteLine("---------------------------Default Constructor student details");
        //    obj2.display();


        //    employee5 e=new employee5();
        //    Console.WriteLine("---------------------------Default Constructor Employee details");
        //    e.displayemp();
        //    employee5 emp = new employee5(102, "Sita", 300000);
        //    Console.WriteLine("---------------------------Parameterized Constructor Employee details");
        //    emp.displayemp();
           

        //}
    }
}
