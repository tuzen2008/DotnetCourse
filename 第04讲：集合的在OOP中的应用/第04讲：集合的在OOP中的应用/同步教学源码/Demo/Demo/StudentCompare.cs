using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    //年龄升序排列
    class AgeASC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Age - y.Age;
        }
    }
    //年龄降序排列
    class AgeDESC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            //return y.Age - x.Age;
            return y.Age.CompareTo(x.Age);
        }
    }
    //姓名升序排列
    class NameASC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.StuName.CompareTo(y.StuName);
        }
    }
    //姓名降序排列
    class NameDESC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.StuName.CompareTo(x.StuName);
        }
    }
}
