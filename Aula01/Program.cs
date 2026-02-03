Double NI, PI, PO, Media;

Console.WriteLine("NI: ");
NI = Convert.ToDouble(Console.ReadLine());

Console.Write("PI: ");
PI = Convert.ToDouble(Console.ReadLine());

Console.Write("PO: ");
PO = Convert.ToDouble(Console.ReadLine());

Media = (NI*0.20) + (PI*0.30) + (PO*0.50);

if (Media >= 6) 
{
    Console.Write("Aprovado: ");
}

if (Media >= 4.0 && Media < 6.0)
{
    Console.Write("Exame - nota 6: ");
}

if (Media >= 2 && Media < 4)
{
    Console.Write("Exame - nota 7: ");
}

if (Media < 2)
{
    Console.Write("Reprovado: ");
}


Console.WriteLine("A média final é " + Media);
