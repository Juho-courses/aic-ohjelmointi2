class Opintojakso
{
    private string nimi;
    private int opintopisteet;

    public Opintojakso(string _nimi, int pinnat)
    {
        nimi = _nimi;
        opintopisteet = pinnat;
    }

    public void Print()
    {
        Console.WriteLine($"{nimi}: {opintopisteet} pistettä");
    }
}