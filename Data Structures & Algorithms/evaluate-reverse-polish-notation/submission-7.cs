public class Solution {
    public int EvalRPN(string[] tokens) {
        if(tokens.Length == 1){
            return Convert.ToInt32(tokens[0]);
        }
        var res = 0;
        var h = new HashSet<string>{"+","-","*","/"};
        var stack = new Stack<int>();
        for(var i = 0; i < tokens.Length; i++){
            if(h.Contains(tokens[i])){
                var b =  stack.Pop();
               
                var a = stack.Pop();
                
                if(tokens[i] == "+"){
                    res = a + b;
                }
                if(tokens[i] == "-"){
                    res = a - b;
                }
                if(tokens[i] == "*"){
                    res = a * b;
                }
                if(tokens[i] == "/"){
                    res = a / b;  
                }
                stack.Push(res);
            }
            else{
                stack.Push(Convert.ToInt32(tokens[i]));
            }
        }
        return res;
    }
}
