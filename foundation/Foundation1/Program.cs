using System;

public class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("video 1", "Micheal Smith", 150);
        video1.Comments.Add(new Comment("I enjoyed from 55 sec", "Pet Nelson"));
        video1.Comments.Add(new Comment("I love from 55 sec", "Jane Nelson"));
        video1.Comments.Add(new Comment("Thats aamazing: from 55 sec", "Andre Nelson"));
        videos.Add(video1);

    
        Video video2 = new Video("video 1", "Micheal Smith", 150);
        video2.Comments.Add(new Comment("tThis is nice", "Peter Workman"));
        video2.Comments.Add(new Comment("What a video", "Emmanuel"));
        video2.Comments.Add(new Comment("Beautiful", "Andre john"));
        videos.Add(video2);
        
    
        Video video3 = new Video("video 1", "Micheal Smith", 150);
        video3.Comments.Add(new Comment("I love this", "Mike Boston"));
        video3.Comments.Add(new Comment("What an amazing video", "Jane Simpson"));
        video3.Comments.Add(new Comment("I could just put this on repeat mode", "Collins Robert"));
        videos.Add(video3);
    
        foreach (Video video in videos)
        {
            Console.WriteLine($"Video Tittle: {video.Title}, Video Author: {video.Author}, Video length: {video.Length}");
            Console.WriteLine($"Nunber of comments: {video.numberOfComments()}");
        }
        foreach (Comment comment in Video.comment)
        {
            Console.WriteLine($"  {comment._name}: {comment._text}");
        }
    }
}