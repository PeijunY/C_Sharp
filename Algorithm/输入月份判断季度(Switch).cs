 	static void Main(string[] args)
        {
            //����һ���·ݣ��ж�����·������ĸ����ڣ�
            Console.Write("������һ���·ݣ� ");
            byte month = byte.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0}���Ƕ���", month.ToString());
                    break;
                case 3:
                case 4:
                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0}���Ǵ���", month.ToString());
                    break;
                case 6:
                case 7:
                case 8:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0}�����ļ�", month.ToString());
                    break;
                case 9:
                case 10:
                case 11:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0}�����ļ�", month.ToString());
                    break;

                default:
                    break;
            }
            Console.ResetColor();
            Console.ReadKey();
        }