public class Solution {
    public string GetPermutation(int n, int k) {
        var num = new List<int>();
		//先给相应的数 e.g 1 2 3 4 
        for (int i = 1; i <= n; i++)
        {
            num.Add(i);
        }

		//给出了可能出现的总数 （n*n-1*n-2.......*2*1）
        var fact = new int[n];
        fact[0] = 1;
        for (int i = 1; i < n; i++)
        {
            fact[i] = i * fact[i - 1];
        }
        		
        k = k - 1;
        var result = new char[n];
        for (int i = n; i > 0; i--)
        {
			//选择当前数字的位置； 
			//为什么呢？因为可以发现总是的规律是 n*n-1*....*2*1;
			//所以如果k的选择少于n-1*...*2*1,那么就证明开始的第一位数字是1；
            int ind = k / fact[i - 1];
			//当找到当前位置 就要找到下一个k的位置；
            k = k % fact[i - 1];
            result[n - i] = (char)(num[ind] + '0');
            num.RemoveAt(ind);
        }
        return new string(result);
    }
}


class Solution:
    def getPermutation(self, n: int, k: int) -> str:
        ans = ""
        remain = [i for i in range(1, n + 1)]
        factorial = [1] * (n + 1)
        for j in range(1, n + 1): factorial[j] = factorial[j - 1] * j
        k -= 1
        for i in range(1, n + 1):
            index, k = divmod(k, factorial[n - i])
            ans += str(remain[index])
            remain.remove(remain[index])
        return ans