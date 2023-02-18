int[] result = MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
Console.ReadLine();
int[] MoveZeroes(int[] nums)
{
    int length = nums.Length - 1;
    int l = 0, r = 1;
    while (r <= length)
    {
        if (nums[l] == 0 && nums[r] != 0)
        {
            nums[l] = nums[r];
            nums[r] = 0;
            l++;
        }
        if (nums[l] != 0)
        {
            l++;
        }

        r++;
    }
    return nums;
}