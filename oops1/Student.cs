using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace oops1
{
    internal class Student
    {
        public int id;
        public string name;
        public int age;
        public static string clgname;

        public void details(int num)
        {
            Console.WriteLine("Enter College name: ");
            clgname = Console.ReadLine();
            for (int i=0;i<num;i++)
            {
                Console.WriteLine("Enter Student ID: ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Student Age: ");
                age= int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------");
                Console.WriteLine("Student ID  : "+id);
                Console.WriteLine("Student Name: "+name);
                Console.WriteLine("Student age : "+age);
                Console.WriteLine("College Name:" + clgname+"\n\n");
            }
           
        }
        static void Main(string[] args)
        {
            Student std = new Student();
            Console.WriteLine("Enter Number of students you want:");
            int num=int.Parse(Console.ReadLine());
            std.details(num);

          
        }
    }
}
