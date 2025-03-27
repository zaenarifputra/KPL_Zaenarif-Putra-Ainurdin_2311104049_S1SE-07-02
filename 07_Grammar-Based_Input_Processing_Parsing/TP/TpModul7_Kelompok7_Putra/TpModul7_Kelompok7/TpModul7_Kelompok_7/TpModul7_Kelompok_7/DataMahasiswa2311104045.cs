using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TpModul7_Kelompok_7
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class DataMahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public class DataMahasiswa2311104045
    {
        public static void ReadJSON()
        {
            try
            {
                string filePath = "tp7_1_2311104045.json";

                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File {filePath} tidak ditemukan!");
                    Console.WriteLine("Lokasi pencarian: " + Path.GetFullPath(filePath));
                    return;
                }


                // Baca dan deserialize file JSON
                string jsonString = File.ReadAllText(filePath);
                DataMahasiswa data = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);

                // Tampilkan hasil
                Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} " +
                    $"dengan nim {data.nim} dari fakultas {data.fakultas}");
            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine($"Error parsing JSON: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.ReadLine();
            }
        }
    }
}

