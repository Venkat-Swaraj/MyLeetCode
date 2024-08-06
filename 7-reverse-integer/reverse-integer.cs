public class Solution {
    public int Reverse(int x) {
        int reversed = 0;
        while (x != 0)
        {
            try
            {
                checked
                {
                    reversed = reversed * 10 + (x % 10);
                }
                x = x / 10;
            }
            catch (OverflowException ex) 
            {
                return 0;
            }
            
        }
        return reversed;
    }
}