using System;
using MatematikaLibraries;

class Program
{
    static void Main()
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("            TJ MODUL 10              ");
        Console.WriteLine("=====================================\n");

        // FPB
        int a = 60, b = 45;
        Console.WriteLine($"FPB dari {a} dan {b} = {MatematikaApps.FPB(a, b)}");

        // KPK
        int c = 12, d = 8;
        Console.WriteLine($"KPK dari {c} dan {d} = {MatematikaApps.KPK(c, d)}");

        // Turunan
        int[] turunanKoef = { 1, 4, -12, 9 };
        Console.WriteLine($"\nTurunan dari f(x) = 1x^3 + 4x^2 - 12x + 9");
        Console.WriteLine("Adalah : " + MatematikaApps.Turunan(turunanKoef));

        // Integral
        int[] integralKoef = { 4, 6, -12, 9 };
        Console.WriteLine($"\nIntegral dari f(x) = 4x^3 + 6x^2 - 12x + 9");
        Console.WriteLine("Adalah : " + MatematikaApps.Integral(integralKoef));

        Console.WriteLine("\n=== Perhitungan Selesai ===");
        Console.WriteLine("Tekan Enter untuk keluar...");
        Console.ReadLine();
    }
}
