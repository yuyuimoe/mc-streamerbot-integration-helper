using MSBIHelper.Types.Message;

namespace MSBIHelper.Types.Payload;

public class ChatPayload : AbstractPayload
{
    public User UserInformation { get; }
    public List<Part> Parts { get; }


    public ChatPayload(User userInformation, List<Part> parts, long timestamp, byte[]? bearerToken = null)
    {
        Type = EType.CHAT;
        BearerToken = bearerToken;
        UserInformation = userInformation;
        Parts = parts;
        Timestamp = timestamp;
    }
}