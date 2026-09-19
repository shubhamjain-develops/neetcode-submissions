public class Solution {
    public int MaxArea(int[] heights) {
        var len = heights.Length;
        var r = len - 1;
        var l = 0;
        var sum = 0;

        while(l < r){
            sum = Math.Max(sum, Math.Min(heights[l] , heights[r]) * (r-l));
            if(heights[l] > heights[r]){
                r--;
            }
            else{
                l++;
            }
        }

        return sum;
    }
}
