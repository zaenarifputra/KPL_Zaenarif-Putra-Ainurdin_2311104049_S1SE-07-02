using System;
using tpmodul8_2311104049;

public class Program
{
    static void Main(string[] args)
    {
        CovidConfig config = CovidConfig.LoadFromFile("covid_config.json");

        if (config == null)
        {
            Console.WriteLine("Gagal memuat konfigurasi. Pastikan file config tersedia dan formatnya benar.");
            return;
        }

        Console.WriteLine("============================================");
        Console.WriteLine("     Selamat Datang di Sistem Screening     ");
        Console.WriteLine("============================================\n");

        Console.Write($"Berapa suhu badan anda saat ini? (dalam {config.satuan_suhu}): ");
        double suhu = Convert.ToDouble(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir mengalami gejala demam?: ");
        int hariDemam = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n============================================");
        Console.WriteLine("                HASIL SCREENING              ");
        Console.WriteLine("============================================");

        bool suhuNormal = (config.satuan_suhu == "celcius" && suhu >= 36.5 && suhu <= 37.5) ||
                           (config.satuan_suhu == "fahrenheit" && suhu >= 97.7 && suhu <= 99.5);

        bool hariDemamValid = hariDemam < config.batas_hari_deman;

        if (suhuNormal && hariDemamValid)
            Console.WriteLine($"✅ {config.pesan_diterima}");
        else
            Console.WriteLine($"❌ {config.pesan_ditolak}");

        // Ubah satuan suhu setelah selesai
        config.UbahSatuan();
        Console.WriteLine($"\n🔄 Satuan suhu telah diubah menjadi: {config.satuan_suhu.ToUpper()}");

        Console.WriteLine("\nTerima kasih telah melakukan screening!");
        Console.WriteLine("============================================");

        Console.ReadLine();
    }
}
