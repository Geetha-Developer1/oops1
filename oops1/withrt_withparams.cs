using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class class1
    {
        public int sum1(int x,int y)
        {
            int z;
            z = x + y;
            return z;
        }
        public string methname(string name)
        {
            return name;
        }
    }
    internal class withrt_withparams
    {
        static void Main(string[] args)
        {
            class1 obj1 = new class1();
            int res = obj1.sum1(11, 22);
            Console.WriteLine("The return sum result: " + res);
            string resname = obj1.methname("Rama");
            Console.WriteLine("The return Name result: " + resname);

        }

    }
}
