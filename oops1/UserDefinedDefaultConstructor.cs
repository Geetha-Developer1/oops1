using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    class studentforc
    {
        int sid;
        string sname;
        int sfee;
        //public studentforc()
        //{
        //    sid = 101;
        //    sname = "Rama";
        //    sfee = 25000;
        //}
        public void studentdisplay()
        {
            Console.WriteLine("Student ID:" + sid);
            Console.WriteLine("Student Name:" + sname);
            Console.WriteLine("Student Fee:" + sfee);
        }
    }
    internal class UserDefinedDefaultConstructor
    {
        //static void Main(string[] args)
        //{
        //    studentforc std1 = new studentforc();
        //    std1.studentdisplay();
        //    studentforc std2 = new studentforc();
        //    std2.studentdisplay();

        //}
    }
}
