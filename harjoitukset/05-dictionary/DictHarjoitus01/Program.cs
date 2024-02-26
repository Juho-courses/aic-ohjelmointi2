void PrintList(List<int> lista)
{
    foreach (var item in lista)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

void PrintDict(Dictionary<int, int> dicti)
{
    foreach (KeyValuePair<int, int> pair in dicti)
    {
        Console.Write($"({pair.Key}: {pair.Value}) ");
    }
    Console.WriteLine();
}

Dictionary<int, int> CalculateOccurances(List<int> ints)
{
    Dictionary<int, int> occurances = new Dictionary<int, int>();

    foreach (var number in ints)
    {
        if (occurances.ContainsKey(number))
        {
            int old = occurances[number];
            occurances[number] = old + 1;
        }
        else
        {
            occurances.Add(number, 1);
        }
    }

    return occurances;
}

List<List<int>> tests = [
    [1,2,3,4],
    [1,2,3],
    [1,2,3, 1],
    [],
    [123],
    [123, 123, 123, 123, 123, 123],
];

foreach (var test in tests)
{
    Console.WriteLine("----");
    Console.Write("Testing: ");
    PrintList(test);
    Console.Write("Result: ");
    PrintDict(CalculateOccurances(test));
}