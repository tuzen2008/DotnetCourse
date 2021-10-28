using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    /// <summary>
    /// 带泛型接口的Student
    /// </summary>
    class Student : IComparable<Student>
    {
        public Student() { }
        public Student(string name)
        {
            this.stuName = name;
        }

        public int Age { get; set; }
        public int StuId { get; set; }

        private string stuName;
        public string StuName
        {
            get { return stuName; }
            set { stuName = value; }
        }

        /// <summary>
        /// 泛型接口中必须要实现的方法
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        //public int CompareTo(Student other)
        //{
        //    //return other.StuId - this.StuId;//按照学号降序排列     
        //    return this.StuId - other.StuId;//按照学号升序排列
        //}

        /// <summary>
        ///  泛型接口中必须要实现的方法
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns> 
        public int CompareTo(Student other)
        {
            //按照姓名降序排列
            return other.stuName.CompareTo(this.stuName);
        }
    }

}
