public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length == 1)
                return 0;            
        int sum = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            int maxPrice = 0;
            for (int j = i+1; j < prices.Length; j++)
            {
                if (prices[i] < prices[j])
                {
                    maxPrice = Math.Max(maxPrice, prices[j]);
                }
            }
            if (maxPrice != 0)
            {
                sum = Math.Max(sum, maxPrice - prices[i]);
            }
        }
        return sum;
    }
}