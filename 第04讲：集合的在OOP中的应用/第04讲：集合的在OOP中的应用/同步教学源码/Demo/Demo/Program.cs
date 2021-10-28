using System;
using System.Collections;//引入非泛型集合命名空间（在.NET1.1版本使用）
using System.Collections.Generic;//（.NET2.0以后出现泛型，建议集合都是用泛型集合）
using System.Linq;
using System.Text;

namespace Demo
{
    class Program
    {
        #region 示例1：ArrayList的使用
        static void Main(string[] args)
        {
            //实例化集合对象
            ArrayList list = new ArrayList();
            //添加对象元素
            Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
            Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
            Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
            list.Add(objStu1);
            list.Add(objStu2);
            list.Add(objStu3);
            //遍历元素
            for (int i = 0; i < list.Count; i++)
            {
                Student obj = (Student)list[i];
                Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", obj.StuName, obj.Age, obj.StuId);
            }
            //删除元素
            list.RemoveAt(1);
            Console.WriteLine("删除后元素总数：{0}", list.Count);
            Console.ReadLine();
        }
        #endregion

        #region 演示：使用索引查找元素的方法的局限性
        //static void Main(string[] args)
        //{
        //    //实例化集合对象
        //    ArrayList list = new ArrayList();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    list.Add(objStu1);
        //    list.Add(objStu2);
        //    list.Add(objStu3);

