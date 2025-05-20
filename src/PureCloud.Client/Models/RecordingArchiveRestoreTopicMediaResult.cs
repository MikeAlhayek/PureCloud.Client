using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RecordingArchiveRestoreTopicMediaResult
{
    /// <summary>
    /// Gets or Sets ChannelId
    /// </summary>
    public string ChannelId { get; set; }

    /// <summary>
    /// Gets or Sets WaveUri
    /// </summary>
    public string WaveUri { get; set; }

    /// <summary>
    /// Gets or Sets MediaUri
    /// </summary>
    public string MediaUri { get; set; }

    /// <summary>
    /// Gets or Sets WaveformData
    /// </summary>
    public IEnumerable<double?> WaveformData { get; set; }
}
