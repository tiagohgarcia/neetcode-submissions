public class Solution {
    public bool hasDuplicate(int[] nums) {
        var singles = new HashSet<int>();

        foreach(int num in nums) {
            if(singles.Contains(num)) return true;
            singles.Add(num);
        }

        return false;
    }
}