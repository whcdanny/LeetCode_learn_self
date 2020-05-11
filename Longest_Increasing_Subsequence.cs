/*
给定一个无序的整数数组，找到其中最长上升子序列的长度。
示例:
输入: [10,9,2,5,3,7,101,18]
输出: 4 
解释: 最长的上升子序列是 [2,3,7,101]，它的长度是 4。
*/
		public static int findNum(int[] nums)
        {
            int length = nums.Length;
            if (nums == null || nums.Length == 0)
                return 0;
            int[] save = new int[length];
            save[0] = 1;
            int res = 1;
            for (int i = 1; i < length; i++)
            {
                int max = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[i] > nums[j] && max < save[j])
                        max = save[j];
                }
                save[i] = max + 1;
                if (res < save[i])
                    res = save[i];
            }
            return res;
        }        