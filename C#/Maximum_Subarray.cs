public class Solution {
    public int MaxSubArray(int[] nums) {
        int res = nums[0];
        int total = 0;

        foreach (int n in nums) {
            if (total < 0) {
                total = 0;
            }

            total += n;
            res = Math.Max(res, total);
        }

        return res;  
    }
}