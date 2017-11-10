namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "静夜思", "李白", "床前明月光", "疑是地上霜", "举头望明月", "低头思故乡" };
            OutputUseColor("下面默写"+strArray[1]+"的<<" + strArray[0]+">>，总共四句","Magenta");
            Console.WriteLine();
            int count = 0;
            
            for (int i = 0; i < strArray.Length-2; i++)
            {
                int wrongcount = 0;  //注意这个只能在for循环的里面不然当为3后，没有清零！！
            Rerun:
                OutputUseColor("请默写第"+(i+1).ToString()+"句：", "white");
                string strInput = InputUseYellow();
                
                if (strInput.ToString().Trim() == strArray[i + 2])
                {
                    OutputUseColor("恭喜你！"+"第" + (i + 1) + "句默写正确！\n", "green");
                    count++;
                    
                }
                else
                {
                    if (wrongcount < 2)
                    {
                        OutputUseColor("第" + (i + 1) + "句默写错误，请重新默写\n", "red");
                        wrongcount++;
                        goto Rerun;
                    }
                    else
                    {
                        OutputUseColor("第" + (i + 1) + "句默写错误已达三次，正确答案为：" + strArray[i + 2] + "\n", "red");
                        continue;
                    }
                }
                
            }
            Console.WriteLine();
            OutputUseColor("本次默写《"+strArray[0]+"》总共四句，默写正确的语句有"+count+"句，正确率为"+(count*(1.00)/4)*100+"%","cyan");
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