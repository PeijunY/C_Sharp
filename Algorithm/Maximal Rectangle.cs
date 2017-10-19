Maximal Rectangle
Given a 2D binary matrix filled with 0's and 1's, find the largest rectangle containing only 1's and return its area. 
For example, given the following matrix: 
1 0 1 0 0
1 0 1 1 1
1 1 1 1 1
1 0 0 1 0
Return 6. 
==================================================================
class Program
    {
        static void Main(string[] args)
        {
            int[,] Array = new int[,]
              {
                {1,0,1,0,0 },
                {1,0,1,1,1 },
                {1,1,1,1,1 },
                {1,0,1,0,0 }
              };
            Maxmethod(Array);
            Console.WriteLine("The max area is {0}", Maxmethod(Array));
            Console.ReadKey();
        }
        public static int Maxmethod(int[,] array)
        {
            int Col = array.GetLength(1);   // 列数
            int Row = array.GetLength(0);   // 行数
            int curr_area = 0;
            int max_area = 0;
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    if (array[i, j] == 1 )
                    {
                        int lastj = Col;
                        for (int k = i; k < Row && array[k, j] == 1; k++)
                        {
                            for (int l = j; l < lastj; l++)
                            {
                                if (array[k, l] == 1)
                                {
                                    curr_area = (l - j + 1) * (k - i + 1);
                                    max_area = Math.Max(max_area, curr_area);
                                }
                                else
                                    lastj = l;
                            }
                        }
                    }
                }
            }
            return max_area;         
        }
    }
