using System;
using System.IO;
using System.Text.Json;

namespace TPModul7
{
    // Kelas untuk menyimpan data nama mahasiswa
    public class Nama
    {
        public string Depan { get; set; }
        public string Belakang { get; set; }
    }

    // Kelas untuk menyimpan data mahasiswa
    public class DataMahasiswa
    {
        public Nama Nama { get; set; }
        public long NIM { get; set; }
        public string Fakultas { get; set; }
        public string Jurusan { get; set; }
    }

    public class DataMahasiswa2311104049
    {
        private const string FilePath = "tp7_1_2311104049.json";

        public static void ReadJSON()
        {
            try
            {
                // Periksa apakah file JSON tersedia
                if (!File.Exists(FilePath))
                {
                    Console.WriteLine($"File {FilePath} tidak ditemukan!");
                    Console.WriteLine("Lokasi pencarian: " + Path.GetFullPath(FilePath));
                    return;
                }

                // Baca isi file JSON
                string jsonString = File.ReadAllText(FilePath);

                // Lakukan deserialisasi JSON ke dalam objek DataMahasiswa
                DataMahasiswa data = JsonSerializer.Deserialize<DataMahasiswa>(
                    jsonString,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                );

                // Periksa apakah data berhasil terbaca
                if (data?.Nama == null)
                {
                    Console.WriteLine("Data JSON tidak valid atau tidak sesuai dengan format yang diharapkan.");
                    return;
                }

                // Tampilkan hasil deserialisasi
                Console.WriteLine($"Nama : {data.Nama.Depan} {data.Nama.Belakang}");
                Console.WriteLine($"NIM : {data.NIM}");
                Console.WriteLine($"Fakultas : {data.Fakultas}");
                Console.WriteLine($"Jurusan : {data.Jurusan}");
            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine($"Kesalahan parsing JSON: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            }
        }
    }
}
