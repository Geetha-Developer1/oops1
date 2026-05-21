using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class newclass
    {
        int a;
        int b;
        public newclass(int a,int b)
        {
           this. a = a;
           this. b = b;
        }
        public void add()
        {
            int c = a + b;
            Console.WriteLine("Sum is:" + c);
        }
    }
    internal class thiskeyword
    {
        //static void Main(String[] args)
        //{
        //    newclass obj = new newclass(10,20);
        //    obj.add();
        //}
    }
}
