DivisibleSumPairs(6, 5, new List<int>() { 1, 2, 3,4, 5, 6 });



Console.ReadLine();

static int DivisibleSumPairs(int n, int k, List<int> ar)
{
    int length=ar.Count;
    int pairs = 0;
    Dictionary<int,int> map = new();
    for (int i = 0; i < length; i++)
    {
        int mod = ar[i] % k;
        int com = k - mod==k?0:k-mod;

        if(map.ContainsKey(com))
            pairs+=map[com];
        if (map.ContainsKey(mod))
            map[mod] = map[mod] + 1;
        if (!map.ContainsKey(mod))
            map.Add(mod, 1);
    }
    return pairs;
}