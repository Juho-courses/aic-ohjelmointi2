Queue<string> jobs = new Queue<string>();
string job_in_progress = null;

void Start()
{
    Console.WriteLine("--- Tulostinsimulaattori ---");

    string operation;
    while (true)
    {
        operation = Menu();

        // 1 lisää
        // 2 aloita
        // 3 peruuta
        // 4 tarkastele jonoa
        if (operation.ToUpper() == "Q")
        {
            break;
        }
        else if (operation == "1")
        {
            AddJob();
        }
        else if (operation == "2")
        {
            ProcessNextJob();
        }
        else if (operation == "3")
        {
            CancelJob();
        }
        else if (operation == "4")
        {
            PrintQueue();
        }
        else
        {
            Console.WriteLine("Epäkelpo valinta.");
        }
        Console.WriteLine();
    }
}

void CancelJob()
{
    if (job_in_progress == null)
    {
        Console.WriteLine("Ei keskeneräistä työtä.");
        return;
    }

    Console.WriteLine($"Peruutetaan työ \"{job_in_progress}\".");
    job_in_progress = null;
}

void ProcessNextJob()
{
    if (job_in_progress != null)
    {
        Console.WriteLine($"Työ \"{job_in_progress}\" valmis.");
        job_in_progress = null;
    }

    if (jobs.Count == 0)
    {
        Console.WriteLine("Jono tyhjä.");
        return;
    }

    job_in_progress = jobs.Dequeue();
    Console.WriteLine($"Aloitettu työ \"{job_in_progress}\".");
}

void AddJob()
{
    Console.Write("Lisää työ: ");
    string job = Console.ReadLine();
    jobs.Enqueue(job);
    Console.WriteLine($"Työ \"{job}\" lisätty.");
}

void PrintQueue()
{
    if (job_in_progress != null)
    {
        Console.WriteLine($"Työ \"{job_in_progress}\" kesken.");
    }
    Console.WriteLine();
    if (jobs.Count == 0)
    {
        Console.WriteLine("Jono tyhjä.");
        return;
    }
    Console.WriteLine("Jono:");
    foreach (var item in jobs)
    {
        Console.WriteLine($"  - {item}");
    }
}

string Menu()
{
    Console.WriteLine("Mahdolliset operaatiot:");
    Console.WriteLine("  1) Lisää työ");
    Console.WriteLine("  2) Aloita työ");
    Console.WriteLine("  3) Peruuta työ");
    Console.WriteLine("  4) Tarkastele jonoa");
    Console.WriteLine("  Q) Lopeta");
    Console.Write("Valinta: ");
    string input = Console.ReadLine();
    return input;
}

Start();