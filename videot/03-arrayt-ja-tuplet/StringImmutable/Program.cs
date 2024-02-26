string nimi = "Jape";

// nimi[2] = 'k';

char[] merkit = nimi.ToCharArray();
merkit[2] = 'k';

nimi = new string(merkit);
Console.WriteLine(nimi);