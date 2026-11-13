public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var pq = new PriorityQueue<int, int>();
        foreach(int n in nums) {
            pq.Enqueue(n, n);
        }

        int result = 0;
        for(int i = 0; i <= nums.Length - k; i++) {
            result = pq.Dequeue();
        }

        return result;
    }
}
