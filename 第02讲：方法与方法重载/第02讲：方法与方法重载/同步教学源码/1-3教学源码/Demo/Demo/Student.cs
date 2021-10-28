using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    class Student
    {

        private int studentId;
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        // public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }

        // private string info;

        /// <summary>
        /// 获取默认学员信息
        /// </summary>
        /// <returns></returns>
        public string GetStudent()
        {
            string info = string.Format("姓名：{0}   学号：{1}   年龄：{2}", StudentName, studentId, Age);
            return info;
        }
        /// <summary>
        /// 根据输入的学员信息返回详细内容
        /// </summary>
        /// <param name="stuName">学员姓名</param>
        /// <param name="stuId">学号</param>
        /// <param name="birthday">出生日期</param>
        /// <returns>返回完整的学员信息</returns>
        public string GetStudentInfo(string stuName, int stuId, DateTime birthday)
        {
            this.Birthday = birthday;
            string info = string.Format("姓名：{0}   学号：{1}", stuName, stuId);
            return info;
        }
        /// <summary>
        /// 展示学员信息
        /// </summary>
        public void ShowStudentInfo()
        {
            string info = string.Format("姓名：{0}   学号：{1}   年龄：{2}", StudentName, studentId, Age);
            Console.WriteLine(info);
        }

        
    }
}
