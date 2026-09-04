public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string,List<string>>();
        foreach(string s in strs){
            var count = new int[26];
            foreach(char c in s){
                count[c - 'a']++;
            }
            var key = String.Join(",",count);
            if(dict.ContainsKey(key)){
                dict[key].Add(s);
            }
            else{
                dict[key] = new List<String>(){s};
            }
        }

        return dict.Values.ToList<List<string>>();
    }
}
