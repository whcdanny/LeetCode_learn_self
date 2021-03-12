public class Solution {
    public int NthUglyNumber(int n) {
        if (n <= 0)
            return 0;

        List<int> list = new List<int>();
        list.Add(1);

        int i = 0;
        int j = 0;
        int k = 0;

        while (list.Count < n)
        {
            int m2 = list[i] * 2;
            int m3 = list[j] * 3;
            int m5 = list[k] * 5;

            int min = Math.Min(m2, Math.Min(m3, m5));
            list.Add(min);
            if (min == m2)
                   i++;

            if (min == m3)
                j++;

            if (min == m5)
                k++;
        }

        return list[list.Count - 1];
    }
}

//C++
class Solution {
public:
    int nthUglyNumber(int n) {
        priority_queue<long, vector<long>, greater<long>> pq;
        pq.push(1);

        long cur;
        while (n-- > 0) {
            cur = pq.top();
            pq.pop();
        while (!pq.empty() && cur == pq.top()) 
            pq.pop();

        pq.push(cur * 2);
        pq.push(cur * 3);
        pq.push(cur * 5);
        }
        return cur;
    }
};

//Java
class Solution {
    public int nthUglyNumber(int n) {
        if (n <= 0)
			return 0;

		ArrayList<Integer> list = new ArrayList<Integer>();
		list.add(1);

		int i = 0;
		int j = 0;
		int k = 0;

		while (list.size() < n) {
			int m2 = list.get(i) * 2;
			int m3 = list.get(j) * 3;
			int m5 = list.get(k) * 5;

			int min = Math.min(m2, Math.min(m3, m5));
			list.add(min);
			if (min == m2)
				i++;

			if (min == m3)
				j++;

			if (min == m5)
				k++;
		}

		return list.get(list.size() - 1);
    }
}