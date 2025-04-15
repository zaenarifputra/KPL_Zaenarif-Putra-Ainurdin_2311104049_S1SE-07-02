using System;
using TjModul7_Kelompok7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== [2] Menampilkan Parsing Team Members Mahasiswa ===");
        var teamMembers = new TeamMembers2311104049();
        teamMembers.ReadJSON();
        Console.ReadLine();
    }
}
