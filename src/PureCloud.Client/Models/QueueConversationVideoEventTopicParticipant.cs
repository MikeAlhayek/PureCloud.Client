using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationVideoEventTopicParticipant
/// </summary>

public partial class QueueConversationVideoEventTopicParticipant : IEquatable<QueueConversationVideoEventTopicParticipant>
{
    /// <summary>
    /// The current screen recording state for this participant.
    /// </summary>
    /// <value>The current screen recording state for this participant.</value>
    
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
    /// The current screen recording state for this participant.
    /// </summary>
    /// <value>The current screen recording state for this participant.</value>
    [JsonPropertyName("screenRecordingState")]
    public ScreenRecordingStateEnum? ScreenRecordingState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicParticipant" /> class.
    /// </summary>
    /// <param name="Id">A globally unique identifier for this conversation..</param>
    /// <param name="ConnectedTime">The timestamp when this participant was connected to the conversation in the provider clock..</param>
    /// <param name="EndTime">The timestamp when this participant disconnected from the conversation in the provider clock..</param>
    /// <param name="UserId">If this participant represents a user, then this will be the globally unique identifier for the user..</param>
    /// <param name="ExternalContactId">If this participant represents an external contact, then this will be the globally unique identifier for the external contact..</param>
    /// <param name="ExternalContactInitialDivisionId">If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned..</param>
    /// <param name="ExternalOrganizationId">If this participant represents an external org, then this will be the globally unique identifier for the external org..</param>
    /// <param name="Name">A human readable name identifying the participant..</param>
    /// <param name="QueueId">If present, the queue id that the communication channel came in on..</param>
    /// <param name="GroupId">If present, the group id that the participant represents..</param>
    /// <param name="TeamId">The team id that this participant is a member of when added to the conversation..</param>
    /// <param name="Purpose">A well known string that specifies the purpose or type of this participant..</param>
    /// <param name="ConsultParticipantId">If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred..</param>
    /// <param name="Address">The address for the this participant. For a phone call this will be the ANI..</param>
    /// <param name="WrapupRequired">True iff this participant is required to enter wrapup for this conversation..</param>
    /// <param name="WrapupExpected">True when a participant is expected to enter a wrapup code once the call connects..</param>
    /// <param name="WrapupPrompt">This field controls how the UI prompts the agent for a wrapup..</param>
    /// <param name="WrapupTimeoutMs">Specifies how long a timed ACW session will last..</param>
    /// <param name="Wrapup">Wrapup.</param>
    /// <param name="StartAcwTime">The timestamp when this participant started after-call work..</param>
    /// <param name="EndAcwTime">The timestamp when this participant ended after-call work..</param>
    /// <param name="ConversationRoutingData">ConversationRoutingData.</param>
    /// <param name="AlertingTimeoutMs">Specifies how long the agent has to answer an interaction before being marked as not responding..</param>
    /// <param name="MonitoredParticipantId">If this participant is a monitor, then this will be the id of the participant that is being monitored..</param>
    /// <param name="CoachedParticipantId">If this participant is a coach, then this will be the id of the participant that is being coached..</param>
    /// <param name="BargedParticipantId">If this participant created a barge in conference, then this will be the id of the participant that is barged in..</param>
    /// <param name="MediaRoles">List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc..</param>
    /// <param name="ScreenRecordingState">The current screen recording state for this participant..</param>
    /// <param name="FlaggedReason">If this participant has flagged the conversation, the reason code given..</param>
    /// <param name="Attributes">Additional participant attributes.</param>
    /// <param name="Calls">Calls.</param>
    /// <param name="Callbacks">Callbacks.</param>
    /// <param name="Chats">Chats.</param>
    /// <param name="Cobrowsesessions">Cobrowsesessions.</param>
    /// <param name="Emails">Emails.</param>
    /// <param name="Messages">Messages.</param>
    /// <param name="InternalMessages">InternalMessages.</param>
    /// <param name="Screenshares">Screenshares.</param>
    /// <param name="SocialExpressions">SocialExpressions.</param>
    /// <param name="Videos">Videos.</param>
    /// <param name="Workflow">Workflow.</param>
    public QueueConversationVideoEventTopicParticipant(string Id = null, DateTime? ConnectedTime = null, DateTime? EndTime = null, string UserId = null, string ExternalContactId = null, string ExternalContactInitialDivisionId = null, string ExternalOrganizationId = null, string Name = null, string QueueId = null, string GroupId = null, string TeamId = null, string Purpose = null, string ConsultParticipantId = null, string Address = null, bool? WrapupRequired = null, bool? WrapupExpected = null, string WrapupPrompt = null, long? WrapupTimeoutMs = null, QueueConversationVideoEventTopicWrapup Wrapup = null, DateTime? StartAcwTime = null, DateTime? EndAcwTime = null, QueueConversationVideoEventTopicConversationRoutingData ConversationRoutingData = null, long? AlertingTimeoutMs = null, string MonitoredParticipantId = null, string CoachedParticipantId = null, string BargedParticipantId = null, List<string> MediaRoles = null, ScreenRecordingStateEnum? ScreenRecordingState = null, string FlaggedReason = null, Dictionary<string, string> Attributes = null, List<QueueConversationVideoEventTopicCall> Calls = null, List<QueueConversationVideoEventTopicCallback> Callbacks = null, List<QueueConversationVideoEventTopicChat> Chats = null, List<QueueConversationVideoEventTopicCobrowse> Cobrowsesessions = null, List<QueueConversationVideoEventTopicEmail> Emails = null, List<QueueConversationVideoEventTopicMessage> Messages = null, List<QueueConversationVideoEventTopicInternalMessage> InternalMessages = null, List<QueueConversationVideoEventTopicScreenshare> Screenshares = null, List<QueueConversationVideoEventTopicSocialExpression> SocialExpressions = null, List<QueueConversationVideoEventTopicVideo> Videos = null, QueueConversationVideoEventTopicWorkflow Workflow = null)
    {
        this.Id = Id;
        this.ConnectedTime = ConnectedTime;
        this.EndTime = EndTime;
        this.UserId = UserId;
        this.ExternalContactId = ExternalContactId;
        this.ExternalContactInitialDivisionId = ExternalContactInitialDivisionId;
        this.ExternalOrganizationId = ExternalOrganizationId;
        this.Name = Name;
        this.QueueId = QueueId;
        this.GroupId = GroupId;
        this.TeamId = TeamId;
        this.Purpose = Purpose;
        this.ConsultParticipantId = ConsultParticipantId;
        this.Address = Address;
        this.WrapupRequired = WrapupRequired;
        this.WrapupExpected = WrapupExpected;
        this.WrapupPrompt = WrapupPrompt;
        this.WrapupTimeoutMs = WrapupTimeoutMs;
        this.Wrapup = Wrapup;
        this.StartAcwTime = StartAcwTime;
        this.EndAcwTime = EndAcwTime;
        this.ConversationRoutingData = ConversationRoutingData;
        this.AlertingTimeoutMs = AlertingTimeoutMs;
        this.MonitoredParticipantId = MonitoredParticipantId;
        this.CoachedParticipantId = CoachedParticipantId;
        this.BargedParticipantId = BargedParticipantId;
        this.MediaRoles = MediaRoles;
        this.ScreenRecordingState = ScreenRecordingState;
        this.FlaggedReason = FlaggedReason;
        this.Attributes = Attributes;
        this.Calls = Calls;
        this.Callbacks = Callbacks;
        this.Chats = Chats;
        this.Cobrowsesessions = Cobrowsesessions;
        this.Emails = Emails;
        this.Messages = Messages;
        this.InternalMessages = InternalMessages;
        this.Screenshares = Screenshares;
        this.SocialExpressions = SocialExpressions;
        this.Videos = Videos;
        this.Workflow = Workflow;

    }



