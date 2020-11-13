public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        return RestoreIpAddresses(s, 4);
    }
    private IList<string> RestoreIpAddresses(string s, int num)
    {
        if (string.IsNullOrEmpty(s) || s.Length < num || s.Length > num * 3)
        {
            return new List<string>();
        }
        if (num == 1)
        {
            if (int.Parse(s) > 255 || (s.Length > 1 && s[0] == '0'))
            {
                return new List<string>();
            }
            return new List<string>() { s };
        }
        IList<string> list = new List<string>();
        for (int i = 1; i < s.Length + 1; i++)
        {
            string start = s.Substring(0, i);
            if (int.Parse(start) > 255 || (i > 1 && start[0] == '0'))
            {
                break;
            }
            var subList = RestoreIpAddresses(s.Substring(i), num - 1);
            if (subList == null || subList.Count == 0)
            {
                continue;
            }
            foreach (string sb in subList)
            {
                list.Add(start + "." + sb);
            }

        }
        return list;
    }
}