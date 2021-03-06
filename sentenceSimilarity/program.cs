public class Solution {
    public bool AreSentencesSimilar(string[] words1, string[] words2, IList<IList<string>> pairs) {
        if (words1.Length != words2.Length) return false;
        var map = new Dictionary<string, HashSet<string>>();
        foreach (var p in pairs) {
            if (!map.ContainsKey(p[0])) map.Add(p[0], new HashSet<string>());
            map[p[0]].Add(p[1]);
        }

        for (int i = 0; i < words1.Length; i++)
            if (words1[i] != words2[i]
                && !map.GetValueOrDefault(words1[i], new HashSet<string>()).Contains(words2[i]) 
                && !map.GetValueOrDefault(words2[i], new HashSet<string>()).Contains(words1[i]))
                return false;
        return true;
        
    }
}