    /// <summary>
    /// A globally unique identifier for this conversation.
    /// </summary>
    /// <value>A globally unique identifier for this conversation.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The timestamp when this participant was connected to the conversation in the provider clock.
    /// </summary>
    /// <value>The timestamp when this participant was connected to the conversation in the provider clock.</value>
    [JsonPropertyName("connectedTime")]
    public DateTime? ConnectedTime { get; set; }



    /// <summary>
    /// The timestamp when this participant disconnected from the conversation in the provider clock.
    /// </summary>
    /// <value>The timestamp when this participant disconnected from the conversation in the provider clock.</value>
    [JsonPropertyName("endTime")]
    public DateTime? EndTime { get; set; }



    /// <summary>
    /// If this participant represents a user, then this will be the globally unique identifier for the user.
    /// </summary>
    /// <value>If this participant represents a user, then this will be the globally unique identifier for the user.</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// If this participant represents an external contact, then this will be the globally unique identifier for the external contact.
    /// </summary>
    /// <value>If this participant represents an external contact, then this will be the globally unique identifier for the external contact.</value>
    [JsonPropertyName("externalContactId")]
    public string ExternalContactId { get; set; }



    /// <summary>
    /// If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned.
    /// </summary>
    /// <value>If this participant represents an external contact, then this will be the initial division for the external contact. This value will not be updated if the external contact is reassigned.</value>
    [JsonPropertyName("externalContactInitialDivisionId")]
    public string ExternalContactInitialDivisionId { get; set; }



