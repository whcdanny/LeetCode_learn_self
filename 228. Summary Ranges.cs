public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
       IList<string> res = new List<string>();

        if (nums == null || nums.Length == 0)
            return res;
        if (nums.Length == 1)
            res.Add(nums[0] + "");
        int pre = nums[0];
        int first = pre;

        for(int i=1; i<nums.Length; i++)
        {
            if (nums[i] == pre + 1)
            {
                if (i == nums.Length - 1)
                {
                    res.Add(first + "->" + nums[i]);
                }
            }
            else
            {
                if (first == pre)
                    res.Add(first + "");
                else
                    res.Add(first + "->" + pre);
                if (i == nums.Length - 1)
                    res.Add(nums[i] + "");
                first = nums[i];
            }
            pre = nums[i];
        }
        return res; 
    }
}

//Java
class Solution {
    public List<String> summaryRanges(int[] nums) {
        List<String> result = new ArrayList<String>();
 
        if(nums == null || nums.length==0)
            return result;
 
        if(nums.length==1)
            result.add(nums[0]+"");     
        
        int pre = nums[0];  
        int first = pre; 
 
        for(int i=1; i<nums.length; i++){
            if(nums[i]==pre+1){
                if(i==nums.length-1){
                    result.add(first+"->"+nums[i]);
                }
            }else{
                if(first == pre){
                    result.add(first+"");
                }else{
                    result.add(first + "->"+pre);   
                }
 
                if(i==nums.length-1){
                    result.add(nums[i]+"");
                }
 
                first = nums[i];
            }
 
            pre = nums[i];
        }
 
        return result;
    }
}