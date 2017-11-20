Content:
Given an nums S of n integers, are there elements a, b, c in S such that a + b + c = 0? Find all unique triplets in the nums which gives the sum of zero.
Note: The solution set must not contain duplicate triplets.
For example, given nums S = [-1, 0, 1, 2, -1, -4],
A solution set is:
[
  [-1, 0, 1],
  [-1, -1, 2]
]

Solution 1:
class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 3, -2, 1, 0, -1, -8, 5};
            //int[] nums = { 3, 4, 5};
            //int[] nums = { 1, 0, -1, 1, 0, -1 };
            //int[] nums = {0, 0, 0, 0};
            Console.WriteLine("Please input a set array , example 1,2,3,4,5,6");
            string[] array = Console.ReadLine().Split(',');
            int[] nums = Array.ConvertAll<string, int>(array, s => int.Parse(s));
          //Sort this array from small to big.
            Array.Sort(nums);
         //Solution 1:
            if (nums.Length >= 3)
            {
                //ArrayList list1 = new ArrayList();
                List<string> listString = new List<string>();
                string result = "";
                for (int a = 0; a < nums.Length - 1; a++)
                {

                    for (int b = a + 1; b < nums.Length; b++)
                    {
                        for (int c = b + 1; c < nums.Length; c++)
                        {
                            int temp = nums[a] + nums[b] + nums[c];
                            if (temp == 0 && !result.Contains("[" + nums[a] + "," + nums[b] + "," + nums[c] + "]") && result != null)
                            {
                                result = result + "[" + nums[a] + "," + nums[b] + "," + nums[c] + "]" + '\n';
                            }
                        }
                    }
                }
                if (result != "")
                {
                    Console.WriteLine("A solution set is:\n[\n{0}]", result);
                }
                else
                {
                    Console.WriteLine("There are no three elements a, b, b such that a+b+c=0 in Array!");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The member of nums is enough,please check it!");
            }
        }
    }

Solution 2:
if (nums.Length >= 3)
    {
        List<string> listString = new List<string>();
string result = "";
        for (int i = 0; i<nums.Length - 1; i++)
        {
            int left = i + 1;
int right = nums.Length - 1;
            while(left<right)
            {
                int value = nums[i] + nums[left] + nums[right];
                if (result != null && value == 0 && !result.Contains("[" + nums[i] + "," + nums[left] + "," + nums[right] + "]"))
                {
                    result = result + "[" + nums[i] + "," + nums[left] + "," + nums[right] + "]" + '\n';
                }
                else if (value< 0)
                    left++;
                else
                    right--;
            }
