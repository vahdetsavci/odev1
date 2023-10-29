using System;

namespace odev1._1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Pozitif bir sayı giriniz: ");
        Kontrol.DiziYazdır(new int[Kontrol.PozitifSayiAl()]);
    }
}

static class Kontrol
{
    internal static int SayiKontrol(this string param)
    {
        bool sayiKontrol = int.TryParse(param, out int sayi);
        if(!sayiKontrol)
            Console.WriteLine("HATA: Girilen değer sayı değil, lütfen bir sayı giriniz!");
        else if (sayi <= 0)
            Console.WriteLine("HATA: Girilen değer bir pozitif sayı değil, lütfen pozitif bir sayı giriniz!");
        return sayi;
    }

    internal static int PozitifSayiAl()
    {
        int sayi = 0;
        while (sayi <= 0)
        {
            sayi = Console.ReadLine().SayiKontrol();
        }
        return sayi;
    }

    internal static void DiziYazdır(int[] dizi)
    {
        Console.WriteLine(dizi.Length + " adet pozitif sayı giriniz!");
        for (int i = 0; i < dizi.Length; i++)
        {
                Console.Write(i+1+".sayı: ");
                dizi[i] = PozitifSayiAl();
        }
        Console.Write("Girdiğiniz pozitif çift sayılar: ");
        foreach (int sayi in dizi)
        {
            if (sayi % 2 == 0)
                Console.Write(sayi+" ");
        }
    }
}
