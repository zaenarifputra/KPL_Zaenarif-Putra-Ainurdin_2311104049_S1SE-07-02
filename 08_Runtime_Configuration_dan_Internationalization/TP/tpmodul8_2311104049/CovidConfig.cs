using System.Text.Json;
using System.IO;

namespace tpmodul8_2311104049
{
    class CovidConfig
    {
        public string satuan_suhu { get; set; }
        public int batas_hari_deman { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        public CovidConfig()
        {
        }

        public static CovidConfig LoadFromFile(string path)
        {
            try
            {
                string jsonString = File.ReadAllText(path);
                return JsonSerializer.Deserialize<CovidConfig>(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saat membaca file config: {ex.Message}");
                return null;
            }
        }

        public void UbahSatuan()
        {
            if (satuan_suhu.ToLower() == "celcius")
            {
                satuan_suhu = "fahrenheit";
            }
            else
            {
                satuan_suhu = "celcius";
            }
        }
    }
}
