// 1, Matti
// 2, Ville

Dictionary<int, string> users = new Dictionary<int, string>();

users.Add(1, "Matti");
users.Add(2, "Ville");

Console.WriteLine(users[1]);

users[2] = "Kalle";
users.Remove(1);

foreach (KeyValuePair<int, string> item in users)
{
    Console.WriteLine($"id {item.Key}: {item.Value}");
}


if (users.ContainsKey(1))
{
    Console.WriteLine(users[1]);
}