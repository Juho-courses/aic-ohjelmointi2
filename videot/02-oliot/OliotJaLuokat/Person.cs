class Person
{
    public string Name { get; private set; } = "asd";

    public Person(string _name)
    {
        Name = _name;
    }

    public Person()
    {
        Name = "ei tiedossa";
    }
    public void Greet()
    {
        Console.WriteLine($"Hi, I'm {Name}");
    }
}