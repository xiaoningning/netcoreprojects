public class Solution {
    int[] wSums;
    Random rnd;
    public Solution(int[] w) {
        rnd = new Random();
        for(int i = 1; i < w.Length; ++i)
            w[i] += w[i-1];
        wSums = w;
    }
    
    public int PickIndex() {
        int len = wSums.Length;
        int idx = rnd.Next(wSums[len-1]) + 1;
        int left = 0, right = len - 1;
        // search position 
        while(left < right){
            int mid = left + (right-left)/2;
            if(wSums[mid] == idx)
                return mid;
            else if (wSums[mid] < idx)
                left = mid + 1;
            else
                right = mid;
        }
        return left;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */