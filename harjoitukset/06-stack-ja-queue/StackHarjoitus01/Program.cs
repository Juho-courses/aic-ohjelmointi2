string ReverseString(string orig)
{
    Stack<char> stack = new Stack<char>();

    foreach (char ch in orig)
    {
        stack.Push(ch);
    }

    return new string(stack.ToArray());
}

string[] words = { "word", "dog", "", "school" };
foreach (string word in words)
{
    Console.WriteLine($"\"{word}\" kaannettyna on {ReverseString(word)}");
}