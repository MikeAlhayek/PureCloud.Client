using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AcknowledgeScreenRecordingRequest
/// </summary>

public partial class AcknowledgeScreenRecordingRequest : IEquatable<AcknowledgeScreenRecordingRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AcknowledgeScreenRecordingRequest" /> class.
    /// </summary>
    /// <param name="ParticipantJid">ParticipantJid.</param>
    /// <param name="RoomId">RoomId.</param>
    /// <param name="ConversationId">ConversationId.</param>
    public AcknowledgeScreenRecordingRequest(string ParticipantJid = null, string RoomId = null, string ConversationId = null)
    {
        this.ParticipantJid = ParticipantJid;
        this.RoomId = RoomId;
        this.ConversationId = ConversationId;

    }



    /// <summary>
    /// Gets or Sets ParticipantJid
    /// </summary>
    [JsonPropertyName("participantJid")]
    public string ParticipantJid { get; set; }



    /// <summary>
    /// Gets or Sets RoomId
    /// </summary>
    [JsonPropertyName("roomId")]
    public string RoomId { get; set; }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AcknowledgeScreenRecordingRequest {\n");

        sb.Append("  ParticipantJid: ").Append(ParticipantJid).Append("\n");
        sb.Append("  RoomId: ").Append(RoomId).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
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
        return Equals(obj as AcknowledgeScreenRecordingRequest);
    }

    /// <summary>
    /// Returns true if AcknowledgeScreenRecordingRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AcknowledgeScreenRecordingRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AcknowledgeScreenRecordingRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ParticipantJid == other.ParticipantJid ||
                ParticipantJid != null &&
                ParticipantJid.Equals(other.ParticipantJid)
            ) &&
            (
                RoomId == other.RoomId ||
                RoomId != null &&
                RoomId.Equals(other.RoomId)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
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
            if (ParticipantJid != null)
            {
                hash = hash * 59 + ParticipantJid.GetHashCode();
            }

            if (RoomId != null)
            {
                hash = hash * 59 + RoomId.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            return hash;
        }
    }
}
