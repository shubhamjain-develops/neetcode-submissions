public class Solution {
    public int Trap(int[] height) {
        var n = height.Length;
        var r = n-1;
        var l = 0;
        var rmax = height[n-1];
        var lmax = height[0];
        var res = 0;

        while(l != r){
            rmax = Math.Max(rmax, height[r]);
            lmax = Math.Max(lmax, height[l]);

            if(height[l] < height[r]){
                res +=  lmax - height[l];
                l++;
            }
            else{
                res +=  rmax - height[r];
                r--;
            }
        }

        return res;
    }
}
