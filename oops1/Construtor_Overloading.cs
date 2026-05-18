using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class student4
    {
        public int sid;
        public string sname;
        public short sage;
        public student4(int id)
        {
            sid = id;
            sname = "Not Provided";
        
        }
        public student4(string name)
        {
            sname = name;

        }
        public student4(short age)
        {
            sage = age;
            sname = "Not Provided";
        }
        public student4(int id,string name)
        {
            sid = id;
            sname = name;
        }
        public student4(int id,string name,short age)
        {
            sid = id;
            sname = name;
            sage = age;
        }
        public student4(string name,short age)
        {
            sname = name;
            sage = age;
        }
        public void display()
        {
            Console.WriteLine("Student Id is:" + sid);
            Console.WriteLine("Student name is:" + sname);
            Console.WriteLine("Student age is:" + sage);

        }
    }
    internal class Construtor_Overloading
    {
      static void Main(string[] args)
        {
            student4 s1 = new student4(101);
            s1.display();
            Console.WriteLine("-------------------------");
            student4 s2 = new student4("Rama");
            s2.display();
            Console.WriteLine("-------------------------");
            student4 s3 = new student4(20);
            s3.display();
            Console.WriteLine("-------------------------");
            student4 s4 = new student4(102,"Sita",21);
            s4.display();

        }
    }
}
