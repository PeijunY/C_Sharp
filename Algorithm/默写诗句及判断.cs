namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "��ҹ˼", "���", "��ǰ���¹�", "���ǵ���˪", "��ͷ������", "��ͷ˼����" };
            OutputUseColor("����Ĭд"+strArray[1]+"��<<" + strArray[0]+">>���ܹ��ľ�","Magenta");
            Console.WriteLine();
            int count = 0;
            
            for (int i = 0; i < strArray.Length-2; i++)
            {
                int wrongcount = 0;  //ע�����ֻ����forѭ�������治Ȼ��Ϊ3��û�����㣡��
            Rerun:
                OutputUseColor("��Ĭд��"+(i+1).ToString()+"�䣺", "white");
                string strInput = InputUseYellow();
                
                if (strInput.ToString().Trim() == strArray[i + 2])
                {
                    OutputUseColor("��ϲ�㣡"+"��" + (i + 1) + "��Ĭд��ȷ��\n", "green");
                    count++;
                    
                }
                else
                {
                    if (wrongcount < 2)
                    {
                        OutputUseColor("��" + (i + 1) + "��Ĭд����������Ĭд\n", "red");
                        wrongcount++;
                        goto Rerun;
                    }
                    else
                    {
                        OutputUseColor("��" + (i + 1) + "��Ĭд�����Ѵ����Σ���ȷ��Ϊ��" + strArray[i + 2] + "\n", "red");
                        continue;
                    }
                }
                
            }
            Console.WriteLine();
            OutputUseColor("����Ĭд��"+strArray[0]+"���ܹ��ľ䣬Ĭд��ȷ�������"+count+"�䣬��ȷ��Ϊ"+(count*(1.00)/4)*100+"%","cyan");
            Console.ReadKey();
        }

        static string InputUseYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string str01 = Console.ReadLine();
            Console.ResetColor();
            return str01;
        }
        static void OutputUseColor(string str, string color)
        {
            switch (color.Trim().ToUpper())
            {
                case "RED":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(str);
                    Console.ResetColor();
                    break;
                case "GREEN":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(str);
                    Console.ResetColor();
                    break;
                case "CYAN":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(str);
                    Console.ResetColor();
                    break;
                case "MAGENTA":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(str);
                    Console.ResetColor();
                    break;
                case "WHITE":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(str);
                    Console.ResetColor();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(str);
                    Console.ResetColor();
                    break;
            }
        }
    }
}