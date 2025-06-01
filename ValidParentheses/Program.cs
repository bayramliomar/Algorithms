IsValid3("[[]{{}()}]");
IsValid2("[[]{{}()}]");
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
    while (input.Length != limit)
    {
        limit = input.Length;
        input = input.Replace("()", "");
        input = input.Replace("[]", "");
        input = input.Replace("{}", "");
    }
    if (input.Length == 0) return true;
    else return false;
}

bool IsValid3(string s)
{
    // Stack to hold opening brackets
    Stack<char> stack = new Stack<char>();

    // Dictionary to map closing brackets to their respective opening brackets
    Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

    foreach (char c in s)
    {
        // If it's a closing bracket, check for a matching opening bracket
        if (bracketPairs.ContainsKey(c))
        {
            // Pop from the stack if it's not empty, otherwise use a dummy value
            char top = stack.Count > 0 ? stack.Pop() : '#';

            // If the top of the stack doesn't match the current closing bracket, return false
            if (top != bracketPairs[c])
                return false;
        }
        else
        {
            // Push opening brackets onto the stack
            stack.Push(c);
        }
    }

    // If the stack is empty, all brackets were matched; otherwise, return false
    return stack.Count == 0;
}