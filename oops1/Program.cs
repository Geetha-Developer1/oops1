using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class Myclass
    {
        public void greet()
        {
            Console.WriteLine("Welcome to The World!");

        }
        public void greet(string name)
        {
            Console.WriteLine("Hello " + name + ", Welcome to the Methods and here the name is coming by parameter");
        }
        public void add(int a, int b)

        {
            int c = a + b;
            Console.WriteLine("Addition of two numbers With parameter values:-   " + c);
        }  
        public void add()
        {
            int a = 100;
            int b = 200;
            int c = a + b;
            Console.WriteLine("Addition of two numbers without parameter values:-   " + c);
        }
    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Myclass obj1 = new Myclass();
        //    obj1.greet();
        //    obj1.greet("Rama");
        //    obj1.add(10, 20);
        //    obj1.add();
        //}
    }
}
