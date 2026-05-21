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
        string name;
        public Student6(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Student ID:" + id);
            Console.WriteLine("Student Name:" + name);
        }
    }
    internal class this1
    {
       static void Main(string[] args)
        {
            Student6 obj = new Student6(101, "Rama");
            obj.Display();
        }
    }
}
