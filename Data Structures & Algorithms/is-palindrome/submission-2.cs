public class Solution {
    public bool IsPalindrome(string s) {
        var str = s.Replace(" ","").ToLower();
        str = Regex.Replace(str, "[^a-zA-Z0-9]", "");

        var i = 0;
        var j = str.Length - 1;

        while(i<=j){
            if(str[i] != str[j]){
                return false;
            }
            i++;j--;
        }

        return true;
    }
}
