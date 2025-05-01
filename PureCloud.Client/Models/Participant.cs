using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Participant
/// </summary>
[DataContract]
public partial class Participant : IEquatable<Participant>
{
    /// <summary>
    /// This field controls how the UI prompts the agent for a wrapup.
    /// </summary>
    /// <value>This field controls how the UI prompts the agent for a wrapup.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WrapupPromptEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Mandatory for "mandatory"
        /// </summary>
        [EnumMember(Value = "mandatory")]
        Mandatory,

        /// <summary>
        /// Enum Optional for "optional"
        /// </summary>
        [EnumMember(Value = "optional")]
        Optional,

        /// <summary>
        /// Enum Agentrequested for "agentRequested"
        /// </summary>
        [EnumMember(Value = "agentRequested")]
        Agentrequested,

        /// <summary>
        /// Enum Timeout for "timeout"
        /// </summary>
        [EnumMember(Value = "timeout")]
        Timeout,

        /// <summary>
        /// Enum Forcedtimeout for "forcedTimeout"
        /// </summary>
        [EnumMember(Value = "forcedTimeout")]
        Forcedtimeout
    }
    /// <summary>
    /// The current screen recording state for this participant.
    /// </summary>
    /// <value>The current screen recording state for this participant.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ScreenRecordingStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Requested for "requested"
        /// </summary>
        [EnumMember(Value = "requested")]
        Requested,

        /// <summary>
        /// Enum Active for "active"
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Enum Paused for "paused"
        /// </summary>
        [EnumMember(Value = "paused")]
        Paused,

        /// <summary>
        /// Enum Stopped for "stopped"
        /// </summary>
        [EnumMember(Value = "stopped")]
        Stopped,

        /// <summary>
        /// Enum Error for "error"
        /// </summary>
        [EnumMember(Value = "error")]
        Error,

        /// <summary>
        /// Enum Timeout for "timeout"
        /// </summary>
        [EnumMember(Value = "timeout")]
        Timeout
    }
    /// <summary>
    /// The reason specifying why participant flagged the conversation.
    /// </summary>
    /// <value>The reason specifying why participant flagged the conversation.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// This field controls how the UI prompts the agent for a wrapup.
    /// </summary>
    /// <value>This field controls how the UI prompts the agent for a wrapup.</value>
    [DataMember(Name = "wrapupPrompt", EmitDefaultValue = false)]
    public WrapupPromptEnum? WrapupPrompt { get; set; }
    /// <summary>
    /// The current screen recording state for this participant.
    /// </summary>
    /// <value>The current screen recording state for this participant.</value>
    [DataMember(Name = "screenRecordingState", EmitDefaultValue = false)]
    public ScreenRecordingStateEnum? ScreenRecordingState { get; set; }
    /// <summary>
    /// The reason specifying why participant flagged the conversation.
    /// </summary>
    /// <value>The reason specifying why participant flagged the conversation.</value>
    [DataMember(Name = "flaggedReason", EmitDefaultValue = false)]
    public FlaggedReasonEnum? FlaggedReason { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Participant" /> class.
    /// </summary>
    /// <param name="Id">A globally unique identifier for this conversation..</param>
    /// <param name="StartTime">The timestamp when this participant joined the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndTime">The timestamp when this participant disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ConnectedTime">The timestamp when this participant was connected to the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Name">A human readable name identifying the participant..</param>
    /// <param name="UserUri">If this participant represents a user, then this will be an URI that can be used to fetch the user..</param>
    /// <param name="UserId">If this participant represents a user, then this will be the globally unique identifier for the user..</param>
    /// <param name="ExternalContactId">If this participant represents an external contact, then this will be the globally unique identifier for the external contact..</param>
    /// <param name="ExternalContactInitialDivisionId">If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned..</param>
    /// <param name="ExternalOrganizationId">If this participant represents an external org, then this will be the globally unique identifier for the external org..</param>
    /// <param name="QueueId">If present, the queue id that the communication channel came in on..</param>
    /// <param name="GroupId">If present, group of users the participant represents..</param>
    /// <param name="TeamId">The team id that this participant is a member of when added to the conversation..</param>
    /// <param name="QueueName">If present, the queue name that the communication channel came in on..</param>
    /// <param name="Purpose">A well known string that specifies the purpose of this participant..</param>
    /// <param name="ParticipantType">A well known string that specifies the type of this participant..</param>
    /// <param name="ConsultParticipantId">If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred..</param>
    /// <param name="Address">The address for the this participant. For a phone call this will be the ANI..</param>
    /// <param name="Ani">The address for the this participant. For a phone call this will be the ANI..</param>
    /// <param name="AniName">The ani-based name for this participant..</param>
    /// <param name="Dnis">The address for the this participant. For a phone call this will be the ANI..</param>
    /// <param name="Locale">An ISO 639 language code specifying the locale for this participant.</param>
    /// <param name="WrapupRequired">True iff this participant is required to enter wrapup for this conversation..</param>
    /// <param name="WrapupPrompt">This field controls how the UI prompts the agent for a wrapup..</param>
    /// <param name="WrapupTimeoutMs">Specifies how long a timed ACW session will last..</param>
    /// <param name="WrapupSkipped">The UI sets this field when the agent chooses to skip entering a wrapup for this participant..</param>
    /// <param name="Wrapup">Call wrap up or disposition data..</param>
    /// <param name="MediaRoles">List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc..</param>
    /// <param name="ConversationRoutingData">Information on how a communication should be routed to an agent..</param>
    /// <param name="AlertingTimeoutMs">Specifies how long the agent has to answer an interaction before being marked as not responding..</param>
    /// <param name="MonitoredParticipantId">If this participant is a monitor, then this will be the id of the participant that is being monitored..</param>
    /// <param name="CoachedParticipantId">If this participant is a coach, then this will be the id of the participant that is being coached..</param>
    /// <param name="Attributes">Additional participant attributes.</param>
    /// <param name="Calls">Calls.</param>
    /// <param name="Callbacks">Callbacks.</param>
    /// <param name="Chats">Chats.</param>
    /// <param name="Cobrowsesessions">Cobrowsesessions.</param>
    /// <param name="Emails">Emails.</param>
    /// <param name="Messages">Messages.</param>
    /// <param name="Screenshares">Screenshares.</param>
    /// <param name="SocialExpressions">SocialExpressions.</param>
    /// <param name="Videos">Videos.</param>
    /// <param name="Evaluations">Evaluations.</param>
    /// <param name="ScreenRecordingState">The current screen recording state for this participant..</param>
    /// <param name="FlaggedReason">The reason specifying why participant flagged the conversation..</param>
    /// <param name="StartAcwTime">The timestamp when this participant started after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndAcwTime">The timestamp when this participant ended after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="InternalMessages">InternalMessages.</param>
    /// <param name="BargedParticipantId">If this participant barged in a participant&#39;s call, then this will be the id of the targeted participant..</param>
    public Participant(string Id = null, DateTime? StartTime = null, DateTime? EndTime = null, DateTime? ConnectedTime = null, string Name = null, string UserUri = null, string UserId = null, string ExternalContactId = null, string ExternalContactInitialDivisionId = null, string ExternalOrganizationId = null, string QueueId = null, string GroupId = null, string TeamId = null, string QueueName = null, string Purpose = null, string ParticipantType = null, string ConsultParticipantId = null, string Address = null, string Ani = null, string AniName = null, string Dnis = null, string Locale = null, bool? WrapupRequired = null, WrapupPromptEnum? WrapupPrompt = null, int? WrapupTimeoutMs = null, bool? WrapupSkipped = null, Wrapup Wrapup = null, List<string> MediaRoles = null, ConversationRoutingData ConversationRoutingData = null, int? AlertingTimeoutMs = null, string MonitoredParticipantId = null, string CoachedParticipantId = null, Dictionary<string, string> Attributes = null, List<Call> Calls = null, List<Callback> Callbacks = null, List<ConversationChat> Chats = null, List<Cobrowsesession> Cobrowsesessions = null, List<Email> Emails = null, List<Message> Messages = null, List<Screenshare> Screenshares = null, List<SocialExpression> SocialExpressions = null, List<Video> Videos = null, List<Evaluation> Evaluations = null, ScreenRecordingStateEnum? ScreenRecordingState = null, FlaggedReasonEnum? FlaggedReason = null, DateTime? StartAcwTime = null, DateTime? EndAcwTime = null, List<InternalMessage> InternalMessages = null, string BargedParticipantId = null)
    {
        this.Id = Id;
        this.StartTime = StartTime;
        this.EndTime = EndTime;
        this.ConnectedTime = ConnectedTime;
        this.Name = Name;
        this.UserUri = UserUri;
        this.UserId = UserId;
        this.ExternalContactId = ExternalContactId;
        this.ExternalContactInitialDivisionId = ExternalContactInitialDivisionId;
        this.ExternalOrganizationId = ExternalOrganizationId;
        this.QueueId = QueueId;
        this.GroupId = GroupId;
        this.TeamId = TeamId;
        this.QueueName = QueueName;
        this.Purpose = Purpose;
        this.ParticipantType = ParticipantType;
        this.ConsultParticipantId = ConsultParticipantId;
        this.Address = Address;
        this.Ani = Ani;
        this.AniName = AniName;
        this.Dnis = Dnis;
        this.Locale = Locale;
        this.WrapupRequired = WrapupRequired;
        this.WrapupPrompt = WrapupPrompt;
        this.WrapupTimeoutMs = WrapupTimeoutMs;
        this.WrapupSkipped = WrapupSkipped;
        this.Wrapup = Wrapup;
        this.MediaRoles = MediaRoles;
        this.ConversationRoutingData = ConversationRoutingData;
        this.AlertingTimeoutMs = AlertingTimeoutMs;
        this.MonitoredParticipantId = MonitoredParticipantId;
        this.CoachedParticipantId = CoachedParticipantId;
        this.Attributes = Attributes;
        this.Calls = Calls;
        this.Callbacks = Callbacks;
        this.Chats = Chats;
        this.Cobrowsesessions = Cobrowsesessions;
        this.Emails = Emails;
        this.Messages = Messages;
        this.Screenshares = Screenshares;
        this.SocialExpressions = SocialExpressions;
        this.Videos = Videos;
        this.Evaluations = Evaluations;
        this.ScreenRecordingState = ScreenRecordingState;
        this.FlaggedReason = FlaggedReason;
        this.StartAcwTime = StartAcwTime;
        this.EndAcwTime = EndAcwTime;
        this.InternalMessages = InternalMessages;
        this.BargedParticipantId = BargedParticipantId;

    }



    /// <summary>
    /// A globally unique identifier for this conversation.
    /// </summary>
    /// <value>A globally unique identifier for this conversation.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The timestamp when this participant joined the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this participant joined the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "startTime", EmitDefaultValue = false)]
    public DateTime? StartTime { get; set; }



    /// <summary>
    /// The timestamp when this participant disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this participant disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "endTime", EmitDefaultValue = false)]
    public DateTime? EndTime { get; set; }



    /// <summary>
    /// The timestamp when this participant was connected to the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this participant was connected to the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "connectedTime", EmitDefaultValue = false)]
    public DateTime? ConnectedTime { get; set; }



    /// <summary>
    /// A human readable name identifying the participant.
    /// </summary>
    /// <value>A human readable name identifying the participant.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// If this participant represents a user, then this will be an URI that can be used to fetch the user.
    /// </summary>
    /// <value>If this participant represents a user, then this will be an URI that can be used to fetch the user.</value>
    [DataMember(Name = "userUri", EmitDefaultValue = false)]
    public string UserUri { get; set; }



    /// <summary>
    /// If this participant represents a user, then this will be the globally unique identifier for the user.
    /// </summary>
    /// <value>If this participant represents a user, then this will be the globally unique identifier for the user.</value>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// If this participant represents an external contact, then this will be the globally unique identifier for the external contact.
    /// </summary>
    /// <value>If this participant represents an external contact, then this will be the globally unique identifier for the external contact.</value>
    [DataMember(Name = "externalContactId", EmitDefaultValue = false)]
    public string ExternalContactId { get; set; }



    /// <summary>
    /// If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned.
    /// </summary>
    /// <value>If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned.</value>
    [DataMember(Name = "externalContactInitialDivisionId", EmitDefaultValue = false)]
    public string ExternalContactInitialDivisionId { get; set; }



    /// <summary>
    /// If this participant represents an external org, then this will be the globally unique identifier for the external org.
    /// </summary>
    /// <value>If this participant represents an external org, then this will be the globally unique identifier for the external org.</value>
    [DataMember(Name = "externalOrganizationId", EmitDefaultValue = false)]
    public string ExternalOrganizationId { get; set; }



    /// <summary>
    /// If present, the queue id that the communication channel came in on.
    /// </summary>
    /// <value>If present, the queue id that the communication channel came in on.</value>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public string QueueId { get; set; }



    /// <summary>
    /// If present, group of users the participant represents.
    /// </summary>
    /// <value>If present, group of users the participant represents.</value>
    [DataMember(Name = "groupId", EmitDefaultValue = false)]
    public string GroupId { get; set; }



    /// <summary>
    /// The team id that this participant is a member of when added to the conversation.
    /// </summary>
    /// <value>The team id that this participant is a member of when added to the conversation.</value>
    [DataMember(Name = "teamId", EmitDefaultValue = false)]
    public string TeamId { get; set; }



    /// <summary>
    /// If present, the queue name that the communication channel came in on.
    /// </summary>
    /// <value>If present, the queue name that the communication channel came in on.</value>
    [DataMember(Name = "queueName", EmitDefaultValue = false)]
    public string QueueName { get; set; }



    /// <summary>
    /// A well known string that specifies the purpose of this participant.
    /// </summary>
    /// <value>A well known string that specifies the purpose of this participant.</value>
    [DataMember(Name = "purpose", EmitDefaultValue = false)]
    public string Purpose { get; set; }



    /// <summary>
    /// A well known string that specifies the type of this participant.
    /// </summary>
    /// <value>A well known string that specifies the type of this participant.</value>
    [DataMember(Name = "participantType", EmitDefaultValue = false)]
    public string ParticipantType { get; set; }



    /// <summary>
    /// If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred.
    /// </summary>
    /// <value>If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred.</value>
    [DataMember(Name = "consultParticipantId", EmitDefaultValue = false)]
    public string ConsultParticipantId { get; set; }



    /// <summary>
    /// The address for the this participant. For a phone call this will be the ANI.
    /// </summary>
    /// <value>The address for the this participant. For a phone call this will be the ANI.</value>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public string Address { get; set; }



    /// <summary>
    /// The address for the this participant. For a phone call this will be the ANI.
    /// </summary>
    /// <value>The address for the this participant. For a phone call this will be the ANI.</value>
    [DataMember(Name = "ani", EmitDefaultValue = false)]
    public string Ani { get; set; }



    /// <summary>
    /// The ani-based name for this participant.
    /// </summary>
    /// <value>The ani-based name for this participant.</value>
    [DataMember(Name = "aniName", EmitDefaultValue = false)]
    public string AniName { get; set; }



    /// <summary>
    /// The address for the this participant. For a phone call this will be the ANI.
    /// </summary>
    /// <value>The address for the this participant. For a phone call this will be the ANI.</value>
    [DataMember(Name = "dnis", EmitDefaultValue = false)]
    public string Dnis { get; set; }



    /// <summary>
    /// An ISO 639 language code specifying the locale for this participant
    /// </summary>
    /// <value>An ISO 639 language code specifying the locale for this participant</value>
    [DataMember(Name = "locale", EmitDefaultValue = false)]
    public string Locale { get; set; }



    /// <summary>
    /// True iff this participant is required to enter wrapup for this conversation.
    /// </summary>
    /// <value>True iff this participant is required to enter wrapup for this conversation.</value>
    [DataMember(Name = "wrapupRequired", EmitDefaultValue = false)]
    public bool? WrapupRequired { get; set; }





    /// <summary>
    /// Specifies how long a timed ACW session will last.
    /// </summary>
    /// <value>Specifies how long a timed ACW session will last.</value>
    [DataMember(Name = "wrapupTimeoutMs", EmitDefaultValue = false)]
    public int? WrapupTimeoutMs { get; set; }



    /// <summary>
    /// The UI sets this field when the agent chooses to skip entering a wrapup for this participant.
    /// </summary>
    /// <value>The UI sets this field when the agent chooses to skip entering a wrapup for this participant.</value>
    [DataMember(Name = "wrapupSkipped", EmitDefaultValue = false)]
    public bool? WrapupSkipped { get; set; }



    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    [DataMember(Name = "wrapup", EmitDefaultValue = false)]
    public Wrapup Wrapup { get; set; }



    /// <summary>
    /// List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc.
    /// </summary>
    /// <value>List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc.</value>
    [DataMember(Name = "mediaRoles", EmitDefaultValue = false)]
    public List<string> MediaRoles { get; set; }



    /// <summary>
    /// Information on how a communication should be routed to an agent.
    /// </summary>
    /// <value>Information on how a communication should be routed to an agent.</value>
    [DataMember(Name = "conversationRoutingData", EmitDefaultValue = false)]
    public ConversationRoutingData ConversationRoutingData { get; set; }



    /// <summary>
    /// Specifies how long the agent has to answer an interaction before being marked as not responding.
    /// </summary>
    /// <value>Specifies how long the agent has to answer an interaction before being marked as not responding.</value>
    [DataMember(Name = "alertingTimeoutMs", EmitDefaultValue = false)]
    public int? AlertingTimeoutMs { get; set; }



    /// <summary>
    /// If this participant is a monitor, then this will be the id of the participant that is being monitored.
    /// </summary>
    /// <value>If this participant is a monitor, then this will be the id of the participant that is being monitored.</value>
    [DataMember(Name = "monitoredParticipantId", EmitDefaultValue = false)]
    public string MonitoredParticipantId { get; set; }



    /// <summary>
    /// If this participant is a coach, then this will be the id of the participant that is being coached.
    /// </summary>
    /// <value>If this participant is a coach, then this will be the id of the participant that is being coached.</value>
    [DataMember(Name = "coachedParticipantId", EmitDefaultValue = false)]
    public string CoachedParticipantId { get; set; }



    /// <summary>
    /// Additional participant attributes
    /// </summary>
    /// <value>Additional participant attributes</value>
    [DataMember(Name = "attributes", EmitDefaultValue = false)]
    public Dictionary<string, string> Attributes { get; set; }



    /// <summary>
    /// Gets or Sets Calls
    /// </summary>
    [DataMember(Name = "calls", EmitDefaultValue = false)]
    public List<Call> Calls { get; set; }



    /// <summary>
    /// Gets or Sets Callbacks
    /// </summary>
    [DataMember(Name = "callbacks", EmitDefaultValue = false)]
    public List<Callback> Callbacks { get; set; }



    /// <summary>
    /// Gets or Sets Chats
    /// </summary>
    [DataMember(Name = "chats", EmitDefaultValue = false)]
    public List<ConversationChat> Chats { get; set; }



    /// <summary>
    /// Gets or Sets Cobrowsesessions
    /// </summary>
    [DataMember(Name = "cobrowsesessions", EmitDefaultValue = false)]
    public List<Cobrowsesession> Cobrowsesessions { get; set; }



    /// <summary>
    /// Gets or Sets Emails
    /// </summary>
    [DataMember(Name = "emails", EmitDefaultValue = false)]
    public List<Email> Emails { get; set; }



    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    [DataMember(Name = "messages", EmitDefaultValue = false)]
    public List<Message> Messages { get; set; }



    /// <summary>
    /// Gets or Sets Screenshares
    /// </summary>
    [DataMember(Name = "screenshares", EmitDefaultValue = false)]
    public List<Screenshare> Screenshares { get; set; }



    /// <summary>
    /// Gets or Sets SocialExpressions
    /// </summary>
    [DataMember(Name = "socialExpressions", EmitDefaultValue = false)]
    public List<SocialExpression> SocialExpressions { get; set; }



    /// <summary>
    /// Gets or Sets Videos
    /// </summary>
    [DataMember(Name = "videos", EmitDefaultValue = false)]
    public List<Video> Videos { get; set; }



    /// <summary>
    /// Gets or Sets Evaluations
    /// </summary>
    [DataMember(Name = "evaluations", EmitDefaultValue = false)]
    public List<Evaluation> Evaluations { get; set; }







    /// <summary>
    /// The timestamp when this participant started after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this participant started after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "startAcwTime", EmitDefaultValue = false)]
    public DateTime? StartAcwTime { get; set; }



    /// <summary>
    /// The timestamp when this participant ended after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this participant ended after-call work. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "endAcwTime", EmitDefaultValue = false)]
    public DateTime? EndAcwTime { get; set; }



    /// <summary>
    /// Gets or Sets InternalMessages
    /// </summary>
    [DataMember(Name = "internalMessages", EmitDefaultValue = false)]
    public List<InternalMessage> InternalMessages { get; set; }



    /// <summary>
    /// If this participant barged in a participant&#39;s call, then this will be the id of the targeted participant.
    /// </summary>
    /// <value>If this participant barged in a participant&#39;s call, then this will be the id of the targeted participant.</value>
    [DataMember(Name = "bargedParticipantId", EmitDefaultValue = false)]
    public string BargedParticipantId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Participant {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
        sb.Append("  EndTime: ").Append(EndTime).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  UserUri: ").Append(UserUri).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
        sb.Append("  ExternalContactInitialDivisionId: ").Append(ExternalContactInitialDivisionId).Append("\n");
        sb.Append("  ExternalOrganizationId: ").Append(ExternalOrganizationId).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  GroupId: ").Append(GroupId).Append("\n");
        sb.Append("  TeamId: ").Append(TeamId).Append("\n");
        sb.Append("  QueueName: ").Append(QueueName).Append("\n");
        sb.Append("  Purpose: ").Append(Purpose).Append("\n");
        sb.Append("  ParticipantType: ").Append(ParticipantType).Append("\n");
        sb.Append("  ConsultParticipantId: ").Append(ConsultParticipantId).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  Ani: ").Append(Ani).Append("\n");
        sb.Append("  AniName: ").Append(AniName).Append("\n");
        sb.Append("  Dnis: ").Append(Dnis).Append("\n");
        sb.Append("  Locale: ").Append(Locale).Append("\n");
        sb.Append("  WrapupRequired: ").Append(WrapupRequired).Append("\n");
        sb.Append("  WrapupPrompt: ").Append(WrapupPrompt).Append("\n");
        sb.Append("  WrapupTimeoutMs: ").Append(WrapupTimeoutMs).Append("\n");
        sb.Append("  WrapupSkipped: ").Append(WrapupSkipped).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  MediaRoles: ").Append(MediaRoles).Append("\n");
        sb.Append("  ConversationRoutingData: ").Append(ConversationRoutingData).Append("\n");
        sb.Append("  AlertingTimeoutMs: ").Append(AlertingTimeoutMs).Append("\n");
        sb.Append("  MonitoredParticipantId: ").Append(MonitoredParticipantId).Append("\n");
        sb.Append("  CoachedParticipantId: ").Append(CoachedParticipantId).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  Calls: ").Append(Calls).Append("\n");
        sb.Append("  Callbacks: ").Append(Callbacks).Append("\n");
        sb.Append("  Chats: ").Append(Chats).Append("\n");
        sb.Append("  Cobrowsesessions: ").Append(Cobrowsesessions).Append("\n");
        sb.Append("  Emails: ").Append(Emails).Append("\n");
        sb.Append("  Messages: ").Append(Messages).Append("\n");
        sb.Append("  Screenshares: ").Append(Screenshares).Append("\n");
        sb.Append("  SocialExpressions: ").Append(SocialExpressions).Append("\n");
        sb.Append("  Videos: ").Append(Videos).Append("\n");
        sb.Append("  Evaluations: ").Append(Evaluations).Append("\n");
        sb.Append("  ScreenRecordingState: ").Append(ScreenRecordingState).Append("\n");
        sb.Append("  FlaggedReason: ").Append(FlaggedReason).Append("\n");
        sb.Append("  StartAcwTime: ").Append(StartAcwTime).Append("\n");
        sb.Append("  EndAcwTime: ").Append(EndAcwTime).Append("\n");
        sb.Append("  InternalMessages: ").Append(InternalMessages).Append("\n");
        sb.Append("  BargedParticipantId: ").Append(BargedParticipantId).Append("\n");
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
        return Equals(obj as Participant);
    }

    /// <summary>
    /// Returns true if Participant instances are equal
    /// </summary>
    /// <param name="other">Instance of Participant to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Participant other)
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
                ConnectedTime == other.ConnectedTime ||
                ConnectedTime != null &&
                ConnectedTime.Equals(other.ConnectedTime)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                UserUri == other.UserUri ||
                UserUri != null &&
                UserUri.Equals(other.UserUri)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                ExternalContactId == other.ExternalContactId ||
                ExternalContactId != null &&
                ExternalContactId.Equals(other.ExternalContactId)
            ) &&
            (
                ExternalContactInitialDivisionId == other.ExternalContactInitialDivisionId ||
                ExternalContactInitialDivisionId != null &&
                ExternalContactInitialDivisionId.Equals(other.ExternalContactInitialDivisionId)
            ) &&
            (
                ExternalOrganizationId == other.ExternalOrganizationId ||
                ExternalOrganizationId != null &&
                ExternalOrganizationId.Equals(other.ExternalOrganizationId)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                GroupId == other.GroupId ||
                GroupId != null &&
                GroupId.Equals(other.GroupId)
            ) &&
            (
                TeamId == other.TeamId ||
                TeamId != null &&
                TeamId.Equals(other.TeamId)
            ) &&
            (
                QueueName == other.QueueName ||
                QueueName != null &&
                QueueName.Equals(other.QueueName)
            ) &&
            (
                Purpose == other.Purpose ||
                Purpose != null &&
                Purpose.Equals(other.Purpose)
            ) &&
            (
                ParticipantType == other.ParticipantType ||
                ParticipantType != null &&
                ParticipantType.Equals(other.ParticipantType)
            ) &&
            (
                ConsultParticipantId == other.ConsultParticipantId ||
                ConsultParticipantId != null &&
                ConsultParticipantId.Equals(other.ConsultParticipantId)
            ) &&
            (
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
            ) &&
            (
                Ani == other.Ani ||
                Ani != null &&
                Ani.Equals(other.Ani)
            ) &&
            (
                AniName == other.AniName ||
                AniName != null &&
                AniName.Equals(other.AniName)
            ) &&
            (
                Dnis == other.Dnis ||
                Dnis != null &&
                Dnis.Equals(other.Dnis)
            ) &&
            (
                Locale == other.Locale ||
                Locale != null &&
                Locale.Equals(other.Locale)
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
                Wrapup == other.Wrapup ||
                Wrapup != null &&
                Wrapup.Equals(other.Wrapup)
            ) &&
            (
                MediaRoles == other.MediaRoles ||
                MediaRoles != null &&
                MediaRoles.SequenceEqual(other.MediaRoles)
            ) &&
            (
                ConversationRoutingData == other.ConversationRoutingData ||
                ConversationRoutingData != null &&
                ConversationRoutingData.Equals(other.ConversationRoutingData)
            ) &&
            (
                AlertingTimeoutMs == other.AlertingTimeoutMs ||
                AlertingTimeoutMs != null &&
                AlertingTimeoutMs.Equals(other.AlertingTimeoutMs)
            ) &&
            (
                MonitoredParticipantId == other.MonitoredParticipantId ||
                MonitoredParticipantId != null &&
                MonitoredParticipantId.Equals(other.MonitoredParticipantId)
            ) &&
            (
                CoachedParticipantId == other.CoachedParticipantId ||
                CoachedParticipantId != null &&
                CoachedParticipantId.Equals(other.CoachedParticipantId)
            ) &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
            ) &&
            (
                Calls == other.Calls ||
                Calls != null &&
                Calls.SequenceEqual(other.Calls)
            ) &&
            (
                Callbacks == other.Callbacks ||
                Callbacks != null &&
                Callbacks.SequenceEqual(other.Callbacks)
            ) &&
            (
                Chats == other.Chats ||
                Chats != null &&
                Chats.SequenceEqual(other.Chats)
            ) &&
            (
                Cobrowsesessions == other.Cobrowsesessions ||
                Cobrowsesessions != null &&
                Cobrowsesessions.SequenceEqual(other.Cobrowsesessions)
            ) &&
            (
                Emails == other.Emails ||
                Emails != null &&
                Emails.SequenceEqual(other.Emails)
            ) &&
            (
                Messages == other.Messages ||
                Messages != null &&
                Messages.SequenceEqual(other.Messages)
            ) &&
            (
                Screenshares == other.Screenshares ||
                Screenshares != null &&
                Screenshares.SequenceEqual(other.Screenshares)
            ) &&
            (
                SocialExpressions == other.SocialExpressions ||
                SocialExpressions != null &&
                SocialExpressions.SequenceEqual(other.SocialExpressions)
            ) &&
            (
                Videos == other.Videos ||
                Videos != null &&
                Videos.SequenceEqual(other.Videos)
            ) &&
            (
                Evaluations == other.Evaluations ||
                Evaluations != null &&
                Evaluations.SequenceEqual(other.Evaluations)
            ) &&
            (
                ScreenRecordingState == other.ScreenRecordingState ||
                ScreenRecordingState != null &&
                ScreenRecordingState.Equals(other.ScreenRecordingState)
            ) &&
            (
                FlaggedReason == other.FlaggedReason ||
                FlaggedReason != null &&
                FlaggedReason.Equals(other.FlaggedReason)
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
                InternalMessages == other.InternalMessages ||
                InternalMessages != null &&
                InternalMessages.SequenceEqual(other.InternalMessages)
            ) &&
            (
                BargedParticipantId == other.BargedParticipantId ||
                BargedParticipantId != null &&
                BargedParticipantId.Equals(other.BargedParticipantId)
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

            if (StartTime != null)
            {
                hash = hash * 59 + StartTime.GetHashCode();
            }

            if (EndTime != null)
            {
                hash = hash * 59 + EndTime.GetHashCode();
            }

            if (ConnectedTime != null)
            {
                hash = hash * 59 + ConnectedTime.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (UserUri != null)
            {
                hash = hash * 59 + UserUri.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            if (ExternalContactInitialDivisionId != null)
            {
                hash = hash * 59 + ExternalContactInitialDivisionId.GetHashCode();
            }

            if (ExternalOrganizationId != null)
            {
                hash = hash * 59 + ExternalOrganizationId.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (GroupId != null)
            {
                hash = hash * 59 + GroupId.GetHashCode();
            }

            if (TeamId != null)
            {
                hash = hash * 59 + TeamId.GetHashCode();
            }

            if (QueueName != null)
            {
                hash = hash * 59 + QueueName.GetHashCode();
            }

            if (Purpose != null)
            {
                hash = hash * 59 + Purpose.GetHashCode();
            }

            if (ParticipantType != null)
            {
                hash = hash * 59 + ParticipantType.GetHashCode();
            }

            if (ConsultParticipantId != null)
            {
                hash = hash * 59 + ConsultParticipantId.GetHashCode();
            }

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            if (Ani != null)
            {
                hash = hash * 59 + Ani.GetHashCode();
            }

            if (AniName != null)
            {
                hash = hash * 59 + AniName.GetHashCode();
            }

            if (Dnis != null)
            {
                hash = hash * 59 + Dnis.GetHashCode();
            }

            if (Locale != null)
            {
                hash = hash * 59 + Locale.GetHashCode();
            }

            if (WrapupRequired != null)
            {
                hash = hash * 59 + WrapupRequired.GetHashCode();
            }

            if (WrapupPrompt != null)
            {
                hash = hash * 59 + WrapupPrompt.GetHashCode();
            }

            if (WrapupTimeoutMs != null)
            {
                hash = hash * 59 + WrapupTimeoutMs.GetHashCode();
            }

            if (WrapupSkipped != null)
            {
                hash = hash * 59 + WrapupSkipped.GetHashCode();
            }

            if (Wrapup != null)
            {
                hash = hash * 59 + Wrapup.GetHashCode();
            }

            if (MediaRoles != null)
            {
                hash = hash * 59 + MediaRoles.GetHashCode();
            }

            if (ConversationRoutingData != null)
            {
                hash = hash * 59 + ConversationRoutingData.GetHashCode();
            }

            if (AlertingTimeoutMs != null)
            {
                hash = hash * 59 + AlertingTimeoutMs.GetHashCode();
            }

            if (MonitoredParticipantId != null)
            {
                hash = hash * 59 + MonitoredParticipantId.GetHashCode();
            }

            if (CoachedParticipantId != null)
            {
                hash = hash * 59 + CoachedParticipantId.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (Calls != null)
            {
                hash = hash * 59 + Calls.GetHashCode();
            }

            if (Callbacks != null)
            {
                hash = hash * 59 + Callbacks.GetHashCode();
            }

            if (Chats != null)
            {
                hash = hash * 59 + Chats.GetHashCode();
            }

            if (Cobrowsesessions != null)
            {
                hash = hash * 59 + Cobrowsesessions.GetHashCode();
            }

            if (Emails != null)
            {
                hash = hash * 59 + Emails.GetHashCode();
            }

            if (Messages != null)
            {
                hash = hash * 59 + Messages.GetHashCode();
            }

            if (Screenshares != null)
            {
                hash = hash * 59 + Screenshares.GetHashCode();
            }

            if (SocialExpressions != null)
            {
                hash = hash * 59 + SocialExpressions.GetHashCode();
            }

            if (Videos != null)
            {
                hash = hash * 59 + Videos.GetHashCode();
            }

            if (Evaluations != null)
            {
                hash = hash * 59 + Evaluations.GetHashCode();
            }

            if (ScreenRecordingState != null)
            {
                hash = hash * 59 + ScreenRecordingState.GetHashCode();
            }

            if (FlaggedReason != null)
            {
                hash = hash * 59 + FlaggedReason.GetHashCode();
            }

            if (StartAcwTime != null)
            {
                hash = hash * 59 + StartAcwTime.GetHashCode();
            }

            if (EndAcwTime != null)
            {
                hash = hash * 59 + EndAcwTime.GetHashCode();
            }

            if (InternalMessages != null)
            {
                hash = hash * 59 + InternalMessages.GetHashCode();
            }

            if (BargedParticipantId != null)
            {
                hash = hash * 59 + BargedParticipantId.GetHashCode();
            }

            return hash;
        }
    }
}
