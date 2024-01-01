using Fetcher.Entities;

namespace Fetcher.Clients.Chat;

public delegate void CommentHandler(List<Comment> comments);

public abstract class ChatClient
{
    public event CommentHandler? OnCommentReceived;

    protected void InvokeOnCommentReceived(List<Comment> comments)
    {
        if (OnCommentReceived == null) return;
        OnCommentReceived(comments);
    }

    public abstract Task ListenAsync();
}
