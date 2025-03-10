using System;

namespace tjmodul4_2311104049
{

    class Program
{
    static void Main()
        {
            Console.WriteLine("=== Selamat datang di program kode buah ===");
            Console.WriteLine("Masukkan nama buah: ");
            string inputBuah = Console.ReadLine();
            string kode = KodeBuah.getKodeBuah(inputBuah);
            Console.WriteLine($"Kode buah untuk {inputBuah}: {kode}");
            Console.ReadLine();


            Console.WriteLine("=== Selamat datang di program karakter game ===");
            Console.Write("Masukkan NIM Anda: ");
            long nim = long.Parse(Console.ReadLine());

            Karakter karakter = new Karakter(nim);

            // Simulasi perubahan state berdasarkan tombol yang ditekan
            karakter.TekanTombolS(); // Jongkok
            karakter.TekanTombolS(); // Tengkurap
            karakter.TekanTombolW(); // Kembali Jongkok
            karakter.TekanTombolW(); // Kembali Berdiri
            karakter.TekanTombolW(); // Terbang
            karakter.TekanTombolS(); // Kembali Berdiri
            Console.ReadLine();
        }
    }
}