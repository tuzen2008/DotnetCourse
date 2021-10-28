using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    /// <summary>
    /// 计算器类
    /// </summary>
    class Calculator
    {
        public Calculator()
        { 
        
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(int a, double b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            //  int result =Add(a, b);        
            // return result + c;
            return a + b + c; 
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Sub(int a, double b)
        {
            return a - b;
        }
    }
}
