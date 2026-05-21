using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class  Student6
    {
        int id;
        public string name;
        public Student6(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("\nStudent ID:" + id);
            Console.WriteLine("Student Name:" + name);
        }
    }
    internal class this1
    {
       //static void Main(string[] args)
       // {
       //     Console.WriteLine("How many students you want to tack:");
       //     int a = int.Parse(Console.ReadLine());
       //     Student6[] std = new Student6[a];

       //     for (int i = 0; i < a; i++)
       //     {
       //         Console.WriteLine("\nEnter Student ID:");
       //         int sid = int.Parse(Console.ReadLine());
       //         Console.WriteLine("Enter Student Name:");
       //         string sname = Console.ReadLine();
       //         std[i] = new Student6(sid, sname);
       //     }
       //     for(int i=0;i<a;i++)
       //     {
       //         std[i].Display();
       //     }
       //     Console.WriteLine("Enter name for searching");
       //     string searchname= Console.ReadLine();
       //     for(int i=0;i<a;i++)
       //     {
       //         if (searchname == std[i].name)
       //         {
       //             std[i].Display();
       //         }
       //     }
       // }
    }
}
