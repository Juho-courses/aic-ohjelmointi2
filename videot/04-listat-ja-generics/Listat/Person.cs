class Person
{
    public string Name { get; set; } = "Ei tiedossa";
    public int Age { get; set; } = -1;
    public void Print()
    {
        Console.WriteLine($"{Name} {Age}");
    }
}