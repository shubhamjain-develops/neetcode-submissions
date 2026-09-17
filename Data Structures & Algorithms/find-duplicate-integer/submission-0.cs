public class Solution {
    public int FindDuplicate(int[] nums) {
        var fast = 0; var slow = 0;

        while(true){
            fast = nums[nums[fast]];
            slow = nums[slow];
            if(fast == slow) break;
        }

        var slow2 = 0;

        while(true){
            slow = nums[slow];
            slow2 = nums[slow2];
             if(slow2 == slow) return slow;
        }

        
    }
}
