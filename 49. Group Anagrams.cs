/*Given an array of strings, group anagrams together.

Example:

Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
Output:
[
  ["ate","eat","tea"],
  ["nat","tan"],
  ["bat"]
]*/    

/*思路：把26个字母放入，检查每一个个数*/
	
	public IList<IList<string>> GroupAnagrams(string[] strs) {
        if (strs == null || strs.Length == 0) return new List<IList<string>>();

        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        int[] count = new int[26];
        foreach (var str in strs)
        {
            Array.Fill(count, 0);
            foreach (var c in str) count[c - 'a']++;

            var key = string.Join(",", count);
            if (!map.ContainsKey(key)) map[key] = new List<string>() { str };
            else map[key].Add(str);
        }

        return map.Values.ToArray();
    }