class Person
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string City { get; private set; }

    public Person(int id, string name, int age, string _city)
    {
        Id = id;
        Name = name;
        Age = age;
        City = _city;
    }

    public void Print()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}, City: {City}");
    }
}