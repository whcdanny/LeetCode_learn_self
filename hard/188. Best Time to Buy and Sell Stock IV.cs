public int MaxProfit(int k, int[] prices)
{
    if (k <= 0 || prices == null || prices.Length == 0) 
        return 0;

    if (k >= prices.Length / 2) 
        return getProfit(prices);

	int[,] profits = new int[k + 1, prices.Length];

	for (int i = 1; i <= k; i++)
	{
		int localMax = -prices[0]; 
		for (int j = 1; j < prices.Length; j++)
		{
			profits[i,j] = Math.Max(profits[i,j - 1], prices[j] + localMax);                   
			localMax = Math.Max(localMax, profits[i - 1,j] - prices[j]);
		}
	}

	return profits[k,prices.Length - 1];
}
private int getProfit(int[] prices)
{
	int res = 0;
	for (int i = 1; i < prices.Length; i++)
	{
		res += Math.Max(0, prices[i] - prices[i - 1]);
	}
	return res;
}	

//Java
public class Solution {
    public int maxProfit(int k, int[] prices) {
        if (k <= 0 || prices == null || prices.length == 0) 
            return 0;
        
        if (k >= prices.length / 2) 
            return quickPath(prices);
        
        int[][] mem = new int[k + 1][prices.length];
        
        for (int i = 1; i <= k; i++) {
            for (int j = 0; j < prices.length; j++) {
                for (int prev = 0; prev < j; prev++) {
                    int currProfit = prices[j] - prices[prev];
                    mem[i][j] = Math.max(mem[i][j], Math.max(mem[i][j - 1], currProfit + mem[i - 1][prev]));
                }
            }
        }
        
        return mem[k][prices.length - 1];
    }
    
    private int quickPath(int[] prices) {
        int ret = 0;
        for (int i = 1; i < prices.length; i++) {
            ret += Math.max(0, prices[i] - prices[i - 1]);
        }
        
        return ret;
    }
}