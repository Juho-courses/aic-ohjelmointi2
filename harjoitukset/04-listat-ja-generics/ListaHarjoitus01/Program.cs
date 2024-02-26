void PrintList(List<int> l)
{
    if (l.Count == 0)
    {
        Console.WriteLine("Empty list");
        return;
    }
    foreach (var item in l)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

List<int> FindDuplicates(List<int> ilist)
{
    List<int> ret = new List<int>();

    List<int> found = new List<int>();

    foreach (int num in ilist)
    {
        if (!found.Contains(num))
        {
            found.Add(num);
        }
        else
        {
            if (!ret.Contains(num))
            {
                ret.Add(num);
            }
        }
    }

    return ret;
}

PrintList(FindDuplicates(new List<int>() { 1, 2, 3, 4, 4 }));
PrintList(FindDuplicates(new List<int>() { 1, 1, 2, 3, 4, 4, 2 }));
PrintList(FindDuplicates(new List<int>() { 1, 2, 3, 4, 4, 4 }));
PrintList(FindDuplicates(new List<int>() { 1 }));
PrintList(FindDuplicates(new List<int>() { 1, 1, 2, 1, 3, 4, 4, 2 }));