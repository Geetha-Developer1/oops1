using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1
{
    public class student1
    {
        int[] id;
        string[] name ;
        int[] age;
        public void Details(int num)
        {
            id = new int[num];
            name=new string[num];
            age = new int[num];
            for(int i=0;i<id.Length;i++)
            {
                Console.WriteLine("Enter ID:");
                id[i]= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                name[i]=Console.ReadLine();
                Console.WriteLine("Enter age:");
                age[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Name for getting details:");
            string search=Console.ReadLine();
            for(int i=0;i<name.Length;i++)
            {
                if (search == name[i])
                {
                    Console.WriteLine("Student ID:" + id[i]);
                    Console.WriteLine("Student Name:" + name[i]);
                    Console.WriteLine("Student age:" + age[i]);
                }
            }
        }
       
    }
    internal class StudentwithSearch
    {
        //static void Main(string[] args)
        //{
        //  student1 obj1=new student1();
        //    Console.WriteLine("How many student you want to enter:");
        //    int num = int.Parse(Console.ReadLine());
        //    obj1.Details(num);
        //}
    }
}
