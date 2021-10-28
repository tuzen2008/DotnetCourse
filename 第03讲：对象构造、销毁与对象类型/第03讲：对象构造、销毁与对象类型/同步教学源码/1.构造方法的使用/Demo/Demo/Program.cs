using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator objCal = new Calculator();
            int result1 = objCal.Add(10, 20);
            double result2 = objCal.Sub(20.09, 12.9);
            int result3 = Calculator.Add(10, 24, 55);
            Console.WriteLine("result1={0}", result1);
            Console.WriteLine("result2={0}", result2);
            Console.WriteLine("result3={0}", result3);
            Console.ReadLine();

        }

        //static void Main(string[] args)
        //{

        //     Student objStudent = new Student();
        //     objStudent.StudentName = "小王";
        //     objStudent.StudentId = 1008;


        //    Student objStudent1 = new Student(1002, "刘超");

        //    Student objStudent3 = new Student(1002, "刘超", 20);
        //    Console.WriteLine("姓名={0}  学号={1}", objStudent1.StudentName, objStudent1.StudentId);
        //    Console.WriteLine("姓名={0}  年龄={1}", objStudent3.StudentName, objStudent3.Age);

        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{

        //    for (int a = 1; a <= 9; a++)//外循环：控制函数
        //    {
        //        for (int b = 1; b <= a; b++)
        //        {
        //            Console.Write("{0}*{1}={2}\t", a, b, a * b);
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.ReadLine();
        //}
    }
}
