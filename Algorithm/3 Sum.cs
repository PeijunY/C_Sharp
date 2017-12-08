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


public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);
        List<IList<int>> myList = new List<IList<int>>();  //嵌套nested list

        for (int i = 0; i < nums.Length-2; i++)
        {
            //筛除第一个数nums[i]重复的数！！
            if (i == 0 || i > 0 && nums[i] != nums[i - 1])
            {
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int Sum = nums[i] + nums[left] + nums[right];

                    if (Sum == 0)
                    {
                        List<int> subList = new List<int>();
                        subList.Add(nums[i]);
                        subList.Add(nums[left]);
                        subList.Add(nums[right]);

                        myList.Add(subList);
                        //筛除第一个数nums[i]重复的数！！
                        while (left < right && nums[left] == nums[left + 1]) left++;

                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++; right--;
                    }
                    else if (Sum < 0)
                        left++;
                    else
                        right--;
                }
            }            
        }
        return myList;
    }
}

=============================================================
Failed!!
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);
        List<IList<int>> myList = new List<IList<int>>();  

        for (int i = 0; i < nums.Length-2; i++)
        { 
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int Sum = nums[i] + nums[left] + nums[right];
		    //避免重复的问题！
                    if (Sum == 0 && (!myList.Contains(new List<int> { nums[i], nums[left], nums[right] })))
                    {
                        List<int> subList = new List<int>();
                        subList.Add(nums[i]);
                        subList.Add(nums[left]);
                        subList.Add(nums[right]);

                        myList.Add(subList);
                        left++; 
			right--;
                    }
                    else if (Sum < 0)
                        left++;
                    else
                        right--;
                }
            }            
        }
        return myList;
    }
}

