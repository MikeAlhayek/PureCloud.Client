using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// VideoConferenceDetails
/// </summary>
[DataContract]
public partial class VideoConferenceDetails : IEquatable<VideoConferenceDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VideoConferenceDetails" /> class.
    /// </summary>
    /// <param name="ConferenceId">The conferenceId..</param>
    /// <param name="ConversationId">The conversationId of the video conference..</param>
    /// <param name="ParticipantInfo">Information about the participants of the video conference..</param>
    public VideoConferenceDetails(string ConferenceId = null, string ConversationId = null, ParticipantInfo ParticipantInfo = null)
    {
        this.ConferenceId = ConferenceId;
        this.ConversationId = ConversationId;
        this.ParticipantInfo = ParticipantInfo;

    }



    /// <summary>
    /// The conferenceId.
    /// </summary>
    /// <value>The conferenceId.</value>
    [DataMember(Name = "conferenceId", EmitDefaultValue = false)]
    public string ConferenceId { get; set; }



    /// <summary>
    /// The conversationId of the video conference.
    /// </summary>
    /// <value>The conversationId of the video conference.</value>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// Information about the participants of the video conference.
    /// </summary>
    /// <value>Information about the participants of the video conference.</value>
    [DataMember(Name = "participantInfo", EmitDefaultValue = false)]
    public ParticipantInfo ParticipantInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VideoConferenceDetails {\n");

        sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
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
        return Equals(obj as VideoConferenceDetails);
    }

    /// <summary>
    /// Returns true if VideoConferenceDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of VideoConferenceDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VideoConferenceDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ConferenceId == other.ConferenceId ||
                ConferenceId != null &&
                ConferenceId.Equals(other.ConferenceId)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
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
            if (ConferenceId != null)
            {
                hash = hash * 59 + ConferenceId.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (ParticipantInfo != null)
            {
                hash = hash * 59 + ParticipantInfo.GetHashCode();
            }

            return hash;
        }
    }
}
