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
            string info = objStudent1.GetStudentInfo("肖明亮", 1002, Convert.ToDateTime("1990-10-10"));
            Console.WriteLine(info);

            Student objStudent2 = new Student();
            objStudent2.StudentName = "黎明";
            objStudent2.StudentId = 1003;
            objStudent2.Birthday = Convert.ToDateTime("1993-10-12");
            objStudent2.ShowStudentInfo();

            Console.ReadLine();

        }
    }
}
