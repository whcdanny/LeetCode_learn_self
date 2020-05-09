/*
给定正整数 n，找到若干个完全平方数（比如 1, 4, 9, 16, ...）
使得它们的和等于 n。你需要让组成和的完全平方数的个数最少。
示例 1:
输入: n = 12
输出: 3 
解释: 12 = 4 + 4 + 4.
示例 2:
输入: n = 13
输出: 2
解释: 13 = 4 + 9. 
     
*/

		public static int NumSquares(int n)
        {
            if (n < 2) return 1;

            int[] nums = new int[n + 1];
            int num = 0;
            int squareNum = 0;
            for (int startIndex = 1; startIndex <= n; startIndex++)
            {
                num = startIndex;
                squareNum = 1;
                while (true)
                {
                    int i = startIndex - squareNum * squareNum;
                    if (i == 0)
                    {
                        num = 1;
                        break;
                    }
                    if (i < 0) break;

                    ++squareNum;
                    num = Math.Min(num, nums[i] + 1);
                }
                nums[startIndex] = num;
            }
            return num;
		}