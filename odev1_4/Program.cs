using System;

namespace odev1_4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir cümle yazınız: ");
        KelimeVeHarf(Console.ReadLine().Split(" "));
    }

    static void KelimeVeHarf(string[] kelimeler)
    {
        int n = 0;
        foreach (string kelime in kelimeler)
             n += kelime.Length;
        Console.WriteLine("Girdiğiniz cümle " + kelimeler.Length + " kelime, " + n + " harf içerir.");
    }
}
