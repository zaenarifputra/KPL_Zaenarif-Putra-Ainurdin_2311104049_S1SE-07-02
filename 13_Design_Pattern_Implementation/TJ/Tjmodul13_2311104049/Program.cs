using implementasi_singleton;
using System;

class Program
{
    static void Main(string[] args)
    {
        //Buat dua variabel singleton
        PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
        PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

        //Tambahkan data ke data1
        data1.AddSebuahData("Anggota 1 - Budi");
        data1.AddSebuahData("Anggota 2 - Sari");
        data1.AddSebuahData("Asisten - Riko");

        //Print dari data2 (harus tampil semua)
        Console.WriteLine("Data dari data2:");
        data2.PrintSemuaData();

        //Hapus nama asisten dari data2
        data2.HapusSebuahData(2); 

        //Print ulang dari data1 (harus sudah terhapus)
        Console.WriteLine("\nData dari data1 setelah penghapusan:");
        data1.PrintSemuaData();

        //Print jumlah data
        Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData().Count}");
    }
}
