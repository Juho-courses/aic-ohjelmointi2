(string Firstname, int Age, string Occupation) ParsePerson(string input)
{
    string[] data = input.Split(':');
    return (Firstname: data[0], Age: int.Parse(data[1]), Occupation: data[2]);
}

var henkilo = ParsePerson("Jaska:27:LVI-asentaja");
Console.WriteLine(henkilo.Firstname + ", " + henkilo.Age + ", " + henkilo.Occupation);
henkilo = ParsePerson("Leenu:21:Opiskelija");
Console.WriteLine(henkilo.Firstname + ", " + henkilo.Age + ", " + henkilo.Occupation);