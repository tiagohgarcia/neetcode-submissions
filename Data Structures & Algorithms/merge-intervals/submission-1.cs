public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> result = new List<int[]>();
        result.Add(intervals[0]);
        int current = 0;    // which row we are comparing with

        for(int i = 1; i < intervals.Length; i++) {
            if(result[current][0] <= intervals[i][0] 
                && intervals[i][0] <= result[current][1]) 
            { // it overlaps
                result[current][1] = Math.Max(result[current][1], intervals[i][1]); // extend the current interval
            }
            else
            {
                // create a new interval
                current++;
                result.Add(intervals[i]);            
            }
        }

        return result.ToArray();
    }
}
