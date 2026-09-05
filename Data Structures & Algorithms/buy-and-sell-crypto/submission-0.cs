public class Solution {
    public int MaxProfit(int[] prices) {
        var min = prices[0];
        var max = prices[0];
        var msum = 0;
        var sum = 0;

        for(var i = 0; i < prices.Length; i++){
            if(prices[i] < min){
                sum = Math.Max(sum, max-min);
                min = prices[i];
                max = prices[i];
            }
            if(prices[i]> max){
                max = prices[i];
                sum = Math.Max(sum, max-min); 
            }
        }

        return sum;
    }
}
