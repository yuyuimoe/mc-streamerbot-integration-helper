using System.IO.Compression;
using System.Text;

namespace MSBIHelper.Utils;

public static class StringExtensions
{
    public static byte[] CompressGZip(this string data)
    {
        byte[] byteArray = Encoding.UTF8.GetBytes(data);
        using MemoryStream memoryStream = new MemoryStream();
        using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionLevel.Optimal))
        {
            gzipStream.Write(byteArray, 0, byteArray.Length);
        }

        return memoryStream.ToArray();
    }

    public static byte[] ToSha256(this string data) => System.Security.Cryptography.SHA256.Create()
        .ComputeHash(Encoding.UTF8.GetBytes(data)).ToArray();
}