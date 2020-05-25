/*Given a string, find the length of the longest substring without repeating characters.

Example 1:

Input: "abcabcbb"
Output: 3 
Explanation: The answer is "abc", with the length of 3. 
Example 2:

Input: "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3. 
             Note that the answer must be a substring, "pwke" is a subsequence and not a substring.*/
/*思路：基本上是一个一个去比较，注意不是遇到重复 而是onebyone*/
		
		public static int LengthOfLongestSubstring(string s)
        {
            string subString = "";
            int max = 0;
            for (var i = 0; i < s.Length; i++)
            {
                subString = "";
                for (var j = i; j < s.Length; j++)
                {
                    if (subString.Contains(s[j]))
                    {
                        break;
                    }
                    subString = s.Substring(i, j - i + 1);
                }
                if (subString.Length > max)
                {
                    max = subString.Length;
                }
            }
            return max;
        }
		
		 //public static int LengthOfLongestSubstring(string s)
        //{
        //    int max = 0;
        //    List<char> list = new List<char>();            
        //    if (s == "") return 0;
        //    if (s == " ") return 1;
        //    for(int i=0; i<s.Count(); i++)
        //    {
                
        //        for (int j =i; j<s.Count(); j++)
        //        {
        //            char c = s[i];
        //            list.Add(s[i]);
        //            if (!list.Contains(s[j]))
        //            {
        //                list.Add(s[j]);
        //            }
        //            else
        //            {                        
        //                break;
        //            }
        //        }
        //        int count = list.Count;
        //        if (count > max)
        //        {
        //            max = count;
        //        }
        //        list = new List<char>();
        //    }
        //    
        //    return max;
        //}