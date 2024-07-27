public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> hashMap = new Dictionary<int,int>();
        int i = 0;
        int difference = 0;
        while(i < nums.Length)
        {
            difference = target - nums[i];
            if(hashMap.ContainsKey(difference))
            {
                return new int[] { hashMap[difference] ,i};
            }
            else
            {
                hashMap[nums[i]] = i;
            }
            i++;
        }
        return new int[] { };
    }
}