using System;

public class Video
{
    private string _title {get; set;}
    private string _author {get; set;}
    private int _length {get; set;}
    public List<Comment> _comments {get; set;}
    public Video(string title, string author, int lengthPerSec)
    {
        _title = title;
        _author = author;
        _length = lengthPerSec;
        _comments = new List<Comment>();
    }
    public numberOfComments()
    {
        return _comments.Count;
    }
}