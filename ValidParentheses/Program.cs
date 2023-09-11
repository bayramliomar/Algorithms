IsValid("([]{})");
Console.ReadLine();

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