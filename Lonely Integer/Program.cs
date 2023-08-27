LonelyInteger(new List<int> { 4, 9, 95, 93, 57, 4, 57, 93, 9 });
LonelyInteger(new List<int> { 1, 2, 3, 4, 3, 2, 1 });
Console.ReadLine();

/*Given an array of integers, where all elements but one occur twice, find the unique element.
Example: a=[1,2,3,4,3,2,1]
The unique element is 4
Function Description:
Complete the LonelyInteger function in the editor below.
LonelyInteger has the following parameter(s):
int a[n]: an array of integers
Returns:
int: the element that occurs only once

*/
static int LonelyInteger(List<int> a)
{
    Dictionary<int, int> result = new Dictionary<int, int>();
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] >= 1 && a[i] < 100)
        {
            if (!result.ContainsKey(a[i]))
                result.Add(a[i], 1);
            else
                result[a[i]]++;
        }
    }
    return result.Where(x=>x.Value==1).FirstOrDefault().Key;
}