public class Solution {
    public bool IsValid(string s) {
        List<char> stack = new List<char>();

        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{') {
                stack.Add(s[i]);
            } else {
                char opposite;
                if (s[i] == ')') {
                    opposite = '(';
                } else if (s[i] == ']'){
                    opposite = '[';
                } else {
                    opposite = '{';
                }
                if (stack.Count == 0 || stack[stack.Count - 1] != opposite) {
                    return false;
                } else {
                    stack.RemoveAt(stack.Count - 1);
                }
            }
        }

        if (stack.Count == 0) {
            return true;
        }
        else {
            return false;
        }

        return false;
    }
}