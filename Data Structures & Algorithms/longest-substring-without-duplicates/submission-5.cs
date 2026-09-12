public class Solution {
    public int LengthOfLongestSubstring(string s) {
       var hash = new HashSet<char>();
       var l = 0; 
       var res = 0;

       for(var r = 0; r < s.Length; r++){
            while(hash.Contains(s[r])){
                hash.Remove(s[l]);
                l++;
            }
            
            hash.Add(s[r]);
            res = Math.Max(res, hash.Count);
       }

        return res;

    }
}
 