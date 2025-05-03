using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationCallEventTopicCallConversation
/// </summary>

public partial class QueueConversationCallEventTopicCallConversation : IEquatable<QueueConversationCallEventTopicCallConversation>
{
    /// <summary>
    /// Gets or Sets RecordingState
    /// </summary>
    
    public enum RecordingStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Enum Active for "active"
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Enum Paused for "paused"
        /// </summary>
        [EnumMember(Value = "paused")]
        Paused
    }
    /// <summary>
    /// Gets or Sets RecordingState
    /// </summary>
    [JsonPropertyName("recordingState")]
    public RecordingStateEnum? RecordingState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationCallEventTopicCallConversation" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Participants">Participants.</param>
    /// <param name="OtherMediaUris">OtherMediaUris.</param>
    /// <param name="Address">Address.</param>
    /// <param name="UtilizationLabelId">UtilizationLabelId.</param>
    /// <param name="Divisions">Divisions.</param>
    /// <param name="RecordingState">RecordingState.</param>
    /// <param name="SecurePause">SecurePause.</param>
    /// <param name="MaxParticipants">MaxParticipants.</param>
    public QueueConversationCallEventTopicCallConversation(string Id = null, string Name = null, List<QueueConversationCallEventTopicCallMediaParticipant> Participants = null, List<string> OtherMediaUris = null, string Address = null, string UtilizationLabelId = null, List<QueueConversationCallEventTopicConversationDivisionMembership> Divisions = null, RecordingStateEnum? RecordingState = null, bool? SecurePause = null, long? MaxParticipants = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Participants = Participants;
        this.OtherMediaUris = OtherMediaUris;
        this.Address = Address;
        this.UtilizationLabelId = UtilizationLabelId;
        this.Divisions = Divisions;
        this.RecordingState = RecordingState;
        this.SecurePause = SecurePause;
        this.MaxParticipants = MaxParticipants;

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
    public List<QueueConversationCallEventTopicCallMediaParticipant> Participants { get; set; }



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
    public List<QueueConversationCallEventTopicConversationDivisionMembership> Divisions { get; set; }





    /// <summary>
    /// Gets or Sets SecurePause
    /// </summary>
    [JsonPropertyName("securePause")]
    public bool? SecurePause { get; set; }



    /// <summary>
    /// Gets or Sets MaxParticipants
    /// </summary>
    [JsonPropertyName("maxParticipants")]
    public long? MaxParticipants { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationCallEventTopicCallConversation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Participants: ").Append(Participants).Append("\n");
        sb.Append("  OtherMediaUris: ").Append(OtherMediaUris).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  UtilizationLabelId: ").Append(UtilizationLabelId).Append("\n");
        sb.Append("  Divisions: ").Append(Divisions).Append("\n");
        sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
        sb.Append("  SecurePause: ").Append(SecurePause).Append("\n");
        sb.Append("  MaxParticipants: ").Append(MaxParticipants).Append("\n");
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
        return Equals(obj as QueueConversationCallEventTopicCallConversation);
    }

    /// <summary>
    /// Returns true if QueueConversationCallEventTopicCallConversation instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationCallEventTopicCallConversation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationCallEventTopicCallConversation other)
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
            ) &&
            (
                RecordingState == other.RecordingState ||
                RecordingState != null &&
                RecordingState.Equals(other.RecordingState)
            ) &&
            (
                SecurePause == other.SecurePause ||
                SecurePause != null &&
                SecurePause.Equals(other.SecurePause)
            ) &&
            (
                MaxParticipants == other.MaxParticipants ||
                MaxParticipants != null &&
                MaxParticipants.Equals(other.MaxParticipants)
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

            if (RecordingState != null)
            {
                hash = hash * 59 + RecordingState.GetHashCode();
            }

            if (SecurePause != null)
            {
                hash = hash * 59 + SecurePause.GetHashCode();
            }

            if (MaxParticipants != null)
            {
                hash = hash * 59 + MaxParticipants.GetHashCode();
            }

            return hash;
        }
    }
}
