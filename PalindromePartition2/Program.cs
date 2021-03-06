public class Solution {
    public int MinCut1(string s) {
        int n = s.Length;
        int[] dp = new int[n];
        bool[,] p = new bool[n, n];
        for (int i = 0; i < n; ++i) {
            // single letter is panlindrome
            // max cuts: i cuts i
            dp[i] = i; 
            for (int j = 0; j <= i; ++j) {
                if (s[i] == s[j] && (i - j < 2 || p[j + 1,i - 1])) {
                    p[j,i] = true;
                    // one more cut after j-1
                    dp[i] = (j == 0) ? 0 : Math.Min(dp[i], dp[j - 1] + 1);
                }
            }
        }
        return dp[n-1];
    }
    
    public int MinCut(string s) {
        int n = s.Length;
        // number of cuts for the first i characters
        int[] dp = new int[n];
        for(int i = 0; i < n; i++) dp[i] = i; // max cuts
        for(int i = 0; i < n; i++){
            // odd length palindrome: xyx
            for(int j = 0; i-j>=0 && i+j < n && s[i+j] == s[i-j]; j++)
                dp[i+j] = Math.Min(dp[i+j], i-j-1 < 0 ? 0 : 1+dp[i-j-1]);
            // even length palindrome: xx
            for(int j = 1; i-j+1>=0 && i+j < n && s[i+j] == s[i-j+1]; j++)
                dp[i+j] = Math.Min(dp[i+j], i-j < 0 ? 0 : 1+dp[i-j]);
        }
        return dp[n-1];
    }
}
