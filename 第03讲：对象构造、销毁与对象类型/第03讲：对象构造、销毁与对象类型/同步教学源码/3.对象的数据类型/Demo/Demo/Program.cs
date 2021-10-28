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
            Student objStudent1 = new Student();
            objStudent1.StudentId = 10003;
            objStudent1.StudentName = "小李";
            objStudent1.Birthday = Convert.ToDateTime("1990-09-10");

            Student objStudent2 = new Student(10004, "小张", Convert.ToDateTime("1989-10-10"));

            Student objStudent3 = new Student()
            {
                StudentId = 10005,
                Birthday = Convert.ToDateTime("1987-10-11"),
                StudentName = "小红"
            };


            Student objStudent4 = objStudent3;//将第三个对象赋值给第四个对象
            objStudent4.StudentName = "小赵";
            objStudent4.StudentId = 10009;

            Console.WriteLine("objStudent3.StudentId={0}     objStudent3.StudentName={1}", objStudent3.StudentId, objStudent3.StudentName);

            Console.WriteLine("objStudent4.StudentId={0}     objStudent4.StudentName={1}", objStudent4.StudentId, objStudent4.StudentName);


            object obj = 10;

            int a = 50;
            int b = a;
            b += 5;
            Console.WriteLine("a={0}   b={1}",a,b);

            Console.ReadLine();
        }
    }
}
