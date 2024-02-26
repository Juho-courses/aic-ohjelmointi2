class Address
{
    // ominaisuudet
    public string StreetName { get; private set; }
    public int Number { get; private set; }

    // konstruktori
    public Address(string _name, int _number)
    {
        StreetName = _name;
        Number = _number;
    }

    // metodit
    public void ChangeAddress(string name, int number)
    {
        StreetName = name;
        Number = number;
    }
    public void Print()
    {
        // ”katu, tonttinumero”
        Console.WriteLine(StreetName + ", " + Number);
    }
}