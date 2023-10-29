using System;

namespace odev1._2;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = SpecialClass.PozitifSayilar(new int[2]);
        int n = dizi[0], m = dizi[1];
        SpecialClass.PozitifSayilar(new int[n]).DiziKontrol(m);
    }
}

static class SpecialClass
{
    internal static int SayiKontol(this string param)
    {
            bool sayiKontrol = int.TryParse(param, out int sayiInt);
            if(!sayiKontrol)
                Console.WriteLine("Girdiğiniz değer sayı değil, lütfen bir sayı girip tekrar deneyin!");
            else if (sayiInt <= 0)
                Console.WriteLine("Girdiğiniz sayı pozitif değil, lütfen pozitif bir sayı girip tekrar deneyin!");
            return sayiInt;
    }

    internal static void DiziKontrol(this int[] param, int m)
    {
        foreach (int sayi in param)
        {
            if (sayi == m || sayi % m == 0)
                Console.Write(sayi+" ");
        }
    }

    internal static int PozitifSayiAl()
    {
        int sayi = 0;
        while (sayi <= 0)
        {    
            sayi = Console.ReadLine().SayiKontol();
        }
        return sayi;
    }

    internal static int[] PozitifSayilar(int[] dizi)
    {
        Console.WriteLine(dizi.Length + " adet pozitif sayı giriniz!");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write(i+1 + ".sayı: ");
            dizi[i] = PozitifSayiAl();
        }
        return dizi;
    }
}
