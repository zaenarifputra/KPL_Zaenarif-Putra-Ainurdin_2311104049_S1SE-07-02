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
        Console.WriteLine();

        Console.WriteLine("=== [2] Menampilkan Parsing Team Members Mahasiswa ===");
        var teamMembers = new TeamMembers2311104049();
        teamMembers.ReadJSON();
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("=== [3] Menampilkan Parsing Glossary Item Mahasiswa ===");
        var glossaryItem = new GlossaryItem2311104049();    
        glossaryItem.ReadJSON();
        Console.ReadLine();
    }
}
