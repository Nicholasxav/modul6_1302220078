// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
class main
{
    static void Main(String[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Nicholas Xavier");
        SayaTubeVideo video1 = new SayaTubeVideo("Satu");
        video1.IncreasePLayCount(1);
        video1.PrintVideoDetails();
        SayaTubeVideo video2= new SayaTubeVideo("Dua");
        video1.IncreasePLayCount(1);
        video1.PrintVideoDetails();
        SayaTubeVideo video3 = new SayaTubeVideo("Tiga");
        video1.IncreasePLayCount(1);
        video1.PrintVideoDetails();
        SayaTubeVideo video4 = new SayaTubeVideo("Empat");
        video1.IncreasePLayCount(1);
        video1.PrintVideoDetails();
        SayaTubeVideo video5 = new SayaTubeVideo("Lima");
        video1.IncreasePLayCount(1);
        video1.PrintVideoDetails();
        SayaTubeVideo video6 = new SayaTubeVideo("Enam");
        video1.IncreasePLayCount(1);
        video1.PrintVideoDetails();
        SayaTubeVideo video7 = new SayaTubeVideo("Tujuh");
        video1.IncreasePLayCount(1);
        video1.PrintVideoDetails();
        SayaTubeVideo video8 = new SayaTubeVideo("Delapan");
        video1.IncreasePLayCount(1);
        video1.PrintVideoDetails();
        SayaTubeVideo video9 = new SayaTubeVideo("Sembilan");
        video1.IncreasePLayCount(1);
        video1.PrintVideoDetails();
        SayaTubeVideo video10 = new SayaTubeVideo("Sepuluh");
        video1.IncreasePLayCount(1);
        video1.PrintVideoDetails();
        user.AddVideo(video1);
    }
}