using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    class Student
    {
        public Student()
        {
            //this.StudentId = 10001;
            //this.StudentName = "张晓宇";
        }
        public Student(int stuId, string stuName)
        {
            this.StudentId = stuId;
            this.StudentName = stuName;
        }
        public Student(int stuId, string stuName, int age)
            : this(stuId, stuName)
        {
            //this.StudentId = stuId;
            //this.StudentName = stuName;
            this.Age = age;
        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }


    }
}
