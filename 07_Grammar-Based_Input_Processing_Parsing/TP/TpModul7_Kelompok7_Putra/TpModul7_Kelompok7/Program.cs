using System;

namespace TPModul7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM DESERIALISASI JSON ===");
            Console.WriteLine("=== Praktikum Modul 7 - NIM 2311104049 ===\n");

            // Jalankan fungsi pertama (Data Mahasiswa)
            Console.WriteLine("\n===============MENAMBAHKAN JSON DESERIALIZATON 1==================");
            Console.WriteLine("\n[1] MEMBACA DATA MAHASISWA");
            DataMahasiswa2311104049.ReadJSON();

            Console.WriteLine("\n=== SEMUA PROSES TELAH SELESAI ===");
            Console.ReadKey();
        }
    }
}