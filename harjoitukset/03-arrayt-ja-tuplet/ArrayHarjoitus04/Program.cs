string[] juomat = { "maito", "vesi", "limu" };

Console.WriteLine("Vaihtoehdot");

Console.WriteLine("0: maito, 1: vesi, 2: limu");

Console.Write("Valintasi: [0-2]");
int valinta = int.Parse(Console.ReadLine());

if (valinta >= 0 && valinta < juomat.Length)
{
    Console.WriteLine(juomat[valinta] + "! Hyvä valinta.");
}
else
{
    Console.WriteLine("viallinen vaihtoehto");
}
