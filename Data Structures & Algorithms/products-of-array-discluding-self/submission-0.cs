public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var pre = new List<int>();
        var suf = new List<int>();
        var i = 0;
        var j = nums.Length - 1;
        while(i < nums.Length && j>=0){
            if(i == 0){
                pre.Add(1);
            }
            else{
                var mul = pre[i-1] * nums[i-1];
                pre.Add(mul);
            }
            
            if(j == nums.Length - 1){
                suf.Add(1);
            }
            else{
                var mul2 = suf[i-1] * nums[j+1];
                suf.Add(mul2);
            }
            i++;
            j--;
        }
        var res = new List<int>();
        for(var k = 0; k < nums.Length; k++){
            res.Add(pre[k] * suf[nums.Length - 1 - k]);
        }

        return res.ToArray();
    }
}
