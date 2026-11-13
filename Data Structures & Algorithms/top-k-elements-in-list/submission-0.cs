public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        foreach(int n in nums) {
            freq[n] = freq.GetValueOrDefault(n) + 1;
        }

        int numberOfBuckets = nums.Length + 1;
        List<int>[] buckets = new List<int>[numberOfBuckets];
        for(int i = 1; i < numberOfBuckets; i++) {
            buckets[i] = new List<int>();
        }

        foreach(var (n, f) in freq) {
            buckets[f].Add(n);
        }

        var result = new int[k];
        int curr = 0;
        for(int i = numberOfBuckets - 1; i >= 0 && curr < k; i--) {
            foreach(int n in buckets[i]) {
                result[curr++] = n;
                if(curr == k) break;
            }
        }

        return result;
    }
}
