string path = "data.csv";

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
        Console.WriteLine(line);

        string[] pieces = line.Split(",");

        Person person = new Person(int.Parse(pieces[0]), pieces[1], int.Parse(pieces[2]));
        // Person person = new Person(pieces[0], pieces[1], pieces[2]);
        person.Print();
    }
}
