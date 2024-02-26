Stack<string> names = new Stack<string>();

names.Push("Matti");
names.Push("Ville");
names.Push("Viivi");

string viimeisin = names.Pop();
Console.WriteLine($"viimeisin: {viimeisin}");

Console.WriteLine($"seuraavaksi: {names.Peek()}");
names.Pop();
names.Pop();

if (names.Count > 0)
{
    names.Pop();
}


foreach (var item in names)
{
    Console.WriteLine(item);
}