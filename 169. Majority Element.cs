public class Solution {
    public int MajorityElement(int[] nums) {        
        Dictionary<int, int> map = new Dictionary<int, int>();
        int res = 0;
        for(int i=0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
                map[nums[i]]++;
            else
                map[nums[i]]=0;
            if (map[nums[i]] == nums.Length / 2)
            {
                res = nums[i];
                break;
            }                    
        }
        return res;
    }
}

//C++
class Solution {
public:
    int majorityElement(vector<int>& nums) {
        unordered_map<int, int> map;
        int len=nums.size();
        for(int i=0;i<len;i++){
            if(map.find(nums[i])==map.end()){
                map[nums[i]]=0;
            }
            else{
                map[nums[i]]++;
            }
            if(map[nums[i]]==len/2){
                return nums[i];
            }
        }
    }
};