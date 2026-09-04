public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<List<int>>();

        for (int k = 0; k < nums.Length - 2; k++) {
            if (k > 0 && nums[k] == nums[k - 1]) continue; 
            if (nums[k] > 0) break; 

            int i = k + 1;
            int j = nums.Length - 1;

            while (i < j) {
                int sum = nums[k] + nums[i] + nums[j];

                if (sum < 0) {
                    i++;
                } else if (sum > 0) {
                    j--;
                } else {
                    result.Add(new List<int> { nums[k], nums[i], nums[j] });
                    i++;
                    j--;
                    while (i < j && nums[i] == nums[i - 1]) i++; 
                    while (i < j && nums[j] == nums[j + 1]) j--; 
                }
            }
        }

        return result;
    }
}