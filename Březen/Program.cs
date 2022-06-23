Console.Write("Napiš první číslo: ");
int cislo1 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.Write("Napiš druhé číslo: ");
int cislo2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if (cislo1 > cislo2)
{
    Console.WriteLine($"Číslo {cislo1} je větší než číslo {cislo2}");
}
else
{
    Console.WriteLine($"Číslo {cislo2} je větší než číslo {cislo1}");
}