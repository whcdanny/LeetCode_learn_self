/*Given a set of distinct positive integers, find the largest subset such that every pair (Si, Sj) of elements in this subset satisfies:

Si % Sj = 0 or Sj % Si = 0.

If there are multiple solutions, return any subset is fine.

Example 1:

Input: [1,2,3]
Output: [1,2] (of course, [1,3] will also be ok)
Example 2:

Input: [1,2,4,8]
Output: [1,2,4,8]*/
/*思路： 先要sort 原因 这样大的可以整除小的；然后 跟i之前的除 算出多少个能被i整除，跟要输出的list做对比 输出最大的*/
		
		public IList<int> LargestDivisibleSubset(int[] nums)
        {
            if (nums.Length < 1) return new List<int>();
            Array.Sort(nums);
            int count = 1;
            List<int> list = new List<int> { nums[0] };
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            dic[0] = new List<int> { nums[0] };

            for (int i = 1; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(i))
                {
                    dic[i] = new List<int> { nums[i] };
                }
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] % nums[j] == 0)
                    {
                        if (dic[j].Count + 1 > dic[i].Count)
                        {
                            dic[i] = new List<int>(dic[j]);
                            dic[i].Add(nums[i]);
                        }

                        if (dic[i].Count > count)
                        {
                            count = dic[i].Count;
                            list = new List<int>(dic[i]);
                        }
                    }
                }
            }        
            return list;            
        }