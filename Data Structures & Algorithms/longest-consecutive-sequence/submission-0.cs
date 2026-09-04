public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hashnums = new HashSet<int>();
        foreach(var n in nums){
            if(!hashnums.Contains(n)) hashnums.Add(n);
        }
        var start_seq = new HashSet<int>();
        var i = 0;
        while(i < nums.Length){
            if(!hashnums.Contains(nums[i] - 1)){
                start_seq.Add(nums[i]);
            }
            i++;
        }

        var count = 0;
        var max_count = 0;
        foreach(var s in start_seq){
            var sum = s;
            count= 0;
            while(hashnums.Contains(sum)){
                count++;
                sum++;
            }
            
            if(count>max_count){
                max_count = count;
            }
        }

        return max_count;
    }
}
