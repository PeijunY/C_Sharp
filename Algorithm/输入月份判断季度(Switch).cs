 	static void Main(string[] args)
        {
            //输入一个月份，判断这个月份属于哪个季节？
            Console.Write("请输入一个月份： ");
            byte month = byte.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0}月是冬季", month.ToString());
                    break;
                case 3:
                case 4:
                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0}月是春季", month.ToString());
                    break;
                case 6:
                case 7:
                case 8:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0}月是夏季", month.ToString());
                    break;
                case 9:
                case 10:
                case 11:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0}月是夏季", month.ToString());
                    break;

                default:
                    break;
            }
            Console.ResetColor();
            Console.ReadKey();
        }