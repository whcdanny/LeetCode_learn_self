public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        for(int i=0;i<s.Length-9; i++)
        {
                string sequence = s.Substring(i, 10);
                if (dic.ContainsKey(sequence))
                {
                    dic[sequence]++;
                }
                else
                {
                    dic.Add(sequence, 1);
                }          
            }
            List<string> res = new List<string>();
            foreach(string seq in dic.Keys)
            {
                if (dic[seq] > 1)
                    res.Add(seq);
            }
            return res;
    }
}

//Java
class Solution {
    public List<String> findRepeatedDnaSequences(String s) {
        Map<String, Integer> map = new HashMap();
        for (int i = 0; i < s.length() - 9; i++) {
            String sequence = s.substring(i, i + 10);
            map.put(sequence, map.getOrDefault(sequence, 0) + 1);
        }
        List<String> repeatedSequences = new ArrayList<>();
        for (Map.Entry<String, Integer> entry : map.entrySet()) {
            if (entry.getValue() > 1) {
                repeatedSequences.add(entry.getKey());
            }
        }
        return repeatedSequences;
    }
}