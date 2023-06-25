using System.Globalization;

Generate(17);

IList<IList<int>> Generate(int numRows)
{
    List<int[]> nums = new List<int[]>();
    for (int i = 0; i < numRows; i++)
    {
        int[] num = new int[i + 1];
        num[0] = 1;
        num[i] = 1;
        for (int j = 1; j < i; j++)
        {
            num[j] = nums[i - 1].ToArray()[j - 1] + nums[i - 1].ToArray()[j];
        }
        nums.Add(num);
    }

    return nums.ToArray();
}