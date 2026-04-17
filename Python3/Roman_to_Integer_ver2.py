class Solution:
    ROMAN = ('I', 'V', 'X', 'L', 'C', 'D', 'M')

    def get_nom(self, x: int) -> int:
        power = x // 2

        if x % 2 == 0:
            return 1 * (10**power)
        else:
            return 5 * (10**power)

    def romanToInt(self, s: str) -> int:
        result = 0
        for x in range(len(s)):
            get_indx = self.ROMAN.index(s[x])
            if (x+1<len(s)) and get_indx < self.ROMAN.index(s[x+1]):
                result -= self.get_nom(get_indx)
            else:
                result += self.get_nom(get_indx)

        return(result)

        