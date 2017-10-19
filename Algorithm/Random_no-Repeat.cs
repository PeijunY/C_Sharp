如果是不考虑数字的重复，若产生100以内的任意数可以用如下:
Random r = new Random();
int num = r.Next(Max)   ---Max==100
==========================================================================
Method1:
class Program
    {
        static void Main(string[] args)
        {
            int[] index = new int[15];
            for (int i = 0; i < 15; i++)
            {
                index[i] = i+10;
            }
            Random r = new Random();

            int[] result= new int[10];  //用来保存随机生成的不重复的10个数
            int MaxValue = 15;           //设置上限
            int id;
            for (int j = 0; j < 10; j++)
            {
                id = r.Next(1, MaxValue - 1);
                if (!result.Contains(index[id]))
                {
                    result[j] = index[id];
                }
                else
                {
                    j--;                 //当有生成重复的数字时再次“操作随机生成”
                }
            }
            foreach (int c in result)
            {
                Console.Write(c + " ");
            }
            Console.ReadKey();
        }
    }

==========================================================================
Method2：
class Program
    {
        static void Main(string[] args)
        {
            int[] index = new int[15];
            for (int i = 0; i < 15; i++)
            {
                index[i] = i+10;
            }
            Random r = new Random();
           
            int[] result = new int[10];  //用来保存随机生成的不重复的10个数
            int MaxValue = 15;           //设置上限
            int id;
            for (int j = 0; j < 10; j++)
            {
                id = r.Next(1, MaxValue - 1);               
                result[j] = index[id];  //在随机位置取出一个数，保存到结果数组    
                //再把index[i]写入数组result后，将最后一位数index[MaxValue - 1]来替换，对，“替换”这个在index数组中的index[i]值！之后总的个数再少一！
                //这个就是本道算法的关键之处！           
                index[id] = index[MaxValue - 1];              
                MaxValue--;
            }
            foreach (int c in result)
            {
                Console.Write(c+" ");
            }
            Console.ReadKey();
        }
    }
==========================================================================
Method3：
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable hashtable = new Hashtable();
            Random rm = new Random();
            int RmNum = 10;
            for (int i = 0; hashtable.Count < RmNum; i++)
            {
                int nValue = rm.Next(10, 25);
                if (!hashtable.ContainsValue(nValue) && nValue != 0)
                {
                    hashtable.Add(nValue, nValue);  //hashtable不能添加重复键
                    Console.Write(nValue + " ");
                }
            }
            Console.ReadKey();
        }
    }
