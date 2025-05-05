using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationBasic
/// </summary>

public partial class ConversationBasic : IEquatable<ConversationBasic>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationBasic" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationBasic() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationBasic" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ExternalTag">The external tag associated with the conversation..</param>
    /// <param name="StartTime">The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="EndTime">The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Divisions">Identifiers of divisions associated with this conversation.</param>
    /// <param name="SecurePause">True when the recording of this conversation is in secure pause status..</param>
    /// <param name="UtilizationLabelId">An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level.</param>
    public ConversationBasic(string Name = null, string ExternalTag = null, DateTime? StartTime = null, DateTime? EndTime = null, List<ConversationDivisionMembership> Divisions = null, bool? SecurePause = null, string UtilizationLabelId = null)
    {
        this.Name = Name;
        this.ExternalTag = ExternalTag;
        this.StartTime = StartTime;
        this.EndTime = EndTime;
        this.Divisions = Divisions;
        this.SecurePause = SecurePause;
        this.UtilizationLabelId = UtilizationLabelId;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The external tag associated with the conversation.
    /// </summary>
    /// <value>The external tag associated with the conversation.</value>
    [JsonPropertyName("externalTag")]
    public string ExternalTag { get; set; }



    /// <summary>
    /// The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }



    /// <summary>
    /// The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("endTime")]
    public DateTime? EndTime { get; set; }



    /// <summary>
    /// Identifiers of divisions associated with this conversation
    /// </summary>
    /// <value>Identifiers of divisions associated with this conversation</value>
    [JsonPropertyName("divisions")]
    public List<ConversationDivisionMembership> Divisions { get; set; }



    /// <summary>
    /// True when the recording of this conversation is in secure pause status.
    /// </summary>
    /// <value>True when the recording of this conversation is in secure pause status.</value>
    [JsonPropertyName("securePause")]
    public bool? SecurePause { get; set; }



    /// <summary>
    /// An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level
    /// </summary>
    /// <value>An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level</value>
    [JsonPropertyName("utilizationLabelId")]
    public string UtilizationLabelId { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }



    /// <summary>
    /// Gets or Sets Participants
    /// </summary>
    [JsonPropertyName("participants")]
    public List<ParticipantBasic> Participants { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationBasic {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
        sb.Append("  EndTime: ").Append(EndTime).Append("\n");
        sb.Append("  Divisions: ").Append(Divisions).Append("\n");
        sb.Append("  SecurePause: ").Append(SecurePause).Append("\n");
        sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as ConversationBasic);
    }

    /// <summary>
    /// Returns true if ConversationBasic instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationBasic to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationBasic other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ExternalTag == other.ExternalTag ||
                ExternalTag != null &&
                ExternalTag.Equals(other.ExternalTag)
            ) &&
            (
                StartTime == other.StartTime ||
                StartTime != null &&
                StartTime.Equals(other.StartTime)
            ) &&
            (
                EndTime == other.EndTime ||
                EndTime != null &&
                EndTime.Equals(other.EndTime)
            ) &&
            (
                Divisions == other.Divisions ||
                Divisions != null &&
                Divisions.SequenceEqual(other.Divisions)
            ) &&
            (
                SecurePause == other.SecurePause ||
                SecurePause != null &&
                SecurePause.Equals(other.SecurePause)
            ) &&
            (
                UtilizationLabelId == other.UtilizationLabelId ||
                UtilizationLabelId != null &&
                UtilizationLabelId.Equals(other.UtilizationLabelId)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ExternalTag != null)
            {
                hash = hash * 59 + ExternalTag.GetHashCode();
            }

            if (StartTime != null)
            {
                hash = hash * 59 + StartTime.GetHashCode();
            }

            if (EndTime != null)
            {
                hash = hash * 59 + EndTime.GetHashCode();
            }

            if (Divisions != null)
            {
                hash = hash * 59 + Divisions.GetHashCode();
            }

            if (SecurePause != null)
            {
                hash = hash * 59 + SecurePause.GetHashCode();
            }

            if (UtilizationLabelId != null)
            {
                hash = hash * 59 + UtilizationLabelId.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Participants != null)
            {
                hash = hash * 59 + Participants.GetHashCode();
            }

            return hash;
        }
    }
}
