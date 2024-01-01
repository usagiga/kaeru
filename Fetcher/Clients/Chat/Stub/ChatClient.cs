using Fetcher.Entities;

namespace Fetcher.Clients.Chat.Stub;

public class ChatClient : Fetcher.Clients.Chat.ChatClient
{
    private async IAsyncEnumerable<List<RawComment>> GenerateCommentsAsync()
    {
        while (true)
        {
            yield return [RawComment.GenerateRandomComment()];
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
        // ReSharper disable once IteratorNeverReturns
    }

    public override async Task ListenAsync()
    {
        var rawCommentGenerator = GenerateCommentsAsync();
        await foreach (var rawComment in rawCommentGenerator)
        {
            InvokeOnCommentReceived((
                from c in rawComment
                select c.Cast()
            ).ToList());
        }
    }
}
