public class Solution {
    public string LicenseKeyFormatting(string S, int K) {
        string res = "";
        int cnt = 0;
        for (int i = S.Length -1; i >=0; i--) {
            if (S[i] == '-') continue;
            res += Char.ToUpper(S[i]);
            if (++cnt % K == 0)  res += "-";            
        }
        if (res.Length != 0 && res[res.Length -1] == '-') res = res.Substring(0, res.Length - 1);
        char[] r = res.ToCharArray();
        Array.Reverse(r);
        return new string(r);
    }
}
