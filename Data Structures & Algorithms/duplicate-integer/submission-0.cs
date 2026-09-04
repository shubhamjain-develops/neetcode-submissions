public class Solution {
    public bool hasDuplicate(int[] nums) {
        var unique = new HashSet<int>();
        foreach(var num in nums){
            if(unique.Contains(num)){
                return true;
            }
            else{
                unique.Add(num);
            }
        }
        return false;
    }
}