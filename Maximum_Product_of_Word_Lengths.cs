/*Given a string array words, find the maximum value of length(word[i]) * length(word[j]) where the two words do not share common letters. You may assume that each word will contain only lower case letters. If no such two words exist, return 0.

Example 1:

Input: ["abcw","baz","foo","bar","xtfn","abcdef"]
Output: 16 
Explanation: The two words can be "abcw", "xtfn".
Example 2:

Input: ["a","ab","abc","d","cd","bcd","abcd"]
Output: 4 
Explanation: The two words can be "ab", "cd".
Example 3:

Input: ["a","aa","aaa","aaaa"]
Output: 0 
Explanation: No such pair of words.*/

/*我的问题是runtime 太长了 要找到解决办法 下面附赠一个例子*/	

		public static int MaxProduct(string[] words)
        {
            int res = 0;
            List<char> charList = new List<char>();           
            foreach(string s in words)
            {                
                for(int i=0; i<s.Length; i++)
                {
                    if (!charList.Contains(s[i]))
                    {
                        charList.Add(s[i]);
                    }                    
                }
            }

            bool haveAllWord = true;
            for (int i = 0; i < words.Length; i++)
            {
                List<char> testList = new List<char>(charList);                            
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!testList.Contains(words[i][j]))
                    {                        
                        haveAllWord = false;
                        break;
                    }                    
                }
                if (haveAllWord)
                {
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (testList.Contains(words[i][j]))
                        {
                            testList.Remove(words[i][j]);                            
                        }                        
                    }
                    res = Math.Max(getMaxWithWord(testList, words, words[i].Length), res);
                }
            }


            return res;

        }            

        private static int getMaxWithWord(List<char> testList, string[] words, int length)
        {
            int res = 0;
            foreach(string s in words)
            {
                bool test = true;
               
                for (int i = 0; i<s.Length; i++)
                {
                    if (!testList.Contains(s[i]))
                    {                        
                        test = false;
                        break;
                    }                    
                }
                if (test)
                {                    
                    res = Math.Max(res, s.Length * length);
                }
            }
            return res;
        }
		
		
		
		
		public class Solution {
        public int MaxProduct(string[] words) {
            if (words == null || words.Length == 0) return 0;
                int len = words.Length;
                int[] value = new int[len];
                for (int i = 0; i < len; i++)
                {
                    string temp = words[i];
                    value[i] = 0;
                    for (int j = 0; j < temp.Length; j++)
                    {
                        value[i] |= 1 << (temp[j] - 'a');
                    }
                }
                int maxProduct = 0;
                for (int i = 0; i < len; i++)
                {
                    for (int j = i + 1; j < len; j++)
                    {
                        if ((value[i] & value[j]) == 0 && (words[i].Length * words[j].Length > maxProduct))
                            maxProduct = words[i].Length * words[j].Length;
                    }
                }
                return maxProduct;
        }
}