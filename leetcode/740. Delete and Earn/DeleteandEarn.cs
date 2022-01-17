public class Solution {
    // same as the Q198, can steal the two adjacent houses,and the treasure 
    // each house holds should be count by yourself. 
    public int DeleteAndEarn(int[] nums) {
        int maxVal = 0;
        foreach(int val in nums){
            maxVal = Math.Max(maxVal, val);
        }
        int[] vals = new int[maxVal + 1];
        foreach(int val in nums){
            vals[val] += val;
        }
        return Rob(vals);
    }

    public int Rob(int[] nums){
        int l = nums.Length;
        if(l == 1){
            return nums[0];
        }
        int pre1 = 0, pre2 = 0;
        int cur = 0;
        for(int i = 0; i < l; ++ i){
            cur = Math.Max(nums[i] + pre2, pre1);
            pre2 = pre1;
            pre1 = cur;
        }
        return cur;

    }
}