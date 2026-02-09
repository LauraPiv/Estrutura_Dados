using System;
Int64 fatorial(Int64 n)
{
    int fat = 1;
    for (Int32 i = 1; i <= n; i++)
    {
        fat = fat * i;
    }
    return fat;
}

Int16 N;
Console.WriteLine("Fatorial de N: ");
N = Int16.Parse(Console.ReadLine());
Int64 resutado = fatorial(N);
Console.WriteLine(N + "! = " + resutado);

