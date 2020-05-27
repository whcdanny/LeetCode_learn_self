/*Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

Note:

The solution set must not contain duplicate triplets.

Example:

Given array nums = [-1, 0, 1, 2, -1, -4],

A solution set is:
[
  [-1, 0, 1],
  [-1, -1, 2]
]*/

/*思路：先sort 然后从头开和尾分别开始 个带一个数 然后满足条件并且不重复的 加入到result*/		
		
		
		public IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums.Length < 3) return new List<List<int>>().ToArray();

            List<List<int>> threeSumList = new List<List<int>>();
            //sort input to save duplication check consumption
            List<int> sortList = new List<int>(nums);
            sortList.Sort();
            nums = sortList.ToArray();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                //if same nums[i], skip
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0)
                    {
                        List<int> threeSum = new List<int>();
                        threeSum.Add(nums[i]);
                        threeSum.Add(nums[j]);
                        threeSum.Add(nums[k]);
                        //check duplications
                        if (threeSumList.Count() > 0)
                        {
                            bool isDuplicate = false;
                            List<int> last = threeSumList.Last();
                            for (int index = 0; index < last.Count(); index++)
                            {
                                if (last[index] != threeSum[index]) break;
                                else if (last[index] == threeSum[index] && index == last.Count() - 1) isDuplicate = true;
                            }
                            if (!isDuplicate) threeSumList.Add(threeSum);
                        }
                        else
                        {
                            threeSumList.Add(threeSum);
                        }
                    }
                    //update j,k
                    if (sum <= 0) j++;
                    if (sum >= 0) k--;
                }
            }
            return threeSumList.ToArray();
        }
		
		
		/*public static IList<IList<int>> ThreeSum(int[] nums)
        {
            List<int> intList = new List<int>(nums);
            int sum = 0;      
            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);

            if (nums.Length <= 2)
                return result;

            for (int index1 = 0; index1 < nums.Length-2; index1++)
            {
                for(int index2 = index1+1; index2< nums.Length-1; index2++)
                {
                    int missing = sum - (nums[index1] + nums[index2]);
                    intList.Remove(nums[index1]);
                    intList.Remove(nums[index2]);
                    if (intList.Contains(missing))
                    {
                        IList<int> threeSum = new List<int>();

                        threeSum.Add(nums[index1]);
                        threeSum.Add(nums[index2]);
                        threeSum.Add(missing);
                        if (!checkInList(result, threeSum))
                        {
                            result.Add(threeSum);
                        }
                    }
                    intList.Add(nums[index1]);
                    intList.Add(nums[index2]);
                }                
            }
            return result;
        }

        private static bool checkInList(IList<IList<int>> result, IList<int> threeSum)
        {
            foreach (List<int> list in result)
            {
                if (list.Contains(threeSum[0]))
                {
                    list.Remove(threeSum[0]);
                    if (list.Contains(threeSum[1]))
                    {
                        list.Remove(threeSum[1]);
                        if (list.Contains(threeSum[2]))
                        {
                            list.Add(threeSum[0]);
                            list.Add(threeSum[1]);
                            return true;
                        }
                        list.Add(threeSum[1]);
                    }
                    list.Add(threeSum[0]);
                }
            }
            return false;
        }*/
