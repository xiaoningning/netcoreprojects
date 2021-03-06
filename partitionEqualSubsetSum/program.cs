public class Solution {
    public bool CanPartition(int[] nums) {
        int sum = nums.Sum(), target = sum / 2;
        if (sum % 2 != 0) return false;
        var dp = new bool[target + 1];
        dp[0] = true;
        foreach (int num in nums) {
            // must from target to num, not reverse order
            /* if num == 1, from num to target, 
              then all dp is true. 
              It makes dp invalid for this case
            */
            // update if sum exists in DP
            for (int i = target; i >= num; --i) {
                dp[i] |= dp[i - num];
            }
        }
        return dp[target];
    }
}
