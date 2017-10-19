/// <summary>
/// Reverse an integer value by digits, any value in range of int type should be handled
/// E.g. 123456 -> 654321, -123 -> -321    
/// </summary>
namespace Reverse_an_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseInteger reverse = new ReverseInteger();
            reverse.Execute();
            Console.ReadKey();
        }
    }
    class ReverseInteger
    {
        public void Execute()
        {
            do
            {
                Console.WriteLine("Please input a integer:");
                string input = Console.ReadLine();
                if (input.ToLower() == "x")
                    return;
                int val;
                if (int.TryParse(input, out val))
                    Console.WriteLine(ReverseInt(val));
                else
                    Console.WriteLine("Invlid input!");
            } while (true);
        }
        public long ReverseInt(int val)
        {
            long result = 0;
            int val1 = Math.Abs(val);
            int sign = val / val1; //key step.
            while (val1 > 0)
            {
                //Get every number from integer
                int temp = val1 % 10;
                result = result * 10 + temp;
                val1 /= 10;
            }
            return result * sign;
        }
    }

}
