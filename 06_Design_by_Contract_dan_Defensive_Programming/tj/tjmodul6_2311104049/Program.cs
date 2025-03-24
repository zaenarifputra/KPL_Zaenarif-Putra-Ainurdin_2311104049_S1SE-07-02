using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Meminta input nama panggilan dari pengguna
            Console.Write("Masukkan Nama Panggilan: ");
            string namaPanggilan = Console.ReadLine();

            if (string.IsNullOrEmpty(namaPanggilan) || namaPanggilan.Length > 100)
            {
                throw new ArgumentException("Nama panggilan tidak boleh kosong dan maksimal 100 karakter.");
            }

            SayaTubeUser user = new SayaTubeUser(namaPanggilan);

            string[] judulFilm = {
                "Dark", "Cars", "Cars 2",
                "PeeMak", "Interstellar", "Inception",
                "Parasite", "Avengers: Endgame", "John Wick 4",
                "Oppenheimer"
            };

            foreach (var judul in judulFilm)
            {
                // Judul video akan mengikuti nama panggilan yang diinputkan pengguna
                SayaTubeVideo video = new SayaTubeVideo($"Review Film {judul} oleh {namaPanggilan}");
                user.AddVideo(video);
            }

            user.PrintAllVideoPlaycount();
            Console.WriteLine($"Total Play Count: {user.GetTotalVideoPlayCount()}");

            // Uji kasus: Tambah play count dengan nilai negatif (seharusnya error)
            try
            {
                SayaTubeVideo testVideo = new SayaTubeVideo("Video Uji Error");
                testVideo.IncreasePlayCount(-5);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terjadi error: {e.Message}");
            }

            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error utama: {e.Message}");
        }
    }
}
