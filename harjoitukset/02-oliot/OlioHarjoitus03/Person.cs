class Person
{
    public string FirstName { get; private set; }
    public int Age { get; private set; }
    public Address Address { get; private set; }

    public Person(string name, int age)
    {
        FirstName = name;
        Age = age;
        Address = new Address("tuntematon osoite", -1);
    }

    public void SetAddress(Address a)
    {
        Address = a;
    }

    public int MakeOlder()
    {
        Age++;
        return Age;
    }
}