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
            string input = Console.ReadLine();

            if (!long.TryParse(input, out long nim))
            {
                Console.WriteLine("NIM tidak valid! Masukkan angka yang benar.");
                return;
            }

            Karakter karakter = new Karakter(nim);

            // Loop untuk menerima input pengguna
            while (true)
            {
                Console.WriteLine("\nTekan W (naik), S (turun), atau X (keluar): ");
                string perintah = Console.ReadLine().ToUpper();

                if (perintah == "X")
                {
                    Console.WriteLine("Keluar dari program.");
                    break;
                }
                else if (perintah == "W")
                {
                    karakter.TekanTombolW();
                }
                else if (perintah == "S")
                {
                    karakter.TekanTombolS();
                }
                else
                {
                    Console.WriteLine("Perintah tidak dikenali. Silakan tekan W, S, atau X.");
                }
            }
            Console.ReadLine();
        }
    }
}