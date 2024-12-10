namespace MSBIHelper.Types.Message;

public struct Emoji
{
    public string Name { get; }
    public string Text { get; }
    public string ImagePath { get; }
    public int StartIndex { get; }
    public int EndIndex { get; }

    public Emoji(string name, string text, string imagePath, int startIndex, int endIndex)
    {
        Name = name;
        Text = text;
        ImagePath = imagePath;
        StartIndex = startIndex;
        EndIndex = endIndex;
    }
}