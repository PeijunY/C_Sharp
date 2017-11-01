	static void Main(string[] args)
        {
            Console.WriteLine("我的计算器");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================================");
            Console.WriteLine("请输入第一个数");
            int num01 = int.Parse(Console.ReadLine());
            Console.Write("请选择运算符 -> +、-、*、/、% : ");
            string operatorchar = Console.ReadLine();
            Console.WriteLine("请输入第二个数");
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
                    if (num02 == 0) Console.WriteLine("除数不能为0"); // Attention!
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