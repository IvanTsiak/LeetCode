public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        Array.Sort(boxTypes, (a, b) => b[1].CompareTo(a[1]));
        int result = 0;
        foreach(int[] boxType in boxTypes) {
            if (truckSize <= 0) {
                break;
            }
            int howMany = Math.Min(truckSize, boxType[0]);
            result += howMany * boxType[1];
            truckSize -= howMany;
        }

        return result;
    }
}