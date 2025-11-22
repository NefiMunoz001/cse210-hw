using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        v1.AddComment(new Comment("Alice", "Great tutorial!"));
        v1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        v1.AddComment(new Comment("Chris", "I'm learning so much."));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("The Future of AI", "TechTalks", 900);
        v2.AddComment(new Comment("Daisy", "Amazing explanation"));
        v2.AddComment(new Comment("Leo", "AI will change everything"));
        v2.AddComment(new Comment("Maria", "Very interesting content"));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("How to Cook Pasta", "ChefMario", 300);
        v3.AddComment(new Comment("Lucia", "Delicious recipe!"));
        v3.AddComment(new Comment("Oscar", "Trying this tonight!"));
        v3.AddComment(new Comment("Nina", "Looks easy to make."));
        videos.Add(v3);

        // Display all videos
        foreach (Video vid in videos)
        {
            vid.Display();
        }
    }
}

