using System.Text;

string result=MergeAlternately("abc", "pqrli");
string result2=MergeAlternately2("abc", "pqrli");



Console.ReadLine();


string MergeAlternately(string word1, string word2)
{
	StringBuilder mergedString = new();
	int w1length=word1.Length-1;
	int w2length=word2.Length-1;
	int i=0,j = 0;
	while(i<=w1length && j<=w2length)
	{
		mergedString.Append(word1[i++]);
		mergedString.Append(word2[j++]);
	}
	while(i <= w1length)
	{
        mergedString.Append(word1[i++]);
    }
    while (j <= w2length)
    {
        mergedString.Append(word2[j++]);
    }
    return mergedString.ToString();
}

string MergeAlternately2(string word1, string word2)
{
    var len = word1.Length + word2.Length;

    var sb = new StringBuilder(len);

    var en1 = word1.GetEnumerator();
    var en2 = word2.GetEnumerator();

    while (sb.Length < len)
    {
        if (en1.MoveNext()) sb.Append(en1.Current);
        if (en2.MoveNext()) sb.Append(en2.Current);
    }

    return sb.ToString();
}