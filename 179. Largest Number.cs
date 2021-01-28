public class Solution {
    public string LargestNumber(int[] nums) {
        if (nums == null || nums.Length == 0)
            return "";
        string[] stringArray = new string[nums.Length];
        for(int i=0; i < stringArray.Length; i++)
        {
            stringArray[i] = Convert.ToString(nums[i]);
        }            

        Array.Sort(stringArray, delegate (string s1, string s2)
            { return (s2 + s1).CompareTo(s1 + s2); });
            
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < stringArray.Length; i++)
        {
            sb.Append(stringArray[i]);
        }

        string ans = sb.ToString();
        if (ans[0] == '0') 
            return "0";
        else 
            return ans;
    }
}

//Java
class Solution {
    public String largestNumber(int[] nums) {
        String[] s = new String[nums.length];
        for(int i=0; i<nums.length; i++){
            s[i] = String.valueOf(nums[i]);
        }
        
        Arrays.sort(s,new Comparator<String>(){
            public int compare(String a, String b){
                return (b+a).compareTo(a+b);
            }
        });
        StringBuilder sb = new StringBuilder();
        for(int i=0; i<s.length; i++){
            sb.append(s[i]);
        }
        String ans = new String(sb);
        if(ans.charAt(0)=='0') return "0";
        else return ans;
    }
}