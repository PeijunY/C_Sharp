//Given an array of integers, return indices of the two numbers such that they add up to a specific target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//Given nums = [2, 7, 11, 15], target = 9,
//Because nums[0] + nums[1] = 2 + 7 = 9,
//return [0, 1].

        
public int[] TwoSum(int[] nums, int target)
        {     
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = len - 1; j > i; j--)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return new int[] { 0, 0 };
        }