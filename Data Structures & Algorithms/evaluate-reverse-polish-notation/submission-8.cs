public class Solution {
    public int EvalRPN(string[] tokens) {
        if(tokens.Length == 1){
            return Convert.ToInt32(tokens[0]);
        }
        var res = 0;
        var stack = new Stack<int>();
        for(var i = 0; i < tokens.Length; i++){
                
                if(tokens[i] == "+"){
                    var b =  stack.Pop();
                    var a = stack.Pop();
                    res = a + b;
                    stack.Push(res);
                }
                else if(tokens[i] == "-"){
                    var b =  stack.Pop();
                    var a = stack.Pop();
                    res = a - b;
                    stack.Push(res);
                }
                else if(tokens[i] == "*"){
                    var b =  stack.Pop();
                    var a = stack.Pop();
                    res = a * b;
                    stack.Push(res);
                }
                else if(tokens[i] == "/"){
                    var b =  stack.Pop();
                    var a = stack.Pop();
                    res = a / b; 
                    stack.Push(res); 
                }
                else{
                    stack.Push(int.Parse(tokens[i]));
                }
        }
        return res;
    }
}
