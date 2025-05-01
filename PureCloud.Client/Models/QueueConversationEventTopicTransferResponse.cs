using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationEventTopicTransferResponse
/// </summary>
[DataContract]
public partial class QueueConversationEventTopicTransferResponse : IEquatable<QueueConversationEventTopicTransferResponse>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pending for "pending"
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// Enum Active for "active"
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Enum Complete for "complete"
        /// </summary>
        [EnumMember(Value = "complete")]
        Complete,

        /// <summary>
        /// Enum Canceled for "canceled"
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled,

        /// <summary>
        /// Enum Failed for "failed"
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,

        /// <summary>
        /// Enum Timeout for "timeout"
        /// </summary>
        [EnumMember(Value = "timeout")]
        Timeout,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown
    }
    /// <summary>
    /// The type of transfer to perform.
    /// </summary>
    /// <value>The type of transfer to perform.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TransferTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Attended for "attended"
        /// </summary>
        [EnumMember(Value = "attended")]
        Attended,

        /// <summary>
        /// Enum Unattended for "unattended"
        /// </summary>
        [EnumMember(Value = "unattended")]
        Unattended
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// The type of transfer to perform.
    /// </summary>
    /// <value>The type of transfer to perform.</value>
    [DataMember(Name = "transferType", EmitDefaultValue = false)]
    public TransferTypeEnum? TransferType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationEventTopicTransferResponse" /> class.
    /// </summary>
    /// <param name="Id">The id of the command..</param>
    /// <param name="State">State.</param>
    /// <param name="DateIssued">The date/time that this command was issued..</param>
    /// <param name="Initiator">Initiator.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    /// <param name="Destination">Destination.</param>
    /// <param name="TransferType">The type of transfer to perform..</param>
    public QueueConversationEventTopicTransferResponse(string Id = null, StateEnum? State = null, DateTime? DateIssued = null, QueueConversationEventTopicTransferInitiator Initiator = null, QueueConversationEventTopicTransferModifedBy ModifiedBy = null, QueueConversationEventTopicTransferDestination Destination = null, TransferTypeEnum? TransferType = null)
    {
        this.Id = Id;
        this.State = State;
        this.DateIssued = DateIssued;
        this.Initiator = Initiator;
        this.ModifiedBy = ModifiedBy;
        this.Destination = Destination;
        this.TransferType = TransferType;

    }



    /// <summary>
    /// The id of the command.
    /// </summary>
    /// <value>The id of the command.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }





    /// <summary>
    /// The date/time that this command was issued.
    /// </summary>
    /// <value>The date/time that this command was issued.</value>
    [DataMember(Name = "dateIssued", EmitDefaultValue = false)]
    public DateTime? DateIssued { get; set; }



    /// <summary>
    /// Gets or Sets Initiator
    /// </summary>
    [DataMember(Name = "initiator", EmitDefaultValue = false)]
    public QueueConversationEventTopicTransferInitiator Initiator { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public QueueConversationEventTopicTransferModifedBy ModifiedBy { get; set; }



    /// <summary>
    /// Gets or Sets Destination
    /// </summary>
    [DataMember(Name = "destination", EmitDefaultValue = false)]
    public QueueConversationEventTopicTransferDestination Destination { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationEventTopicTransferResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  DateIssued: ").Append(DateIssued).Append("\n");
        sb.Append("  Initiator: ").Append(Initiator).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  Destination: ").Append(Destination).Append("\n");
        sb.Append("  TransferType: ").Append(TransferType).Append("\n");
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
        return Equals(obj as QueueConversationEventTopicTransferResponse);
    }

    /// <summary>
    /// Returns true if QueueConversationEventTopicTransferResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationEventTopicTransferResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationEventTopicTransferResponse other)
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
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                DateIssued == other.DateIssued ||
                DateIssued != null &&
                DateIssued.Equals(other.DateIssued)
            ) &&
            (
                Initiator == other.Initiator ||
                Initiator != null &&
                Initiator.Equals(other.Initiator)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                Destination == other.Destination ||
                Destination != null &&
                Destination.Equals(other.Destination)
            ) &&
            (
                TransferType == other.TransferType ||
                TransferType != null &&
                TransferType.Equals(other.TransferType)
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

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (DateIssued != null)
            {
                hash = hash * 59 + DateIssued.GetHashCode();
            }

            if (Initiator != null)
            {
                hash = hash * 59 + Initiator.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (Destination != null)
            {
                hash = hash * 59 + Destination.GetHashCode();
            }

            if (TransferType != null)
            {
                hash = hash * 59 + TransferType.GetHashCode();
            }

            return hash;
        }
    }
}
