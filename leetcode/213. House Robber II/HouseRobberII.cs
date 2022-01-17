public class Solution {
    public int Rob(int[] nums) {
        int l = nums.Length;
        if(l == 0){
            return 0;
        } else if(l == 1){
            return nums[0];
        }
        // can't steal the 1st and the last at the same time
        // steal[0, l - 1] or steal [1, l]
        return Math.Max(RobRange(nums, 0, l - 1), RobRange(nums, 1, l));
    }

    public int RobRange(int[] nums, int start, int end){
        // same as Q198
        int pre1 = 0, pre2 = 0;
        int ans = 0;
        for(int i = start; i < end; ++ i){
            ans = Math.Max(nums[i] + pre2, pre1);
            pre2 = pre1;
            pre1 = ans;
        }
        return ans;
    }
}