using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 200)
            throw new ArgumentException("Judul video tidak boleh kosong dan maksimal 200 karakter.");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public string Title
    {
        get { return title; }
    }

    public int PlayCount
    {
        get { return playCount; }
    }

    public void IncreasePlayCount(int increment)
    {
        if (increment < 0 || increment > 25000000)
            throw new ArgumentOutOfRangeException("Increment tidak valid, harus antara 0 - 25.000.000");

        checked
        {
            playCount += increment;
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
        Console.WriteLine("----------------------------");
    }
}
