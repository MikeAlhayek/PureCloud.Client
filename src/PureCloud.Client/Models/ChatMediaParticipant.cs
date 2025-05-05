using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatMediaParticipant
/// </summary>

public partial class ChatMediaParticipant : IEquatable<ChatMediaParticipant>
{
    /// <summary>
    /// The participant's state.  Values can be: 'alerting', 'connected', 'disconnected', 'dialing', 'contacting
    /// </summary>
    /// <value>The participant's state.  Values can be: 'alerting', 'connected', 'disconnected', 'dialing', 'contacting</value>
    
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
        /// Enum Dialing for "dialing"
        /// </summary>
        [EnumMember(Value = "dialing")]
        Dialing,

        /// <summary>
        /// Enum Contacting for "contacting"
        /// </summary>
        [EnumMember(Value = "contacting")]
        Contacting,

        /// <summary>
        /// Enum Offering for "offering"
        /// </summary>
        [EnumMember(Value = "offering")]
        Offering,

        /// <summary>
        /// Enum Connected for "connected"
        /// </summary>
        [EnumMember(Value = "connected")]
        Connected,

        /// <summary>
        /// Enum Disconnected for "disconnected"
        /// </summary>
        [EnumMember(Value = "disconnected")]
        Disconnected,

        /// <summary>
        /// Enum Terminated for "terminated"
        /// </summary>
        [EnumMember(Value = "terminated")]
        Terminated,

        /// <summary>
        /// Enum Converting for "converting"
        /// </summary>
        [EnumMember(Value = "converting")]
        Converting,

        /// <summary>
        /// Enum Uploading for "uploading"
        /// </summary>
        [EnumMember(Value = "uploading")]
        Uploading,

        /// <summary>
        /// Enum Transmitting for "transmitting"
        /// </summary>
        [EnumMember(Value = "transmitting")]
        Transmitting,

