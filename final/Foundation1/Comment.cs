

public class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string commenter, string comment)
    {
        _commenterName = commenter;
        _commentText = comment;
    }

    public string GetCommentersName()
    {
        return _commenterName;
    }

    public string GetCommentText()
    {
        return _commentText;
    }
}