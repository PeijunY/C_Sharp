//（3）编写一个简单的计算器程序，能够根据用户从键盘输入的运算指令和整数，进行简单的加减乘除运算。
using System;
using System.Collections.Generic;
using System.Text;
namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个运算数字：");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("请输入运算符号：");
            char s = Convert .ToChar (Console .ReadLine());
            switch (s)
            {
                case '+': Console.WriteLine(a + "+" + b + "={0}", a + b); break;
                case '-': Console.WriteLine(a + "-" + b + "={0}", a - b); break;
                case '*': Console.WriteLine(a + "*" + b + "={0}", a * b); break;
                case '/': Console.WriteLine(a + "/" + b + "={0}", (Single )a / b); break;
                default: Console.WriteLine("输入的运算符有误！"); break;
            }
        }
    }
}
