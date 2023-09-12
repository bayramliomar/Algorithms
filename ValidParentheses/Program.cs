IsValid2("([}{})");
Console.ReadLine();

//Initial Solution
bool IsValid(string input)
{
    Stack<char> stack = new();
    int length = input.Length;
    for (int i = 0; i < length; i++)
    {
        char c = input[i];
        if (input[i] == '(' || input[i] == '[' || input[i] == '{')
            stack.Push(c);
        else if (c == ')' && stack.Count != 0 && (char)stack.Peek() == '(')
            stack.Pop();

        else if (c == '}' && stack.Count != 0 && (char)stack.Peek() == '{')
            stack.Pop();

        else if (c == ']' && stack.Count != 0 && (char)stack.Peek() == '[')
            stack.Pop();

        else
            return false; // no match

    }
    return true;
}

///Accepted Solution
bool IsValid2(string input)
{
    int limit = -1;
    while (input.Length!= limit)
    {
        limit = input.Length;
        input=input.Replace("()", "");
        input=input.Replace("[]", "");
        input=input.Replace("{}", "");
    }
    if (input.Length == 0) return true;
    else return false;
}