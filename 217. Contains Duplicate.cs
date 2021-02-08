public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Array.Sort(nums);
        for(int i=1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
                return true;
        }
        return false;
    }
}


//C
class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        int len=nums.size();
        unordered_map<int,int> map;
        for(int i=0; i<len; i++){
            if(map.find(nums[i])==map.end()){
                map[nums[i]]=0;
            }
            else{
                map[nums[i]]++;
            }
            if(map[nums[i]]>0){
                return true;
            }
        }
        return false;
    }
};