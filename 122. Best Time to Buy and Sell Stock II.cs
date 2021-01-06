public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length == 1)
                return 0;            
        int sum = 0;
        for (int i = 0; i < prices.Length-1; i++)
        {
            if (prices[i] < prices[i+1])
            {
                sum += prices[i+1]-prices[i];
            }
        }
        return sum;
    }
}

//C++
class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int res=0;
        if(prices.size()==0){
            return 0;
        }
        for(int i=0; i<prices.size()-1; i++){
            if(prices[i+1]>prices[i]){
                res+=prices[i+1]-prices[i];
            }
        }
        return res;
    }
};