class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Stack<int> stack = new Stack<int>();
            Stack<int> minstack = new Stack<int>();
            int[] valueArray = new int[] { 10, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 16, 18, -1, 20, 21, 22, 23, -8, -9, 100 };
            foreach (int i in valueArray)
            {
                stack.Push(i);             
                Console.Write("{0}\n",stack.Peek());
            }           
            if (stack.Pop()<= n)
            {
                minstack.Push(stack.Pop());
            }
            else
            {
                stack.Pop();
            }
            Console.WriteLine(minstack.Peek());
            Console.ReadKey();
        }
    }  
