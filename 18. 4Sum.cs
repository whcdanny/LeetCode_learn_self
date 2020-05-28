/*Given an array nums of n integers and an integer target, are there elements a, b, c, and d in nums such that a + b + c + d = target? Find all unique quadruplets in the array which gives the sum of target.

Note:

The solution set must not contain duplicate quadruplets.

Example:

Given array nums = [1, 0, -1, 0, -2, 2], and target = 0.

A solution set is:
[
  [-1,  0, 0, 1],
  [-2, -1, 1, 2],
  [-2,  0, 0, 2]
]*/
/*思路：和3sum一样，一个一个来*/		
		
		
		public IList<IList<int>> FourSum(int[] nums, int target)
        {
            if (nums.Length < 4) return new List<List<int>>().ToArray();

            List<List<int>> fourSumList = new List<List<int>>();
            //sort input to save duplication check consumption
            List<int> sortList = new List<int>(nums);
            sortList.Sort();
            nums = sortList.ToArray();
            for (int h = 0; h < nums.Length - 3; h++)
            {
                //if same nums[h], skip
                if (h > 0 && nums[h] == nums[h - 1]) continue;
                for (int i = h + 1; i < nums.Length - 2; i++)
                {
                    //if same nums[i], skip
                    if (i > 0 && i - 1 != h && nums[i] == nums[i - 1]) continue;
                    int j = i + 1;
                    int k = nums.Length - 1;
                    while (j < k)
                    {
                        int sum = nums[h] + nums[i] + nums[j] + nums[k];
                        if (sum == target)
                        {
                            List<int> fourSum = new List<int>();
                            fourSum.Add(nums[h]);
                            fourSum.Add(nums[i]);
                            fourSum.Add(nums[j]);
                            fourSum.Add(nums[k]);
                            //check duplications
                            if (fourSumList.Count() > 0)
                            {
                                bool isDuplicate = false;
                                List<int> last = fourSumList.Last();
                                for (int index = 0; index < last.Count(); index++)
                                {
                                    if (last[index] != fourSum[index]) break;
                                    else if (last[index] == fourSum[index] && index == last.Count() - 1) isDuplicate = true;
                                }
                                if (!isDuplicate) fourSumList.Add(fourSum);
                            }
                            else
                            {
                                fourSumList.Add(fourSum);
                            }
                        }
                        //update j,k
                        if (sum <= target) j++;
                        if (sum >= target) k--;
                    }
                }
            }
            return fourSumList.ToArray();
        }