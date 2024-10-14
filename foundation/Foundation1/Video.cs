using System;

public class Video
{
    internal static IEnumerable<Comment> comment;

    // internal object title;
    // internal object author;

    public string Title {get; set;}
    public string Author {get; set;}
    public int Length {get; set;}
    public List<Comment> Comments {get; set;}
    public Video(string title, string author, int lengthPerSec)
    {
        Title = title;
        Author = author;
        Length = lengthPerSec;
        Comments = new List<Comment>();
    }
    public int numberOfComments()
    {
        return Comments.Count;
    }
}