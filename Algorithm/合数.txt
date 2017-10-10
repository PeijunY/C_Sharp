namespace 合数
{
    //合数就是非素数，即除了1和它本身之外还有其他约数的正整数。
    //编写一个程序求出指定数据范围（假设10~100）内的所有合数。
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 100; i++)
                for (int j = 2; j < Math.Sqrt(i)+1; j++)  //根号i加1  ****模的思想****
                    if (i % j == 0)
                    {
                        Console.Write("{0} ",i); //让结果不换行，write ot writeline                      
                        break;
                    }
        }
    }
}
//****模的思想****
//无论是判断质数还是合数只要验证这个数的根号数加1的范围内是否有满足的结果就可以了！！判断有的话，只要判断有一个满足就行！！！！
