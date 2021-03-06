public class Solution {
    public int SumSubseqWidths1(int[] A) {
        Array.Sort(A);
        long res = 0;
        long mod = (long)(Math.Pow(10,9)) + 7, c = 1; 
        // c : 2^i
        for (int i = 0; i < A.Length; ++i, c = (c << 1) % mod)
            res = (res + A[i] * c - A[A.Length - i - 1] * c) % mod;
        return (int)(res % mod);
    }
    
    public int SumSubseqWidths(int[] A) {
        Array.Sort(A);
        long res = 0;
        long mod = (long)(Math.Pow(10,9)) + 7, c = 1; 
        // c : 2^i
        int leftSum = 0, rightSum = 0, left = 0, right = A.Length -1;
        while (left < A.Length) {
            leftSum += A[left++];
            rightSum += A[right--];
            res = (res + (rightSum - leftSum) * c) % mod;
            c = (c << 1) % mod;
        }
        return (int)(res);
    }
    // not pass OJ
    public int SumSubseqWidths3(int[] A) {
        Array.Sort(A);
        double res = 0;
        long mod = (long)(Math.Pow(10,9)) + 7; 
        for (int i = 0; i < A.Length; ++i) {
            for (int j = i+1; j < A.Length; j++) {
                res += Math.Pow(2,(j-i-1)) * (A[j]-A[i]);
                res %= mod;
            }
        }
        return (int)(res % mod);
    }
}
