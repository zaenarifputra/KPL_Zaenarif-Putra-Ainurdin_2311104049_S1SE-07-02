using System;
using TjModul7_Kelompok7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== [1] Menampilkan Parsing Data Mahasiswa ===");
        var dataMahasiswa = new DataMahasiswa2311104049();
        dataMahasiswa.ReadJSON();
        Console.ReadLine();
    }
}
