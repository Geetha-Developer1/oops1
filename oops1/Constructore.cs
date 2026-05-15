using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class myclass
    {
        public int a;
        int b;
        public myclass()
        {
            a = 10;
            b = 20;
            Console.WriteLine("Constructore Calling");
        }
        public int add()
        {
            Console.WriteLine("a value: " + a);
            Console.WriteLine("b value: " + b);
            return a+b;
        }
        public int sub()
        {
            return a - b;
        }
        public int mul()
        {
            return a * b;
        }
        public int div()
        {
            return a / b;
        }
    }
    internal class Constructore
    {
        //static void Main(String[] args)
        //{
        //    myclass obj = new myclass();
        //   int addres= obj.add();
        //    Console.WriteLine("Add is:" + addres);
        //    int subres=obj.sub();
        //    Console.WriteLine("sub is:" + subres);
        //    int mulres = obj.mul();
        //    Console.WriteLine("mul is:" + mulres);
        //    int divres = obj.div();
        //    Console.WriteLine("div is:" + divres);

        //}
    }
}

