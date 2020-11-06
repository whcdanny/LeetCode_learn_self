public class Solution {
    public int MySqrt(int x) {
        double value = Math.Sqrt(x);
        return (int)value;
    }
}



class Solution:
    def mySqrt(self, x: int) -> int:
        return int(x ** (1 / 2))