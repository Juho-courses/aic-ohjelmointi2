class Car
{
    // ominaisuudet
    public string Valmistaja { get; private set; }
    public int AjetutKilsat { get; private set; }

    // konstruktori
    public Car(string valmistaja)
    {
        Valmistaja = valmistaja;
        AjetutKilsat = 0;
    }

    // metodit
    public void Drive(int matka)
    {
        AjetutKilsat += matka;
    }
}