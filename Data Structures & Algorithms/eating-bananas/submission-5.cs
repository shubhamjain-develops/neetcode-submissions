public class Solution {
    public int FindMin(int[] nums) {
        var r = nums.Length - 1;
        var l = 0;
        while (l < r) {
            var m = l + (r - l) / 2;
            if (nums[m] < nums[r]) {
                r = m;
            } else {
                l = m + 1;
            }
        }

        return nums[l];
    }
}
