public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        LinkedList<int> dq = new LinkedList<int>();
        List<int> res = new List<int>();
        
        for (int i = 0; i < nums.Length; i++) {
            if (dq.Count > 0 && dq.First.Value == i - k) {
                dq.RemoveFirst();
            }

            while (dq.Count > 0 && nums[dq.Last.Value] < nums[i]) {
                dq.RemoveLast();
            }

            dq.AddLast(i);
            if (i >= k - 1) {
                res.Add(nums[dq.First.Value]);
            }
        }

        return res.ToArray();
    }
}