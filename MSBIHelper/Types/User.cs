namespace MSBIHelper.Types;

public struct User
{
    public string Name { get; }
    public string YoutubeId { get; }
    public bool IsSubscriber { get; }
    public bool IsModerator { get; }
    public bool IsMember { get; }
    public bool IsBroadcaster { get; }

    public User(string name, string youtubeId, bool isSub, bool isMod, bool isMember, bool isBroadcaster)
    {
        Name = name;
        YoutubeId = youtubeId;
        IsSubscriber = isSub;
        IsModerator = isMod;
        IsMember = isMember;
        IsBroadcaster = isBroadcaster;
    }
}