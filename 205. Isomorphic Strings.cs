public class Solution {
    public bool IsIsomorphic(string s, string t) {
        char[] sarray = s.ToCharArray();
            char[] tarray = t.ToCharArray();

            Dictionary<char, char> dis = new Dictionary<char, char>();

            if (sarray.Length != tarray.Length)
                return false;
            for(int i=0; i < sarray.Length; i++)
            {
                if (!dis.ContainsKey(sarray[i]))
                {
                    if (dis.ContainsValue(tarray[i]))
                        return false;
                    dis.Add(sarray[i], tarray[i]);
                }
                else
                {
                    char c = dis[sarray[i]];
                    if (c != tarray[i])
                        return false;
                }
            }
            return true;
    }
}

//Java
class Solution {
    public boolean isIsomorphic(String s, String t) {
        char[] ss = s.toCharArray();
        char[] tt = t.toCharArray();
    
        HashMap<Character, Character> map = new HashMap<Character, Character>();
    
        if(ss.length != tt.length) 
        {
            return false;
        }
    
        for(int i=0; i<ss.length; i++)
        {
            if(!map.containsKey(ss[i]))
            {
                if(map.containsValue(tt[i]))
                {
                    return false;
                }
            
                map.put(ss[i], tt[i]);
            }
            else{
                char value = map.get(ss[i]);
                if(value!=tt[i])
                {
                    return false;
                }
            }
        }
    
        return true;
    }
}