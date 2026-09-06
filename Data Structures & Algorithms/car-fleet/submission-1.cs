public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        
        var pands = new Dictionary<int,int>();
        
        for(var i = 0; i < speed.Length; i++){
            pands[position[i]] = speed[i];
        } 
        
        Array.Sort(position);
        
        double fc = (target - position[position.Length - 1])/pands[position[position.Length - 1]];
        var count = 1;
        for(var i = position.Length - 2; i >= 0; i--){
            double tc = ((double)target - position[i])/pands[position[i]];
            if(tc > fc){
                count++;
                fc = tc;
            }
        } 

        return count;
    }
}
