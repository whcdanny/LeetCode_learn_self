public class Solution {
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        int areaA = (C - A) * (D - B);
        int areaB = (G - E) * (H - F);

        int top = Math.Min(D, H);
        int bottom = Math.Max(B, F);
        int left = Math.Max(A, E);
        int right = Math.Min(C, G);

        int overlap = 0;
        if (top > bottom && right > left) {
            overlap = (top - bottom) * (right - left);
        }
        return areaA + areaB - overlap;
    }
}

//Java
class Solution {
    public int computeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        int areaA = (C - A) * (D - B);
        int areaB = (G - E) * (H - F);

        int top = Math.min(D, H);
        int bottom = Math.max(B, F);
        int left = Math.max(A, E);
        int right = Math.min(C, G);

        int overlap = 0;
        if (top > bottom && right > left) {
            overlap = (top - bottom) * (right - left);
        }
        return areaA + areaB - overlap;
    }
}