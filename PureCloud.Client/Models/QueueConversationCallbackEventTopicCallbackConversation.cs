using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationCallbackEventTopicCallbackConversation
/// </summary>

public partial class QueueConversationCallbackEventTopicCallbackConversation : IEquatable<QueueConversationCallbackEventTopicCallbackConversation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationCallbackEventTopicCallbackConversation" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Participants">Participants.</param>
    /// <param name="OtherMediaUris">OtherMediaUris.</param>
    /// <param name="Address">Address.</param>
    /// <param name="UtilizationLabelId">UtilizationLabelId.</param>
    /// <param name="Divisions">Divisions.</param>
    public QueueConversationCallbackEventTopicCallbackConversation(string Id = null, string Name = null, List<QueueConversationCallbackEventTopicCallbackMediaParticipant> Participants = null, List<string> OtherMediaUris = null, string Address = null, string UtilizationLabelId = null, List<QueueConversationCallbackEventTopicConversationDivisionMembership> Divisions = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Participants = Participants;
        this.OtherMediaUris = OtherMediaUris;
        this.Address = Address;
        this.UtilizationLabelId = UtilizationLabelId;
        this.Divisions = Divisions;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Participants
    /// </summary>
    [JsonPropertyName("participants")]
    public List<QueueConversationCallbackEventTopicCallbackMediaParticipant> Participants { get; set; }



    /// <summary>
    /// Gets or Sets OtherMediaUris
    /// </summary>
    [JsonPropertyName("otherMediaUris")]
    public List<string> OtherMediaUris { get; set; }



    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [JsonPropertyName("address")]
    public string Address { get; set; }



    /// <summary>
    /// Gets or Sets UtilizationLabelId
    /// </summary>
    [JsonPropertyName("utilizationLabelId")]
    public string UtilizationLabelId { get; set; }



    /// <summary>
    /// Gets or Sets Divisions
    /// </summary>
    [JsonPropertyName("divisions")]
    public List<QueueConversationCallbackEventTopicConversationDivisionMembership> Divisions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationCallbackEventTopicCallbackConversation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Participants: ").Append(Participants).Append("\n");
        sb.Append("  OtherMediaUris: ").Append(OtherMediaUris).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
        sb.Append("  Divisions: ").Append(Divisions).Append("\n");
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
        return Equals(obj as QueueConversationCallbackEventTopicCallbackConversation);
    }

    /// <summary>
    /// Returns true if QueueConversationCallbackEventTopicCallbackConversation instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationCallbackEventTopicCallbackConversation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationCallbackEventTopicCallbackConversation other)
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
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
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

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            if (UtilizationLabelId != null)
            {
                hash = hash * 59 + UtilizationLabelId.GetHashCode();
            }

            if (Divisions != null)
            {
                hash = hash * 59 + Divisions.GetHashCode();
            }

            return hash;
        }
    }
}
