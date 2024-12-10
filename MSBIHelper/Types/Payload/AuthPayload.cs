using MSBIHelper.Types.Message;

namespace MSBIHelper.Types.Payload;

public class AuthPayload : AbstractPayload
{
    public AuthPayload(long timestamp, byte[]? bearerToken = null)
    {
        Type = EType.AUTH;
        BearerToken = bearerToken;
        Timestamp = timestamp;
    }
}