        /// <summary>
        /// Enum Parked for "parked"
        /// </summary>
        [EnumMember(Value = "parked")]
        Parked,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
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
    /// The participant's state.  Values can be: 'alerting', 'connected', 'disconnected', 'dialing', 'contacting
    /// </summary>
    /// <value>The participant's state.  Values can be: 'alerting', 'connected', 'disconnected', 'dialing', 'contacting</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
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
    /// Initializes a new instance of the <see cref="ChatMediaParticipant" /> class.
    /// </summary>
    /// <param name="Id">The unique participant ID..</param>
    /// <param name="Name">The display friendly name of the participant..</param>
    /// <param name="Address">The participant address..</param>
    /// <param name="StartTime">The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ConnectedTime">The time when this participant went connected for this media (eg: video connected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndTime">The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="StartHoldTime">The time when this participant&#39;s hold started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Purpose">The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr.</param>
    /// <param name="State">The participant&#39;s state.  Values can be: &#39;alerting&#39;, &#39;connected&#39;, &#39;disconnected&#39;, &#39;dialing&#39;, &#39;contacting.</param>
    /// <param name="Direction">The participant&#39;s direction.  Values can be: &#39;inbound&#39; or &#39;outbound&#39;.</param>
    /// <param name="DisconnectType">The reason the participant was disconnected from the conversation..</param>
    /// <param name="Held">Value is true when the participant is on hold..</param>
    /// <param name="WrapupRequired">Value is true when the participant requires wrap-up..</param>
    /// <param name="WrapupPrompt">The wrap-up prompt indicating the type of wrap-up to be performed..</param>
    /// <param name="MediaRoles">List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc.</param>
    /// <param name="User">The PureCloudEnvironment user for this participant..</param>
    /// <param name="Queue">The PureCloudEnvironment queue for this participant..</param>
    /// <param name="Team">The PureCloudEnvironment team for this participant..</param>
    /// <param name="Attributes">A list of ad-hoc attributes for the participant..</param>
    /// <param name="ErrorInfo">If the conversation ends in error, contains additional error details..</param>
    /// <param name="Script">The Engage script that should be used by this participant..</param>
    /// <param name="WrapupTimeoutMs">The amount of time the participant has to complete wrap-up..</param>
    /// <param name="WrapupSkipped">Value is true when the participant has skipped wrap-up..</param>
    /// <param name="AlertingTimeoutMs">Specifies how long the agent has to answer an interaction before being marked as not responding..</param>
    /// <param name="Provider">The source provider for the communication..</param>
    /// <param name="ExternalContact">If this participant represents an external contact, then this will be the reference for the external contact..</param>
    /// <param name="ExternalContactInitialDivisionId">If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned..</param>
    /// <param name="ExternalOrganization">If this participant represents an external org, then this will be the reference for the external org..</param>
    /// <param name="Wrapup">Wrapup for this participant, if it has been applied..</param>
    /// <param name="Peer">The peer communication corresponding to a matching leg for this communication..</param>
    /// <param name="FlaggedReason">The reason specifying why participant flagged the conversation..</param>
    /// <param name="JourneyContext">Journey System data/context that is applicable to this communication.  When used for historical purposes, the context should be immutable.  When null, there is no applicable Journey System context..</param>
    /// <param name="ConversationRoutingData">Information on how a communication should be routed to an agent..</param>
    /// <param name="StartAcwTime">The timestamp when this participant started after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndAcwTime">The timestamp when this participant ended after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ParkTime">The time when this participant&#39;s communication was last parked.  Does not reset on resume. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ResumeTime">The time when this participant&#39;s communications will resume. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="RoomId">The ID of the chat room..</param>
    /// <param name="AvatarImageUrl">If available, the URI to the avatar image of this communication..</param>
    public ChatMediaParticipant(string Id = null, string Name = null, string Address = null, DateTime? StartTime = null, DateTime? ConnectedTime = null, DateTime? EndTime = null, DateTime? StartHoldTime = null, string Purpose = null, StateEnum? State = null, DirectionEnum? Direction = null, DisconnectTypeEnum? DisconnectType = null, bool? Held = null, bool? WrapupRequired = null, string WrapupPrompt = null, List<string> MediaRoles = null, DomainEntityRef User = null, DomainEntityRef Queue = null, DomainEntityRef Team = null, Dictionary<string, string> Attributes = null, ErrorInfo ErrorInfo = null, DomainEntityRef Script = null, int? WrapupTimeoutMs = null, bool? WrapupSkipped = null, int? AlertingTimeoutMs = null, string Provider = null, DomainEntityRef ExternalContact = null, string ExternalContactInitialDivisionId = null, DomainEntityRef ExternalOrganization = null, Wrapup Wrapup = null, string Peer = null, FlaggedReasonEnum? FlaggedReason = null, JourneyContext JourneyContext = null, ConversationRoutingData ConversationRoutingData = null, DateTime? StartAcwTime = null, DateTime? EndAcwTime = null, DateTime? ParkTime = null, DateTime? ResumeTime = null, string RoomId = null, string AvatarImageUrl = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Address = Address;
        this.StartTime = StartTime;
        this.ConnectedTime = ConnectedTime;
        this.EndTime = EndTime;
        this.StartHoldTime = StartHoldTime;
        this.Purpose = Purpose;
        this.State = State;
        this.Direction = Direction;
        this.DisconnectType = DisconnectType;
        this.Held = Held;
        this.WrapupRequired = WrapupRequired;
        this.WrapupPrompt = WrapupPrompt;
        this.MediaRoles = MediaRoles;
        this.User = User;
        this.Queue = Queue;
        this.Team = Team;
        this.Attributes = Attributes;
        this.ErrorInfo = ErrorInfo;
        this.Script = Script;
        this.WrapupTimeoutMs = WrapupTimeoutMs;
        this.WrapupSkipped = WrapupSkipped;
        this.AlertingTimeoutMs = AlertingTimeoutMs;
        this.Provider = Provider;
        this.ExternalContact = ExternalContact;
        this.ExternalContactInitialDivisionId = ExternalContactInitialDivisionId;
        this.ExternalOrganization = ExternalOrganization;
        this.Wrapup = Wrapup;
        this.Peer = Peer;
        this.FlaggedReason = FlaggedReason;
        this.JourneyContext = JourneyContext;
        this.ConversationRoutingData = ConversationRoutingData;
        this.StartAcwTime = StartAcwTime;
        this.EndAcwTime = EndAcwTime;
        this.ParkTime = ParkTime;
        this.ResumeTime = ResumeTime;
        this.RoomId = RoomId;
        this.AvatarImageUrl = AvatarImageUrl;

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
    /// The time when this participant went connected for this media (eg: video connected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when this participant went connected for this media (eg: video connected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("connectedTime")]
    public DateTime? ConnectedTime { get; set; }



    /// <summary>
    /// The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("endTime")]
    public DateTime? EndTime { get; set; }



    /// <summary>
    /// The time when this participant&#39;s hold started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when this participant&#39;s hold started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startHoldTime")]
    public DateTime? StartHoldTime { get; set; }



    /// <summary>
    /// The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr
    /// </summary>
    /// <value>The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr</value>
    [JsonPropertyName("purpose")]
    public string Purpose { get; set; }









    /// <summary>
    /// Value is true when the participant is on hold.
    /// </summary>
    /// <value>Value is true when the participant is on hold.</value>
    [JsonPropertyName("held")]
    public bool? Held { get; set; }



    /// <summary>
    /// Value is true when the participant requires wrap-up.
    /// </summary>
    /// <value>Value is true when the participant requires wrap-up.</value>
    [JsonPropertyName("wrapupRequired")]
    public bool? WrapupRequired { get; set; }



    /// <summary>
    /// The wrap-up prompt indicating the type of wrap-up to be performed.
    /// </summary>
    /// <value>The wrap-up prompt indicating the type of wrap-up to be performed.</value>
    [JsonPropertyName("wrapupPrompt")]
    public string WrapupPrompt { get; set; }



    /// <summary>
    /// List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc
    /// </summary>
    /// <value>List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc</value>
    [JsonPropertyName("mediaRoles")]
    public List<string> MediaRoles { get; set; }



    /// <summary>
    /// The PureCloudEnvironment user for this participant.
    /// </summary>
    /// <value>The PureCloudEnvironment user for this participant.</value>
    [JsonPropertyName("user")]
    public DomainEntityRef User { get; set; }



    /// <summary>
    /// The PureCloudEnvironment queue for this participant.
    /// </summary>
    /// <value>The PureCloudEnvironment queue for this participant.</value>
    [JsonPropertyName("queue")]
    public DomainEntityRef Queue { get; set; }



    /// <summary>
    /// The PureCloudEnvironment team for this participant.
    /// </summary>
    /// <value>The PureCloudEnvironment team for this participant.</value>
    [JsonPropertyName("team")]
    public DomainEntityRef Team { get; set; }



    /// <summary>
    /// A list of ad-hoc attributes for the participant.
    /// </summary>
    /// <value>A list of ad-hoc attributes for the participant.</value>
    [JsonPropertyName("attributes")]
    public Dictionary<string, string> Attributes { get; set; }



    /// <summary>
    /// If the conversation ends in error, contains additional error details.
    /// </summary>
    /// <value>If the conversation ends in error, contains additional error details.</value>
    [JsonPropertyName("errorInfo")]
    public ErrorInfo ErrorInfo { get; set; }



    /// <summary>
    /// The Engage script that should be used by this participant.
    /// </summary>
    /// <value>The Engage script that should be used by this participant.</value>
    [JsonPropertyName("script")]
    public DomainEntityRef Script { get; set; }



    /// <summary>
    /// The amount of time the participant has to complete wrap-up.
    /// </summary>
    /// <value>The amount of time the participant has to complete wrap-up.</value>
    [JsonPropertyName("wrapupTimeoutMs")]
    public int? WrapupTimeoutMs { get; set; }



    /// <summary>
    /// Value is true when the participant has skipped wrap-up.
    /// </summary>
    /// <value>Value is true when the participant has skipped wrap-up.</value>
    [JsonPropertyName("wrapupSkipped")]
    public bool? WrapupSkipped { get; set; }



    /// <summary>
    /// Specifies how long the agent has to answer an interaction before being marked as not responding.
    /// </summary>
    /// <value>Specifies how long the agent has to answer an interaction before being marked as not responding.</value>
    [JsonPropertyName("alertingTimeoutMs")]
    public int? AlertingTimeoutMs { get; set; }



    /// <summary>
    /// The source provider for the communication.
    /// </summary>
    /// <value>The source provider for the communication.</value>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }



    /// <summary>
    /// If this participant represents an external contact, then this will be the reference for the external contact.
    /// </summary>
    /// <value>If this participant represents an external contact, then this will be the reference for the external contact.</value>
    [JsonPropertyName("externalContact")]
    public DomainEntityRef ExternalContact { get; set; }



    /// <summary>
    /// If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned.
    /// </summary>
    /// <value>If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned.</value>
    [JsonPropertyName("externalContactInitialDivisionId")]
    public string ExternalContactInitialDivisionId { get; set; }



    /// <summary>
    /// If this participant represents an external org, then this will be the reference for the external org.
    /// </summary>
    /// <value>If this participant represents an external org, then this will be the reference for the external org.</value>
    [JsonPropertyName("externalOrganization")]
    public DomainEntityRef ExternalOrganization { get; set; }



    /// <summary>
    /// Wrapup for this participant, if it has been applied.
    /// </summary>
    /// <value>Wrapup for this participant, if it has been applied.</value>
    [JsonPropertyName("wrapup")]
    public Wrapup Wrapup { get; set; }



    /// <summary>
    /// The peer communication corresponding to a matching leg for this communication.
    /// </summary>
    /// <value>The peer communication corresponding to a matching leg for this communication.</value>
    [JsonPropertyName("peer")]
    public string Peer { get; set; }





    /// <summary>
    /// Journey System data/context that is applicable to this communication.  When used for historical purposes, the context should be immutable.  When null, there is no applicable Journey System context.
    /// </summary>
    /// <value>Journey System data/context that is applicable to this communication.  When used for historical purposes, the context should be immutable.  When null, there is no applicable Journey System context.</value>
    [JsonPropertyName("journeyContext")]
    public JourneyContext JourneyContext { get; set; }



    /// <summary>
    /// Information on how a communication should be routed to an agent.
    /// </summary>
    /// <value>Information on how a communication should be routed to an agent.</value>
    [JsonPropertyName("conversationRoutingData")]
    public ConversationRoutingData ConversationRoutingData { get; set; }



    /// <summary>
    /// The timestamp when this participant started after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this participant started after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startAcwTime")]
    public DateTime? StartAcwTime { get; set; }



    /// <summary>
    /// The timestamp when this participant ended after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this participant ended after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("endAcwTime")]
    public DateTime? EndAcwTime { get; set; }



    /// <summary>
    /// The time when this participant&#39;s communication was last parked.  Does not reset on resume. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when this participant&#39;s communication was last parked.  Does not reset on resume. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("parkTime")]
    public DateTime? ParkTime { get; set; }



    /// <summary>
    /// The time when this participant&#39;s communications will resume. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time when this participant&#39;s communications will resume. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("resumeTime")]
    public DateTime? ResumeTime { get; set; }



    /// <summary>
    /// The ID of the chat room.
    /// </summary>
    /// <value>The ID of the chat room.</value>
    [JsonPropertyName("roomId")]
    public string RoomId { get; set; }



    /// <summary>
    /// If available, the URI to the avatar image of this communication.
    /// </summary>
    /// <value>If available, the URI to the avatar image of this communication.</value>
    [JsonPropertyName("avatarImageUrl")]
    public string AvatarImageUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChatMediaParticipant {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  EndTime: ").Append(EndTime).Append("\n");
        sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
        sb.Append("  Purpose: ").Append(Purpose).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  Held: ").Append(Held).Append("\n");
        sb.Append("  WrapupRequired: ").Append(WrapupRequired).Append("\n");
        sb.Append("  WrapupPrompt: ").Append(WrapupPrompt).Append("\n");
        sb.Append("  MediaRoles: ").Append(MediaRoles).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  Team: ").Append(Team).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
        sb.Append("  Script: ").Append(Script).Append("\n");
        sb.Append("  WrapupTimeoutMs: ").Append(WrapupTimeoutMs).Append("\n");
        sb.Append("  WrapupSkipped: ").Append(WrapupSkipped).Append("\n");
        sb.Append("  AlertingTimeoutMs: ").Append(AlertingTimeoutMs).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
        sb.Append("  ExternalContactInitialDivisionId: ").Append(ExternalContactInitialDivisionId).Append("\n");
        sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  Peer: ").Append(Peer).Append("\n");
        sb.Append("  FlaggedReason: ").Append(FlaggedReason).Append("\n");
        sb.Append("  JourneyContext: ").Append(JourneyContext).Append("\n");
        sb.Append("  ConversationRoutingData: ").Append(ConversationRoutingData).Append("\n");
        sb.Append("  StartAcwTime: ").Append(StartAcwTime).Append("\n");
        sb.Append("  EndAcwTime: ").Append(EndAcwTime).Append("\n");
        sb.Append("  ParkTime: ").Append(ParkTime).Append("\n");
        sb.Append("  ResumeTime: ").Append(ResumeTime).Append("\n");
        sb.Append("  RoomId: ").Append(RoomId).Append("\n");
        sb.Append("  AvatarImageUrl: ").Append(AvatarImageUrl).Append("\n");
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
        return Equals(obj as ChatMediaParticipant);
    }

    /// <summary>
    /// Returns true if ChatMediaParticipant instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatMediaParticipant to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatMediaParticipant other)
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
                ConnectedTime == other.ConnectedTime ||
                ConnectedTime != null &&
                ConnectedTime.Equals(other.ConnectedTime)
            ) &&
            (
                EndTime == other.EndTime ||
                EndTime != null &&
                EndTime.Equals(other.EndTime)
            ) &&
            (
                StartHoldTime == other.StartHoldTime ||
                StartHoldTime != null &&
                StartHoldTime.Equals(other.StartHoldTime)
            ) &&
            (
                Purpose == other.Purpose ||
                Purpose != null &&
                Purpose.Equals(other.Purpose)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
            (
                DisconnectType == other.DisconnectType ||
                DisconnectType != null &&
                DisconnectType.Equals(other.DisconnectType)
            ) &&
            (
                Held == other.Held ||
                Held != null &&
                Held.Equals(other.Held)
            ) &&
            (
                WrapupRequired == other.WrapupRequired ||
                WrapupRequired != null &&
                WrapupRequired.Equals(other.WrapupRequired)
            ) &&
            (
                WrapupPrompt == other.WrapupPrompt ||
                WrapupPrompt != null &&
                WrapupPrompt.Equals(other.WrapupPrompt)
            ) &&
            (
                MediaRoles == other.MediaRoles ||
                MediaRoles != null &&
                MediaRoles.SequenceEqual(other.MediaRoles)
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
                Team == other.Team ||
                Team != null &&
                Team.Equals(other.Team)
            ) &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
            ) &&
            (
                ErrorInfo == other.ErrorInfo ||
                ErrorInfo != null &&
                ErrorInfo.Equals(other.ErrorInfo)
            ) &&
            (
                Script == other.Script ||
                Script != null &&
                Script.Equals(other.Script)
            ) &&
            (
                WrapupTimeoutMs == other.WrapupTimeoutMs ||
                WrapupTimeoutMs != null &&
                WrapupTimeoutMs.Equals(other.WrapupTimeoutMs)
            ) &&
            (
                WrapupSkipped == other.WrapupSkipped ||
                WrapupSkipped != null &&
                WrapupSkipped.Equals(other.WrapupSkipped)
            ) &&
            (
                AlertingTimeoutMs == other.AlertingTimeoutMs ||
                AlertingTimeoutMs != null &&
                AlertingTimeoutMs.Equals(other.AlertingTimeoutMs)
            ) &&
            (
                Provider == other.Provider ||
                Provider != null &&
                Provider.Equals(other.Provider)
            ) &&
            (
                ExternalContact == other.ExternalContact ||
                ExternalContact != null &&
                ExternalContact.Equals(other.ExternalContact)
            ) &&
            (
                ExternalContactInitialDivisionId == other.ExternalContactInitialDivisionId ||
                ExternalContactInitialDivisionId != null &&
                ExternalContactInitialDivisionId.Equals(other.ExternalContactInitialDivisionId)
            ) &&
            (
                ExternalOrganization == other.ExternalOrganization ||
                ExternalOrganization != null &&
                ExternalOrganization.Equals(other.ExternalOrganization)
            ) &&
            (
                Wrapup == other.Wrapup ||
                Wrapup != null &&
                Wrapup.Equals(other.Wrapup)
            ) &&
            (
                Peer == other.Peer ||
                Peer != null &&
                Peer.Equals(other.Peer)
            ) &&
            (
                FlaggedReason == other.FlaggedReason ||
                FlaggedReason != null &&
                FlaggedReason.Equals(other.FlaggedReason)
            ) &&
            (
                JourneyContext == other.JourneyContext ||
                JourneyContext != null &&
                JourneyContext.Equals(other.JourneyContext)
            ) &&
            (
                ConversationRoutingData == other.ConversationRoutingData ||
                ConversationRoutingData != null &&
                ConversationRoutingData.Equals(other.ConversationRoutingData)
            ) &&
            (
                StartAcwTime == other.StartAcwTime ||
                StartAcwTime != null &&
                StartAcwTime.Equals(other.StartAcwTime)
            ) &&
            (
                EndAcwTime == other.EndAcwTime ||
                EndAcwTime != null &&
                EndAcwTime.Equals(other.EndAcwTime)
            ) &&
            (
                ParkTime == other.ParkTime ||
                ParkTime != null &&
                ParkTime.Equals(other.ParkTime)
            ) &&
            (
                ResumeTime == other.ResumeTime ||
                ResumeTime != null &&
                ResumeTime.Equals(other.ResumeTime)
            ) &&
            (
                RoomId == other.RoomId ||
                RoomId != null &&
                RoomId.Equals(other.RoomId)
            ) &&
            (
                AvatarImageUrl == other.AvatarImageUrl ||
                AvatarImageUrl != null &&
                AvatarImageUrl.Equals(other.AvatarImageUrl)
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

            if (ConnectedTime != null)
            {
                hash = hash * 59 + ConnectedTime.GetHashCode();
            }

            if (EndTime != null)
            {
                hash = hash * 59 + EndTime.GetHashCode();
            }

            if (StartHoldTime != null)
            {
                hash = hash * 59 + StartHoldTime.GetHashCode();
            }

            if (Purpose != null)
            {
                hash = hash * 59 + Purpose.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (DisconnectType != null)
            {
                hash = hash * 59 + DisconnectType.GetHashCode();
            }

            if (Held != null)
            {
                hash = hash * 59 + Held.GetHashCode();
            }

            if (WrapupRequired != null)
            {
                hash = hash * 59 + WrapupRequired.GetHashCode();
            }

            if (WrapupPrompt != null)
            {
                hash = hash * 59 + WrapupPrompt.GetHashCode();
            }

            if (MediaRoles != null)
            {
                hash = hash * 59 + MediaRoles.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (Team != null)
            {
                hash = hash * 59 + Team.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            if (Script != null)
            {
                hash = hash * 59 + Script.GetHashCode();
            }

            if (WrapupTimeoutMs != null)
            {
                hash = hash * 59 + WrapupTimeoutMs.GetHashCode();
            }

            if (WrapupSkipped != null)
            {
                hash = hash * 59 + WrapupSkipped.GetHashCode();
            }

            if (AlertingTimeoutMs != null)
            {
                hash = hash * 59 + AlertingTimeoutMs.GetHashCode();
            }

            if (Provider != null)
            {
                hash = hash * 59 + Provider.GetHashCode();
            }

            if (ExternalContact != null)
            {
                hash = hash * 59 + ExternalContact.GetHashCode();
            }

            if (ExternalContactInitialDivisionId != null)
            {
                hash = hash * 59 + ExternalContactInitialDivisionId.GetHashCode();
            }

            if (ExternalOrganization != null)
            {
                hash = hash * 59 + ExternalOrganization.GetHashCode();
            }

            if (Wrapup != null)
            {
                hash = hash * 59 + Wrapup.GetHashCode();
            }

            if (Peer != null)
            {
                hash = hash * 59 + Peer.GetHashCode();
            }

            if (FlaggedReason != null)
            {
                hash = hash * 59 + FlaggedReason.GetHashCode();
            }

            if (JourneyContext != null)
            {
                hash = hash * 59 + JourneyContext.GetHashCode();
            }

            if (ConversationRoutingData != null)
            {
                hash = hash * 59 + ConversationRoutingData.GetHashCode();
            }

            if (StartAcwTime != null)
            {
                hash = hash * 59 + StartAcwTime.GetHashCode();
            }

            if (EndAcwTime != null)
            {
                hash = hash * 59 + EndAcwTime.GetHashCode();
            }

            if (ParkTime != null)
            {
                hash = hash * 59 + ParkTime.GetHashCode();
            }

            if (ResumeTime != null)
            {
                hash = hash * 59 + ResumeTime.GetHashCode();
            }

            if (RoomId != null)
            {
                hash = hash * 59 + RoomId.GetHashCode();
            }

            if (AvatarImageUrl != null)
            {
                hash = hash * 59 + AvatarImageUrl.GetHashCode();
            }

            return hash;
        }
    }
}
