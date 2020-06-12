/*Implement pow(x, n), which calculates x raised to the power n (xn).

Example 1:

Input: 2.00000, 10
Output: 1024.00000
Example 2:

Input: 2.10000, 3
Output: 9.26100
Example 3:

Input: 2.00000, -2
Output: 0.25000
Explanation: 2-2 = 1/22 = 1/4 = 0.25*/

/*思路：把次方以除以2的方式一次一次分开，相当于二分法*/	
	
	public double MyPow(double x, int n) {
        if (n == 0 || x == 1) return 1;
        if (n < 0) return 1 / (x * MyPow (x, -n - 1));
        double ans = 1;
        while (n > 0) {
            if (n % 2 == 1) {
                ans *= x;
            }
            x *= x;
            n >>= 1;
        }
        return ans;
    }
}