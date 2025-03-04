// See https://aka.ms/new-console-template for more information
using System;

namespace tpmodul3_2311104049
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePos kodePos = new KodePos();
            Console.WriteLine("Menampilkan Data Kode Pos : ");
            kodePos.MenampilkanSemuaKodePos();
            Console.WriteLine("");


            DoorMachine pintu = new DoorMachine(); // Pintu awal terkunci

            Console.WriteLine(); // Spasi untuk kejelasan output

            pintu.BukaPintu();   // Membuka pintu
            pintu.StatusPintu(); // Mengecek status pintu

            Console.WriteLine(); // Spasi

            pintu.KunciPintu();  // Mengunci pintu
            pintu.StatusPintu(); // Mengecek status pintu

            Console.WriteLine(); // Spasi

            pintu.KunciPintu();  // Coba kunci lagi (sudah terkunci)
            pintu.BukaPintu();   // Coba buka lagi
        }
    }
}
