bool IsValid(string s)
{
    Stack<char> stack = new Stack<char>();

    for (int i = 0; i < s.Length; i++)
    {
        char c = s[i];

        if (c == '(' || c == '{' || c == '[')
        {
            stack.Push(c);
        }
        else if (c == ')' && stack.Count > 0 && stack.Peek() == '(')
        {
            stack.Pop();
        }
        else if (c == '}' && stack.Count > 0 && stack.Peek() == '{')
        {
            stack.Pop();
        }
        else if (c == ']' && stack.Count > 0 && stack.Peek() == '[')
        {
            stack.Pop();
        }
        else
        {
            return false;
        }
    }

    return stack.Count == 0;
}

string input = "()";// change & try other inputs


bool result = IsValid(input);


Console.WriteLine(result);