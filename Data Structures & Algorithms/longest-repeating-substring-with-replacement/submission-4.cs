public class Solution {
    public int CharacterReplacement(string s, int k) {
        var dict = new Dictionary<char,int>();
        var maxf = 0;
        var res = 0; 
        var l = 0;
        for(var i = 0; i < s.Length; i++){
            if(dict.ContainsKey(s[i])){
                dict[s[i]]++;
            }
            else{
                dict[s[i]] = 1;
            }

            maxf = Math.Max(maxf, dict[s[i]]);    
                
            while((i-l+1) - maxf > k){
                dict[s[l]]--;
                l++;
            }
            res = Math.Max(res, i - l + 1);
        }

        return res;
    }
}