class Solution {
    public void moveZeroes(int[] nums) {
        int j = 1;
        for (int i = 0; i < nums.length && j <nums.length;)
        {
            if (nums[i] == 0)
            {
                if (nums[j] != 0)
                {
                    nums[i] = nums[j];
                    nums[j] = 0;
                }
                else
                {
                    j++;
                }
            }
            else {
                i++; j++;
            }
            
        }
    }
}