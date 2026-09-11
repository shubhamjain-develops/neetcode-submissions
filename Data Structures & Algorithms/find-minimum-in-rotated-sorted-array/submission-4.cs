public class Solution {
    public int FindMin(int[] nums) {
        var r = nums.Length - 1;
        var l = 0;
        int res = nums[0];
        while(l <= r){

            if(nums[l] < nums[r]){
                res = Math.Min(nums[l],res);
                break;
            }
            int m = l + (r - l) / 2;
            res = Math.Min(nums[m],res);
            
            if (nums[m] >= nums[l]) {
                l = m+1;
            }
            else{
                r = m-1;
            }
            
        }

        return res;
    }
}
