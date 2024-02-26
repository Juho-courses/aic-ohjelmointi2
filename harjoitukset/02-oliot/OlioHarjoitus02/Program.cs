Address a1 = new Address("Satakunnankatu", 23);

Console.WriteLine(a1.StreetName);
Console.WriteLine(a1.Number);
a1.Print();

a1.ChangeAddress("Karjalankatu", 12);
a1.Print();
