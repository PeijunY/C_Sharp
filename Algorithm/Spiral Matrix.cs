//Spiral Matrix
//Given a matrix of m x n elements(m rows, n columns), return all elements of the matrix in spiral order.
//For example,
//Given the following matrix: 
//[
//[ 1, 2, 3 ],
//[ 4, 5, 6 ],
//[ 7, 8, 9 ]
//]
//You should return [1,2,3,6,9,8,7,4,5]. 

namespace Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 1, 2, 3, 1 }, { 4, 5, 6, 2 }, { 7, 8, 9, 3 }, { 10, 11, 12, 4 } };
            //int[,] array = new int[,] { {1, 2, 3 }, { 4, 5, 6} };
            //int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };
            int rl = 0, rh = array.GetUpperBound(0) + 1, cl = 0, ch = array.GetLength(1);
            string result = "";
            int symbol = 0;
            if (rh != 0)
            {
                while (rl <= rh - 1 && cl <= ch - 1)
                {
                    if (symbol == 0)
                    {
                        for (int i = cl; i <= ch - 1; i++)
                            result = result + array[rl, i] + ",";
                        rl++;
                    }
                    if (symbol == 1)
                    {
                        for (int i = rl; i <= rh - 1; i++)
                            result = result + array[i, ch - 1] + ",";
                        ch--;
                    }
                    if (symbol == 2)
                    {
                        for (int i = ch - 1; i >= cl; i--)
                            result = result + array[rh - 1, i] + ",";
                        rh--;
                    }
                    if (symbol == 3)
                    {
                        for (int i = rh - 1; i >= rl; i--)
                            result = result + array[i, cl] + ",";
                        cl++;
                    }
                    symbol = (symbol + 1) % 4; //key step to change direction to run next!
                }
            }
            result = result.Remove(result.LastIndexOf(","), 1);
            Console.WriteLine("the return result is {0} {1} {2}", '[', result, ']');
            Console.ReadKey();

        }
    }
}
============================================================================================================================
============================================================================================================================
namespace Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };
            int rl = 0, rh = array.GetUpperBound(0) + 1, cl = 0, ch = array.GetLength(1);
            StringBuilder result = new StringBuilder();
            StringBuilder newresult = new StringBuilder();
            int symbol = 0;
            if (rh != 0)
            {
                while (rl <= rh - 1 && cl <= ch - 1)
                {
                    if (symbol == 0)
                    {
                        for (int i = cl; i <= ch - 1; i++)
                            result.Append(array[rl, i]);
                        rl++;
                    }
                    else if (symbol == 1)
                    {
                        for (int i = rl; i <= rh - 1; i++)
                            result.Append(array[i, ch - 1]);
                        ch--;
                    }
                    else if (symbol == 2)
                    {
                        for (int i = ch - 1; i >= cl; i--)
                            result.Append(array[rh - 1, i]);
                        rh--;
                    }
                    else if (symbol == 3)
                    {
                        for (int i = rh - 1; i >= rl; i--)
                            result.Append(array[i, cl]);
                        cl++;
                    }
                    symbol = (symbol + 1) % 4; 
                }
            }
            char[] CharArr=result.ToString().ToCharArray();
            foreach (char s in CharArr)
            {
                if (s != ' ')
                {
                    newresult.Append(s);
                    newresult.Append("->");
                }
                else
                    newresult.Append(s);
            }            
            Console.WriteLine("the return result is {0} {1} {2} ", '[', newresult, ']');
            Console.ReadKey();
        }
    }
}
