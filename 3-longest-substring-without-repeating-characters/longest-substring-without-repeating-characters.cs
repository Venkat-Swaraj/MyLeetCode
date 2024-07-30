public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
        int start = 0;
        Dictionary<char,int> map = new Dictionary<char,int>();


        for (int end = 0; end < s.Length; end++) {
            char c = s[end];
            if (map.ContainsKey(c) && map[c] >= start)
            {
                start = map[c] + 1;

            }
            else
            {
                maxLength = Math.Max(maxLength, end - start + 1);
            }
            map[c] = end;
        }
        return maxLength;
    }
}