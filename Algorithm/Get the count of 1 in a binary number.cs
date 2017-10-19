/// <summary>
/// 输入一个整数，输出该数二进制表示中1的个数。其中负数用补码表示。
/// </summary>

class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input a int number:");
                int n = Convert.ToInt32(Console.ReadLine());
                string n2 = Convert.ToString(n, 2);
                int count=0;
                foreach (char c in n2)
                {
                    if (c == '1')
                        count++;
                }

                //int result= ChargeOnesCountInNum(Convert.ToInt32(n2));
                Console.WriteLine("The binary result is {0}, the count of 1 is {1}", n2, count);
                Console.ReadKey();
            }
        }
    }
