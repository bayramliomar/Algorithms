Console.WriteLine(Reverse("Hi my name is"));
Console.WriteLine(Reverse2("Hi my name is"));
Console.ReadLine();

//brute force solution
//time complexity-O(n), space complexity-O(n)
static string Reverse(string str)
{
    if (str.Length > 0)
    {
        string reverseStr = "";
        char[] charArray = str.ToCharArray();
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            reverseStr += charArray[i];
        }
        return reverseStr;
    }
    return "";
}

//Two Pointers
//time complexity-O(n), space complexity-O(1)
static string Reverse2(string str)
{
    if (str.Length > 0)
    {
        char temp = ' ';
        char[] reverseArray = new char[str.Length];
        char[] charArray = str.ToCharArray();
        for (int i = 0, j = charArray.Length - 1; i < charArray.Length && j >= 0; i++, j--)
        {
            temp = charArray[j];
            reverseArray[j] = charArray[i];
            reverseArray[i] = temp;
        }
        String reverseStr = new String(reverseArray);
        return reverseStr;
    }
    return "";
}