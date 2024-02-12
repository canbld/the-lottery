

using System.Drawing;

Random rnd = new Random();
int[] sayilar=new int[7];
int tutulan,sayac;
    sayac = 0;
    while (sayac < 7)
    {
        tutulan = rnd.Next(1, 50);

        if (Array.IndexOf(sayilar, tutulan) == -1)
        {
            sayilar[sayac] = tutulan;
            sayac++;
        }
    }
int d=0, y=0;
int tahminler;
for (int k = 0; k < sayilar.Length; k++)
{
    Console.Write($"{k+1}. sayıyı tahmin ediniz : ");
    tahminler = int.Parse(Console.ReadLine());
    if (Array.IndexOf(sayilar, tahminler) == -1)
    {
        y++;
    }
    else
    {
        d++;
    }
}
Console.WriteLine();
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.Write("Tutulan sayilar : ");
for (int n = 0; n < sayilar.Length; n++)
{
    Console.Write($"{sayilar[n]} ");
}
Console.WriteLine();
Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.WriteLine();
Console.WriteLine($"{sayilar.Length} tahmininizden {d} tanesi doğru, {y} tanesi yanlış.");