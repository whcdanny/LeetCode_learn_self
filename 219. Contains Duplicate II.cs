public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        for(int i=0; i<nums.Length; i++)
        {
            for(int j=i+1; j<nums.Length; j++)
            {
                if (nums[i] == nums[j] && Math.Abs(j - i) <= k)
                    return true;
            }
        }
        return false;
    }
}

//C++
class Solution {
public:
    bool containsNearbyDuplicate(vector<int>& nums, int k) {
         unordered_map<int, int> m;
        int d=0;
        for(int i=0; i<nums.size(); i++){
            if(m.find(nums[i])!=m.end() && i-m[nums[i]]<=k){
                return true;
            }
            else{
                m[nums[i]]=i;
            }
        }
        return false;
    }
};
