namespace MSBIHelper.Types.Payload;

public abstract class AbstractPayload
{
    public Message.EType Type { get; protected set; }
    public byte[]? BearerToken { get; protected set; }
    public long Timestamp { get; protected set; }
}