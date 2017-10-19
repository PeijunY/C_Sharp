/// <summary>
/// 输入一个整数数组，实现一个函数来调整该数组中数字的顺序，
/// 使得所有的奇数位于数组的前半部分，所有的偶数位于位于数组的后半部分，
/// 并保证奇数和奇数，偶数和偶数之间的相对位置不变。
/// </summary>
Two solutions
======================================================================
 class Program
    {
        static void Main(string[] args)
        {
            SortArray shuzu = new SortArray();
            shuzu.Execute();
        }

    }
    class SortArray
    {
        public void Execute()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 16, 18, 19 };
            //arr = new int[] { 2 };
            Console.Write("Before: ");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            arr = reOrderArray(arr);
            Console.Write("\r\n\r\nAfter: ");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public int[] reOrderArray(int[] array)
        {
            if (array.Length <= 1)
                return array;

            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] % 2 == 0 && array[i + 1] % 2 == 1)
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            return array;
        }
    }

======================================================================
namespace Order_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 16, 18, 19  };
            string evenresult = "";
            string oddresult = "";
            for (int k=0; k<array.Length;k++)
            {

                if (array[k] % 2 != 0)
                {
                    oddresult = oddresult + ", " + array[k];
                    
                }
                else
                {
                    evenresult = evenresult + ", " + array[k];
                }
            }
            Console.WriteLine("the rusult after arrange is {0} {1} {2} {3}","[", oddresult.Substring(1,oddresult.Length-1), evenresult, "]");
            Console.ReadKey();
        }
    }
}
