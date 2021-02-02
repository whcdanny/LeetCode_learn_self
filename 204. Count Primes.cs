public class Solution {
    public int CountPrimes(int n) {
        int count = 0;
        bool[] notPrime = new bool[n];
        for (int i = 2; i < n; i++)
            if (!notPrime[i])
            {
                count++;
                for (int j = 2; i * j < n; j++)
                    notPrime[i * j] = true;
            }
        return count;
    }
}

//Time out
public int CountPrimes(int n)
{
	if (n == 0 || n == 1)
		return 0;
	int res = 0;
	for(int i = 2; i<n; i++)
	{
		if (isPrimes(i))
			res++;
	}

	return res;
}

private bool isPrimes(int num)
{
	bool res = true;
	for(int i = 2; i<num; i++)
	{
		if (num % i == 0)
		{
			res = false;
			break;
		}                    
	}
	return res;
}

//Java
class Solution {
    public int countPrimes(int n) {
        int count = 0;
        boolean[] notPrime = new boolean[n];
        for (int i = 2; i < n; i++) 
            if (!notPrime[i]) { 
                count++;
                for (int j = 2; i * j < n; j++) 
                    notPrime[i * j] = true;
            }
        return count;
    }
}