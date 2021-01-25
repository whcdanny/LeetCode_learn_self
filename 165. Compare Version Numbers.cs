public class Solution {
    public int CompareVersion(string version1, string version2) {
        if (version1.Equals(version2))
            {
                return 0;
            }
            string[] subVersion1 = version1.Split('.');
            string[] subVersion2 = version2.Split('.');
            int size = Math.Max(subVersion1.Length, subVersion2.Length);
            int res = 0;
            for (int i = 0; i < size; i++)
            {
                if (i >= subVersion1.Length)
                {
                    res = Int32.Parse(subVersion2[i]) == 0 ? 0 : -1;
                }
                else if (i >= subVersion2.Length)
                {
                    res = Int32.Parse(subVersion1[i]) == 0 ? 0 : 1;
                }
                else
                {
                    if (Int32.Parse(subVersion1[i]) != Int32.Parse(subVersion2[i]))
                    {
                        res = Int32.Parse(subVersion1[i]) < Int32.Parse(subVersion2[i]) ? -1 : 1;
                    }
                }
                if (res != 0)
                {
                    return res;
                }
            }
            return res;
    }
}

//Java
class Solution {
    public int compareVersion(String version1, String version2) {
        if (version1.equals(version2)) {
            return 0;
        }
        String[] subVersion1 = version1.split("\\.");
        String[] subVersion2 = version2.split("\\.");
        int size = Math.max(subVersion1.length, subVersion2.length);
        int res = 0;
        for (int i = 0; i < size; i++) {
            if (i >= subVersion1.length) {
                res = Integer.parseInt(subVersion2[i]) == 0 ? 0 : -1; 
            } else if (i >= subVersion2.length) {
                res = Integer.parseInt(subVersion1[i]) == 0 ? 0 : 1; 
            } else {
                if (Integer.parseInt(subVersion1[i]) != Integer.parseInt(subVersion2[i])) {
                    res = Integer.parseInt(subVersion1[i]) < Integer.parseInt(subVersion2[i]) ? -1 : 1;    
                }
            }
            if (res != 0) {
                return res;
            }
        }
        return res;
    }
}