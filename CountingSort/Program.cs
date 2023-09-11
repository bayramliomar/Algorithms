

countingSort(new List<int> { 63, 25, 73, 1, 98, 73, 56, 84, 86, 57, 16, 83, 8, 25, 81, 56, 9, 53, 98, 67, 99, 12, 83, 89, 80, 91, 39, 86, 76, 85, 74, 39, 25, 90, 59, 10, 94, 32, 44, 3, 89, 30, 27, 79, 46, 96, 27, 32, 18, 21, 92, 69, 81, 40, 40, 34, 68, 78, 24, 87, 42, 69, 23, 41, 78, 22, 6, 90, 99, 89, 50, 30, 20, 1, 43, 3, 70, 95, 33, 46, 44, 9, 69, 48, 33, 60, 65, 16, 82, 67, 61, 32, 21, 79, 75, 75, 13, 87, 70, 33 });

Console.ReadLine();
static List<int> countingSort(List<int> arr)
{
    int elementCount = 100;
    int[] emptyArr = new int[elementCount];
    if (arr.Count >= 100 && arr.Count <= 1000000)
    {
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] >= 0 && arr[i] < 100)
            {
                emptyArr[arr[i]] += 1;
            }
        }
    }
    return emptyArr.ToList();
}
