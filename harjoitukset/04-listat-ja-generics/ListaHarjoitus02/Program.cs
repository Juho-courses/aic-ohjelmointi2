List<Opintojakso> opintojaksot = new List<Opintojakso>();

Console.WriteLine("-- Tallenna opintojaksoja --");
while (true)
{
    Console.WriteLine("----");
    Console.WriteLine("Mitä teet:");
    Console.WriteLine("1) Tallenna uusi opintojakso");
    Console.WriteLine("Q) Lopeta");
    Console.Write("Valinta: ");

    string valinta = Console.ReadLine();

    if (valinta == "Q")
    {
        break;
    }
    else if (valinta == "1")
    {
        Console.Write("Opintojakson nimi: ");
        string nimi = Console.ReadLine();
        Console.Write("Opintopistemäärä: ");
        int pisteet = int.Parse(Console.ReadLine());
        opintojaksot.Add(new Opintojakso(nimi, pisteet));
        Console.WriteLine("Tallenettu!");
    }

}

if (opintojaksot.Count > 0)
{
    Console.WriteLine("Opintojaksot:");
    foreach (Opintojakso opintojakso in opintojaksot)
    {
        Console.Write("- ");
        opintojakso.Print();
    }
}
else
{
    Console.WriteLine("Ei opintojaksoja!");
}


