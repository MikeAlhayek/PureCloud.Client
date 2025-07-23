namespace PureCloud.Client.Models;

/// <summary>
/// MediaResult
/// </summary>
public sealed class MediaResult
{
    /// <summary>
    /// Gets or Sets MediaUri
    /// </summary>
    public string MediaUri { get; set; }

    /// <summary>
    /// Gets or Sets WaveformData
    /// </summary>
    public IEnumerable<float?> WaveformData { get; set; }
}