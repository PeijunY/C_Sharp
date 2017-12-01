class Program
    {
        static void Main(string[] args)
        {
            Solution method = new Solution();
            Console.WriteLine(method.RomanToInt("MDCCC"));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int getValue(char ch)
        {
            switch (ch)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
        public int RomanToInt(string s)
        {
            int result = 0;
            int temp = 0;   //设立临时变量
            int current = 0;    //当前变量
            int pre = 0;    //前一个值
            char ch;    //储存逐个读取的单个字符
            char[] Chars = s.ToCharArray();
            temp = getValue(Chars[0]);
            pre = temp;
            for (int i = 1; i < Chars.Length; i++)
            {
                ch = Chars[i];
                current = getValue(ch);
                //分三种情况
                if (current == pre)
                {
                    //当前值和前一个值相等
                    temp += current;                   
                }
                else if (current < pre)
                {
                    //当前值比前一个小
                    result += temp;
                    temp = current;
                }
                else
                {
                    //当前值比前一个大
                    temp = current - temp;
                }
                pre = current;
            }
            result += temp;
            return result;
        }
    }