public class Comment
{
    

    public string _name {get; set;}
    public string _text {get; set;}
    public static object Count { get; internal set; }

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
    
    
}