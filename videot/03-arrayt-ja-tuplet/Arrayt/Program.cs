// int[] ints = new int[5];
// Console.WriteLine(ints[0]);

// ints[0] = 123;
// Console.WriteLine(ints[0]);

// int[] ints1 = new int[] { 12, 234, 4234, 523523, 87 };
// Console.WriteLine(ints1[0]);
// Console.WriteLine(ints1[4]);

int[] ints2 = { 12, 987, 4234, 523523, 87 };
// Console.WriteLine(ints2[1]);

// Console.WriteLine(ints2[ints2.Length - 1]);

// for (int i = 0; i < ints2.Length; i++)
// {
//     Console.WriteLine(ints2[i]);
// }

foreach (int luku in ints2)
{
    Console.WriteLine(luku);
}