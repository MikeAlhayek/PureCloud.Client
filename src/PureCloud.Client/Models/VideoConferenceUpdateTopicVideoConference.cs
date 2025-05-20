using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class VideoConferenceUpdateTopicVideoConference
{
    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public Guid? ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets ConferenceId
    /// </summary>
    public string ConferenceId { get; set; }

    /// <summary>
    /// Gets or Sets ParticipantInfo
    /// </summary>
    public VideoConferenceUpdateTopicParticipantInfo ParticipantInfo { get; set; }
}
