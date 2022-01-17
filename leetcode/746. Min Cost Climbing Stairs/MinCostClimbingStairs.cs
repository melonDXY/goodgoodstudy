public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        //看做第70题，但是每一阶楼梯本身存在权重（增加了cost[n]种从平行世界跨到这里的方法）
        // f(n) = min(f(n-1) + cost[n-1], f(n-2) + cost[n-2])
        int l = cost.Length;
        int cur = 0;
        //跨上第1和第0阶阶梯不需要花费。
        int pre1 = 0, pre2 = 0;
        for(int i = 2; i <= l; ++ i){
            cur = Math.Min(pre1 + cost[i - 1], pre2 + cost[i - 2]);
            pre2 = pre1;
            pre1 = cur;
        }
        return cur;
    }
}