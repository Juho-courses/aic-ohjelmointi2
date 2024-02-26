class Person
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Person(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
    public Person(string id, string name, string age)
    {
        Id = int.Parse(id);
        Name = name;
        Age = int.Parse(age);
    }

    public void Print()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Age: {Age}");
    }
}