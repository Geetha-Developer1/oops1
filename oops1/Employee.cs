using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    public class employee
    {
        int eid;
        public string name;
        double sal;
        static string company = "ABC Company";
        public void getdetails()
        {
            Console.WriteLine("Enter Employee ID:");
            eid=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            name=Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            sal=double.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Employee ID : " + eid);
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee Salary : " + sal);
            Console.WriteLine("Employee Company Name : " + company);
        }
    }
    internal class Employee
    {
        //static void Main(String[] args)
        //{
        //    Console.WriteLine("How many Employee Details you want to Enter:");
        //    int num = int.Parse(Console.ReadLine());
        //    employee[] emp = new employee[num];
        //    for (int i = 0; i < emp.Length; i++)
        //    {
        //        emp[i] = new employee();
        //        emp[i].getdetails();
                
        //    }
        //    Console.WriteLine("-----------------------");
        //    Console.WriteLine("Enter employee name to search:");
        //    string search = Console.ReadLine();
        //    for (int i = 0; i < emp.Length; i++)
        //    {
        //        if (search == emp[i].name)
        //        {
        //            emp[i].display();
        //        }
               
        //    }
       // }
    }
}
