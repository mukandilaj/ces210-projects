using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1 = new Video();
        video1._title = "Joyce birthday";
        video1._author = "Berthe";
        video1._length = 588;

        Video video2 = new Video();
        video2._title = "House for rent";
        video2._author = "Moses";
        video2._length = 133;

        Video video3 = new Video();
        video3._title = "Excursion";
        video3._author = "Alice";
        video3._length = 900;

        Comment comment1 = new Comment();
        comment1._nameCommenter = "Thethe";
        comment1._comment = "Happy birthday Joyce!";

        Comment comment2 = new Comment();
        comment2._nameCommenter = "Mamie Jeanne";
        comment2._comment = "Happy birthday my pretty daugther!";

        Comment comment3 = new Comment();
        comment3._nameCommenter = "Soraya";
        comment3._comment = "Happy birtday my lovely sister!";

        Comment comment4 = new Comment();
        comment4._nameCommenter = "Jimmy";
        comment4._comment = "Nice house for rent.";

        Comment comment5 = new Comment();
        comment5._nameCommenter = "Natacha";
        comment5._comment = "I am interesting.";

        Comment comment6 = new Comment();
        comment6._nameCommenter = "Sylvain";
        comment6._comment = "What are the conditions?";

        Comment comment7 = new Comment();
        comment7._nameCommenter = "Belinda";
        comment7._comment = "Enjoy it!";

        Comment comment8 = new Comment();
        comment8._nameCommenter = "Bob";
        comment8._comment = "Magnifique!";

        Comment comment9 = new Comment();
        comment9._nameCommenter = "Ariana";
        comment9._comment = "Miss you!";

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine($"Number of comments: {video.GetNumberComments()}");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"Commenter: {comment._nameCommenter}");
                Console.WriteLine($"Comment: {comment._comment}");
            }
            Console.WriteLine();
        }
    }
}