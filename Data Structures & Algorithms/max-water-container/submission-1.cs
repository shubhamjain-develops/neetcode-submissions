public class Solution {
    public int MaxArea(int[] heights) {
        var i = 0;
        var j = heights.Length - 1;
        var max_area = 0;
        var h = heights;
        while(i<j){
            var area = 0;
            if(h[i]<h[j]){
                area = h[i] * (j-i);
            }
            else{
                area = h[j] * (j-i);
            }
            if(max_area<area) max_area = area;
            if(h[i]<h[j]){
                i++;
            }
            else{
                j--;
            }

        }
        return max_area;
    }
}