    /// <summary>
    /// If this participant represents an external org, then this will be the globally unique identifier for the external org.
    /// </summary>
    /// <value>If this participant represents an external org, then this will be the globally unique identifier for the external org.</value>
    [JsonPropertyName("externalOrganizationId")]
    public string ExternalOrganizationId { get; set; }



    /// <summary>
    /// A human readable name identifying the participant.
    /// </summary>
    /// <value>A human readable name identifying the participant.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// If present, the queue id that the communication channel came in on.
    /// </summary>
    /// <value>If present, the queue id that the communication channel came in on.</value>
    [JsonPropertyName("queueId")]
    public string QueueId { get; set; }



    /// <summary>
    /// If present, the group id that the participant represents.
    /// </summary>
    /// <value>If present, the group id that the participant represents.</value>
    [JsonPropertyName("groupId")]
    public string GroupId { get; set; }



    /// <summary>
    /// The team id that this participant is a member of when added to the conversation.
    /// </summary>
    /// <value>The team id that this participant is a member of when added to the conversation.</value>
    [JsonPropertyName("teamId")]
    public string TeamId { get; set; }



    /// <summary>
    /// A well known string that specifies the purpose or type of this participant.
    /// </summary>
    /// <value>A well known string that specifies the purpose or type of this participant.</value>
    [JsonPropertyName("purpose")]
    public string Purpose { get; set; }



    /// <summary>
    /// If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred.
    /// </summary>
    /// <value>If this participant is part of a consult transfer, then this will be the participant id of the participant being transferred.</value>
    [JsonPropertyName("consultParticipantId")]
    public string ConsultParticipantId { get; set; }



    /// <summary>
    /// The address for the this participant. For a phone call this will be the ANI.
    /// </summary>
    /// <value>The address for the this participant. For a phone call this will be the ANI.</value>
    [JsonPropertyName("address")]
    public string Address { get; set; }



    /// <summary>
    /// True iff this participant is required to enter wrapup for this conversation.
    /// </summary>
    /// <value>True iff this participant is required to enter wrapup for this conversation.</value>
    [JsonPropertyName("wrapupRequired")]
    public bool? WrapupRequired { get; set; }



    /// <summary>
    /// True when a participant is expected to enter a wrapup code once the call connects.
    /// </summary>
    /// <value>True when a participant is expected to enter a wrapup code once the call connects.</value>
    [JsonPropertyName("wrapupExpected")]
    public bool? WrapupExpected { get; set; }



