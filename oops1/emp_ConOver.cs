using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class employe
    {
        int id;
        string name;
        int sal;
        public employe()
        {
            id = 101;
            name = "ABC";
            sal = 50000;
        }
        public employe(int id)
        {
            this.id = id;
        }
        public employe(string name)
        {
            this.name = name;
        }
        //public employe(int sal)
        //{
        //    this.sal = sal;
        //}
        public employe(int id, string name, int sal)
        {
            this.id = id;
            this.name = name;
            this.sal = sal;
        }
            public void display()
            {
            Console.WriteLine("ID:" + id);
            Console.WriteLine("name:" + name);
            Console.WriteLine("salary:" + sal);
        }
    }
    internal class emp_ConOver
    {
        static void Main(String[] args)
        {
            employe e1 = new employe();
            e1.display();
            employe e2 = new employe(1);
            e2.display();
            employe e3 = new employe("ABC");
            e3.display();
            employe e4 = new employe(2,"XYZ",100000);
            e4.display();
        }
    }
}
