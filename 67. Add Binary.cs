public class Solution {
    public string AddBinary(string a, string b) {
        if (string.IsNullOrWhiteSpace(a) && string.IsNullOrWhiteSpace(b))
        {
            return "0";
        }

        if (string.IsNullOrWhiteSpace(a))
        {
            return b;
        }

        if (string.IsNullOrWhiteSpace(b))
        {
            return a;
        }

        StringBuilder result = new StringBuilder();

        int l1 = a.Length - 1;
        int l2 = b.Length - 1;

        int count = Math.Max(l1, l2);
        bool carry = false;
        bool isZero = false;

        while (count-- >= 0)
        {
            char aNum = l1 >= 0 ? a[l1--] : '0';
            char bNum = l2 >= 0 ? b[l2--] : '0';

            if (aNum == '0' && bNum == '0')
            {
                result.Insert(0, carry ? "1" : "0");
                carry = false;
            }
            else if (aNum == '1' && bNum == '1')
            {
                isZero = true;
                result.Insert(0, carry ? "1" : "0");
                carry = true;
            }
            else
            {
                isZero = true;
                result.Insert(0, carry ? "0" : "1");
            }
        }

        if (!isZero)
        {
            return "0";
        }

        if (carry)
        {
            result.Insert(0, "1");
        }

        return result.ToString();
    }
}