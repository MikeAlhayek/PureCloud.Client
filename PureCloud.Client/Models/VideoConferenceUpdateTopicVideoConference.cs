using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// VideoConferenceUpdateTopicVideoConference
/// </summary>

public partial class VideoConferenceUpdateTopicVideoConference : IEquatable<VideoConferenceUpdateTopicVideoConference>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VideoConferenceUpdateTopicVideoConference" /> class.
    /// </summary>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="ConferenceId">ConferenceId.</param>
    /// <param name="ParticipantInfo">ParticipantInfo.</param>
    public VideoConferenceUpdateTopicVideoConference(Guid? ConversationId = null, string ConferenceId = null, VideoConferenceUpdateTopicParticipantInfo ParticipantInfo = null)
    {
        this.ConversationId = ConversationId;
        this.ConferenceId = ConferenceId;
        this.ParticipantInfo = ParticipantInfo;

    }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [JsonPropertyName("conversationId")]
    public Guid? ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets ConferenceId
    /// </summary>
    [JsonPropertyName("conferenceId")]
    public string ConferenceId { get; set; }



    /// <summary>
    /// Gets or Sets ParticipantInfo
    /// </summary>
    [JsonPropertyName("participantInfo")]
    public VideoConferenceUpdateTopicParticipantInfo ParticipantInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VideoConferenceUpdateTopicVideoConference {\n");

        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
        sb.Append("  ParticipantInfo: ").Append(ParticipantInfo).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as VideoConferenceUpdateTopicVideoConference);
    }

    /// <summary>
    /// Returns true if VideoConferenceUpdateTopicVideoConference instances are equal
    /// </summary>
    /// <param name="other">Instance of VideoConferenceUpdateTopicVideoConference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VideoConferenceUpdateTopicVideoConference other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                ConferenceId == other.ConferenceId ||
                ConferenceId != null &&
                ConferenceId.Equals(other.ConferenceId)
            ) &&
            (
                ParticipantInfo == other.ParticipantInfo ||
                ParticipantInfo != null &&
                ParticipantInfo.Equals(other.ParticipantInfo)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (ConferenceId != null)
            {
                hash = hash * 59 + ConferenceId.GetHashCode();
            }

            if (ParticipantInfo != null)
            {
                hash = hash * 59 + ParticipantInfo.GetHashCode();
            }

            return hash;
        }
    }
}