        //    Student obj = (Student)list[1];
        //    Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", obj.StuName, obj.Age, obj.StuId);
        //    //删除元素
        //    list.RemoveAt(0);
        //    obj = (Student)list[0];
        //    Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", obj.StuName, obj.Age, obj.StuId);
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例2：使用关键字查找元素的Hashtable集合
        //static void Main(string[] args)
        //{
        //    //实例化集合对象
        //    Hashtable stus = new Hashtable();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    stus.Add("小张",objStu1);
        //    stus.Add("小李", objStu2);
        //    stus.Add("小王", objStu3);
        //    Student obj = (Student)stus["小李"];//通过关键字查找对象
        //    Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", obj.StuName, obj.Age, obj.StuId);
        //    //删除元素
        //    stus.Remove("小张");
        //    obj = (Student)stus["小李"];//查找元素的方式不变
        //    Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", obj.StuName, obj.Age, obj.StuId);
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例3：Hashtable元素的遍历
        //static void Main(string[] args)
        //{
        //    //实例化集合对象
        //    Hashtable stus = new Hashtable();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    stus.Add("小张", objStu1);
        //    stus.Add("小李", objStu2);
        //    stus.Add("小王", objStu3);
        //    //遍历key
        //    foreach (string item in stus.Keys)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    //遍历values
        //    foreach (object item in stus.Values)
        //    {
        //        Student obj = (Student)item;
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", obj.StuName, obj.Age, obj.StuId);
        //    }
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例4：ArrayList数据类型安全问题
        //static void Main(string[] args)
        //{
        //    //实例化集合对象
        //    ArrayList list = new ArrayList();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    list.Add(objStu1);
        //    list.Add(objStu2);
        //    list.Add(objStu3);
        //    //添加教师对象
        //    list.Add(new Teacher() { Name = "王老师", Age = 28 });
        //    //遍历元素
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Student obj = (Student)list[i];
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", obj.StuName, obj.Age, obj.StuId);
        //    }
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例5：ArrayList数据类型安全问题解决
        //static void Main(string[] args)
        //{
        //    //实例化集合对象
        //    ArrayList list = new ArrayList();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    list.Add(objStu1);
        //    list.Add(objStu2);
        //    list.Add(objStu3);
        //    //添加教师对象
        //    list.Add(new Teacher() { Name = "王老师", Age = 28 });
        //    //遍历元素
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i] is Student)
        //        {
        //            Student obj = (Student)list[i];
        //            Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", obj.StuName, obj.Age, obj.StuId);
        //        }
        //        else if (list[i] is Teacher)
        //        {
        //            Teacher obj = (Teacher)list[i];
        //            Console.WriteLine("姓名：{0}  年龄：{1} ", obj.Name, obj.Age, obj.Age);
        //        }              
        //    }
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例6：List集合常用方法
        //static void Main(string[] args)
        //{
        //    //实例化List<T>集合对象
        //    List<Student> list = new List<Student>();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    list.Add(objStu1);
        //    list.Add(objStu2);
        //    list.Add(objStu3);
        //    Student objStu4 = new Student() { Age = 25, StuId = 1004, StuName = "小秦" };
        //    //在指定位置插入元素,指定位置元素会相应后移
        //    list.Insert(1, objStu4);
        //    //遍历元素,取出元素时不需要强制转换
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", list[i].StuName, list[i].Age, list[i].StuId);
        //    }
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例7：泛型集合对元素类型的约束
        //static void Main(string[] args)
        //{
        //    //实例化List<T>集合对象
        //    List<Student> list = new List<Student>();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    list.Add(objStu1);
        //    list.Add(objStu2);
        //    list.Add(objStu3);
        //    Teacher objTeacher=new Teacher() { Name = "王老师", Age = 28 };
        //    list.Add(objTeacher);
        //    //遍历元素,取出元素时不需要强制转换
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", list[i].StuName, list[i].Age, list[i].StuId);
        //    }
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例8：集合初始化器的使用
        //static void Main(string[] args)
        //{
        //    //集合初始化器：使用基本数据类型元素
        //    List<string> nameList = new List<string>() 
        //    { 
        //         "小张","小李","小秦"
        //    };
        //    //集合初始化器和对象初始化器共同使用
        //    List<Student> stuList = new List<Student>() 
        //    { 
        //         new Student() { Age = 20, StuId = 1001, StuName = "小张" },
        //         new Student() { Age = 22, StuId = 1003, StuName = "小李" },
        //         new Student() { Age = 22, StuId = 1002, StuName = "小王" }
        //    };
        //    foreach (string item in nameList)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    foreach (Student stu in stuList)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", stu.StuName, stu.Age, stu.StuId);
        //    }
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例9：Dictionary<K,V>的使用
        //static void Main(string[] args)
        //{
        //    //实例化集合对象
        //    Dictionary<string, Student> stus = new Dictionary<string, Student>();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    stus.Add("小张", objStu1);
        //    stus.Add("小李", objStu2);
        //    Console.WriteLine("小李的年龄：{0}", stus["小李"].Age);//通过key查找value
        //    stus.Add("小王", objStu3);
        //    Console.WriteLine("小李的年龄：{0}", stus["小李"].Age);
        //    //遍历key
        //    foreach (string item in stus.Keys)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    //遍历values
        //    foreach (Student stu in stus.Values)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", stu.StuName, stu.Age, stu.StuId);
        //    }
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例10：基本数据类型元素的排序
        //static void Main(string[] args)
        //{
        //    //集合初始化器：使用基本数据类型元素
        //    List<string> nameList = new List<string>() 
        //    { 
        //         "小张","小李","小秦","小东","小唐","小白"
        //    };  
        //    Console.WriteLine ("-------------字符串默认排序--------------");
        //    foreach (string item in nameList)
        //    {
        //        Console.WriteLine(item);
        //    }      
        //    nameList.Sort();//使用Sort()方法对集合中元素排序（默认升序）
        //    Console.WriteLine("-------------字符串排序后--------------");
        //    foreach (string item in nameList)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    nameList.Reverse();//集合元素反转
        //    Console.WriteLine("-------------元素反转后--------------");
        //    foreach (string item in nameList)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    //集合初始化器：使用基本数据类型元素
        //    List<int> ageList = new List<int>() 
        //    { 
        //        20,27,21,26,28,30
        //    };
        //    Console.WriteLine("-------------整数元素默认排序--------------");
        //    foreach (int item in ageList)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    ageList.Sort();//使用Sort()方法对集合中元素排序（默认升序）
        //    Console.WriteLine("-------------整数元素排序后--------------");
        //    foreach (int item in ageList)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    ageList.Reverse();//集合元素反转
        //    Console.WriteLine("-------------元素反转后--------------");
        //    foreach (int item in ageList)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例11：对象类型元素排序的问题
        //static void Main(string[] args)
        //{
        //    //实例化List<T>集合对象
        //    List<Student> list = new List<Student>();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    list.Add(objStu1);
        //    list.Add(objStu2);
        //    list.Add(objStu3);
        //    list.Sort();//将对象元素排序       
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", list[i].StuName, list[i].Age, list[i].StuId);
        //    }
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例12：实现IComparable接口完成对象默认排序
        //static void Main(string[] args)
        //{
        //    //实例化List<T>集合对象
        //    List<Student> list = new List<Student>();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    list.Add(objStu1);
        //    list.Add(objStu2);
        //    list.Add(objStu3);
        //    list.Sort();//将对象元素排序（排序对象已经实现IComparable泛型接口）  
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", list[i].StuName, list[i].Age, list[i].StuId);
        //    }
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例12：实现IComparable接口完成对象默认排序
        //static void Main(string[] args)
        //{
        //    //实例化List<T>集合对象
        //    List<Student> list = new List<Student>();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    list.Add(objStu1);
        //    list.Add(objStu2);
        //    list.Add(objStu3);
        //    list.Sort();//按照学号升序排列
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", list[i].StuName, list[i].Age, list[i].StuId);
        //    }
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例13：实现IComparable接口完成对象按姓名排序
        //static void Main(string[] args)
        //{
        //    //实例化List<T>集合对象
        //    List<Student> list = new List<Student>();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    list.Add(objStu1);
        //    list.Add(objStu2);
        //    list.Add(objStu3);
        //    list.Sort();//按照姓名降序排列
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", list[i].StuName, list[i].Age, list[i].StuId);
        //    }
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例14：使用比较器ICompare<T>实现动态排序
        //static void Main(string[] args)
        //{
        //    //实例化List<T>集合对象
        //    List<Student> list = new List<Student>();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 22, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    list.Add(objStu1);
        //    list.Add(objStu2);
        //    list.Add(objStu3);
        //    //默认排序
        //    Console.WriteLine("------------默认排序------------");
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", list[i].StuName, list[i].Age, list[i].StuId);
        //    }
        //    //年龄降序排序
        //    Console.WriteLine("------------年龄降序排序------------");
        //    list.Sort(new AgeDESC());
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", list[i].StuName, list[i].Age, list[i].StuId);
        //    }
        //    //姓名升排序
        //    Console.WriteLine("------------姓名升序排序------------");
        //    list.Sort(new NameASC());
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", list[i].StuName, list[i].Age, list[i].StuId);
        //    }
        //    Console.ReadLine();
        //}
        #endregion

        #region 示例15：使用LINQ排序【后面VIP课程中详细讲解】
        //static void Main(string[] args)
        //{
        //    //实例化List<T>集合对象
        //    List<Student> list = new List<Student>();
        //    //添加对象元素
        //    Student objStu1 = new Student() { Age = 20, StuId = 1001, StuName = "小张" };
        //    Student objStu2 = new Student() { Age = 25, StuId = 1003, StuName = "小李" };
        //    Student objStu3 = new Student() { Age = 22, StuId = 1002, StuName = "小王" };
        //    list.Add(objStu1);
        //    list.Add(objStu2);
        //    list.Add(objStu3);
        //    //默认排序
        //    Console.WriteLine("------------默认排序------------");
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", list[i].StuName, list[i].Age, list[i].StuId);
        //    }
        //    //年龄降序排序
        //    Console.WriteLine("------------年龄降序排序------------");
        //    List<Student> stuList = list.OrderByDescending(s => s.Age).ToList();
        //    for (int i = 0; i < stuList.Count; i++)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", stuList[i].StuName, stuList[i].Age, stuList[i].StuId);
        //    }
        //    //姓名升序排序
        //    Console.WriteLine("------------姓名升序排序------------");
        //    stuList = list.OrderBy(s => s.StuName).ToList();
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine("姓名：{0}  年龄：{1}  学号：{2}", stuList[i].StuName, stuList[i].Age, stuList[i].StuId);
        //    }
        //    Console.ReadLine();
        //}
        #endregion


    }
}
