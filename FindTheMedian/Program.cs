FindMedian(new List<int>() { 5,3,1,2,4});


Console.ReadLine();

static int FindMedian(List<int> arr)
{
    int length=arr.Count;
    arr.Sort();
    return arr[length/2];
}
