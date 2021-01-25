public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        long v1 = numerator;
        long v2 = denominator;

        StringBuilder res = new StringBuilder();

        if (v1 % v2 == 0)
        {
            res.Append(v1 / v2);
            return res.ToString();
        }
        Hashtable ht = new Hashtable();
        if (numerator < 0 ^ denominator < 0)
            res.Append("-");
        v1 = Math.Abs(v1);
        v2 = Math.Abs(v2);

        res.Append(v1 / v2 + ".");

        long remainder = (v1 % v2) * 10;

        while (!ht.ContainsKey(remainder))
        {
            if (!ht.ContainsKey(remainder))
            {
                ht.Add(remainder, res.Length);
                res.Append(remainder / v2);
                remainder = (remainder % v2) * 10;
                if (remainder == 0)
                    return res.ToString();
            }
        }
        res.Insert((int)ht[remainder], "(");
        res.Append(")");
        return res.ToString();
    }
}

//Java
class Solution {
    public String fractionToDecimal(int numerator, int denominator) {
        long a = numerator, b = denominator;
		if (a%b == 0)	
			return String.valueOf(a/b);
		HashMap<Long,Integer> map = new HashMap<Long, Integer>();
		StringBuilder sb = new StringBuilder();
		if ((numerator < 0)^(denominator < 0))
			sb.append("-");
		a = Math.abs(a);
		b = Math.abs(b);

		sb.append(a/b+".");
		long remainder = (a % b) * 10;
		
		while (!map.containsKey(remainder)) {
			if (!map.containsKey(remainder)) {
				map.put(remainder, sb.length());
				sb.append(String.valueOf(remainder/b));
				remainder = (remainder % b)*10;

				if (remainder == 0)
					return sb.toString();
			}
		}
		sb.insert(map.get(remainder), "(");
		sb.append(")");
		return sb.toString();
    }
}