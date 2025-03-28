using System;
using TpModul7_Kelompok_7;

namespace TpModul7_Kelompok_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM DESERIALISASI JSON ===");
            Console.WriteLine("=== Praktikum Modul 7 - NIM 2311104049 ===\n");

            // Jalankan fungsi pertama (Data Mahasiswa)
            Console.WriteLine("\n=============== MENAMBAHKAN JSON DESERIALIZATON 1 ==================");
            Console.WriteLine("\n[1] MEMBACA DATA MAHASISWA");
            DataMahasiswa2311104049.ReadJSON();

            // Jalankan fungsi kedua (Daftar Mata Kuliah)
            Console.WriteLine("\n==================MENAMBAHKAN JSON DESERIALIZATON 2=====================");
            Console.WriteLine("\n[2] MEMBACA DAFTAR MATA KULIAH");
            KuliahMahasiswa2311104045.ReadJSON();
            Console.WriteLine("=== Praktikum Modul 7 - NIM 2311104049 ===\n");


            Console.WriteLine("\n=== SEMUA PROSES TELAH SELESAI ===");
            Console.WriteLine("Tekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}
