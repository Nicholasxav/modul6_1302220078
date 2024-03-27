using System;
using System.Security.Cryptography;

public class SayaTubeUser
{
    private int id;
    private string username;
    private List<SayaTubeVideo> uploadedVideos;
    private Random random = new Random();
    int total = 0;
    public SayaTubeUser(String username)
    {
        id = random.Next(10000, 99999);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }
    public int GetTotalVideoPlayCount()
    {
        for (int i = 0 ; i < uploadedVideos.Count ; i++)
        {
            int Total;
            Total = uploadedVideos[i].GetPlayCount() + uploadedVideos[i + 1].GetPlayCount();
        }
        return GetTotalVideoPlayCount();
    }
    public void AddVideo(SayaTubeVideo video) {uploadedVideos.Add(video);}

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine("User: " + username);
        for ( int i = 0 ; i < uploadedVideos.Count ; i++)
        {
            Console.WriteLine("Film " + (i + 1) + "Judul: " + uploadedVideos[i].GetTitle());
        }
        Console.WriteLine("Total Video PlayCount: " + GetTotalVideoPlayCount());
    }
}
