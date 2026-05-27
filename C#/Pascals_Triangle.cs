public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> triangle = new List<IList<int>>();

        for (int i = 0; i < numRows; i++) {
            List<int> row = new List<int>();

            for (int k = 0; k <= i; k++) {
                if (k == 0 || k == i) {
                    row.Add(1);
                }
                else {
                    row.Add(triangle[i-1][k-1] + triangle[i-1][k]);
                }
            }

            triangle.Add(row);
        }

        return triangle;
    }
}