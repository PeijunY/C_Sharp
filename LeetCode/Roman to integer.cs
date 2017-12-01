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
            int temp = 0;   //������ʱ����
            int current = 0;    //��ǰ����
            int pre = 0;    //ǰһ��ֵ
            char ch;    //���������ȡ�ĵ����ַ�
            char[] Chars = s.ToCharArray();
            temp = getValue(Chars[0]);
            pre = temp;
            for (int i = 1; i < Chars.Length; i++)
            {
                ch = Chars[i];
                current = getValue(ch);
                //���������
                if (current == pre)
                {
                    //��ǰֵ��ǰһ��ֵ���
                    temp += current;                   
                }
                else if (current < pre)
                {
                    //��ǰֵ��ǰһ��С
                    result += temp;
                    temp = current;
                }
                else
                {
                    //��ǰֵ��ǰһ����
                    temp = current - temp;
                }
                pre = current;
            }
            result += temp;
            return result;
        }
    }