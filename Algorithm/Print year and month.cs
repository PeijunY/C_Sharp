class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("��������ݣ� ");
            int year = int.Parse(Console.ReadLine());
            //������������
            byte[][] months = new byte[12][];
            //�����·ݲ�ͬ������ͬ�·ݵ�Ԫ��
            for (int month = 0; month < 12; month++)
            {
                switch (month)
                {
                    case 0:  //��ʾ1��
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
                        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))  //������жϣ�
                            months[month] = new byte[29];
                        else months[month] = new byte[28];
                        break;
                    default:
                        break;
                }
            }
            //��ӡ����
            for (int month = 0; month < 12; month++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0}�£� ", month + 1);
                for (int day = 0; day < months[month].Length; day++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0}�� ", day + 1);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }