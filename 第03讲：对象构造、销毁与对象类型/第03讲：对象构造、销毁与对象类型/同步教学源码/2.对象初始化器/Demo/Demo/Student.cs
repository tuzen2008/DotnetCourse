using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    class Student
    {
        public Student()
        { }
        public Student(int stuId, string stuName, DateTime bithday)
        {
            this.StudentId = stuId;
            this.StudentName = stuName;
            this.Birthday = Birthday;
        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime Birthday { get; set; }
    }
}
