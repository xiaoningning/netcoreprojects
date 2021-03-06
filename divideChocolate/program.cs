public class Solution {
    public int MaximizeSweetness(int[] sweetness, int K) {
        // K+1 pieces with K friend + yourself
        int left = sweetness.Min(), right = sweetness.Sum() / (K+1);
        while (left < right) {
            // max total sweetness => right + 1
            // overflow check
            int mid =  right + (left - right + 1) / 2;
            int cur = 0, cuts = 0;
            foreach (int a in sweetness) {
                if ((cur += a) >= mid) {
                    cur = 0;
                    if (++cuts > K) break;
                }
            }
            // cuts is k+1 pieces
            // but we want bigger total sweetness
            if (cuts >= K + 1)
                left = mid;
            else
                right = mid - 1;
        }
        return left;
    }
}
