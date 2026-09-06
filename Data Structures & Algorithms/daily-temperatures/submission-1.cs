public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var res = new int[temperatures.Length];
        var stack = new Stack<int[]>();
        for(var i = 0; i < temperatures.Length; i++){
            if(stack.Count != 0){
                while(stack.Count != 0 && stack.Peek()[0] < temperatures[i]){
                    res[stack.Peek()[1]] = i-stack.Peek()[1];
                    stack.Pop();
                }
                stack.Push(new int[]{temperatures[i],i});
            }
            else{
                stack.Push(new int[]{temperatures[i],i});
            }
        } 
        return res;
    }
}
