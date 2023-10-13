CountingValleys(12, "DDUUDDUDUUUD");
CountingValleys2(12, "DDUUDDUDUUUD");


Console.ReadLine();

#region Solution 1 :Time complexity: O(n), Space complexity: O(n)

static int CountingValleys(int steps, string path)
{
    int valleyCount = 0;
    Stack<char> stack = new();
    for (int i = 0; i < steps; i++)
    {
        char ch = path[i];
        if (ch == 'D' && stack.Count != 0 && (char)stack.Peek() == 'U')
        {
            stack.Pop();
        }
        else if (ch == 'U' && stack.Count != 0 && (char)stack.Peek() == 'D')
        {
            stack.Pop();
            if (stack.Count == 0) valleyCount++;
        }
        else
        {
            stack.Push(ch);
        }
    }
    return valleyCount;
}

#endregion Solution 1 is finished

#region Solution 2 :Time complexity: O(n), Space complexity: O(1)

static int CountingValleys2(int steps, string path)
{
    int valleyCount = 0,altitude=0;
    for (int i = 0; i < steps; i++)
    {
        char ch = path[i];
        if (ch == 'U')
        {
            altitude++;
            if (altitude == 0) valleyCount++;
        }
        else altitude--;
    }
    return valleyCount;
}

#endregion Solution 2 is finished