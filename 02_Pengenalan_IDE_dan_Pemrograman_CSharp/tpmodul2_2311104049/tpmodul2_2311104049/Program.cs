// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Menampilkan Huruf Vokal dan Konsonan=== ");
        Console.WriteLine("Masukkan satu huruf : ");
        char inputHuruf = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if ("AIUEO".IndexOf(inputHuruf) >= 0)
        {
            Console.WriteLine($"Huruf {inputHuruf} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {inputHuruf} merupakan huruf konsonan");
        }
        Console.WriteLine();

        //Menampilkan Bilangan Genap dari angka 2
        Console.WriteLine("=== Menampilakn Daftar Bilangan Genap ===");
        int[] angkaGenap = new int[5];
        for (int i = 0; i < 5; i++)
        {
            angkaGenap[i] = (i + 1) * 2;
        }

        for (int i = 0; i < angkaGenap.Length; i++)
        {
            Console.WriteLine($"Angka Genap {i + 1} adalah {angkaGenap[i]}");
        }
        Console.ReadLine();
    }
}