using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationEventTopicConversation
/// </summary>
[DataContract]
public partial class ConversationEventTopicConversation : IEquatable<ConversationEventTopicConversation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationEventTopicConversation" /> class.
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
    public ConversationEventTopicConversation(string Id = null, long? MaxParticipants = null, List<ConversationEventTopicParticipant> Participants = null, List<ConversationEventTopicTransferResponse> RecentTransfers = null, string RecordingState = null, string Address = null, string ExternalTag = null, string UtilizationLabelId = null, bool? SecurePause = null, List<ConversationEventTopicConversationDivisionMembership> Divisions = null)
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
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets MaxParticipants
    /// </summary>
    [DataMember(Name = "maxParticipants", EmitDefaultValue = false)]
    public long? MaxParticipants { get; set; }



    /// <summary>
    /// Gets or Sets Participants
    /// </summary>
    [DataMember(Name = "participants", EmitDefaultValue = false)]
    public List<ConversationEventTopicParticipant> Participants { get; set; }



    /// <summary>
    /// Gets or Sets RecentTransfers
    /// </summary>
    [DataMember(Name = "recentTransfers", EmitDefaultValue = false)]
    public List<ConversationEventTopicTransferResponse> RecentTransfers { get; set; }



    /// <summary>
    /// Gets or Sets RecordingState
    /// </summary>
    [DataMember(Name = "recordingState", EmitDefaultValue = false)]
    public string RecordingState { get; set; }



    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public string Address { get; set; }



    /// <summary>
    /// Gets or Sets ExternalTag
    /// </summary>
    [DataMember(Name = "externalTag", EmitDefaultValue = false)]
    public string ExternalTag { get; set; }



    /// <summary>
    /// Gets or Sets UtilizationLabelId
    /// </summary>
    [DataMember(Name = "utilizationLabelId", EmitDefaultValue = false)]
    public string UtilizationLabelId { get; set; }



    /// <summary>
    /// Gets or Sets SecurePause
    /// </summary>
    [DataMember(Name = "securePause", EmitDefaultValue = false)]
    public bool? SecurePause { get; set; }



    /// <summary>
    /// Gets or Sets Divisions
    /// </summary>
    [DataMember(Name = "divisions", EmitDefaultValue = false)]
    public List<ConversationEventTopicConversationDivisionMembership> Divisions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationEventTopicConversation {\n");

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
        return Equals(obj as ConversationEventTopicConversation);
    }

    /// <summary>
    /// Returns true if ConversationEventTopicConversation instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationEventTopicConversation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationEventTopicConversation other)
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
