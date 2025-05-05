using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationVideoEventTopicInternalMessage
/// </summary>

public partial class QueueConversationVideoEventTopicInternalMessage : IEquatable<QueueConversationVideoEventTopicInternalMessage>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    
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
        /// Enum Alerting for "alerting"
        /// </summary>
        [EnumMember(Value = "alerting")]
        Alerting,

        /// <summary>
        /// Enum Connected for "connected"
        /// </summary>
        [EnumMember(Value = "connected")]
        Connected,

        /// <summary>
        /// Enum Disconnected for "disconnected"
        /// </summary>
        [EnumMember(Value = "disconnected")]
        Disconnected
    }
    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    
    public enum InitialStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Alerting for "alerting"
        /// </summary>
        [EnumMember(Value = "alerting")]
        Alerting,

        /// <summary>
        /// Enum Connected for "connected"
        /// </summary>
        [EnumMember(Value = "connected")]
        Connected,

        /// <summary>
        /// Enum Disconnected for "disconnected"
        /// </summary>
        [EnumMember(Value = "disconnected")]
        Disconnected
    }
    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    
    public enum DisconnectTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Client for "client"
        /// </summary>
        [EnumMember(Value = "client")]
        Client,

        /// <summary>
        /// Enum System for "system"
        /// </summary>
        [EnumMember(Value = "system")]
        System,

        /// <summary>
        /// Enum Peer for "peer"
        /// </summary>
        [EnumMember(Value = "peer")]
        Peer,

        /// <summary>
        /// Enum Transfer for "transfer"
        /// </summary>
        [EnumMember(Value = "transfer")]
        Transfer
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    [JsonPropertyName("initialState")]
    public InitialStateEnum? InitialState { get; set; }
    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    [JsonPropertyName("disconnectType")]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicInternalMessage" /> class.
    /// </summary>
    /// <param name="Id">A globally unique identifier for this communication..</param>
    /// <param name="State">State.</param>
    /// <param name="InitialState">InitialState.</param>
    /// <param name="Provider">The source provider of the message..</param>
    /// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
    /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
    /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock..</param>
    /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock..</param>
    /// <param name="TargetUserId">The user ID for the participant on receiving side of the internal message conversation..</param>
    /// <param name="SourceUserId">The user ID for the participant on sending side of the internal message conversation..</param>
    /// <param name="ToAddress">Address and name data for a call endpoint..</param>
    /// <param name="FromAddress">Address and name data for a call endpoint..</param>
    /// <param name="Messages">The messages sent on this communication channel..</param>
    public QueueConversationVideoEventTopicInternalMessage(string Id = null, StateEnum? State = null, InitialStateEnum? InitialState = null, string Provider = null, string PeerId = null, DisconnectTypeEnum? DisconnectType = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, string TargetUserId = null, string SourceUserId = null, QueueConversationVideoEventTopicAddress ToAddress = null, QueueConversationVideoEventTopicAddress FromAddress = null, List<QueueConversationVideoEventTopicInternalMessageDetails> Messages = null)
    {
        this.Id = Id;
        this.State = State;
        this.InitialState = InitialState;
        this.Provider = Provider;
        this.PeerId = PeerId;
        this.DisconnectType = DisconnectType;
        this.ConnectedTime = ConnectedTime;
        this.DisconnectedTime = DisconnectedTime;
        this.TargetUserId = TargetUserId;
        this.SourceUserId = SourceUserId;
        this.ToAddress = ToAddress;
        this.FromAddress = FromAddress;
        this.Messages = Messages;

    }



    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }







    /// <summary>
    /// The source provider of the message.
    /// </summary>
    /// <value>The source provider of the message.</value>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }



    /// <summary>
    /// The id of the peer communication corresponding to a matching leg for this communication.
    /// </summary>
    /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
    [JsonPropertyName("peerId")]
    public string PeerId { get; set; }





    /// <summary>
    /// The timestamp when this communication was connected in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication was connected in the cloud clock.</value>
    [JsonPropertyName("connectedTime")]
    public DateTime? ConnectedTime { get; set; }



    /// <summary>
    /// The timestamp when this communication disconnected from the conversation in the provider clock.
    /// </summary>
    /// <value>The timestamp when this communication disconnected from the conversation in the provider clock.</value>
    [JsonPropertyName("disconnectedTime")]
    public DateTime? DisconnectedTime { get; set; }



    /// <summary>
    /// The user ID for the participant on receiving side of the internal message conversation.
    /// </summary>
    /// <value>The user ID for the participant on receiving side of the internal message conversation.</value>
    [JsonPropertyName("targetUserId")]
    public string TargetUserId { get; set; }



    /// <summary>
    /// The user ID for the participant on sending side of the internal message conversation.
    /// </summary>
    /// <value>The user ID for the participant on sending side of the internal message conversation.</value>
    [JsonPropertyName("sourceUserId")]
    public string SourceUserId { get; set; }



    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    [JsonPropertyName("toAddress")]
    public QueueConversationVideoEventTopicAddress ToAddress { get; set; }



    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    [JsonPropertyName("fromAddress")]
    public QueueConversationVideoEventTopicAddress FromAddress { get; set; }



    /// <summary>
    /// The messages sent on this communication channel.
    /// </summary>
    /// <value>The messages sent on this communication channel.</value>
    [JsonPropertyName("messages")]
    public List<QueueConversationVideoEventTopicInternalMessageDetails> Messages { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationVideoEventTopicInternalMessage {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  InitialState: ").Append(InitialState).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
        sb.Append("  TargetUserId: ").Append(TargetUserId).Append("\n");
        sb.Append("  SourceUserId: ").Append(SourceUserId).Append("\n");
        sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
        sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
        sb.Append("  Messages: ").Append(Messages).Append("\n");
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
        return Equals(obj as QueueConversationVideoEventTopicInternalMessage);
    }

    /// <summary>
    /// Returns true if QueueConversationVideoEventTopicInternalMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationVideoEventTopicInternalMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationVideoEventTopicInternalMessage other)
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
                InitialState == other.InitialState ||
                InitialState != null &&
                InitialState.Equals(other.InitialState)
            ) &&
            (
                Provider == other.Provider ||
                Provider != null &&
                Provider.Equals(other.Provider)
            ) &&
            (
                PeerId == other.PeerId ||
                PeerId != null &&
                PeerId.Equals(other.PeerId)
            ) &&
            (
                DisconnectType == other.DisconnectType ||
                DisconnectType != null &&
                DisconnectType.Equals(other.DisconnectType)
            ) &&
            (
                ConnectedTime == other.ConnectedTime ||
                ConnectedTime != null &&
                ConnectedTime.Equals(other.ConnectedTime)
            ) &&
            (
                DisconnectedTime == other.DisconnectedTime ||
                DisconnectedTime != null &&
                DisconnectedTime.Equals(other.DisconnectedTime)
            ) &&
            (
                TargetUserId == other.TargetUserId ||
                TargetUserId != null &&
                TargetUserId.Equals(other.TargetUserId)
            ) &&
            (
                SourceUserId == other.SourceUserId ||
                SourceUserId != null &&
                SourceUserId.Equals(other.SourceUserId)
            ) &&
            (
                ToAddress == other.ToAddress ||
                ToAddress != null &&
                ToAddress.Equals(other.ToAddress)
            ) &&
            (
                FromAddress == other.FromAddress ||
                FromAddress != null &&
                FromAddress.Equals(other.FromAddress)
            ) &&
            (
                Messages == other.Messages ||
                Messages != null &&
                Messages.SequenceEqual(other.Messages)
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

            if (InitialState != null)
            {
                hash = hash * 59 + InitialState.GetHashCode();
            }

            if (Provider != null)
            {
                hash = hash * 59 + Provider.GetHashCode();
            }

            if (PeerId != null)
            {
                hash = hash * 59 + PeerId.GetHashCode();
            }

            if (DisconnectType != null)
            {
                hash = hash * 59 + DisconnectType.GetHashCode();
            }

            if (ConnectedTime != null)
            {
                hash = hash * 59 + ConnectedTime.GetHashCode();
            }

            if (DisconnectedTime != null)
            {
                hash = hash * 59 + DisconnectedTime.GetHashCode();
            }

            if (TargetUserId != null)
            {
                hash = hash * 59 + TargetUserId.GetHashCode();
            }

            if (SourceUserId != null)
            {
                hash = hash * 59 + SourceUserId.GetHashCode();
            }

            if (ToAddress != null)
            {
                hash = hash * 59 + ToAddress.GetHashCode();
            }

            if (FromAddress != null)
            {
                hash = hash * 59 + FromAddress.GetHashCode();
            }

            if (Messages != null)
            {
                hash = hash * 59 + Messages.GetHashCode();
            }

            return hash;
        }
    }
}
