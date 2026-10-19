public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var positions = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            int wanted = target - nums[i];
            if(positions.ContainsKey(wanted)) return [positions[wanted], i];

            positions.Add(nums[i], i);
        }

        return [];
    }
}
