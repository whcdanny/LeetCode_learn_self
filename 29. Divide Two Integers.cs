/*Given two integers dividend and divisor, divide two integers without using multiplication, division and mod operator.

Return the quotient after dividing dividend by divisor.

The integer division should truncate toward zero, which means losing its fractional part. For example, truncate(8.345) = 8 and truncate(-2.7335) = -2.

Example 1:

Input: dividend = 10, divisor = 3
Output: 3
Explanation: 10/3 = truncate(3.33333..) = 3.
Example 2:

Input: dividend = 7, divisor = -3
Output: -2
Explanation: 7/-3 = truncate(-2.33333..) = -2.*/

/*不是什么好题看看就得了*/
		public int Divide(int dividend, int divisor)
        {
            long res = 0;
            long sum = 0;
            bool isDividendNeg = false;
            bool isDivisorNeg = false;
            long ldividend = dividend;
            long ldivisor = divisor;
            if (ldividend < 0)
            {
                isDividendNeg = true;
                ldividend = -ldividend;
            }
            if (ldivisor < 0)
            {
                isDivisorNeg = true;
                ldivisor = -ldivisor;
            }

            if (ldivisor == 1)
            {
                res = ldividend;
            }
            else
            {
                var i = NarrowDown(ldividend, ldivisor);
                if (i > 0)
                {
                    res = 2 << (i - 1);
                    sum = ldivisor << i;
                }
                while (true)
                {
                    if (sum > ldividend)
                    {
                        res--;
                        break;
                    }
                    sum += ldivisor;
                    res++;
                }
            }

            if (isDividendNeg && isDivisorNeg)
            {
            }
            else if (isDividendNeg || isDivisorNeg)
            {
                res = -res;
            }
            if (res > int.MaxValue)
            {
                res = int.MaxValue;
            }
            return (int)res;
        }
        public static int NarrowDown(long dividend, long divisor)
        {
            // TODO: i from 30,20,10 to 10-0
            int i = 0;
            while (true)
            {
                var x = divisor << i;
                if (x > dividend)
                {
                    i--;
                    break;
                }
                i++;
            }
            return i;
        }