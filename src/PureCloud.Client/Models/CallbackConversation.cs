using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallbackConversation
/// </summary>

public partial class CallbackConversation : IEquatable<CallbackConversation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CallbackConversation" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Participants">The list of participants involved in the conversation..</param>
    /// <param name="OtherMediaUris">The list of other media channels involved in the conversation..</param>
    /// <param name="RecentTransfers">The list of the most recent 20 transfer commands applied to this conversation..</param>
    /// <param name="UtilizationLabelId">An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level.</param>
    /// <param name="Divisions">Identifiers of divisions associated with this conversation..</param>
    public CallbackConversation(string Name = null, List<CallbackMediaParticipant> Participants = null, List<string> OtherMediaUris = null, List<TransferResponse> RecentTransfers = null, string UtilizationLabelId = null, List<ConversationDivisionMembership> Divisions = null)
    {
        this.Name = Name;
        this.Participants = Participants;
        this.OtherMediaUris = OtherMediaUris;
        this.RecentTransfers = RecentTransfers;
        this.UtilizationLabelId = UtilizationLabelId;
        this.Divisions = Divisions;

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
    /// The list of participants involved in the conversation.
    /// </summary>
    /// <value>The list of participants involved in the conversation.</value>
    [JsonPropertyName("participants")]
    public List<CallbackMediaParticipant> Participants { get; set; }



    /// <summary>
    /// The list of other media channels involved in the conversation.
    /// </summary>
    /// <value>The list of other media channels involved in the conversation.</value>
    [JsonPropertyName("otherMediaUris")]
    public List<string> OtherMediaUris { get; set; }



    /// <summary>
    /// The list of the most recent 20 transfer commands applied to this conversation.
    /// </summary>
    /// <value>The list of the most recent 20 transfer commands applied to this conversation.</value>
    [JsonPropertyName("recentTransfers")]
    public List<TransferResponse> RecentTransfers { get; set; }



    /// <summary>
    /// An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level
    /// </summary>
    /// <value>An optional label that categorizes the conversation.  Max-utilization settings can be configured at a per-label level</value>
    [JsonPropertyName("utilizationLabelId")]
    public string UtilizationLabelId { get; set; }



    /// <summary>
    /// Identifiers of divisions associated with this conversation.
    /// </summary>
    /// <value>Identifiers of divisions associated with this conversation.</value>
    [JsonPropertyName("divisions")]
    public List<ConversationDivisionMembership> Divisions { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallbackConversation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Participants: ").Append(Participants).Append("\n");
        sb.Append("  OtherMediaUris: ").Append(OtherMediaUris).Append("\n");
        sb.Append("  RecentTransfers: ").Append(RecentTransfers).Append("\n");
        sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
        sb.Append("  Divisions: ").Append(Divisions).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as CallbackConversation);
    }

    /// <summary>
    /// Returns true if CallbackConversation instances are equal
    /// </summary>
    /// <param name="other">Instance of CallbackConversation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallbackConversation other)
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
                Participants == other.Participants ||
                Participants != null &&
                Participants.SequenceEqual(other.Participants)
            ) &&
            (
                OtherMediaUris == other.OtherMediaUris ||
                OtherMediaUris != null &&
                OtherMediaUris.SequenceEqual(other.OtherMediaUris)
            ) &&
            (
                RecentTransfers == other.RecentTransfers ||
                RecentTransfers != null &&
                RecentTransfers.SequenceEqual(other.RecentTransfers)
            ) &&
            (
                UtilizationLabelId == other.UtilizationLabelId ||
                UtilizationLabelId != null &&
                UtilizationLabelId.Equals(other.UtilizationLabelId)
            ) &&
            (
                Divisions == other.Divisions ||
                Divisions != null &&
                Divisions.SequenceEqual(other.Divisions)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Participants != null)
            {
                hash = hash * 59 + Participants.GetHashCode();
            }

            if (OtherMediaUris != null)
            {
                hash = hash * 59 + OtherMediaUris.GetHashCode();
            }

            if (RecentTransfers != null)
            {
                hash = hash * 59 + RecentTransfers.GetHashCode();
            }

            if (UtilizationLabelId != null)
            {
                hash = hash * 59 + UtilizationLabelId.GetHashCode();
            }

            if (Divisions != null)
            {
                hash = hash * 59 + Divisions.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
