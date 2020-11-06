public class Solution {
    public int ClimbStairs(int n) {
        int first = 0;
        int now = 1;
        for (int i = 1; i <= n; i++)
        {
            int tmp = now;
            now += first;
            first = tmp;
        }
        return now;
    }
}

public static int ClimbStairs(int n)
        {
            long res = 0;
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            int x = n / 2;
            int y = n % 2;
            res = 1;
            for (int i = 1; i <= x; i++)
            {
                res += factorial(n - i) / (factorial(i) * factorial(n - 2 * i));
            }
            return (int)res;
        }
        
        public static long factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * factorial(n - 1);
        }