public class Solution {
    public int[] BeautifulArray(int N) {
        // {1} is beautiful <= no a[k] * 2 = a[i] + a[j]
        // a[i] odd, a[j] even, then a[k] * 2 != a[i] + a[j]
        var res = new List<int>(){1};
        // create a new beautiful arr based on the prev one
        while (res.Count < N) {
            var t = new List<int>();
            foreach (var i in res) if (i * 2 - 1 <= N) t.Add(i * 2 - 1); // odd
            foreach (var i in res) if (i * 2 <= N) t.Add(i * 2); // even
            res = t;
        }
        return res.ToArray();
    }
    /**
    A = [2, 1, 4, 5, 3] // beautiful
    A1 = [3, 1, 7, 9, 5]
    A2 = [4, 2, 8, 10, 6]
    B = A1 + A2 = [3, 1, 7, 9, 5, 4, 2, 8, 10, 6]
    */
}
