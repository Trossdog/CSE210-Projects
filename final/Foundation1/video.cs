

public class Video
{
    private string _title;
    private string _creator;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string creator, int lenghtInSeconds)
    {
        _title = title;
        _creator = creator;
        _lengthInSeconds = lenghtInSeconds;
        _comments = new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetCreator()
    {
        return _creator;
    }

    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }

    public void AddComment(string commenter, string commentText)
    {
        Comment comment = new Comment(commenter, commentText);
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetAllComments()
    {
        return _comments;
    }

}