    /// <summary>
    /// This field controls how the UI prompts the agent for a wrapup.
    /// </summary>
    /// <value>This field controls how the UI prompts the agent for a wrapup.</value>
    [JsonPropertyName("wrapupPrompt")]
    public string WrapupPrompt { get; set; }



    /// <summary>
    /// Specifies how long a timed ACW session will last.
    /// </summary>
    /// <value>Specifies how long a timed ACW session will last.</value>
    [JsonPropertyName("wrapupTimeoutMs")]
    public long? WrapupTimeoutMs { get; set; }



    /// <summary>
    /// Gets or Sets Wrapup
    /// </summary>
    [JsonPropertyName("wrapup")]
    public QueueConversationVideoEventTopicWrapup Wrapup { get; set; }



    /// <summary>
    /// The timestamp when this participant started after-call work.
    /// </summary>
    /// <value>The timestamp when this participant started after-call work.</value>
    [JsonPropertyName("startAcwTime")]
    public DateTime? StartAcwTime { get; set; }



    /// <summary>
    /// The timestamp when this participant ended after-call work.
    /// </summary>
    /// <value>The timestamp when this participant ended after-call work.</value>
    [JsonPropertyName("endAcwTime")]
    public DateTime? EndAcwTime { get; set; }



    /// <summary>
    /// Gets or Sets ConversationRoutingData
    /// </summary>
    [JsonPropertyName("conversationRoutingData")]
    public QueueConversationVideoEventTopicConversationRoutingData ConversationRoutingData { get; set; }



    /// <summary>
    /// Specifies how long the agent has to answer an interaction before being marked as not responding.
    /// </summary>
    /// <value>Specifies how long the agent has to answer an interaction before being marked as not responding.</value>
    [JsonPropertyName("alertingTimeoutMs")]
    public long? AlertingTimeoutMs { get; set; }



    /// <summary>
    /// If this participant is a monitor, then this will be the id of the participant that is being monitored.
    /// </summary>
    /// <value>If this participant is a monitor, then this will be the id of the participant that is being monitored.</value>
    [JsonPropertyName("monitoredParticipantId")]
    public string MonitoredParticipantId { get; set; }



    /// <summary>
    /// If this participant is a coach, then this will be the id of the participant that is being coached.
    /// </summary>
    /// <value>If this participant is a coach, then this will be the id of the participant that is being coached.</value>
    [JsonPropertyName("coachedParticipantId")]
    public string CoachedParticipantId { get; set; }



    /// <summary>
    /// If this participant created a barge in conference, then this will be the id of the participant that is barged in.
    /// </summary>
    /// <value>If this participant created a barge in conference, then this will be the id of the participant that is barged in.</value>
    [JsonPropertyName("bargedParticipantId")]
    public string BargedParticipantId { get; set; }



    /// <summary>
    /// List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc.
    /// </summary>
    /// <value>List of roles this participant&#39;s media has had on the conversation, ie monitor, coach, etc.</value>
    [JsonPropertyName("mediaRoles")]
    public List<string> MediaRoles { get; set; }





    /// <summary>
    /// If this participant has flagged the conversation, the reason code given.
    /// </summary>
    /// <value>If this participant has flagged the conversation, the reason code given.</value>
    [JsonPropertyName("flaggedReason")]
    public string FlaggedReason { get; set; }



    /// <summary>
    /// Additional participant attributes
    /// </summary>
    /// <value>Additional participant attributes</value>
    [JsonPropertyName("attributes")]
    public Dictionary<string, string> Attributes { get; set; }



    /// <summary>
    /// Gets or Sets Calls
    /// </summary>
    [JsonPropertyName("calls")]
    public List<QueueConversationVideoEventTopicCall> Calls { get; set; }



    /// <summary>
    /// Gets or Sets Callbacks
    /// </summary>
    [JsonPropertyName("callbacks")]
    public List<QueueConversationVideoEventTopicCallback> Callbacks { get; set; }



