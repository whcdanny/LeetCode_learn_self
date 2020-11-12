public class Solution {
    public bool IsScramble(string s1, string s2) {
        if (s1.Equals(s2))
			return true;			
		if (s1.Length == 0) 
            return false;
		if (s1.Length != s2.Length)
			return false;
		
		int[] chars = new int[256];
		for (int i = 0; i < s1.Length; i++)
		{
			chars[s1[i]]++;
			chars[s2[i]]--;
		}

		for (int i = 0; i < chars.Length; i++)
			if (chars[i] != 0)
				return false; 	
		
		int len = s1.Length;
		for (int i = 1; i < len; i++)
		{
			if ((IsScramble(s1.Substring(0, i), s2.Substring(0, i)) 
                 && IsScramble(s1.Substring(i), s2.Substring(i)))
			|| (IsScramble(s1.Substring(len - i), s2.Substring(0, i)) 
                && IsScramble(s1.Substring(0, len - i), s2.Substring(i))))
					return true;
		}
		return false;
    }
}