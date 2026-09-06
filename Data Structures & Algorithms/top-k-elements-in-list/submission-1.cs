public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int,int>();
        foreach(int n in nums){
            if(freq.ContainsKey(n)){
                freq[n]++;
            }
            else{
                freq[n] = 1;
            }
        }

        var res = new List<int>[nums.Length + 1];
        foreach(var f in freq.Keys){
            if(res[freq[f]] == null){
               res[freq[f]] = new List<int>{}; 
            }
            
            res[freq[f]].Add(f);
            
        } 

        var result = new List<int>();
        for(var i = res.Length - 1; i >= 0 && result.Count < k; i--){

            if(res[i] != null){
                result.AddRange(res[i]);
            }

        }

        return result.ToArray();
    }
}
