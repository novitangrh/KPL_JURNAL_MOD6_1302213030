// See https://aka.ms/new-console-template for more information

using modul6_1302213030;
using System.Diagnostics;

class main {
    public static void Main(String[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Star Wars 1 oleh Novita Sabila Nugraha");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Star Wars 2 oleh Novita Sabila Nugraha");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Star Wars 3 oleh Novita Sabila Nugraha");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Star Wars 4 oleh Novita Sabila Nugraha");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Star Wars 5 oleh Novita Sabila Nugraha");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Star Wars 6 oleh Novita Sabila Nugraha");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Star Wars 7 oleh Novita Sabila Nugraha");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Star Wars 8 oleh Novita Sabila Nugraha");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Star Wars 9 oleh Novita Sabila Nugraha");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Star Wars 10 oleh Novita Sabila Nugraha");

        video1.increasePlayCount(1);
        video2.increasePlayCount(1);
        video3.increasePlayCount(1);
        video4.increasePlayCount(1);
        video5.increasePlayCount(1);
        video6.increasePlayCount(1);
        video7.increasePlayCount(1);
        video8.increasePlayCount(1);
        video9.increasePlayCount(1);
        video10.increasePlayCount(1);

        SayaTubeUser user = new SayaTubeUser("Novita");
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);

        video1.PrintVideoDetails();
        Console.WriteLine("");
        user.PrintAllVideoPlaycount();

        for (int i = 0; i < 25000000; i += 25000000)
        {
            video1.increasePlayCount(25000000);
        }
        Console.WriteLine();
        video1.PrintVideoDetails();
    

    }
}
