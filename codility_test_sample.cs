/*that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.*/		
		
		
		public static int findNum(int[] A)
        {
            int res = 0;
            int length = A.Length;
            for (int i = 1; i <= length; i++)
            {
                int test = A[i-1];
                if (test <= 0) { res = 1; break; }

                else if (test < i)
                {
                    res = i; break;
                }
                else if (i == length) { res = i + 1; }
            }
            return res;
        }