using Newtonsoft.Json;

namespace MSBIHelper.Types;
[JsonObject(MemberSerialization.OptIn)]
public struct User
{
    [JsonProperty]
    public string Name { get; }
    [JsonProperty]
    public string YoutubeId { get; }
    [JsonProperty]
    public bool IsSubscriber { get; }
    [JsonProperty]
    public bool IsModerator { get; }
    [JsonProperty]
    public bool IsMember { get; }
    [JsonProperty]
    public bool IsBroadcaster { get; }
    [JsonConstructor]
    public User(string name, string youtubeId, bool isSubscriber, bool isModerator, bool isMember, bool isBroadcaster)
    {
        Name = name;
        YoutubeId = youtubeId;
        IsSubscriber = isSubscriber;
        IsModerator = isModerator;
        IsMember = isMember;
        IsBroadcaster = isBroadcaster;
    }
}