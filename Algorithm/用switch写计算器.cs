	static void Main(string[] args)
        {
            Console.WriteLine("�ҵļ�����");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================================");
            Console.WriteLine("�������һ����");
            int num01 = int.Parse(Console.ReadLine());
            Console.Write("��ѡ������� -> +��-��*��/��% : ");
            string operatorchar = Console.ReadLine();
            Console.WriteLine("������ڶ�����");
            int num02 = int.Parse(Console.ReadLine());
            switch (operatorchar.Trim())
            {
                case "+":
                    Console.WriteLine("{0}+{1}={2}",num01,num02,num01+num02);
                    break;
                case "-":
                    Console.WriteLine("{0}-{1}={2}", num01, num02, num01-num02);
                    break;
                case "*":
                    Console.WriteLine("{0}*{1}={2}", num01, num02, num01*num02);
                    break;
                case "/":
                    if (num02 == 0) Console.WriteLine("��������Ϊ0"); // Attention!
                    else Console.WriteLine("{0}/{1}={2}", num01, num02, num01/num02);
                    break;
                case "%":
                    Console.WriteLine("{0}%{1}={2}", num01, num02, num01%num02);
                    break;
                default:
                    break;
            }
            Console.WriteLine("========================================================");
            Console.ReadKey();
        }