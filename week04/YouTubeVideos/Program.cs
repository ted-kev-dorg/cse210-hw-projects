using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();

        // --- VIDEO 1 ---
        Video video1 = new Video();
        video1._title = "10 Easy C# Beginner Tips";
        video1._author = "Code Academy";
        video1._lengthInSeconds = 600;

        Comment c1_1 = new Comment();
        c1_1._name = "Alex";
        c1_1._text = "This helped me so much with my homework!";
        video1._comments.Add(c1_1);

        Comment c1_2 = new Comment();
        c1_2._name = "Sarah";
        c1_2._text = "Great explanation on abstraction!";
        video1._comments.Add(c1_2);

        Comment c1_3 = new Comment();
        c1_3._name = "David";
        c1_3._text = "Can you make a video on lists next?";
        video1._comments.Add(c1_3);

        videos.Add(video1);

        // --- VIDEO 2 ---
        Video video2 = new Video();
        video2._title = "Top 5 Laptops for Programming";
        video2._author = "Tech Reviews Daily";
        video2._lengthInSeconds = 850;

        Comment c2_1 = new Comment();
        c2_1._name = "Jordan";
        c2_1._text = "Option #3 is definitely the best value.";
        video2._comments.Add(c2_1);

        Comment c2_2 = new Comment();
        c2_2._name = "Taylor";
        c2_2._text = "I've been using laptop #1 for months and love it!";
        video2._comments.Add(c2_2);

        Comment c2_3 = new Comment();
        c2_3._name = "Chris";
        c2_3._text = "Thanks for including battery life tests.";
        video2._comments.Add(c2_3);

        videos.Add(video2);

        // --- VIDEO 3 ---
        Video video3 = new Video();
        video3._title = "How to Bake Sourdough Bread at Home";
        video3._author = "Baking Masterclass";
        video3._lengthInSeconds = 1200;

        Comment c3_1 = new Comment();
        c3_1._name = "Maria";
        c3_1._text = "My starter finally worked because of this video!";
        video3._comments.Add(c3_1);

        Comment c3_2 = new Comment();
        c3_2._name = "Liam";
        c3_2._text = "How long do you recommend letting it rise in winter?";
        video3._comments.Add(c3_2);

        Comment c3_3 = new Comment();
        c3_3._name = "Emma";
        c3_3._text = "The crust turned out so crisp!";
        video3._comments.Add(c3_3);

        videos.Add(video3);

        // --- DISPLAY ALL ---
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}