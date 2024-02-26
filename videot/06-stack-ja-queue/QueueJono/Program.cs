Queue<string> reservations = new Queue<string>();

reservations.Enqueue("reader 1");
reservations.Enqueue("reader 2");
reservations.Enqueue("reader 3");

// r1, r2, r3

string next = reservations.Dequeue();
Console.WriteLine($"seuraava lukija: {next}");

Console.WriteLine($"jonossa seuraava: {reservations.Peek()}");

foreach (var item in reservations)
{
    Console.WriteLine(item);
}