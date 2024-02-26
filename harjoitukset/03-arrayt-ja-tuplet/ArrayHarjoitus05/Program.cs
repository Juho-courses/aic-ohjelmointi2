int[] luvut = new int[3];

Console.Write("Anna luku: ");
luvut[0] = int.Parse(Console.ReadLine());

Console.Write("Anna luku: ");
luvut[1] = int.Parse(Console.ReadLine());

Console.Write("Anna luku: ");
luvut[2] = int.Parse(Console.ReadLine());

Console.Write("+, -, *: ");
string operaatio = Console.ReadLine();

int tulos = 0;
if (operaatio == "+")
{
    tulos = luvut[0] + luvut[1] + luvut[2];
}
else if (operaatio == "-")
{
    tulos = luvut[0] - luvut[1] - luvut[2];
}
else if (operaatio == "*")
{
    tulos = luvut[0] * luvut[1] * luvut[2];
}

Console.WriteLine(luvut[0] + " " + operaatio + " " + luvut[1] + " " + operaatio + " " + luvut[2] + " = " + tulos);