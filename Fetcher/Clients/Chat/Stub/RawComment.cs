using Fetcher.Entities;

namespace Fetcher.Clients.Chat.Stub;

class RawComment
{
    public string Name;
    public string Body;

    private static readonly List<string> StubBodies = [
        "きょうも天気で私も元気、ありがたい！",
        "パンツって見せるものじゃなくないですか？",
        "ちょろいね",
    ];

    private static readonly List<string> StubNames =
    [
        "ちさと",
        "たきな",
        "クルミ"
    ];

    private static readonly Random Randomizer = new Random();

    internal static RawComment GenerateRandomComment()
    {
        var bodyIdx = Randomizer.Next(0, 2);
        var userIdx = Randomizer.Next(0, 2);
        return new RawComment()
        {
            Body = StubBodies[bodyIdx],
            Name = StubNames[userIdx],
        };
    }

    public Comment Cast()
    {
        return new Comment()
        {
            Name = Name,
            Body = Body,
        };
    }
}
