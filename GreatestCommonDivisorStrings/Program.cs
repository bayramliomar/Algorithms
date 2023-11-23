Console.WriteLine(GcdOfStrings("ABA", "ABAABA"));
Console.WriteLine(GcdOfStrings("ABAABA", "ABA"));
Console.WriteLine(GcdOfStrings("ABABAB", "ABAB"));

Console.ReadLine();

 string GcdOfStrings(string str1, string str2)
{
    if (str1 + str2 == str2 + str1)
    {
        return str1.Length > str2.Length ?
            str1.Substring(0, GCD(str1.Length, str2.Length)) :
            str2.Substring(0, GCD(str2.Length, str1.Length));
    }

    return "";
}

 int GCD(int a, int b)
{
    if (b == 0)
        return a;
    return GCD(b, a % b);
}

int GCD2(int n1, int n2)
{
    while (n1 != 0 && n2 != 0)
    {
        if (n1 > n2)
        {
            n1 %= n2;
        }
        else
        {
            n2 %= n1;
        }
    }

    return n1 | n2;
}

string GcdOfStrings2(string str1, string str2)
{
    if (str1 + str2 != str2 + str1)
    {
        return "";
    }

    int gcdLen = GCD(str1.Length, str2.Length);
    return str1.Substring(0, gcdLen);
}