using System;
using tpmodul8_2311104049;

public class Program
{
    static void Main(string[] args)
    {
        // Load konfigurasi
        CovidConfig config = CovidConfig.LoadFromFile("covid_config.json");

        if (config == null)
        {
            Console.WriteLine("Gagal memuat konfigurasi. Pastikan file config tersedia dan formatnya benar.");
            return;
        }

        // Tampilan pembuka
        Console.WriteLine("============================================");
        Console.WriteLine("     Selamat Datang di Sistem Screening     ");
        Console.WriteLine("============================================\n");

        // Input suhu
        Console.Write($"Berapa suhu badan anda saat ini? (dalam {config.satuan_suhu}): ");
        double suhu = Convert.ToDouble(Console.ReadLine());

        // Input hari demam
        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir mengalami gejala demam?: ");
        int hariDemam = Convert.ToInt32(Console.ReadLine());

        // Screening hasil
        Console.WriteLine("\n============================================");
        Console.WriteLine("                HASIL SCREENING              ");
        Console.WriteLine("============================================");

        // Normalisasi satuan suhu (biar aman dari typo/spasi)
        string satuanSuhu = config.satuan_suhu.ToLower().Trim();

        bool suhuNormal = (satuanSuhu == "celcius" && suhu >= 36.5 && suhu <= 37.5) ||
                           (satuanSuhu == "fahrenheit" && suhu >= 97.7 && suhu <= 99.5);

        bool hariDemamValid = hariDemam < config.batas_hari_deman;

        // Penilaian hasil
        if (suhuNormal && hariDemamValid)
            Console.WriteLine($"{config.pesan_diterima}");
        else
            Console.WriteLine($"{config.pesan_ditolak}");

        // Ubah satuan suhu untuk sesi berikutnya
        config.UbahSatuan();
        Console.WriteLine($"\nSatuan suhu telah diubah menjadi: {config.satuan_suhu.ToUpper()}");

        Console.WriteLine("\nTerima kasih telah melakukan screening!");
        Console.WriteLine("============================================");

        Console.ReadLine();
    }
}
