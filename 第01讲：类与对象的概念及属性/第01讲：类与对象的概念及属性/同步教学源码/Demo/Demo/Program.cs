using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        #region 示例2：调用对象的属性与方法（断点调试观察执行过程）

        static void Main(string[] args)
        {
            //创建对象
            Student objStudent = new Student();


            //给对象属性赋值
            objStudent.StudentID = 1001;
            objStudent.StudentName = "小王";

            //调用对象的方法
            string info = objStudent.GetStudent();

            Console.WriteLine(info);
            Console.ReadLine();
        }

        #endregion

        #region 示例3：断点调试属性的执行过程

        //static void Main(string[] args)
        //{
        //    //创建对象
        //    Student objStudent = new Student();
        //    //给对象属性赋值
        //    objStudent.Age = 20;
        //    Console.WriteLine("学员的年龄：{0}", 
        //        objStudent.Age);
        //    Console.ReadLine();
        //}

        #endregion

        #region 示例5：使用属性避免非法数据

        //static void Main(string[] args)
        //{
        //    //创建对象
        //    Student objStudent = new Student();
        //    //给对象属性赋值
        //    objStudent.StudentName = "小王";
        //    objStudent.StudentID = 1001;
        //    objStudent.Age = -19;
        //    string info = objStudent.GetStudent();
        //    Console.WriteLine(info);
        //    Console.ReadLine();
        //}

        #endregion

        #region 示例6：只读属性的使用
        //static void Main(string[] args)
        //{
        //    Test objTest = new Test();
        //    objTest.PAI = 3.1415;
        //}
        #endregion

        #region 示例7：没有对应私有字段的属性

        //static void Main(string[] args)
        //{
        //    Student objStu = new Student();
        //    objStu.Birthday = Convert.ToDateTime("1990-5-1");
        //    Console.WriteLine("当年您的年龄：{0}", objStu.Age);
        //    Console.ReadLine();
        //}

        #endregion

        #region 示例9：方法的调用

        //static void Main(string[] args)
        //{
        //    Student objStu1 = new Student();
        //    string info = objStu1.GetStudentInfo("肖明", 1002, Convert.ToDateTime("1990-06-30"));
        //    Console.WriteLine(info);

        //    Student objStu2 = new Student();
        //    objStu2.StudentName = "黎明";
        //    objStu2.StudentID = 1003;
        //    objStu2.Birthday = Convert.ToDateTime("1993-06-21");
        //    objStu2.ShowStudentInfo();
        //    Console.ReadLine();
        //}

        #endregion
    }
}
