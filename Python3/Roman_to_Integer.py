class Solution:
    ROMAN = {
        "I": 1,
        "V": 5,
        "X": 10,
        "L": 50,
        "C": 100,
        "D": 500,
        "M": 1000
    }
    def romanToInt(self, s: str) -> int:
        result = 0
        for x in range(len(s)):
            n = self.ROMAN[s[x]]
            if (x+1<len(s)) and n < self.ROMAN[s[x+1]]:
                result -= n
            else:
                result += n

        return(result)