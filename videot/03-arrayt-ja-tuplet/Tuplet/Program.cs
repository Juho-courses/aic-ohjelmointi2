(string Name, int Age) person = ("Masa", 32);
Console.WriteLine(person.Name);

(string Name, int Age)[] t_arr = new (string, int)[10];
t_arr[0] = person;

foreach (var p in t_arr)
{
    if (p.Name != null)
    {
        Console.WriteLine(p.Name);
    }
}