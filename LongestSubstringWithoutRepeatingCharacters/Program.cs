Console.WriteLine(LengthOfLongestSubstring("dvspaghdf"));
Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
Console.WriteLine(LengthOfLongestSubstring("dvdf"));
Console.WriteLine(LengthOfLongestSubstring("aab"));
Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
Console.WriteLine(LengthOfLongestSubstring(""));
Console.WriteLine(LengthOfLongestSubstring(" "));

Console.ReadLine();

int LengthOfLongestSubstring(string s)
{
    if (s.Length <= 50000 && s.Length > 0)
    {
        int i = 0, j = 0, max = 0;
        HashSet<char> set = new HashSet<char>();
        while (i < s.Length)
        {
            if (set.Add(s[i]))
            {
                i++;
            }
            else
            {
                max = Math.Max(max, set.Count);
                set.Remove(s[j]);
                j++;
            }
        }
        max = Math.Max(max, set.Count);
        return max;
    }
    return 0;
}