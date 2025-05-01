using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignInteraction
/// </summary>
[DataContract]
public partial class CampaignInteraction : IEquatable<CampaignInteraction>
{
    /// <summary>
    /// Describes what happened with call analysis for instance: disposition.classification.callable.person, disposition.classification.callable.noanswer
    /// </summary>
    /// <value>Describes what happened with call analysis for instance: disposition.classification.callable.person, disposition.classification.callable.noanswer</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DispositionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Disconnect for "DISCONNECT"
        /// </summary>
        [EnumMember(Value = "DISCONNECT")]
        Disconnect,

        /// <summary>
        /// Enum LiveVoice for "LIVE_VOICE"
        /// </summary>
        [EnumMember(Value = "LIVE_VOICE")]
        LiveVoice,

        /// <summary>
        /// Enum Busy for "BUSY"
        /// </summary>
        [EnumMember(Value = "BUSY")]
        Busy,

        /// <summary>
        /// Enum Machine for "MACHINE"
        /// </summary>
        [EnumMember(Value = "MACHINE")]
        Machine,

        /// <summary>
        /// Enum NoAnswer for "NO_ANSWER"
        /// </summary>
        [EnumMember(Value = "NO_ANSWER")]
        NoAnswer,

        /// <summary>
        /// Enum SitCallable for "SIT_CALLABLE"
        /// </summary>
        [EnumMember(Value = "SIT_CALLABLE")]
        SitCallable,

        /// <summary>
        /// Enum SitUncallable for "SIT_UNCALLABLE"
        /// </summary>
        [EnumMember(Value = "SIT_UNCALLABLE")]
        SitUncallable,

