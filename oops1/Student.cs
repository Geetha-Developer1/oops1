using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace oops1
{
    internal class Student
    {
        public int id;
        public string name;
        public int age;
        public static string clgname;
        int sum;

        public void details(int num)
        {
           
            Console.WriteLine("Enter College name: ");
            clgname = Console.ReadLine();
            for (int i=0;i<num;i++)
            {
                Console.WriteLine("Enter Student ID: ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Student Age: ");
                age= int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter Number of Subjects of a student:");
                int marksnum = int.Parse(Console.ReadLine());
                Student std1 = new Student();
                 sum=std1.marks(marksnum);

                Console.WriteLine("------------------------------");
                Console.WriteLine("Student ID  : "+id);
                Console.WriteLine("Student Name: "+name);
                Console.WriteLine("Student age : "+age);
                Console.WriteLine("College Name:" + clgname);
                Console.WriteLine("Total Marks :" + sum);
                Console.WriteLine("Average Marks:" + sum / marksnum + "\n\n");


            }


        }
        public int marks( int marksnum)
        {
             sum = 0;
            int[] arr = new int[marksnum];
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine("Enter Marks for Subject " + (j + 1) + " :");
                arr[j] = int.Parse(Console.ReadLine());
            }
            Console.Write("You Entered Marks are:");
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k] + " ");
                sum += arr[k];
            }
            Console.WriteLine();
            return sum;
           
        }
        static void Main(string[] args)
        {
            Student std = new Student();
            Console.WriteLine("Enter Number of students you want:");
            int  num = int.Parse(Console.ReadLine());
            std.details(num);

        }
    }
}
