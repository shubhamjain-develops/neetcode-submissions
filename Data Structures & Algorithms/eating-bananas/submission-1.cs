public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var l = 1;
        var r = piles.Max();
        var res = 0;
        while(l<=r){
            var m = (l+r)/2;
            var k = 0;
            foreach(var p in piles){
                k += (int)Math.Ceiling((double) p / m);
            }

            if(k > h){
                l = m + 1;
            }
            else{
                res = m;
                r = m - 1;
            }
        }
        return res;
    }
}
