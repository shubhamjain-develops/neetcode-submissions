public class Solution {
    public int CharacterReplacement(string s, int k) {
        var dict = new Dictionary<char,int>();
        var l = 0;
        var res = 0;
        var count = 0;
        for(var r = 0; r < s.Length; r++){
            
            if(dict.ContainsKey(s[r])){
                dict[s[r]]++;
            }
            else{
                dict[s[r]] = 1;
            }
            
            count = Math.Max(count, dict[s[r]]);

            if(r - l + 1 - count <= k){
                res = Math.Max(res, r-l+1);
            }
            else{
                dict[s[l]]--;
                l++;
            }

        }
        return res;
    }
}
