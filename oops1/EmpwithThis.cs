using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class  Employ
    {
        int id;
       public string name;
        double salary;
        public Employ(int id,string name,double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void Display()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("\nEmployee ID:"+id);
            Console.WriteLine("Employee name:" + name);
            Console.WriteLine("Employee Salary:" + salary);

        }
    }
    internal class EmpwithThis
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Employees you want to tack:");
            int n = int.Parse(Console.ReadLine());
            Employ[] emp = new Employ[n];
            for(int i=0;i<n;i++)
            {
                Console.Write("\nEnter ID:");
                int eid = int.Parse(Console.ReadLine());
                Console.Write("Enter Name:");
                string ename = Console.ReadLine();
                Console.Write("Enter salary:");
               double esal = double.Parse(Console.ReadLine());

                emp[i] = new Employ(eid, ename, esal);
            }
            for(int i=0;i<n;i++)
            {
                emp[i].Display();
            }
            Console.WriteLine("\nEnter Name for searching");
            string searchname=Console.ReadLine();
            for(int i=0;i<n;i++)
            {
                if (searchname == emp[i].name)
                emp[i].Display();
            }

        }

    }
}
