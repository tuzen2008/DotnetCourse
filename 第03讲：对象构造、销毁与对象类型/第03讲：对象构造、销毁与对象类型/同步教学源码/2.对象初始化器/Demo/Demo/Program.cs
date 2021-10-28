using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
    }
}
