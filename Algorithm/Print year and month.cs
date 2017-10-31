class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("请输入年份： ");
            int year = int.Parse(Console.ReadLine());
            //创建交错数组
            byte[][] months = new byte[12][];
            //根据月份不同创建不同月份的元素
            for (int month = 0; month < 12; month++)
            {
                switch (month)
                {
                    case 0:  //表示1月
                    case 2:
                    case 4:
                    case 6:
                    case 7:
                    case 9:
                    case 11:
                        months[month] = new byte[31];
                        break;
                    case 3:
                    case 5:
                    case 8:
                    case 10:
                        months[month] = new byte[30];
                        break;
                    case 1:
                        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))  //闰年的判断！
                            months[month] = new byte[29];
                        else months[month] = new byte[28];
                        break;
                    default:
                        break;
                }
            }
            //打印日历
            for (int month = 0; month < 12; month++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0}月： ", month + 1);
                for (int day = 0; day < months[month].Length; day++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0}日 ", day + 1);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }