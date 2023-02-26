Console.WriteLine(FirstRecurringCharacter(new int[] {2,5,1,2,3,5,1,2,4}));
Console.WriteLine(FirstRecurringCharacter(new int[] {2,5,5,2,3,5,1,2,4}));
Console.WriteLine(FirstRecurringCharacter(new int[] {2,1,1,2,3,5,1,2,4}));
Console.WriteLine(FirstRecurringCharacter(new int[] {2,3,4,5}));
/*-------------------------------------------------------------------*/
Console.WriteLine(FirstRecurringCharacter2(new int[] { 2, 5, 1, 2, 3, 5, 1, 2, 4 }));
Console.WriteLine(FirstRecurringCharacter2(new int[] { 2, 5, 5, 2, 3, 5, 1, 2, 4 }));
Console.WriteLine(FirstRecurringCharacter2(new int[] { 2, 5, 3, 5, 2, 5, 1, 2, 4 }));
Console.WriteLine(FirstRecurringCharacter2(new int[] { 2, 1, 1, 2, 3, 5, 1, 2, 4 }));
Console.WriteLine(FirstRecurringCharacter2(new int[] { 2, 3, 4, 5 }));
Console.ReadLine();

/*Time complexity:O(n), Space complexity:O(n)*/
int FirstRecurringCharacter(int[] arr)
{
	HashSet<int> result = new HashSet<int>();
	for (int i = 0; i < arr.Length; i++)
	{
		if (!result.Add(arr[i]))
		{
			return arr[i];
		}
	}
	return -1;
}

/*Time complexity:O(n), Space complexity:O(n)*/
int FirstRecurringCharacter2(int[] arr)
{
    Dictionary<int,int> result = new Dictionary<int, int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (result.ContainsKey(arr[i]))
        {
            return arr[i];
        }
        result.Add(arr[i], i);
    }
    return -1;
}