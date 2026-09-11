public class TimeMap {
    private Dictionary<string, List<Tuple<int,string>>> dict;

    public TimeMap() {
        dict = new Dictionary<string, List<Tuple<int,string>>>();
    }

    public void Set(string key, string value, int timestamp) {
        if(!dict.ContainsKey(key)){
            dict[key] = new List<Tuple<int,string>>();
        }
        dict[key].Add(Tuple.Create(timestamp, value));
    }

    public string Get(string key, int timestamp) {
        if(!dict.ContainsKey(key)) return "";
        var arr = dict[key];
        var i = BinarySearch(arr, timestamp);
        if(i == -1) return "";
        return arr[i].Item2;
    }

    private int BinarySearch(List<Tuple<int,string>> arr, int k){
        var l = 0;
        var r = arr.Count - 1;
        var ans = -1;
        while(l <= r){
            var m = l + (r-l)/2;
            if(arr[m].Item1 <= k){
                ans = m;
                l = m + 1;
            }
            else{
                r = m - 1;
            }
        }
        return ans;
    }
}