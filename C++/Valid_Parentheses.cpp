class Solution {
public:
    bool isValid(string s) {
       std::vector<char> stack;

        for (int i = 0; i < s.size(); i++) {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{') {
                stack.push_back(s[i]);
            } else {
                char opposite;
                if (s[i] == ')') {
                    opposite = '(';
                } else if (s[i] == ']'){
                    opposite = '[';
                } else {
                    opposite = '{';
                }
                if (stack.empty() || stack.back() != opposite) {
                    return false;
                } else {
                    stack.pop_back();
                }
            }
        }

        if (stack.empty()) {
            return true;
        }
        else {
            return false;
        }

        return false;
    }
};