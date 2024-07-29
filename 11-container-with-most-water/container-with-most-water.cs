public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int start = 0;
        int end = height.Length - 1;
        while(start < end)
        {
            maxArea = Math.Max(maxArea, (end - start) * Math.Min(height[start],height[end]));
            if (height[start] > height[end])
            {
                end--;
            }
            else { 
                start++;
            }
        }
        return maxArea;
    }
}