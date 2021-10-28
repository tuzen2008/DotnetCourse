using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    #region 示例1：定义学生类

    class Student
    {
        //字段：学号
        private int studentId;
        //字段：学员姓名
        private string studentName = string.Empty;
        //属性：学号
        public int StudentID
        {
            get { return studentId; }
            set { studentId = value; }
        }
        //属性：学员姓名
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        //方法：获取学员信息
        public string GetStudent()
        {
            string info = string.Format("姓名：{0}  学号：{1} ", studentName, studentId);
            return info;
        }
    }

    #endregion

    #region 示例2：断点调试属性的执行过程

    //class Student
    //{
    //    //字段：学号
    //    private int studentId;
    //    //字段：学员姓名
    //    private string studentName = string.Empty;
    //    private int age;
    //    //属性：学号
    //    public int StudentID
    //    {
    //        get { return studentId; }
    //        set { studentId = value; }
    //    }
    //    //属性：学员姓名
    //    public string StudentName
    //    {
    //        get { return studentName; }
    //        set { studentName = value; }
    //    }
    //    //属性：年龄
    //    public int Age
    //    {
    //        get { return age; }
    //        set { age = value; }
    //    }
    //    //方法：获取学员信息
    //    public string GetStudent()
    //    {
    //        string info = string.Format("姓名：{0}  学号：{1} ", studentName, studentId);
    //        return info;
    //    }

    #endregion

    #region 示例5：使用属性避免非法数据

    //class Student
    //{
    //    //字段：学号
    //    private int studentId;
    //    //字段：学员姓名
    //    private string studentName = string.Empty;
    //    private int age;
    //    public int Age
    //    {
    //        get { return age; }
    //        set
    //        {
    //            if (value < 18)
    //                age = 18;
    //            else
    //                age = value;
    //        }
    //    }
    //    //属性：学号
    //    public int StudentID
    //    {
    //        get { return studentId; }
    //        set { studentId = value; }
    //    }
    //    //属性：学员姓名
    //    public string StudentName
    //    {
    //        get { return studentName; }
    //        set { studentName = value; }
    //    }
    //    //方法：获取学员信息
    //    public string GetStudent()
    //    {
    //        string info = string.Format("姓名：{0}  学号：{1}  年龄：{2}", studentName, studentId, age);
    //        return info;
    //    }

    #endregion

    #region 示例7：没有对应私有字段的属性

    //class Student
    //{
    //    //字段：学号
    //    private int studentId;
    //    //字段：学员姓名
    //    private string studentName = string.Empty;
    //    //出生日期
    //    private DateTime birthday;
    //    public DateTime Birthday
    //    {
    //        get { return birthday; }
    //        set { birthday = value; }
    //    }
    //    //没有私有字段的属性
    //    public int Age
    //    {
    //        get { return DateTime.Now.Year - birthday.Year; }
    //    }
    //    //属性：学号
    //    public int StudentID
    //    {
    //        get { return studentId; }
    //        set { studentId = value; }
    //    }
    //    //属性：学员姓名
    //    public string StudentName
    //    {
    //        get { return studentName; }
    //        set { studentName = value; }
    //    }
    //    //方法：获取学员信息
    //    public string GetStudent()
    //    {
    //        string info = string.Format("姓名：{0}  学号：{1}  年龄：{2}", studentName, studentId, Age);
    //        return info;
    //    }

    #endregion

    #region 示例8：方法定义举例

    //class Student
    //{
    //    //字段：学号
    //    private int studentId;
    //    //字段：学员姓名
    //    private string studentName = string.Empty;
    //    //出生日期
    //    private DateTime birthday;
    //    public DateTime Birthday
    //    {
    //        get { return birthday; }
    //        set { birthday = value; }
    //    }
    //    //没有私有字段的属性
    //    public int Age
    //    {
    //        get { return DateTime.Now.Year - birthday.Year; }
    //    }
    //    //属性：学号
    //    public int StudentID
    //    {
    //        get { return studentId; }
    //        set { studentId = value; }
    //    }
    //    //属性：学员姓名
    //    public string StudentName
    //    {
    //        get { return studentName; }
    //        set { studentName = value; }
    //    }
    //    /// <summary>
    //    /// 没有参数的方法
    //    /// </summary>
    //    /// <returns></returns>
    //    public string GetStudent()
    //    {
    //        string info = string.Format("姓名：{0}  学号：{1}  年龄：{2}", studentName, studentId, Age);
    //        return info;
    //    }
    //    /// <summary>
    //    /// 有参数的方法
    //    /// </summary>
    //    /// <param name="stuName">姓名</param>
    //    /// <param name="stuId">学号</param>
    //    /// <param name="birthday">出生日期</param>
    //    /// <returns>返回学生信息</returns>
    //    public string GetStudentInfo(string stuName, int stuId, DateTime birthday)
    //    {
    //        this.birthday = birthday;
    //        return string.Format("姓名：{0}  学号：{1}  年龄：{2}", stuName, stuId, Age);            
    //    }
    //    /// <summary>
    //    /// 没有返回值的方法
    //    /// </summary>
    //    public void ShowStudentInfo()
    //    {
    //        string info = string.Format("姓名：{0}  学号：{1}  年龄：{2}", studentName, studentId, Age);
    //        Console.WriteLine(info);
    //    }


    #endregion

    #region 示例10：方法使用中的常见错误

    //class Student
    //{
    //    //字段：学号
    //    private int studentId;
    //    //字段：学员姓名
    //    private string studentName = string.Empty;
    //    //出生日期
    //    private DateTime birthday;
    //    public DateTime Birthday
    //    {
    //        get { return birthday; }
    //        set { birthday = value; }
    //    }
    //    //没有私有字段的属性
    //    public int Age
    //    {
    //        get { return DateTime.Now.Year - birthday.Year; }
    //    }
    //    //属性：学号
    //    public int StudentID
    //    {
    //        get { return studentId; }
    //        set { studentId = value; }
    //    }
    //    //属性：学员姓名
    //    public string StudentName
    //    {
    //        get { return studentName; }
    //        set { studentName = value; }
    //    }
    //    /// <summary>
    //    /// 没有参数的方法
    //    /// </summary>
    //    /// <returns></returns>
    //    public string GetStudent()
    //    {
    //        string info = string.Format("姓名：{0}  学号：{1}  年龄：{2}", studentName, studentId, Age);
    //        return info;
    //    }
    //    /// <summary>
    //    /// 有参数的方法
    //    /// </summary>
    //    /// <param name="stuName">姓名</param>
    //    /// <param name="stuId">学号</param>
    //    /// <param name="birthday">出生日期</param>
    //    /// <returns>返回学生信息</returns>
    //    public string GetStudentInfo(string stuName, int stuId, DateTime birthday)
    //    {
    //        this.birthday = birthday;
    //        string.Format("姓名：{0}  学号：{1}  年龄：{2}", stuName, stuId, Age);
    //    }
    //    public int GetStudentInfo(string stuName, int stuId, DateTime birthday)
    //    {
    //        this.birthday = birthday;
    //        string info = string.Format("姓名：{0}  学号：{1}  年龄：{2}", stuName, stuId, Age);
    //        return info;
    //    }
    //    /// <summary>
    //    /// 没有返回值的方法
    //    /// </summary>
    //    public void ShowStudentInfo()
    //    {
    //        string stuInfo = string.Format("姓名：{0}  学号：{1}  年龄：{2}", studentName, studentId, Age);
    //        Console.WriteLine(stuInfo);
    //    }
    //    public string ShowStuInfo()
    //    {
    //        string info = stuInfo + " 出生日期：" + birthday;
    //        return info;
    //    }

    //}
    #endregion
}
