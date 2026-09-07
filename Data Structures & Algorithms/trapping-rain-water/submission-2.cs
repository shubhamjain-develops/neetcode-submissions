public class Solution {
    public int Trap(int[] height) {
        if(height.Length <= 2){
            return 0;
        }

        var rmax = new int[height.Length];
        var lmax = new int[height.Length];
        
        lmax[0] = height[0];
        rmax[height.Length - 1] = height[height.Length - 1];

        for(var i = 1; i < height.Length; i++){
           lmax[i] = Math.Max(lmax[i-1],height[i]); 
        }
        for(var i = height.Length - 2; i >= 0; i--){
           rmax[i] = Math.Max(rmax[i+1],height[i]); 
        }

        var res = 0;
        for(var i = 0; i < height.Length; i++){
            res += Math.Min(lmax[i], rmax[i]) - height[i];
        }

        return res;
    }
}
