public class Solution {
    public int[] SingleNumber(int[] nums) {
        if (nums == null)
            return null;
        if (nums.Length == 1)
            return new int[] { nums[0] };
        Array.Sort(nums);
        List<int> res = new List<int>();
        int temp = nums[0];
        int time = 0;
        for(int i=1; i<nums.Length; i++)
        {
            if (temp == nums[i])
                time += 1;
            if(temp != nums[i])
            {
                if(time==0)
                    res.Add(temp);
                temp = nums[i];
                time = 0;                      
            }
            if(i==nums.Length-1 && time==0)
                res.Add(temp);                    
        }
        return res.ToArray();
    }
}

//C++
class Solution {
public:
    vector<int> singleNumber(vector<int>& nums) {
        set <int> s;
        for (int i = 0; i < nums.size(); i++)
        {
            if (s.count(nums[i]) > 0)
                s.erase(nums[i]);
            else
                s.insert(nums[i]);
        }
        vector <int> res;
        copy(s.begin(), s.end(), back_inserter(res));
        return res;
    }
};