using System;

namespace odev1_3;

class Program
{
    static void Main(string[] args)
    {
        Custom instance = new();
        Console.Write("Pozitif bir sayı girin: ");
        int n = instance.PozitifSayiAl();
        instance.KelimeYaz(new string[n]);
    }
}

class Custom
{
    internal int PozitifSayiAl()
    {
        int n = 0;
        while(n <= 0)
            n = SayiKontrol(Console.ReadLine());

        return n;
    }

    private int SayiKontrol(string sayi)
    {
        bool kontrol = int.TryParse(sayi, out int n);
        if (!kontrol)
            Console.WriteLine("HATA: Girdiğiniz değer sayı değil, lütfen pozitif bir sayı girip tekrar deneyin!");
        else if (n <= 0)
            Console.WriteLine("HATA: Girdiğiniz sayı pozitif değil, lütfen pozitif bir sayı girip tekrar deneyin.");
        return n;
    }

    internal void KelimeYaz(string[] dizi)
    {
        Console.WriteLine(dizi.Length + " kelime girin");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write(i+1 + ". ");
            dizi[i] = Console.ReadLine();
        }
        Array.Reverse(dizi);
        Console.WriteLine("************************************");
        foreach (string kelime in dizi)
            Console.Write(kelime + " ");
    }
}