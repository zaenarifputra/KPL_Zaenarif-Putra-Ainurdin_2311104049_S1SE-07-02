using System;
using AljabarLibraries;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine($"Akar-akarnya adalah: {akar[0]} dan {akar[1]}");

            var kuadrat = Aljabar.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine($"Hasil kuadrat adalah: {kuadrat[0]}x^2 + {kuadrat[1]}x + {kuadrat[2]}");
            Console.ReadLine();
        }
    }
}