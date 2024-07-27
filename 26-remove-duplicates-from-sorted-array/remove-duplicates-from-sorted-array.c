int removeDuplicates(int* nums, int numsSize) {
    int l =1;
    for(int r =1; r<numsSize;r++)
    {
        if(nums[r]!=nums[r-1])
        {
            nums[l++] =nums[r];
        }
    }
    return l;
}