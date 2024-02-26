List<int> ints = new List<int>();

ints.Add(12);
ints.Add(24);

// foreach (var item in ints)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine(ints[1]);
ints.Remove(12);
foreach (var item in ints)
{
    Console.WriteLine(item);
}
Console.WriteLine(ints.Contains(12));

Console.WriteLine(ints.Count);
Console.WriteLine(ints.Capacity);




List<Person> peeps = new List<Person>();

peeps.Add(new Person());
peeps.Add(new Person() { Name = "Etunimi" });

foreach (Person p in peeps)
{
    Console.WriteLine(p.Name);
}

// https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable?view=net-8.0
Console.WriteLine(peeps.Any(p => p.Name == "Juho"));