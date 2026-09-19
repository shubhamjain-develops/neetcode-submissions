public class Solution {
    public int Trap(int[] height) {
        var l = 0; 
        var r = height.Length - 1;
        var water = 0;
        var rmax = height[height.Length - 1];
        var lmax = height[0];
        while(l!=r){
            rmax = Math.Max(rmax, height[r]);
            lmax = Math.Max(lmax, height[l]);

            if(height[l] > height[r]){
                water += rmax - height[r];
                r--;
            }
            else{
                water += lmax - height[l];
                l++;
            }
        }

        return water;
    }
}
