using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RecordingArchiveRestoreTopicRecording
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets FileState
    /// </summary>
    public string FileState { get; set; }

    /// <summary>
    /// Gets or Sets MediaUris
    /// </summary>
    public IEnumerable<RecordingArchiveRestoreTopicMediaResult> MediaUris { get; set; }

    /// <summary>
    /// Gets or Sets EstimatedTranscodeTimeMs
    /// </summary>
    public long? EstimatedTranscodeTimeMs { get; set; }

    /// <summary>
    /// Gets or Sets ActualTranscodeTimeMs
    /// </summary>
    public long? ActualTranscodeTimeMs { get; set; }
}
