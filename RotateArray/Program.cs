Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 4);
Rotate2(new int[] { -1 }, 2);
Rotate2(new int[] { 1, 2, 3, 5,7 }, 2);
Rotate2(new int[] { 1, 2, 3, 5,7 }, 3);
Rotate2(new int[] { 1, 2, 3, 5,7,8 }, 2);
Rotate2(new int[] { 1, 2, 3, 5,7,8 }, 3);
Console.ReadLine();

/*
 * Time complexity:O(n+m)
 * Space complexity:O(n)
 */
static int[] Rotate(int[] nums, int k)
{
    int[] result = new int[nums.Length];
    int count = 0;
    for (int i = nums.Length-k; i < nums.Length; i++)
    {
        result[count++] = nums[i];
    }
    for (int i = 0; i < nums.Length - k; i++)
    {
        result[k + i] = nums[i];
    }
    nums = result;
    return nums;
}
/*
 * Best Solution
 * Time complexity:O(n)
 * Space complexity:O(1)
 */
static int[] Rotate2(int[] nums, int k)
{
    int length = nums.Length;
    k%= length;
    leftRotate(0, length - 1,nums);
    leftRotate(0, k - 1, nums);
    leftRotate(k, length - 1, nums);
    return nums;
}
static void leftRotate(int leftPointer,int rightPointer, int[] arr)
{
    for (int i = leftPointer, j = rightPointer; i < j && j > 0; i++, j--)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
