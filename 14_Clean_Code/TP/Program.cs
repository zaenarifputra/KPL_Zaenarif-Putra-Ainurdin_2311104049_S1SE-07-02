using System;
using Doormachine;
using Kodepos;

namespace ProgramApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Membuat objek kode pos dan menampilkan seluruh data kelurahan beserta kode pos-nya
            var kodePos = new KodePos();
            Console.WriteLine("Menampilkan Data Kode Pos:");
            kodePos.TampilkanSemuaKodePos();
            Console.WriteLine();

            // Menjalankan simulasi sistem pintu (state machine)
            Console.WriteLine("Menampilkan Sistem Pintu:");
            var pintu = new DoorMachine();
            Console.WriteLine();

            // Buka pintu dan tampilkan statusnya
            pintu.BukaPintu();
            Console.WriteLine($"Status Pintu: {pintu.StatusPintu()}");
            Console.WriteLine();

            // Kunci pintu dan tampilkan statusnya
            pintu.KunciPintu();
            Console.WriteLine($"Status Pintu: {pintu.StatusPintu()}");
            Console.WriteLine();

            // Coba mengunci dan membuka pintu lagi
            pintu.KunciPintu();
            pintu.BukaPintu();

            Console.ReadLine();
        }
    }
}