    /// <summary>
    /// Gets or Sets Chats
    /// </summary>
    [JsonPropertyName("chats")]
    public List<QueueConversationVideoEventTopicChat> Chats { get; set; }



    /// <summary>
    /// Gets or Sets Cobrowsesessions
    /// </summary>
    [JsonPropertyName("cobrowsesessions")]
    public List<QueueConversationVideoEventTopicCobrowse> Cobrowsesessions { get; set; }



    /// <summary>
    /// Gets or Sets Emails
    /// </summary>
    [JsonPropertyName("emails")]
    public List<QueueConversationVideoEventTopicEmail> Emails { get; set; }



    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    [JsonPropertyName("messages")]
    public List<QueueConversationVideoEventTopicMessage> Messages { get; set; }



    /// <summary>
    /// Gets or Sets InternalMessages
    /// </summary>
    [JsonPropertyName("internalMessages")]
    public List<QueueConversationVideoEventTopicInternalMessage> InternalMessages { get; set; }



    /// <summary>
    /// Gets or Sets Screenshares
    /// </summary>
    [JsonPropertyName("screenshares")]
    public List<QueueConversationVideoEventTopicScreenshare> Screenshares { get; set; }



    /// <summary>
    /// Gets or Sets SocialExpressions
    /// </summary>
    [JsonPropertyName("socialExpressions")]
    public List<QueueConversationVideoEventTopicSocialExpression> SocialExpressions { get; set; }



    /// <summary>
    /// Gets or Sets Videos
    /// </summary>
    [JsonPropertyName("videos")]
    public List<QueueConversationVideoEventTopicVideo> Videos { get; set; }



