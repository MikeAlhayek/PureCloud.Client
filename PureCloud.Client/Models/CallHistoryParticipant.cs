using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallHistoryParticipant
/// </summary>

public partial class CallHistoryParticipant : IEquatable<CallHistoryParticipant>
{
    /// <summary>
    /// The participant's direction.  Values can be: 'inbound' or 'outbound'
    /// </summary>
    /// <value>The participant's direction.  Values can be: 'inbound' or 'outbound'</value>
    
    public enum DirectionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Inbound for "inbound"
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound,

        /// <summary>
        /// Enum Outbound for "outbound"
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound
    }
    /// <summary>
    /// The reason the participant was disconnected from the conversation.
    /// </summary>
    /// <value>The reason the participant was disconnected from the conversation.</value>
    
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
        /// Enum Endpoint for "endpoint"
        /// </summary>
        [EnumMember(Value = "endpoint")]
        Endpoint,

        /// <summary>
        /// Enum Endpointdonotdisturb for "endpoint.donotdisturb"
        /// </summary>
        [EnumMember(Value = "endpoint.donotdisturb")]
        Endpointdonotdisturb,

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
        /// Enum Transfer for "transfer"
        /// </summary>
        [EnumMember(Value = "transfer")]
        Transfer,

        /// <summary>
        /// Enum Transferconference for "transfer.conference"
        /// </summary>
        [EnumMember(Value = "transfer.conference")]
        Transferconference,

        /// <summary>
        /// Enum Transferconsult for "transfer.consult"
        /// </summary>
        [EnumMember(Value = "transfer.consult")]
        Transferconsult,

        /// <summary>
        /// Enum Transferdonotdisturb for "transfer.donotdisturb"
        /// </summary>
        [EnumMember(Value = "transfer.donotdisturb")]
        Transferdonotdisturb,

        /// <summary>
        /// Enum Transferforward for "transfer.forward"
        /// </summary>
        [EnumMember(Value = "transfer.forward")]
        Transferforward,

        /// <summary>
        /// Enum Transfernoanswer for "transfer.noanswer"
        /// </summary>
        [EnumMember(Value = "transfer.noanswer")]
        Transfernoanswer,

        /// <summary>
        /// Enum Transfernotavailable for "transfer.notavailable"
        /// </summary>
        [EnumMember(Value = "transfer.notavailable")]
        Transfernotavailable,

        /// <summary>
        /// Enum Transportfailure for "transport.failure"
        /// </summary>
        [EnumMember(Value = "transport.failure")]
        Transportfailure,

        /// <summary>
        /// Enum Error for "error"
        /// </summary>
        [EnumMember(Value = "error")]
        Error,

        /// <summary>
        /// Enum Peer for "peer"
        /// </summary>
        [EnumMember(Value = "peer")]
        Peer,

        /// <summary>
        /// Enum Other for "other"
        /// </summary>
        [EnumMember(Value = "other")]
        Other,

        /// <summary>
        /// Enum Spam for "spam"
        /// </summary>
        [EnumMember(Value = "spam")]
        Spam
    }
    /// <summary>
    /// The reason specifying why participant flagged the conversation.
    /// </summary>
    /// <value>The reason specifying why participant flagged the conversation.</value>
    
    public enum FlaggedReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum General for "general"
        /// </summary>
        [EnumMember(Value = "general")]
        General
    }
    /// <summary>
    /// The participant's direction.  Values can be: 'inbound' or 'outbound'
    /// </summary>
    /// <value>The participant's direction.  Values can be: 'inbound' or 'outbound'</value>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// The reason the participant was disconnected from the conversation.
    /// </summary>
    /// <value>The reason the participant was disconnected from the conversation.</value>
    [JsonPropertyName("disconnectType")]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// The reason specifying why participant flagged the conversation.
    /// </summary>
    /// <value>The reason specifying why participant flagged the conversation.</value>
    [JsonPropertyName("flaggedReason")]
    public FlaggedReasonEnum? FlaggedReason { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CallHistoryParticipant" /> class.
    /// </summary>
    /// <param name="Id">The unique participant ID..</param>
    /// <param name="Name">The display friendly name of the participant..</param>
    /// <param name="Address">The participant address..</param>
    /// <param name="StartTime">The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndTime">The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Purpose">The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr.</param>
    /// <param name="Direction">The participant&#39;s direction.  Values can be: &#39;inbound&#39; or &#39;outbound&#39;.</param>
    /// <param name="Ani">The call ANI..</param>
    /// <param name="Dnis">The call DNIS..</param>
    /// <param name="User">The PureCloudEnvironment user for this participant..</param>
    /// <param name="Queue">The PureCloudEnvironment queue for this participant..</param>
    /// <param name="Group">The group involved in the group ring call..</param>
    /// <param name="DisconnectType">The reason the participant was disconnected from the conversation..</param>
    /// <param name="ExternalContact">The PureCloudEnvironment external contact.</param>
    /// <param name="ExternalOrganization">The PureCloudEnvironment external organization.</param>
    /// <param name="DidInteract">Indicates whether the contact ever connected.</param>
    /// <param name="SipResponseCodes">Indicates SIP Response codes associated with the participant.</param>
    /// <param name="FlaggedReason">The reason specifying why participant flagged the conversation..</param>
    /// <param name="OutboundCampaign">The outbound campaign associated with the participant.</param>
    public CallHistoryParticipant(string Id = null, string Name = null, string Address = null, DateTime? StartTime = null, DateTime? EndTime = null, string Purpose = null, DirectionEnum? Direction = null, string Ani = null, string Dnis = null, User User = null, Queue Queue = null, Group Group = null, DisconnectTypeEnum? DisconnectType = null, ExternalContact ExternalContact = null, ExternalOrganization ExternalOrganization = null, bool? DidInteract = null, List<long?> SipResponseCodes = null, FlaggedReasonEnum? FlaggedReason = null, Campaign OutboundCampaign = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Address = Address;
        this.StartTime = StartTime;
        this.EndTime = EndTime;
        this.Purpose = Purpose;
        this.Direction = Direction;
        this.Ani = Ani;
        this.Dnis = Dnis;
        this.User = User;
        this.Queue = Queue;
        this.Group = Group;
        this.DisconnectType = DisconnectType;
        this.ExternalContact = ExternalContact;
        this.ExternalOrganization = ExternalOrganization;
        this.DidInteract = DidInteract;
        this.SipResponseCodes = SipResponseCodes;
        this.FlaggedReason = FlaggedReason;
        this.OutboundCampaign = OutboundCampaign;

    }



    /// <summary>
    /// The unique participant ID.
    /// </summary>
    /// <value>The unique participant ID.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The display friendly name of the participant.
    /// </summary>
    /// <value>The display friendly name of the participant.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The participant address.
    /// </summary>
    /// <value>The participant address.</value>
    [JsonPropertyName("address")]
    public string Address { get; set; }



    /// <summary>
    /// The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }



    /// <summary>
    /// The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("endTime")]
    public DateTime? EndTime { get; set; }



    /// <summary>
    /// The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr
    /// </summary>
    /// <value>The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr</value>
    [JsonPropertyName("purpose")]
    public string Purpose { get; set; }





    /// <summary>
    /// The call ANI.
    /// </summary>
    /// <value>The call ANI.</value>
    [JsonPropertyName("ani")]
    public string Ani { get; set; }



    /// <summary>
    /// The call DNIS.
    /// </summary>
    /// <value>The call DNIS.</value>
    [JsonPropertyName("dnis")]
    public string Dnis { get; set; }



    /// <summary>
    /// The PureCloudEnvironment user for this participant.
    /// </summary>
    /// <value>The PureCloudEnvironment user for this participant.</value>
    [JsonPropertyName("user")]
    public User User { get; set; }



    /// <summary>
    /// The PureCloudEnvironment queue for this participant.
    /// </summary>
    /// <value>The PureCloudEnvironment queue for this participant.</value>
    [JsonPropertyName("queue")]
    public Queue Queue { get; set; }



    /// <summary>
    /// The group involved in the group ring call.
    /// </summary>
    /// <value>The group involved in the group ring call.</value>
    [JsonPropertyName("group")]
    public Group Group { get; set; }





    /// <summary>
    /// The PureCloudEnvironment external contact
    /// </summary>
    /// <value>The PureCloudEnvironment external contact</value>
    [JsonPropertyName("externalContact")]
    public ExternalContact ExternalContact { get; set; }



    /// <summary>
    /// The PureCloudEnvironment external organization
    /// </summary>
    /// <value>The PureCloudEnvironment external organization</value>
    [JsonPropertyName("externalOrganization")]
    public ExternalOrganization ExternalOrganization { get; set; }



    /// <summary>
    /// Indicates whether the contact ever connected
    /// </summary>
    /// <value>Indicates whether the contact ever connected</value>
    [JsonPropertyName("didInteract")]
    public bool? DidInteract { get; set; }



    /// <summary>
    /// Indicates SIP Response codes associated with the participant
    /// </summary>
    /// <value>Indicates SIP Response codes associated with the participant</value>
    [JsonPropertyName("sipResponseCodes")]
    public List<long?> SipResponseCodes { get; set; }





    /// <summary>
    /// The outbound campaign associated with the participant
    /// </summary>
    /// <value>The outbound campaign associated with the participant</value>
    [JsonPropertyName("outboundCampaign")]
    public Campaign OutboundCampaign { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallHistoryParticipant {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
        sb.Append("  EndTime: ").Append(EndTime).Append("\n");
        sb.Append("  Purpose: ").Append(Purpose).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  Ani: ").Append(Ani).Append("\n");
        sb.Append("  Dnis: ").Append(Dnis).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
        sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
        sb.Append("  DidInteract: ").Append(DidInteract).Append("\n");
        sb.Append("  SipResponseCodes: ").Append(SipResponseCodes).Append("\n");
        sb.Append("  FlaggedReason: ").Append(FlaggedReason).Append("\n");
        sb.Append("  OutboundCampaign: ").Append(OutboundCampaign).Append("\n");
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
        return Equals(obj as CallHistoryParticipant);
    }

    /// <summary>
    /// Returns true if CallHistoryParticipant instances are equal
    /// </summary>
    /// <param name="other">Instance of CallHistoryParticipant to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallHistoryParticipant other)
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
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
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
                Purpose == other.Purpose ||
                Purpose != null &&
                Purpose.Equals(other.Purpose)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
            (
                Ani == other.Ani ||
                Ani != null &&
                Ani.Equals(other.Ani)
            ) &&
            (
                Dnis == other.Dnis ||
                Dnis != null &&
                Dnis.Equals(other.Dnis)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                Group == other.Group ||
                Group != null &&
                Group.Equals(other.Group)
            ) &&
            (
                DisconnectType == other.DisconnectType ||
                DisconnectType != null &&
                DisconnectType.Equals(other.DisconnectType)
            ) &&
            (
                ExternalContact == other.ExternalContact ||
                ExternalContact != null &&
                ExternalContact.Equals(other.ExternalContact)
            ) &&
            (
                ExternalOrganization == other.ExternalOrganization ||
                ExternalOrganization != null &&
                ExternalOrganization.Equals(other.ExternalOrganization)
            ) &&
            (
                DidInteract == other.DidInteract ||
                DidInteract != null &&
                DidInteract.Equals(other.DidInteract)
            ) &&
            (
                SipResponseCodes == other.SipResponseCodes ||
                SipResponseCodes != null &&
                SipResponseCodes.SequenceEqual(other.SipResponseCodes)
            ) &&
            (
                FlaggedReason == other.FlaggedReason ||
                FlaggedReason != null &&
                FlaggedReason.Equals(other.FlaggedReason)
            ) &&
            (
                OutboundCampaign == other.OutboundCampaign ||
                OutboundCampaign != null &&
                OutboundCampaign.Equals(other.OutboundCampaign)
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

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            if (StartTime != null)
            {
                hash = hash * 59 + StartTime.GetHashCode();
            }

            if (EndTime != null)
            {
                hash = hash * 59 + EndTime.GetHashCode();
            }

            if (Purpose != null)
            {
                hash = hash * 59 + Purpose.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (Ani != null)
            {
                hash = hash * 59 + Ani.GetHashCode();
            }

            if (Dnis != null)
            {
                hash = hash * 59 + Dnis.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (Group != null)
            {
                hash = hash * 59 + Group.GetHashCode();
            }

            if (DisconnectType != null)
            {
                hash = hash * 59 + DisconnectType.GetHashCode();
            }

            if (ExternalContact != null)
            {
                hash = hash * 59 + ExternalContact.GetHashCode();
            }

            if (ExternalOrganization != null)
            {
                hash = hash * 59 + ExternalOrganization.GetHashCode();
            }

            if (DidInteract != null)
            {
                hash = hash * 59 + DidInteract.GetHashCode();
            }

            if (SipResponseCodes != null)
            {
                hash = hash * 59 + SipResponseCodes.GetHashCode();
            }

            if (FlaggedReason != null)
            {
                hash = hash * 59 + FlaggedReason.GetHashCode();
            }

            if (OutboundCampaign != null)
            {
                hash = hash * 59 + OutboundCampaign.GetHashCode();
            }

            return hash;
        }
    }
}
