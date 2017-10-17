Bubbling Method:
http://www.cnblogs.com/wolferfeng/p/3824086.html
1. 
class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] arrSort = new int[] { 10, 8, 3, 5, 6, 7, 9 };
            for (int i = 0; i < arrSort.Length; i++)
            {
                for (int j = i + 1; j < arrSort.Length; j++)
                {
                    if (arrSort[j] < arrSort[i])
                    {
                        temp = arrSort[j];
                        arrSort[j] = arrSort[i];
                        arrSort[i] = temp;
                    }
                }
            }
            foreach (int c in arrSort)
            {
                Console.Write(c + " ");
            }
            Console.ReadKey();
        }
    }

2.
  class Program
    {       
        static void Main(string[] args)
        {
            int[] nums = new int[] { 100, 99, 45, 56, 67, 78, 98, 8, 7, 65, 16, 30, 32, 31, 29, 28, 26, 27, 25, 22, 24 };
            Console.WriteLine("The traditional method of Bubbling:");
            BubbleMethod(nums);
            Console.ReadKey();
        }
        static void BubbleMethod(int[] Array)
        {
            int temp, i, j;
            for (i =0; i<Array.Length;i++)
            {
                for (j=i+1;j<Array.Length;j++)
                {
                    if (Array[j]<Array[i])
                    {
                        temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
            foreach (int c in Array) //输出排序后的数组元素！
            {
                Console.Write(c + "\t");
            }
        }     
    }

3.
class Program
    {       
        static void Main(string[] args)
        {
            int[] nums = new int[] { 100, 99, 45, 56, 67, 13, 14, 15, 16, 30, 32, 31, 29, 28, 26, 27, 25, 22, 24 };
            Console.WriteLine("The traditional method of Bubbling:");
            BubbleMethod(nums);
            Console.ReadKey();
        }
        static void BubbleMethod(int[] Array)
        {
            //IEnumerable<int> num = from a in Array orderby a descending select a; //Linq的查询表达式语法的实现
            var num = from item in Array orderby item ascending select item;    // the same as above expression                
            foreach (int s in num)
            {
                Console.Write(s + "\t");
            }
        }     
    }

4.
        static void Main(string[] args)
        {
            int[] nums = new int[] { 100, 99, 45, 56, 29, 28, 26, 27, 25, 22, 24 };
            Console.WriteLine("The method of bubbling: ");
            BubblingOne(nums);
            Console.ReadKey();
         }
        static void BubblingOne(int[] Array)
        {
            IEnumerable<int> num = Array.OrderByDescending(a => a);
            foreach (int item in num)
            {
                Console.Write(item + " ");
            }
        }
