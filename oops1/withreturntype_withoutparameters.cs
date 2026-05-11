using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class withreturnvalue
    {
        public int sum()
        {
            int a, b, c;
            a = 1000;
            b = 2000;
            c = a + b;
            return c;

        }
        public string name()
        {
            string name = "Rama";
            return name;
        }

    }
    internal class withreturntype_withoutparameters
    {
        //static void Main(string[] args)
        //{
        //    withreturnvalue wrv = new withreturnvalue();
        //    int result=wrv.sum();
        //    Console.WriteLine("The return result is: " + result);
        //    string nameres = wrv.name();
        //    Console.WriteLine("Ruturned Name is: " + nameres);

        //}
    }
}
