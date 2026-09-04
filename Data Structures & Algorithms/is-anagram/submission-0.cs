public class Solution {
    public bool IsAnagram(string s, string t) {
      if(s.Length != t.Length) return false;
      var arr = new int[26];
      for(var i = 0; i< s.Length; i++){
        
          arr[s[i] - 'a']++;
        
          arr[t[i] - 'a']--;
        
      }   
      foreach(var chk in arr){
        if(chk != 0) return false;
      }
      return true;
    }

   
}
