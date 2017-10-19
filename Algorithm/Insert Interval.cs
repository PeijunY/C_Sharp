Insert Interval
Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).
You may assume that the intervals were initially sorted according to their start times.
Example 1:
Given intervals [1,3],[6,9], insert and merge [2,5] in as [1,5],[6,9]. 
Example 2:
Given [1,2],[3,5],[6,7],[8,10],[12,16], insert and merge [4,9] in as [1,2],[3,10],[12,16]. 
This is because the new interval [4,9] overlaps with [3,5],[6,7],[8,10]. 

Solution:

class Program
    {
        static void Main(string[] args)
        {           
            int[,] array = new int[,] { { 1, 2 }, { 3, 5 }, { 6, 7 }, { 8, 10 }, { 12, 16 }, { 17,19} };
            int[] insert = new int[] { 4, 9 };
            int i = 0;
            string result="";
            while( i < array.GetUpperBound(0)+1)
            {
                if (array[i, 1] < insert[0])
                {
                    result = result + "[" + array[i, 0] + "," + array[i, 1] + "]";
                }

                else if (array[i, 1] > insert[0])
                {
                    if (array[i, 0] < insert[0])
                    {
                        result = result + "[" + array[i, 0] + ",";
                    }
                    if (array[i, 0] < insert[1] && array[i, 1] > insert[1])
                    {
                        result = result + array[i, 1] + "]";
                    }
                    if (array[i, 0] > insert[1])
                    {
                        result = result + "[" + array[i, 0] + "," + array[i, 1] + "]";
                    }                   
                }
                i++;
            }
            Console.WriteLine("The result of Insert Interval is:\n{0}", result);
            Console.ReadKey();
        }
    }
