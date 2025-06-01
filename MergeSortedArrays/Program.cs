Merge1(new int[] { 1, 3, 5 }, 3, new int[] { 2, 3, 4 }, 3);
Merge2(new int[] { 1, 3, 5, 0, 0, 0 }, 3, new int[] { 1, 4, 8 }, 3);
MergeSortedArrays(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 });
Console.ReadLine();

static void Merge1(int[] nums1, int m, int[] nums2, int n)
{
    int[] temp = new int[m + n];
    int k = 0;
    if (m >= 0 && n <= 200 && m + n >= 1 && m + n <= 200)
    {
        int i = 0, j = 0;
        while (i < m && j < n)
        {
            Console.WriteLine(nums1[i] + " " + nums2[j]);
            if (nums2[j] > nums1[i])
            {
                temp[k++] = nums1[i++];
            }
            else
            {
                temp[k++] = nums2[j++];
            }

        }
        while (j < n)
        {
            temp[k++] = nums2[j++];
        }
        while (i < m)
        {
            temp[k++] = nums1[i++];
        }
        Console.WriteLine(temp);
        nums1 = temp;
    }


}

static void Merge2(int[] nums1, int m, int[] nums2, int n)
{
    int k = nums1.Length - 1;
    if (m >= 0 && n <= 200 && m + n >= 1 && m + n <= 200)
    {
        m--;
        n--;
        while (m >= 0 && n >= 0)
        {
            Console.WriteLine(nums1[m] + " " + nums2[n]);
            if (nums2[n] > nums1[m])
            {
                nums1[k--] = nums2[n--];
            }
            else
            {
                nums1[k--] = nums1[m--];
            }

        }
        while (m >= 0)
        {
            nums1[k--] = nums1[m--];
        }
        while (n >= 0)
        {
            nums1[k--] = nums2[n--];
        }
        Console.WriteLine(nums1);
    }

}

int[] MergeSortedArrays(int[] nums1, int[] nums2)
{
    int[] result = new int[nums1.Length + nums2.Length];
    int i = 0, j = 0, k = 0;

    while (i < nums1.Length && j < nums2.Length)
    {
        if (nums1[i] <= nums2[j]) result[k++] = nums1[i++];
        else result[k++] = nums2[j++];
    }

    while (i < nums1.Length) result[k++] = nums1[i++];
    while (j < nums2.Length) result[k++] = nums2[j++];

    return result;
}