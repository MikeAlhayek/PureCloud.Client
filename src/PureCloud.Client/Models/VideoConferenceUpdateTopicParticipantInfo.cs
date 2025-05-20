using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class VideoConferenceUpdateTopicParticipantInfo
{
    /// <summary>
    /// Gets or Sets ActiveParticipantCount
    /// </summary>
    public long? ActiveParticipantCount { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public long? Version { get; set; }
}
