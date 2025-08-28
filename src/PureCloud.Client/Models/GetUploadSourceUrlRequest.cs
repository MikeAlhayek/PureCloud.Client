namespace PureCloud.Client.Models;

/// <summary>
/// Get Upload Source URL Request
/// </summary>
public sealed class GetUploadSourceUrlRequest
{
    /// <summary>
    /// File name
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    /// Content type
    /// </summary>
    public string ContentType { get; set; }

    /// <summary>
    /// File size
    /// </summary>
    public long? FileSize { get; set; }
}