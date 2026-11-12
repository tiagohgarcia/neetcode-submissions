public class Solution {
    public int Search(int[] nums, int target) {
        int min = 0;
        int max = nums.Length - 1;

        while(min <= max) {
            int middle = min + (max - min) / 2;

            if(nums[middle] > target) max = middle - 1;
            else if(nums[middle] < target) min = middle + 1;
            else return middle; 
        }

        return -1;
    }
}
