public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var positions = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            int wanted = target - nums[i];
            if(positions.TryGetValue(wanted, out int j)) 
                return [j, i];

            positions.Add(nums[i], i);
        }

        return [];
    }
}
