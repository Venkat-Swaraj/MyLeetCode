public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int buy = 0;
        for (int sell = 1; sell < prices.Length; sell++) 
        {
            if (prices[buy] > prices[sell])
            {
                buy = sell;
            }
            else
            {
                max = (int)MathF.Max(max, prices[sell] - prices[buy]);
            }
        }
        return max;
    }
}