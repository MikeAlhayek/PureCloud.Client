using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConsultTransferResponse
/// </summary>

public partial class ConsultTransferResponse : IEquatable<ConsultTransferResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ConsultTransferResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConsultTransferResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConsultTransferResponse" /> class.
    /// </summary>
    /// <param name="DestinationParticipantId">Participant ID to whom the call is being transferred. (required).</param>
    public ConsultTransferResponse(string DestinationParticipantId = null)
    {
        this.DestinationParticipantId = DestinationParticipantId;

    }



    /// <summary>
    /// Participant ID to whom the call is being transferred.
    /// </summary>
    /// <value>Participant ID to whom the call is being transferred.</value>
    [JsonPropertyName("destinationParticipantId")]
    public string DestinationParticipantId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConsultTransferResponse {\n");

        sb.Append("  DestinationParticipantId: ").Append(DestinationParticipantId).Append("\n");
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
        return Equals(obj as ConsultTransferResponse);
    }

    /// <summary>
    /// Returns true if ConsultTransferResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ConsultTransferResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConsultTransferResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DestinationParticipantId == other.DestinationParticipantId ||
                DestinationParticipantId != null &&
                DestinationParticipantId.Equals(other.DestinationParticipantId)
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
            if (DestinationParticipantId != null)
            {
                hash = hash * 59 + DestinationParticipantId.GetHashCode();
            }

            return hash;
        }
    }
}
