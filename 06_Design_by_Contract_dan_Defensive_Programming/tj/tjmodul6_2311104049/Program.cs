using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Input nama panggilan dari pengguna
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
                // Judul video sesuai nama panggilan
                SayaTubeVideo video = new SayaTubeVideo($"Review Film {judul} oleh {namaPanggilan}");
                user.AddVideo(video);
            }

            // Postcondition: Print maksimal 8 video
            user.PrintAllVideoPlaycount();
            Console.WriteLine($"Total Play Count: {user.GetTotalVideoPlayCount()}");

            // Uji Exception Handling (Play count negatif)
            try
            {
                SayaTubeVideo testVideo = new SayaTubeVideo("Video Uji Error");
                testVideo.IncreasePlayCount(-5);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terjadi error (play count negatif): {e.Message}");
            }

            // Uji Overflow Play Count
            try
            {
                SayaTubeVideo overflowVideo = new SayaTubeVideo("Video Uji Overflow");
                for (int i = 0; i < 10; i++) // Loop untuk mempercepat overflow
                {
                    overflowVideo.IncreasePlayCount(int.MaxValue / 5);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Terjadi error (overflow play count): {e.Message}");
            }

            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error utama: {e.Message}");
        }
    }
}
