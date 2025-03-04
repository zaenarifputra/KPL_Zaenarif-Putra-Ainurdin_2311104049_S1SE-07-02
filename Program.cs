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
        }
    }
}
