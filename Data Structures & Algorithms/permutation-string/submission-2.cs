public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length){
            return false;
        }

        var s1arr = new int[26];
        var s2arr = new int[26];
        var match = 0;
        for(var i = 0; i< s1.Length; i++){
            s1arr[s1[i] - 'a']++;
            s2arr[s2[i] - 'a']++;
        }

        for(var k = 0; k < 26; k++){
            if(s1arr[k] == s2arr[k]){
                match++;
            }
        }

        var l = 0;

        for(var r = s1.Length; r < s2.Length; r++){
            if(match == 26){
                return true;
            }

            var i = s2[r] - 'a';
            s2arr[i]++;
            if(s2arr[i] == s1arr[i]){
                match++;
            }
            else if(s2arr[i] == s1arr[i] + 1){
                match--;
            }

            i = s2[l] - 'a';
            s2arr[i]--;
            if(s2arr[i] == s1arr[i]){
                match++;
            }
            else if(s2arr[i] == s1arr[i] - 1){
                match--;
            }
            l++;
        }

        return match == 26;
    }
}
