Console.WriteLine(FirstUniqueCharacter("aaabbb"));
Console.WriteLine(FirstUniqueCharacter("loveleetcode"));
Console.WriteLine(FirstUniqueCharacter("leetcode"));
Console.WriteLine(FirstUniqueCharacter2("aaabbb"));
Console.WriteLine(FirstUniqueCharacter2("loveleetcode"));
Console.WriteLine(FirstUniqueCharacter2("leetcode"));
Console.WriteLine(FirstUniqueCharacter3("aaabbb"));
Console.WriteLine(FirstUniqueCharacter3("loveleetcode"));
Console.WriteLine(FirstUniqueCharacter3("leetcode"));
Console.ReadLine();


int FirstUniqueCharacter(string input)
{
    Dictionary<int, int[]> result = new Dictionary<int, int[]>();
    char[] chars = input.ToCharArray();
    for (int i = 0; i < chars.Length; i++)
    {
        char c = chars[i];
        int[] arr = new int[2] {i,0};
        if (!result.ContainsKey(c))
        {
            result.Add(c, arr);
        }
        else
        {
            result[c][1] +=1;
        }
    }
    var firstUniqueKey = result.FirstOrDefault(v => v.Value[1] == 0);
    if (firstUniqueKey.Value != null) return firstUniqueKey.Value[0];
    return -1;
}

//Litte bit better(time) than FirstUniqueCharacter method
//Time complexity=O(n),Space complexity=O(n)
int FirstUniqueCharacter2(string input)
{
    Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();
    for (int i = 0; i < input.Length; i++)
    {
        char c = input[i];
        if (!result.ContainsKey(c))
        {
            result.Add(c, new List<int>(new int[] {i}));
        }
        else
        {
            result[c].Add(1);
        }
    }
    for (int i = 0; i < input.Length; i++)
    {
        char c = input[i];
        var current = result[c];
        if (current.Count==1)
        {
            return current[0];
        }
    }
    return -1;
}
//Time complexity=O(n),Space complexity=O(1)
int FirstUniqueCharacter3(string input)
{
    var cMap = new int[26]; // nint why not, would totally make it unsafe for stackalloc and speed if leetcode allowed it
    foreach (var c in input)
    {
        cMap[c - 'a']++;
    }

    for (var i = 0; i < input.Length; i++)
    {
        var c = input[i];
        if (cMap[c - 'a'] == 1)
            return i;
    }

    return -1;
}