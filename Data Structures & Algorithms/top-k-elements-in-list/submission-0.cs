public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int,int>();
        foreach(int n in nums){
            if(!dict.ContainsKey(n)){
                dict[n] = 0;
            }
            dict[n]++;
        }

    var freqarr = new List<int>[nums.Length + 1];   // sized array, index 0..nums.Length
    foreach(var key in dict.Keys){
        int freq = dict[key];               // freq = how often 'key' appears
        if(freqarr[freq] == null){
            freqarr[freq] = new List<int>();
        }
        freqarr[freq].Add(key);             // store the NUMBER in the bucket for its frequency
    } 

        var result = new List<int>();

        for(var p = freqarr.Length -1; p >= 0 && result.Count < k ; p--){
            if(freqarr[p] != null){
                result.AddRange(freqarr[p]);
            }
        }

        return result.ToArray();
    }
}
