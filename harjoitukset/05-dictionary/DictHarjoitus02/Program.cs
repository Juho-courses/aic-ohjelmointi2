Dictionary<int, Person> ReadPeople(string path)
{
    Dictionary<int, Person> people = new Dictionary<int, Person>();

    using (StreamReader reader = new StreamReader(path))
    {
        string line;
        bool header_skipped = false;

        while ((line = reader.ReadLine()) != null)
        {
            if (!header_skipped)
            {
                header_skipped = true;
                continue;
            }

            string[] pieces = line.Split(",");
            int id = int.Parse(pieces[0]);

            Person person = new Person(id, pieces[1], int.Parse(pieces[2]), pieces[3]);
            people.Add(id, person);
        }
    }
    return people;
}

Dictionary<int, Person> people = ReadPeople("people.csv");

while (true)
{
    Console.WriteLine("-- Järjestelmä tuntee seuraavat henkilöt, kenestä haluat lisätietoja?");
    foreach (var person in people)
    {
        Console.WriteLine($"{person.Value.Name} (valitse {person.Key})");
    }

    Console.Write("Valintasi (Q lopettaa): ");
    string selection = Console.ReadLine();

    if (selection == "Q")
    {
        Console.WriteLine("Näkemiin!");
        break;
    }

    int id;
    try
    {
        id = int.Parse(selection);
    }
    catch
    {
        Console.WriteLine("!! Virheellinen syöte.");
        continue;
    }

    if (people.ContainsKey(id))
    {
        Console.WriteLine("Lisätietoja:");
        Console.Write("\t");
        people[id].Print();
    }
    else
    {
        Console.WriteLine("!! Tuntematon id.");
        continue;
    }

}