public class Solution {
    public int Rob(int[] nums) {
        // n = 1: nums[0]
        // n = 2: max(nums[0], nums[1])
        // n > 2: f(n) = Math.Max(nums[n] + f(n - 2), f(n - 1))
        int l = nums.Length;
        if(l == 0){
            return 0;
        } else if (l == 1){
            return nums[0];
        }
        int[] dp = new int[l];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);
        for(int i = 2; i < l; ++ i){
            dp[i] = Math.Max(nums[i] + dp[i - 2], dp[i - 1]);
        }
        return dp[l - 1];

    }
}