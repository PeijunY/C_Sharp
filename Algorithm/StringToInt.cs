//（3）写出一个控制台应用程序，实现一个string类型变量转换为一个int类型变量的多种方法。
using System;
using System.Collections.Generic;
using System.Text;
namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int i = Convert.ToInt32(s);         //第1种方法
            int j = Int32.Parse(s);           //第2种方法
            Console .WriteLine ("{0},{1}",i,j);
        }
    }

}
