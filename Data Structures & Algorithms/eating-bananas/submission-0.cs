public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var len = piles.Length;
        var l = 1;
        var r = piles.Max();
        
        var res = 0;
        while(l <= r){
            var x = (r+l)/2;
            var k = 0;
            foreach(var m in piles){
                k += (int)Math.Ceiling((double)m / (double)x);
            }
            if(k > h){
                l = x + 1;
            }
            else{
                res = x;
                r = x - 1;
            }
        }
        
        return res;
    }
}
