using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class PrintingName
    {
        public void name()
            {
            Console.WriteLine("These message is without returntype and without parameter");
            Console.WriteLine("Name is:-Rama");

            }
        public void name(string name)
        {
            Console.WriteLine("These message is without returntype and with parameter");
            Console.WriteLine("Hello " + name + ", Welcome to the World");
        }

    } 

    internal class Printingmyname
    {
       //static void Main(String[] args)
       // {
       //     PrintingName pn = new PrintingName();
       //     pn.name();
       //     pn.name("Geetha");
       // }
    }
}
