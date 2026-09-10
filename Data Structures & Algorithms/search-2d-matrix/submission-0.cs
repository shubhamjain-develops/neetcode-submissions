public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
       var le = matrix.Length;
       var n = matrix[0].Length;
       var l = 0;
       var r = le*n - 1;

       while(l<=r){

            var m = l + (r - l)/2;
            var i = m/n;
            var j = m%n;

            if(matrix[i][j] > target){
                r = m - 1;  
            }
            else if(matrix[i][j] < target){
                l = m + 1;
            }
            else{
                return true;
            }
       }
       return false;
    }
}
