using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RoomParticipantsResponse
/// </summary>

public partial class RoomParticipantsResponse : IEquatable<RoomParticipantsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RoomParticipantsResponse" /> class.
    /// </summary>
    /// <param name="Participants">list of room participants.</param>
    public RoomParticipantsResponse(List<RoomParticipantResponse> Participants = null)
    {
        this.Participants = Participants;

    }



    /// <summary>
    /// list of room participants
    /// </summary>
    /// <value>list of room participants</value>
    [JsonPropertyName("participants")]
    public List<RoomParticipantResponse> Participants { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RoomParticipantsResponse {\n");

        sb.Append("  Participants: ").Append(Participants).Append("\n");
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
        return Equals(obj as RoomParticipantsResponse);
    }

    /// <summary>
    /// Returns true if RoomParticipantsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of RoomParticipantsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RoomParticipantsResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Participants == other.Participants ||
                Participants != null &&
                Participants.SequenceEqual(other.Participants)
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
            if (Participants != null)
            {
                hash = hash * 59 + Participants.GetHashCode();
            }

            return hash;
        }
    }
}
