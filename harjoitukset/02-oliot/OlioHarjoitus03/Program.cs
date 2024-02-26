Person p1 = new Person("Hermanni", 23);
Console.WriteLine(p1.FirstName);
Console.WriteLine(p1.Age);
int new_age = p1.MakeOlder();
Console.WriteLine($"{new_age} pitäisi olla {p1.Age}");

p1.Address.Print();

Address a1 = new Address("katu", 1298);
p1.SetAddress(a1);
p1.Address.Print();