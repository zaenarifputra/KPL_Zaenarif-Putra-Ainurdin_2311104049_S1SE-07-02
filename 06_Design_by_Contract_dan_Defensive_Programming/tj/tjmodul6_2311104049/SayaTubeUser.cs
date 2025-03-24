using System;
using System.Collections.Generic;

public class SayaTubeUser
{
    private int id;
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        if (string.IsNullOrEmpty(username) || username.Length > 100)
            throw new ArgumentException("Username tidak boleh kosong dan maksimal 100 karakter.");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null)
            throw new ArgumentNullException("Video tidak boleh null");

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (var video in uploadedVideos)
        {
            totalPlayCount += video.PlayCount;
        }
        return totalPlayCount;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {username}");
        for (int i = 0; i < uploadedVideos.Count && i < 8; i++) // Menampilkan max 8 video
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].Title}");
        }
    }
}
