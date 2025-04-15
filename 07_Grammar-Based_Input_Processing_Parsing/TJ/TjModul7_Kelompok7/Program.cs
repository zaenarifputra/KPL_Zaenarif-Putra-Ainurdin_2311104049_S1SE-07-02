using System;
using TjModul7_Kelompok7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== [3] Menampilkan Parsing Glossary Item Mahasiswa ===");
        var teamMembers = new GlossaryItem2311104049();
        teamMembers.ReadJSON();
        Console.ReadLine();
    }
}
