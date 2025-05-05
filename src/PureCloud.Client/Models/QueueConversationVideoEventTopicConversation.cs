using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationVideoEventTopicConversation
/// </summary>

public partial class QueueConversationVideoEventTopicConversation : IEquatable<QueueConversationVideoEventTopicConversation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicConversation" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="MaxParticipants">MaxParticipants.</param>
    /// <param name="Participants">Participants.</param>
    /// <param name="RecentTransfers">RecentTransfers.</param>
    /// <param name="RecordingState">RecordingState.</param>
    /// <param name="Address">Address.</param>
    /// <param name="ExternalTag">ExternalTag.</param>
    /// <param name="UtilizationLabelId">UtilizationLabelId.</param>
    /// <param name="SecurePause">SecurePause.</param>
    /// <param name="Divisions">Divisions.</param>
    public QueueConversationVideoEventTopicConversation(string Id = null, long? MaxParticipants = null, List<QueueConversationVideoEventTopicParticipant> Participants = null, List<QueueConversationVideoEventTopicTransferResponse> RecentTransfers = null, string RecordingState = null, string Address = null, string ExternalTag = null, string UtilizationLabelId = null, bool? SecurePause = null, List<QueueConversationVideoEventTopicConversationDivisionMembership> Divisions = null)
    {
        this.Id = Id;
        this.MaxParticipants = MaxParticipants;
        this.Participants = Participants;
        this.RecentTransfers = RecentTransfers;
        this.RecordingState = RecordingState;
        this.Address = Address;
        this.ExternalTag = ExternalTag;
        this.UtilizationLabelId = UtilizationLabelId;
        this.SecurePause = SecurePause;
        this.Divisions = Divisions;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets MaxParticipants
    /// </summary>
    [JsonPropertyName("maxParticipants")]
    public long? MaxParticipants { get; set; }



    /// <summary>
    /// Gets or Sets Participants
    /// </summary>
    [JsonPropertyName("participants")]
    public List<QueueConversationVideoEventTopicParticipant> Participants { get; set; }



    /// <summary>
    /// Gets or Sets RecentTransfers
    /// </summary>
    [JsonPropertyName("recentTransfers")]
    public List<QueueConversationVideoEventTopicTransferResponse> RecentTransfers { get; set; }



    /// <summary>
    /// Gets or Sets RecordingState
    /// </summary>
    [JsonPropertyName("recordingState")]
    public string RecordingState { get; set; }



    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [JsonPropertyName("address")]
    public string Address { get; set; }



    /// <summary>
    /// Gets or Sets ExternalTag
    /// </summary>
    [JsonPropertyName("externalTag")]
    public string ExternalTag { get; set; }



    /// <summary>
    /// Gets or Sets UtilizationLabelId
    /// </summary>
    [JsonPropertyName("utilizationLabelId")]
    public string UtilizationLabelId { get; set; }



    /// <summary>
    /// Gets or Sets SecurePause
    /// </summary>
    [JsonPropertyName("securePause")]
    public bool? SecurePause { get; set; }



    /// <summary>
    /// Gets or Sets Divisions
    /// </summary>
    [JsonPropertyName("divisions")]
    public List<QueueConversationVideoEventTopicConversationDivisionMembership> Divisions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationVideoEventTopicConversation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  MaxParticipants: ").Append(MaxParticipants).Append("\n");
        sb.Append("  Participants: ").Append(Participants).Append("\n");
        sb.Append("  RecentTransfers: ").Append(RecentTransfers).Append("\n");
        sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
        sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
        sb.Append("  SecurePause: ").Append(SecurePause).Append("\n");
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
        return Equals(obj as QueueConversationVideoEventTopicConversation);
    }

    /// <summary>
    /// Returns true if QueueConversationVideoEventTopicConversation instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationVideoEventTopicConversation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationVideoEventTopicConversation other)
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
                MaxParticipants == other.MaxParticipants ||
                MaxParticipants != null &&
                MaxParticipants.Equals(other.MaxParticipants)
            ) &&
            (
                Participants == other.Participants ||
                Participants != null &&
                Participants.SequenceEqual(other.Participants)
            ) &&
            (
                RecentTransfers == other.RecentTransfers ||
                RecentTransfers != null &&
                RecentTransfers.SequenceEqual(other.RecentTransfers)
            ) &&
            (
                RecordingState == other.RecordingState ||
                RecordingState != null &&
                RecordingState.Equals(other.RecordingState)
            ) &&
            (
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
            ) &&
            (
                ExternalTag == other.ExternalTag ||
                ExternalTag != null &&
                ExternalTag.Equals(other.ExternalTag)
            ) &&
            (
                UtilizationLabelId == other.UtilizationLabelId ||
                UtilizationLabelId != null &&
                UtilizationLabelId.Equals(other.UtilizationLabelId)
            ) &&
            (
                SecurePause == other.SecurePause ||
                SecurePause != null &&
                SecurePause.Equals(other.SecurePause)
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

            if (MaxParticipants != null)
            {
                hash = hash * 59 + MaxParticipants.GetHashCode();
            }

            if (Participants != null)
            {
                hash = hash * 59 + Participants.GetHashCode();
            }

            if (RecentTransfers != null)
            {
                hash = hash * 59 + RecentTransfers.GetHashCode();
            }

            if (RecordingState != null)
            {
                hash = hash * 59 + RecordingState.GetHashCode();
            }

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            if (ExternalTag != null)
            {
                hash = hash * 59 + ExternalTag.GetHashCode();
            }

            if (UtilizationLabelId != null)
            {
                hash = hash * 59 + UtilizationLabelId.GetHashCode();
            }

            if (SecurePause != null)
            {
                hash = hash * 59 + SecurePause.GetHashCode();
            }

            if (Divisions != null)
            {
                hash = hash * 59 + Divisions.GetHashCode();
            }

            return hash;
        }
    }
}
