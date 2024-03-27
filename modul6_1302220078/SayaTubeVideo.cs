using System;
using System.Diagnostics.Contracts;

class SayaTubeVideo
{
    private int id;
    private String title;
    private int PlayCount;

    public SayaTubeVideo(string title)
    {
        Contract.Requires(title != null && title.Length <= 100, "Judul video memiliki panjang maksimal 100 karakter dan tidak berupa null");
        this.id = RandomNumber();
        this.title = title;
        this.PlayCount = 0;
    }

    private int RandomNumber()
    {
        Random random = new Random();
        return random.Next(00000, 99999);
    }

    public void IncreasePLayCount(int count)
    {
        Contract.Requires(count > 0 && count <= 10000000, "Input penambahan Play Count 10000000");
        Contract.Requires(PlayCount <= int.MaxValue - count, "Play Count melebihi jumlah");
        try
        {
            checked
            {
                PlayCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Penambahan play count melebihi batas");
        }
    }
    public void PrintVideoDetails()
    {
        Console.WriteLine("ID : " + this.id);
        Console.WriteLine("Title : " + this.title);
        Console.WriteLine("Play Count :" + this.PlayCount);
    }
    public int GetPlayCount()
    {
        return PlayCount;
    }
    public string GetTitle()
    {
        return title;
    }
}
