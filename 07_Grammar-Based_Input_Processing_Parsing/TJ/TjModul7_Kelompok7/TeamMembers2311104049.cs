using System;
using System.IO;
using System.Text.Json;

namespace TjModul7_Kelompok7
{
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public class TeamMembers2311104049
    {
        public Member[] members { get; set; }

        public void ReadJSON()
        {
            try
            {
                string jsonString = File.ReadAllText("jurnal7_2_2311104049.json");

                TeamMembers2311104049 team = JsonSerializer.Deserialize<TeamMembers2311104049>(jsonString);

                if (team == null || team.members == null)
                {
                    Console.WriteLine("Data JSON kosong atau tidak sesuai format.");
                    return;
                }

                Console.WriteLine("Team member list:");
                foreach (var member in team.members)
                {
                    Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File JSON tidak ditemukan.");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Terjadi kesalahan saat membaca JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error tak terduga: {ex.Message}");
            }
        }
    }
}