    /// <summary>
    /// Gets or Sets Workflow
    /// </summary>
    [JsonPropertyName("workflow")]
    public QueueConversationVideoEventTopicWorkflow Workflow { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationVideoEventTopicParticipant {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  EndTime: ").Append(EndTime).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
        sb.Append("  ExternalContactInitialDivisionId: ").Append(ExternalContactInitialDivisionId).Append("\n");
        sb.Append("  ExternalOrganizationId: ").Append(ExternalOrganizationId).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  GroupId: ").Append(GroupId).Append("\n");
        sb.Append("  TeamId: ").Append(TeamId).Append("\n");
        sb.Append("  Purpose: ").Append(Purpose).Append("\n");
        sb.Append("  ConsultParticipantId: ").Append(ConsultParticipantId).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  WrapupRequired: ").Append(WrapupRequired).Append("\n");
        sb.Append("  WrapupExpected: ").Append(WrapupExpected).Append("\n");
        sb.Append("  WrapupPrompt: ").Append(WrapupPrompt).Append("\n");
        sb.Append("  WrapupTimeoutMs: ").Append(WrapupTimeoutMs).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  StartAcwTime: ").Append(StartAcwTime).Append("\n");
        sb.Append("  EndAcwTime: ").Append(EndAcwTime).Append("\n");
        sb.Append("  ConversationRoutingData: ").Append(ConversationRoutingData).Append("\n");
        sb.Append("  AlertingTimeoutMs: ").Append(AlertingTimeoutMs).Append("\n");
        sb.Append("  MonitoredParticipantId: ").Append(MonitoredParticipantId).Append("\n");
        sb.Append("  CoachedParticipantId: ").Append(CoachedParticipantId).Append("\n");
        sb.Append("  BargedParticipantId: ").Append(BargedParticipantId).Append("\n");
        sb.Append("  MediaRoles: ").Append(MediaRoles).Append("\n");
        sb.Append("  ScreenRecordingState: ").Append(ScreenRecordingState).Append("\n");
        sb.Append("  FlaggedReason: ").Append(FlaggedReason).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  Calls: ").Append(Calls).Append("\n");
        sb.Append("  Callbacks: ").Append(Callbacks).Append("\n");
        sb.Append("  Chats: ").Append(Chats).Append("\n");
        sb.Append("  Cobrowsesessions: ").Append(Cobrowsesessions).Append("\n");
        sb.Append("  Emails: ").Append(Emails).Append("\n");
        sb.Append("  Messages: ").Append(Messages).Append("\n");
        sb.Append("  InternalMessages: ").Append(InternalMessages).Append("\n");
        sb.Append("  Screenshares: ").Append(Screenshares).Append("\n");
        sb.Append("  SocialExpressions: ").Append(SocialExpressions).Append("\n");
        sb.Append("  Videos: ").Append(Videos).Append("\n");
        sb.Append("  Workflow: ").Append(Workflow).Append("\n");
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
        return Equals(obj as QueueConversationVideoEventTopicParticipant);
    }

    /// <summary>
    /// Returns true if QueueConversationVideoEventTopicParticipant instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationVideoEventTopicParticipant to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationVideoEventTopicParticipant other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
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
                Purpose == other.Purpose ||
                Purpose != null &&
                Purpose.Equals(other.Purpose)
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
                WrapupRequired == other.WrapupRequired ||
                WrapupRequired != null &&
                WrapupRequired.Equals(other.WrapupRequired)
            ) &&
            (
                WrapupExpected == other.WrapupExpected ||
                WrapupExpected != null &&
                WrapupExpected.Equals(other.WrapupExpected)
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
                Wrapup == other.Wrapup ||
                Wrapup != null &&
                Wrapup.Equals(other.Wrapup)
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
                BargedParticipantId == other.BargedParticipantId ||
                BargedParticipantId != null &&
                BargedParticipantId.Equals(other.BargedParticipantId)
            ) &&
            (
                MediaRoles == other.MediaRoles ||
                MediaRoles != null &&
                MediaRoles.SequenceEqual(other.MediaRoles)
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
                InternalMessages == other.InternalMessages ||
                InternalMessages != null &&
                InternalMessages.SequenceEqual(other.InternalMessages)
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
                Workflow == other.Workflow ||
                Workflow != null &&
                Workflow.Equals(other.Workflow)
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

            if (ConnectedTime != null)
            {
                hash = hash * 59 + ConnectedTime.GetHashCode();
            }

            if (EndTime != null)
            {
                hash = hash * 59 + EndTime.GetHashCode();
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
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

            if (Purpose != null)
            {
                hash = hash * 59 + Purpose.GetHashCode();
            }

            if (ConsultParticipantId != null)
            {
                hash = hash * 59 + ConsultParticipantId.GetHashCode();
            }

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            if (WrapupRequired != null)
            {
                hash = hash * 59 + WrapupRequired.GetHashCode();
            }

            if (WrapupExpected != null)
            {
                hash = hash * 59 + WrapupExpected.GetHashCode();
            }

            if (WrapupPrompt != null)
            {
                hash = hash * 59 + WrapupPrompt.GetHashCode();
            }

            if (WrapupTimeoutMs != null)
            {
                hash = hash * 59 + WrapupTimeoutMs.GetHashCode();
            }

            if (Wrapup != null)
            {
                hash = hash * 59 + Wrapup.GetHashCode();
            }

            if (StartAcwTime != null)
            {
                hash = hash * 59 + StartAcwTime.GetHashCode();
            }

            if (EndAcwTime != null)
            {
                hash = hash * 59 + EndAcwTime.GetHashCode();
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

            if (BargedParticipantId != null)
            {
                hash = hash * 59 + BargedParticipantId.GetHashCode();
            }

            if (MediaRoles != null)
            {
                hash = hash * 59 + MediaRoles.GetHashCode();
            }

            if (ScreenRecordingState != null)
            {
                hash = hash * 59 + ScreenRecordingState.GetHashCode();
            }

            if (FlaggedReason != null)
            {
                hash = hash * 59 + FlaggedReason.GetHashCode();
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

            if (InternalMessages != null)
            {
                hash = hash * 59 + InternalMessages.GetHashCode();
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

            if (Workflow != null)
            {
                hash = hash * 59 + Workflow.GetHashCode();
            }

            return hash;
        }
    }
}
