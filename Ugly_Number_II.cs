/*
编写一个程序，找出第 n 个丑数。
丑数就是只包含质因数 2, 3, 5 的正整数。
示例:
输入: n = 10
输出: 12
解释: 1, 2, 3, 4, 5, 6, 8, 9, 10, 12 是前 10 个丑数。
说明:  
1 是丑数。
n 不超过1690。
*/		
		
		
		
		public int NthUglyNumber(int n)
        {
            if (n > 1690)
                return 0;
            int tot = 1690;
            int sum = 0;
            int res = 0;
            for (int i = 1; i <= tot; i++)
            {
                if (i == 1)
                    sum++;
                else if (diveidBy(i))
                    sum++;
                else
                    continue;
                if (sum == n)
                {
                    res = i;
                    break;
                }
            }
            return res;
        }
        public static bool diveidBy(int _num)
        {
            bool res = false;
            if (_num / 2 != 1 && _num % 2 == 0)
                res = diveidBy(_num / 2);
            else if (_num / 3 != 1 && _num % 3 == 0)
                res = diveidBy(_num / 3);
            else if (_num / 5 != 1 && _num % 5 == 0)
                res =diveidBy(_num / 5);
            else if (_num / 2 == 1 && _num % 2 == 0)
                res = true;
            else if (_num / 3 == 1 && _num % 3 == 0)
                res = true;
            else if (_num / 5 == 1 && _num % 5 == 0)
                res = true;           
            else
                res = false;
            return res;
        }
		
		
		
	public int NthUglyNumber(int n)
    {
        if (n < 1) return 0;

        int[] results = new int[n];
        int index = 0;
        var lastUgly = 1;
        results[index++] = 1;
        int index2 = 0, index3 = 0, index5 = 0;
        while( index < n)
        {
            var v2 = results[index2] * 2;
            var v3 = results[index3] * 3;
            var v5 = results[index5] * 5;

            lastUgly = Math.Min( Math.Min( v2, v3 ), v5 );
            results[index++] = lastUgly;

            if (v2 == lastUgly) ++index2;
            if (v3 == lastUgly) ++index3;
            if (v5 == lastUgly) ++index5;
        }
        return lastUgly;
    }