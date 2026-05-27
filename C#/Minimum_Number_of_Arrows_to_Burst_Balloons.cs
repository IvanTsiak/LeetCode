public class Solution {
    public int FindMinArrowShots(int[][] points) {
        Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));
        int arrows = 0;
        int lastNum = 0;
        for (int i = 0; i < points.Length; i++) {
            int currEnd = points[i][1];
            if (i == 0) {
                lastNum = currEnd;
                arrows++;
            }
            
            if (points[i][0] <= lastNum) {
                lastNum = Math.Min(lastNum, currEnd);
                continue;
            }
            lastNum = currEnd;
            arrows++;
        }

        return arrows;
    }
}