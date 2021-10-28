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
            Dictionary<string, Student> stuDic = new Dictionary<string, Student>()
            {
                {"A",new Student(){ Name ="A", StudentId=1}},
                {"B",new Student(){ Name ="B", StudentId=2}},
                {"C",new Student(){ Name ="C", StudentId=3}},
                {"D",new Student(){ Name ="D", StudentId=4}}
            };

            foreach (string item in stuDic.Keys )
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
