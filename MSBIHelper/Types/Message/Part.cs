namespace MSBIHelper.Types.Message;

public struct Part
{
    public string Text { get; }
    public Emoji? Emoji { get; }

    public Part(string text, Emoji? emoji = null)
    {
        Text = text;
        Emoji = emoji;
    }
}