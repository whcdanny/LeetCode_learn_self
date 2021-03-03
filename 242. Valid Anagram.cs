public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sarr = s.ToCharArray();
        char[] tarr = t.ToCharArray();            
        Array.Sort(sarr);
        Array.Sort(tarr);
        if(sarr.Length != tarr.Length)
            return false;
        for(int i=0; i<sarr.Length; i++)
        {
            if (!sarr[i].Equals(tarr[i]))
                return false;
        }
        return true;
    }
}

//Java
class Solution {
    public boolean isAnagram(String s, String t) {
        char[] sarr=s.toCharArray();
        char[] tarr=t.toCharArray();
        
        Arrays.sort(sarr);
        Arrays.sort(tarr);
        return String.valueOf(sarr).equals(String.valueOf(tarr));
    }
}