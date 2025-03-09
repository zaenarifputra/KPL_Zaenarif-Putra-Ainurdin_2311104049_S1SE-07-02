// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Menampilkan Program Input Nama ===");
        Console.Write("Masukkan Nama Anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Halo, Selamat Datang {nama}!");
        Console.WriteLine();

        Console.WriteLine("=== Menampilkan Program Array dengan 50 Elemen ===");
        int[] array = new int[50];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i; // Mengisi array dengan nilai indeksnya

            // Menentukan kategori bilangan berdasarkan kelipatan 2 dan/atau 3
            if (i % 2 == 0 && i % 3 == 0)
                Console.WriteLine($"Angka {i} adalah kelipatan 2 dan 3 → #$#$");
            else if (i % 2 == 0)
                Console.WriteLine($"Angka {i} adalah kelipatan 2 → ##");
            else if (i % 3 == 0)
                Console.WriteLine($"Angka {i} adalah kelipatan 3 → $$");
            else
                Console.WriteLine($"Angka {i} bukan kelipatan 2 atau 3");
        }
        Console.WriteLine();

        Console.WriteLine("=== Menampilkan Program Bilangan Prima ===");
        Console.Write("Masukkan angka (1 - 10000): ");
        int angka;
        while (!int.TryParse(Console.ReadLine(), out angka) || angka < 1 || angka > 10000)
        {
            Console.Write("Input tidak valid! Masukkan angka antara 1 - 10000: ");
        }

        if (ApakahPrima(angka))
            Console.WriteLine($"Angka {angka} merupakan bilangan prima");
        else
            Console.WriteLine($"Angka {angka} bukan merupakan bilangan prima");

        Console.ReadLine();
    }

    static bool ApakahPrima(int angka)
    {
        if (angka < 2)
            return false;
        for (int i = 2; i <= Math.Sqrt(angka); i++)
        {
            if (angka % i == 0)
                return false;
        }
        return true;
    }
}