        /// <summary>
        /// Enum Fax for "FAX"
        /// </summary>
        [EnumMember(Value = "FAX")]
        Fax
    }
    /// <summary>
    /// Describes what happened with call analysis for instance: disposition.classification.callable.person, disposition.classification.callable.noanswer
    /// </summary>
    /// <value>Describes what happened with call analysis for instance: disposition.classification.callable.person, disposition.classification.callable.noanswer</value>
    [DataMember(Name = "disposition", EmitDefaultValue = false)]
    public DispositionEnum? Disposition { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignInteraction" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Campaign">Campaign.</param>
    /// <param name="Agent">Agent.</param>
    /// <param name="Contact">Contact.</param>
    /// <param name="DestinationAddress">DestinationAddress.</param>
    /// <param name="ActivePreviewCall">Boolean value if there is an active preview call on the interaction.</param>
    /// <param name="LastActivePreviewWrapupTime">The time when the last preview of the interaction was wrapped up. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreationTime">The time when dialer created the interaction. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CallPlacedTime">The time when the agent or system places the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CallRoutedTime">The time when the agent was connected to the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="PreviewConnectedTime">The time when the customer and routing participant are connected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Queue">Queue.</param>
    /// <param name="Script">Script.</param>
    /// <param name="Disposition">Describes what happened with call analysis for instance: disposition.classification.callable.person, disposition.classification.callable.noanswer.</param>
    /// <param name="CallerName">CallerName.</param>
    /// <param name="CallerAddress">CallerAddress.</param>
    /// <param name="PreviewPopDeliveredTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Conversation">Conversation.</param>
    /// <param name="DialerSystemParticipantId">conversation participant id that is the dialer system participant to monitor the call from dialer perspective.</param>
    /// <param name="DialingMode">DialingMode.</param>
    /// <param name="Skills">Any skills that are attached to the call for routing.</param>
    public CampaignInteraction(string Id = null, DomainEntityRef Campaign = null, DomainEntityRef Agent = null, DomainEntityRef Contact = null, string DestinationAddress = null, bool? ActivePreviewCall = null, DateTime? LastActivePreviewWrapupTime = null, DateTime? CreationTime = null, DateTime? CallPlacedTime = null, DateTime? CallRoutedTime = null, DateTime? PreviewConnectedTime = null, DomainEntityRef Queue = null, DomainEntityRef Script = null, DispositionEnum? Disposition = null, string CallerName = null, string CallerAddress = null, DateTime? PreviewPopDeliveredTime = null, ConversationBasic Conversation = null, string DialerSystemParticipantId = null, string DialingMode = null, List<DomainEntityRef> Skills = null)
    {
        this.Id = Id;
        this.Campaign = Campaign;
        this.Agent = Agent;
        this.Contact = Contact;
        this.DestinationAddress = DestinationAddress;
        this.ActivePreviewCall = ActivePreviewCall;
        this.LastActivePreviewWrapupTime = LastActivePreviewWrapupTime;
        this.CreationTime = CreationTime;
        this.CallPlacedTime = CallPlacedTime;
        this.CallRoutedTime = CallRoutedTime;
        this.PreviewConnectedTime = PreviewConnectedTime;
        this.Queue = Queue;
        this.Script = Script;
        this.Disposition = Disposition;
        this.CallerName = CallerName;
        this.CallerAddress = CallerAddress;
        this.PreviewPopDeliveredTime = PreviewPopDeliveredTime;
        this.Conversation = Conversation;
        this.DialerSystemParticipantId = DialerSystemParticipantId;
        this.DialingMode = DialingMode;
        this.Skills = Skills;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Campaign
    /// </summary>
    [DataMember(Name = "campaign", EmitDefaultValue = false)]
    public DomainEntityRef Campaign { get; set; }



    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    [DataMember(Name = "agent", EmitDefaultValue = false)]
    public DomainEntityRef Agent { get; set; }



    /// <summary>
    /// Gets or Sets Contact
    /// </summary>
    [DataMember(Name = "contact", EmitDefaultValue = false)]
    public DomainEntityRef Contact { get; set; }



    /// <summary>
    /// Gets or Sets DestinationAddress
    /// </summary>
    [DataMember(Name = "destinationAddress", EmitDefaultValue = false)]
    public string DestinationAddress { get; set; }



    /// <summary>
    /// Boolean value if there is an active preview call on the interaction
    /// </summary>
    /// <value>Boolean value if there is an active preview call on the interaction</value>
    [DataMember(Name = "activePreviewCall", EmitDefaultValue = false)]
    public bool? ActivePreviewCall { get; set; }



    /// <summary>
    /// The time when the last preview of the interaction was wrapped up. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the last preview of the interaction was wrapped up. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "lastActivePreviewWrapupTime", EmitDefaultValue = false)]
    public DateTime? LastActivePreviewWrapupTime { get; set; }



    /// <summary>
    /// The time when dialer created the interaction. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when dialer created the interaction. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "creationTime", EmitDefaultValue = false)]
    public DateTime? CreationTime { get; set; }



    /// <summary>
    /// The time when the agent or system places the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the agent or system places the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "callPlacedTime", EmitDefaultValue = false)]
    public DateTime? CallPlacedTime { get; set; }



    /// <summary>
    /// The time when the agent was connected to the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the agent was connected to the call. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "callRoutedTime", EmitDefaultValue = false)]
    public DateTime? CallRoutedTime { get; set; }



    /// <summary>
    /// The time when the customer and routing participant are connected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when the customer and routing participant are connected. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "previewConnectedTime", EmitDefaultValue = false)]
    public DateTime? PreviewConnectedTime { get; set; }



    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    [DataMember(Name = "queue", EmitDefaultValue = false)]
    public DomainEntityRef Queue { get; set; }



    /// <summary>
    /// Gets or Sets Script
    /// </summary>
    [DataMember(Name = "script", EmitDefaultValue = false)]
    public DomainEntityRef Script { get; set; }





    /// <summary>
    /// Gets or Sets CallerName
    /// </summary>
    [DataMember(Name = "callerName", EmitDefaultValue = false)]
    public string CallerName { get; set; }



    /// <summary>
    /// Gets or Sets CallerAddress
    /// </summary>
    [DataMember(Name = "callerAddress", EmitDefaultValue = false)]
    public string CallerAddress { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "previewPopDeliveredTime", EmitDefaultValue = false)]
    public DateTime? PreviewPopDeliveredTime { get; set; }



    /// <summary>
    /// Gets or Sets Conversation
    /// </summary>
    [DataMember(Name = "conversation", EmitDefaultValue = false)]
    public ConversationBasic Conversation { get; set; }



    /// <summary>
    /// conversation participant id that is the dialer system participant to monitor the call from dialer perspective
    /// </summary>
    /// <value>conversation participant id that is the dialer system participant to monitor the call from dialer perspective</value>
    [DataMember(Name = "dialerSystemParticipantId", EmitDefaultValue = false)]
    public string DialerSystemParticipantId { get; set; }



    /// <summary>
    /// Gets or Sets DialingMode
    /// </summary>
    [DataMember(Name = "dialingMode", EmitDefaultValue = false)]
    public string DialingMode { get; set; }



    /// <summary>
    /// Any skills that are attached to the call for routing
    /// </summary>
    /// <value>Any skills that are attached to the call for routing</value>
    [DataMember(Name = "skills", EmitDefaultValue = false)]
    public List<DomainEntityRef> Skills { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignInteraction {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Campaign: ").Append(Campaign).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  Contact: ").Append(Contact).Append("\n");
        sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
        sb.Append("  ActivePreviewCall: ").Append(ActivePreviewCall).Append("\n");
        sb.Append("  LastActivePreviewWrapupTime: ").Append(LastActivePreviewWrapupTime).Append("\n");
        sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
        sb.Append("  CallPlacedTime: ").Append(CallPlacedTime).Append("\n");
        sb.Append("  CallRoutedTime: ").Append(CallRoutedTime).Append("\n");
        sb.Append("  PreviewConnectedTime: ").Append(PreviewConnectedTime).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  Script: ").Append(Script).Append("\n");
        sb.Append("  Disposition: ").Append(Disposition).Append("\n");
        sb.Append("  CallerName: ").Append(CallerName).Append("\n");
        sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
        sb.Append("  PreviewPopDeliveredTime: ").Append(PreviewPopDeliveredTime).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  DialerSystemParticipantId: ").Append(DialerSystemParticipantId).Append("\n");
        sb.Append("  DialingMode: ").Append(DialingMode).Append("\n");
        sb.Append("  Skills: ").Append(Skills).Append("\n");
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
        return Equals(obj as CampaignInteraction);
    }

    /// <summary>
    /// Returns true if CampaignInteraction instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignInteraction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignInteraction other)
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
                Campaign == other.Campaign ||
                Campaign != null &&
                Campaign.Equals(other.Campaign)
            ) &&
            (
                Agent == other.Agent ||
                Agent != null &&
                Agent.Equals(other.Agent)
            ) &&
            (
                Contact == other.Contact ||
                Contact != null &&
                Contact.Equals(other.Contact)
            ) &&
            (
                DestinationAddress == other.DestinationAddress ||
                DestinationAddress != null &&
                DestinationAddress.Equals(other.DestinationAddress)
            ) &&
            (
                ActivePreviewCall == other.ActivePreviewCall ||
                ActivePreviewCall != null &&
                ActivePreviewCall.Equals(other.ActivePreviewCall)
            ) &&
            (
                LastActivePreviewWrapupTime == other.LastActivePreviewWrapupTime ||
                LastActivePreviewWrapupTime != null &&
                LastActivePreviewWrapupTime.Equals(other.LastActivePreviewWrapupTime)
            ) &&
            (
                CreationTime == other.CreationTime ||
                CreationTime != null &&
                CreationTime.Equals(other.CreationTime)
            ) &&
            (
                CallPlacedTime == other.CallPlacedTime ||
                CallPlacedTime != null &&
                CallPlacedTime.Equals(other.CallPlacedTime)
            ) &&
            (
                CallRoutedTime == other.CallRoutedTime ||
                CallRoutedTime != null &&
                CallRoutedTime.Equals(other.CallRoutedTime)
            ) &&
            (
                PreviewConnectedTime == other.PreviewConnectedTime ||
                PreviewConnectedTime != null &&
                PreviewConnectedTime.Equals(other.PreviewConnectedTime)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                Script == other.Script ||
                Script != null &&
                Script.Equals(other.Script)
            ) &&
            (
                Disposition == other.Disposition ||
                Disposition != null &&
                Disposition.Equals(other.Disposition)
            ) &&
            (
                CallerName == other.CallerName ||
                CallerName != null &&
                CallerName.Equals(other.CallerName)
            ) &&
            (
                CallerAddress == other.CallerAddress ||
                CallerAddress != null &&
                CallerAddress.Equals(other.CallerAddress)
            ) &&
            (
                PreviewPopDeliveredTime == other.PreviewPopDeliveredTime ||
                PreviewPopDeliveredTime != null &&
                PreviewPopDeliveredTime.Equals(other.PreviewPopDeliveredTime)
            ) &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                DialerSystemParticipantId == other.DialerSystemParticipantId ||
                DialerSystemParticipantId != null &&
                DialerSystemParticipantId.Equals(other.DialerSystemParticipantId)
            ) &&
            (
                DialingMode == other.DialingMode ||
                DialingMode != null &&
                DialingMode.Equals(other.DialingMode)
            ) &&
            (
                Skills == other.Skills ||
                Skills != null &&
                Skills.SequenceEqual(other.Skills)
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

            if (Campaign != null)
            {
                hash = hash * 59 + Campaign.GetHashCode();
            }

            if (Agent != null)
            {
                hash = hash * 59 + Agent.GetHashCode();
            }

            if (Contact != null)
            {
                hash = hash * 59 + Contact.GetHashCode();
            }

            if (DestinationAddress != null)
            {
                hash = hash * 59 + DestinationAddress.GetHashCode();
            }

            if (ActivePreviewCall != null)
            {
                hash = hash * 59 + ActivePreviewCall.GetHashCode();
            }

            if (LastActivePreviewWrapupTime != null)
            {
                hash = hash * 59 + LastActivePreviewWrapupTime.GetHashCode();
            }

            if (CreationTime != null)
            {
                hash = hash * 59 + CreationTime.GetHashCode();
            }

            if (CallPlacedTime != null)
            {
                hash = hash * 59 + CallPlacedTime.GetHashCode();
            }

            if (CallRoutedTime != null)
            {
                hash = hash * 59 + CallRoutedTime.GetHashCode();
            }

            if (PreviewConnectedTime != null)
            {
                hash = hash * 59 + PreviewConnectedTime.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (Script != null)
            {
                hash = hash * 59 + Script.GetHashCode();
            }

            if (Disposition != null)
            {
                hash = hash * 59 + Disposition.GetHashCode();
            }

            if (CallerName != null)
            {
                hash = hash * 59 + CallerName.GetHashCode();
            }

            if (CallerAddress != null)
            {
                hash = hash * 59 + CallerAddress.GetHashCode();
            }

            if (PreviewPopDeliveredTime != null)
            {
                hash = hash * 59 + PreviewPopDeliveredTime.GetHashCode();
            }

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (DialerSystemParticipantId != null)
            {
                hash = hash * 59 + DialerSystemParticipantId.GetHashCode();
            }

            if (DialingMode != null)
            {
                hash = hash * 59 + DialingMode.GetHashCode();
            }

            if (Skills != null)
            {
                hash = hash * 59 + Skills.GetHashCode();
            }

            return hash;
        }
    }
}
