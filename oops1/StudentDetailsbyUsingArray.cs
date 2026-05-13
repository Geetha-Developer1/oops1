using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    public class student
    {
        int sid;
        string name;
        int age;
        static string clg = "ABC College";
        public void getdetails()
        {
            Console.WriteLine("Enter ID:");
            sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
        }
        public void display() 
        {
            Console.WriteLine("Student ID:" + sid);
            Console.WriteLine("Student Name:" + name);
            Console.WriteLine("Student age:" + age);
            Console.WriteLine("Student College:" + clg);
        }
    }
    internal class StudentDetailsbyUsingArray
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("How many students you want to enter:");
        //    int num=int.Parse(Console.ReadLine());
        //    student[] std = new student[num];
        //    for (int i = 0; i < std.Length; i++)
        //    {
        //        std[i] = new student();
        //        std[i].getdetails();
        //    }
        //    Console.WriteLine("----------------------");
        //    for (int i = 0; i < std.Length; i++)
        //    {
        //        std[i].display();
        //    }
        //}
    }
}
