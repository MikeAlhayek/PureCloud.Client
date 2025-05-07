using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateQueueRequest
/// </summary>

public partial class CreateQueueRequest : IEquatable<CreateQueueRequest>
{
    /// <summary>
    /// The Scoring Method for the queue.
    /// </summary>
    /// <value>The Scoring Method for the queue.</value>
    
    public enum ScoringMethodEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Timestampandpriority for "TimestampAndPriority"
        /// </summary>
        [EnumMember(Value = "TimestampAndPriority")]
        Timestampandpriority,

        /// <summary>
        /// Enum Priorityonly for "PriorityOnly"
        /// </summary>
        [EnumMember(Value = "PriorityOnly")]
        Priorityonly
    }
    /// <summary>
    /// The Last Agent Routing Mode for the queue.
    /// </summary>
    /// <value>The Last Agent Routing Mode for the queue.</value>
    
    public enum LastAgentRoutingModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Disabled for "Disabled"
        /// </summary>
        [EnumMember(Value = "Disabled")]
        Disabled,

        /// <summary>
        /// Enum Queuemembersonly for "QueueMembersOnly"
        /// </summary>
        [EnumMember(Value = "QueueMembersOnly")]
        Queuemembersonly,

        /// <summary>
        /// Enum Anyagent for "AnyAgent"
        /// </summary>
        [EnumMember(Value = "AnyAgent")]
        Anyagent
    }
    /// <summary>
    /// The skill evaluation method to use when routing conversations.
    /// </summary>
    /// <value>The skill evaluation method to use when routing conversations.</value>
    
    public enum SkillEvaluationMethodEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum None for "NONE"
        /// </summary>
        [EnumMember(Value = "NONE")]
        None,

        /// <summary>
        /// Enum Best for "BEST"
        /// </summary>
        [EnumMember(Value = "BEST")]
        Best,

        /// <summary>
        /// Enum All for "ALL"
        /// </summary>
        [EnumMember(Value = "ALL")]
        All
    }
    /// <summary>
    /// The Scoring Method for the queue.
    /// </summary>
    /// <value>The Scoring Method for the queue.</value>
    [JsonPropertyName("scoringMethod")]
    public ScoringMethodEnum? ScoringMethod { get; set; }
    /// <summary>
    /// The Last Agent Routing Mode for the queue.
    /// </summary>
    /// <value>The Last Agent Routing Mode for the queue.</value>
    [JsonPropertyName("lastAgentRoutingMode")]
    public LastAgentRoutingModeEnum? LastAgentRoutingMode { get; set; }
    /// <summary>
    /// The skill evaluation method to use when routing conversations.
    /// </summary>
    /// <value>The skill evaluation method to use when routing conversations.</value>
    [JsonPropertyName("skillEvaluationMethod")]
    public SkillEvaluationMethodEnum? SkillEvaluationMethod { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateQueueRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateQueueRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateQueueRequest" /> class.
    /// </summary>
    /// <param name="Name">The queue name (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The queue description..</param>
    /// <param name="DateCreated">The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ModifiedBy">The ID of the user that last modified the queue..</param>
    /// <param name="CreatedBy">The ID of the user that created the queue..</param>
    /// <param name="MediaSettings">The media settings for the queue..</param>
    /// <param name="RoutingRules">The routing rules for the queue, used for Preferred Agent Routing..</param>
    /// <param name="ConditionalGroupRouting">The Conditional Group Routing settings for the queue..</param>
    /// <param name="Bullseye">The bullseye settings for the queue..</param>
    /// <param name="ScoringMethod">The Scoring Method for the queue..</param>
    /// <param name="LastAgentRoutingMode">The Last Agent Routing Mode for the queue..</param>
    /// <param name="AcwSettings">The ACW settings for the queue..</param>
    /// <param name="SkillEvaluationMethod">The skill evaluation method to use when routing conversations..</param>
    /// <param name="MemberGroups">The groups of agents associated with the queue, if any.  Queue membership will update to match group membership changes..</param>
    /// <param name="QueueFlow">The in-queue flow to use for call conversations waiting in queue..</param>
    /// <param name="EmailInQueueFlow">The in-queue flow to use for email conversations waiting in queue..</param>
    /// <param name="MessageInQueueFlow">The in-queue flow to use for message conversations waiting in queue..</param>
    /// <param name="WhisperPrompt">The prompt used for whisper on the queue, if configured..</param>
    /// <param name="OnHoldPrompt">The audio to be played when calls on this queue are on hold. If not configured, the default on-hold music will play..</param>
    /// <param name="AutoAnswerOnly">Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered..</param>
    /// <param name="CannedResponseLibraries">Canned response library IDs and mode with which they are associated with the queue.</param>
    /// <param name="EnableTranscription">Indicates whether voice transcription is enabled for this queue..</param>
    /// <param name="EnableAudioMonitoring">Indicates whether audio monitoring is enabled for this queue..</param>
    /// <param name="EnableManualAssignment">Indicates whether manual assignment is enabled for this queue..</param>
    /// <param name="AgentOwnedRouting">The Agent Owned Routing settings for the queue.</param>
    /// <param name="DirectRouting">The Direct Routing settings for the queue.</param>
    /// <param name="CallingPartyName">The name to use for caller identification for outbound calls from this queue..</param>
    /// <param name="CallingPartyNumber">The phone number to use for caller identification for outbound calls from this queue..</param>
    /// <param name="DefaultScripts">The default script Ids for the communication types..</param>
    /// <param name="OutboundMessagingAddresses">The messaging addresses for the queue..</param>
    /// <param name="OutboundEmailAddress">The default email address to use for outbound email from this queue..</param>
    /// <param name="PeerId">The ID of an associated external queue..</param>
    /// <param name="SuppressInQueueCallRecording">Indicates whether recording in-queue calls is suppressed for this queue..</param>
    /// <param name="SourceQueueId">The id of an existing queue to copy the settings (does not include GPR settings) from when creating a new queue..</param>
    public CreateQueueRequest(string Name = null, WritableDivision Division = null, string Description = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ModifiedBy = null, string CreatedBy = null, QueueMediaSettings MediaSettings = null, List<RoutingRule> RoutingRules = null, ConditionalGroupRouting ConditionalGroupRouting = null, Bullseye Bullseye = null, ScoringMethodEnum? ScoringMethod = null, LastAgentRoutingModeEnum? LastAgentRoutingMode = null, AcwSettings AcwSettings = null, SkillEvaluationMethodEnum? SkillEvaluationMethod = null, List<MemberGroup> MemberGroups = null, DomainEntityRef QueueFlow = null, DomainEntityRef EmailInQueueFlow = null, DomainEntityRef MessageInQueueFlow = null, DomainEntityRef WhisperPrompt = null, DomainEntityRef OnHoldPrompt = null, bool? AutoAnswerOnly = null, CannedResponseLibraries CannedResponseLibraries = null, bool? EnableTranscription = null, bool? EnableAudioMonitoring = null, bool? EnableManualAssignment = null, AgentOwnedRouting AgentOwnedRouting = null, DirectRouting DirectRouting = null, string CallingPartyName = null, string CallingPartyNumber = null, Dictionary<string, Script> DefaultScripts = null, QueueMessagingAddresses OutboundMessagingAddresses = null, QueueEmailAddress OutboundEmailAddress = null, string PeerId = null, bool? SuppressInQueueCallRecording = null, string SourceQueueId = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.ModifiedBy = ModifiedBy;
        this.CreatedBy = CreatedBy;
        this.MediaSettings = MediaSettings;
        this.RoutingRules = RoutingRules;
        this.ConditionalGroupRouting = ConditionalGroupRouting;
        this.Bullseye = Bullseye;
        this.ScoringMethod = ScoringMethod;
        this.LastAgentRoutingMode = LastAgentRoutingMode;
        this.AcwSettings = AcwSettings;
        this.SkillEvaluationMethod = SkillEvaluationMethod;
        this.MemberGroups = MemberGroups;
        this.QueueFlow = QueueFlow;
        this.EmailInQueueFlow = EmailInQueueFlow;
        this.MessageInQueueFlow = MessageInQueueFlow;
        this.WhisperPrompt = WhisperPrompt;
        this.OnHoldPrompt = OnHoldPrompt;
        this.AutoAnswerOnly = AutoAnswerOnly;
        this.CannedResponseLibraries = CannedResponseLibraries;
        this.EnableTranscription = EnableTranscription;
        this.EnableAudioMonitoring = EnableAudioMonitoring;
        this.EnableManualAssignment = EnableManualAssignment;
        this.AgentOwnedRouting = AgentOwnedRouting;
        this.DirectRouting = DirectRouting;
        this.CallingPartyName = CallingPartyName;
        this.CallingPartyNumber = CallingPartyNumber;
        this.DefaultScripts = DefaultScripts;
        this.OutboundMessagingAddresses = OutboundMessagingAddresses;
        this.OutboundEmailAddress = OutboundEmailAddress;
        this.PeerId = PeerId;
        this.SuppressInQueueCallRecording = SuppressInQueueCallRecording;
        this.SourceQueueId = SourceQueueId;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The queue name
    /// </summary>
    /// <value>The queue name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public WritableDivision Division { get; set; }



    /// <summary>
    /// The queue description.
    /// </summary>
    /// <value>The queue description.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The ID of the user that last modified the queue.
    /// </summary>
    /// <value>The ID of the user that last modified the queue.</value>
    [JsonPropertyName("modifiedBy")]
    public string ModifiedBy { get; set; }



    /// <summary>
    /// The ID of the user that created the queue.
    /// </summary>
    /// <value>The ID of the user that created the queue.</value>
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; set; }



    /// <summary>
    /// The total number of members in the queue.
    /// </summary>
    /// <value>The total number of members in the queue.</value>
    [JsonPropertyName("memberCount")]
    public int? MemberCount { get; set; }



    /// <summary>
    /// The number of user members (i.e., non-group members) in the queue.
    /// </summary>
    /// <value>The number of user members (i.e., non-group members) in the queue.</value>
    [JsonPropertyName("userMemberCount")]
    public int? UserMemberCount { get; set; }



    /// <summary>
    /// The number of joined members in the queue.
    /// </summary>
    /// <value>The number of joined members in the queue.</value>
    [JsonPropertyName("joinedMemberCount")]
    public int? JoinedMemberCount { get; set; }



    /// <summary>
    /// The media settings for the queue.
    /// </summary>
    /// <value>The media settings for the queue.</value>
    [JsonPropertyName("mediaSettings")]
    public QueueMediaSettings MediaSettings { get; set; }



    /// <summary>
    /// The routing rules for the queue, used for Preferred Agent Routing.
    /// </summary>
    /// <value>The routing rules for the queue, used for Preferred Agent Routing.</value>
    [JsonPropertyName("routingRules")]
    public List<RoutingRule> RoutingRules { get; set; }



    /// <summary>
    /// The Conditional Group Routing settings for the queue.
    /// </summary>
    /// <value>The Conditional Group Routing settings for the queue.</value>
    [JsonPropertyName("conditionalGroupRouting")]
    public ConditionalGroupRouting ConditionalGroupRouting { get; set; }



    /// <summary>
    /// The bullseye settings for the queue.
    /// </summary>
    /// <value>The bullseye settings for the queue.</value>
    [JsonPropertyName("bullseye")]
    public Bullseye Bullseye { get; set; }







    /// <summary>
    /// The ACW settings for the queue.
    /// </summary>
    /// <value>The ACW settings for the queue.</value>
    [JsonPropertyName("acwSettings")]
    public AcwSettings AcwSettings { get; set; }





    /// <summary>
    /// The groups of agents associated with the queue, if any.  Queue membership will update to match group membership changes.
    /// </summary>
    /// <value>The groups of agents associated with the queue, if any.  Queue membership will update to match group membership changes.</value>
    [JsonPropertyName("memberGroups")]
    public List<MemberGroup> MemberGroups { get; set; }



    /// <summary>
    /// The in-queue flow to use for call conversations waiting in queue.
    /// </summary>
    /// <value>The in-queue flow to use for call conversations waiting in queue.</value>
    [JsonPropertyName("queueFlow")]
    public DomainEntityRef QueueFlow { get; set; }



    /// <summary>
    /// The in-queue flow to use for email conversations waiting in queue.
    /// </summary>
    /// <value>The in-queue flow to use for email conversations waiting in queue.</value>
    [JsonPropertyName("emailInQueueFlow")]
    public DomainEntityRef EmailInQueueFlow { get; set; }



    /// <summary>
    /// The in-queue flow to use for message conversations waiting in queue.
    /// </summary>
    /// <value>The in-queue flow to use for message conversations waiting in queue.</value>
    [JsonPropertyName("messageInQueueFlow")]
    public DomainEntityRef MessageInQueueFlow { get; set; }



    /// <summary>
    /// The prompt used for whisper on the queue, if configured.
    /// </summary>
    /// <value>The prompt used for whisper on the queue, if configured.</value>
    [JsonPropertyName("whisperPrompt")]
    public DomainEntityRef WhisperPrompt { get; set; }



    /// <summary>
    /// The audio to be played when calls on this queue are on hold. If not configured, the default on-hold music will play.
    /// </summary>
    /// <value>The audio to be played when calls on this queue are on hold. If not configured, the default on-hold music will play.</value>
    [JsonPropertyName("onHoldPrompt")]
    public DomainEntityRef OnHoldPrompt { get; set; }



    /// <summary>
    /// Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered.
    /// </summary>
    /// <value>Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered.</value>
    [JsonPropertyName("autoAnswerOnly")]
    public bool? AutoAnswerOnly { get; set; }



    /// <summary>
    /// Canned response library IDs and mode with which they are associated with the queue
    /// </summary>
    /// <value>Canned response library IDs and mode with which they are associated with the queue</value>
    [JsonPropertyName("cannedResponseLibraries")]
    public CannedResponseLibraries CannedResponseLibraries { get; set; }



    /// <summary>
    /// Indicates whether voice transcription is enabled for this queue.
    /// </summary>
    /// <value>Indicates whether voice transcription is enabled for this queue.</value>
    [JsonPropertyName("enableTranscription")]
    public bool? EnableTranscription { get; set; }



    /// <summary>
    /// Indicates whether audio monitoring is enabled for this queue.
    /// </summary>
    /// <value>Indicates whether audio monitoring is enabled for this queue.</value>
    [JsonPropertyName("enableAudioMonitoring")]
    public bool? EnableAudioMonitoring { get; set; }



    /// <summary>
    /// Indicates whether manual assignment is enabled for this queue.
    /// </summary>
    /// <value>Indicates whether manual assignment is enabled for this queue.</value>
    [JsonPropertyName("enableManualAssignment")]
    public bool? EnableManualAssignment { get; set; }



    /// <summary>
    /// The Agent Owned Routing settings for the queue
    /// </summary>
    /// <value>The Agent Owned Routing settings for the queue</value>
    [JsonPropertyName("agentOwnedRouting")]
    public AgentOwnedRouting AgentOwnedRouting { get; set; }



    /// <summary>
    /// The Direct Routing settings for the queue
    /// </summary>
    /// <value>The Direct Routing settings for the queue</value>
    [JsonPropertyName("directRouting")]
    public DirectRouting DirectRouting { get; set; }



    /// <summary>
    /// The name to use for caller identification for outbound calls from this queue.
    /// </summary>
    /// <value>The name to use for caller identification for outbound calls from this queue.</value>
    [JsonPropertyName("callingPartyName")]
    public string CallingPartyName { get; set; }



    /// <summary>
    /// The phone number to use for caller identification for outbound calls from this queue.
    /// </summary>
    /// <value>The phone number to use for caller identification for outbound calls from this queue.</value>
    [JsonPropertyName("callingPartyNumber")]
    public string CallingPartyNumber { get; set; }



    /// <summary>
    /// The default script Ids for the communication types.
    /// </summary>
    /// <value>The default script Ids for the communication types.</value>
    [JsonPropertyName("defaultScripts")]
    public Dictionary<string, Script> DefaultScripts { get; set; }



    /// <summary>
    /// The messaging addresses for the queue.
    /// </summary>
    /// <value>The messaging addresses for the queue.</value>
    [JsonPropertyName("outboundMessagingAddresses")]
    public QueueMessagingAddresses OutboundMessagingAddresses { get; set; }



    /// <summary>
    /// The default email address to use for outbound email from this queue.
    /// </summary>
    /// <value>The default email address to use for outbound email from this queue.</value>
    [JsonPropertyName("outboundEmailAddress")]
    public QueueEmailAddress OutboundEmailAddress { get; set; }



    /// <summary>
    /// The ID of an associated external queue.
    /// </summary>
    /// <value>The ID of an associated external queue.</value>
    [JsonPropertyName("peerId")]
    public string PeerId { get; set; }



    /// <summary>
    /// Indicates whether recording in-queue calls is suppressed for this queue.
    /// </summary>
    /// <value>Indicates whether recording in-queue calls is suppressed for this queue.</value>
    [JsonPropertyName("suppressInQueueCallRecording")]
    public bool? SuppressInQueueCallRecording { get; set; }



    /// <summary>
    /// The id of an existing queue to copy the settings (does not include GPR settings) from when creating a new queue.
    /// </summary>
    /// <value>The id of an existing queue to copy the settings (does not include GPR settings) from when creating a new queue.</value>
    [JsonPropertyName("sourceQueueId")]
    public string SourceQueueId { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateQueueRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
        sb.Append("  UserMemberCount: ").Append(UserMemberCount).Append("\n");
        sb.Append("  JoinedMemberCount: ").Append(JoinedMemberCount).Append("\n");
        sb.Append("  MediaSettings: ").Append(MediaSettings).Append("\n");
        sb.Append("  RoutingRules: ").Append(RoutingRules).Append("\n");
        sb.Append("  ConditionalGroupRouting: ").Append(ConditionalGroupRouting).Append("\n");
        sb.Append("  Bullseye: ").Append(Bullseye).Append("\n");
        sb.Append("  ScoringMethod: ").Append(ScoringMethod).Append("\n");
        sb.Append("  LastAgentRoutingMode: ").Append(LastAgentRoutingMode).Append("\n");
        sb.Append("  AcwSettings: ").Append(AcwSettings).Append("\n");
        sb.Append("  SkillEvaluationMethod: ").Append(SkillEvaluationMethod).Append("\n");
        sb.Append("  MemberGroups: ").Append(MemberGroups).Append("\n");
        sb.Append("  QueueFlow: ").Append(QueueFlow).Append("\n");
        sb.Append("  EmailInQueueFlow: ").Append(EmailInQueueFlow).Append("\n");
        sb.Append("  MessageInQueueFlow: ").Append(MessageInQueueFlow).Append("\n");
        sb.Append("  WhisperPrompt: ").Append(WhisperPrompt).Append("\n");
        sb.Append("  OnHoldPrompt: ").Append(OnHoldPrompt).Append("\n");
        sb.Append("  AutoAnswerOnly: ").Append(AutoAnswerOnly).Append("\n");
        sb.Append("  CannedResponseLibraries: ").Append(CannedResponseLibraries).Append("\n");
        sb.Append("  EnableTranscription: ").Append(EnableTranscription).Append("\n");
        sb.Append("  EnableAudioMonitoring: ").Append(EnableAudioMonitoring).Append("\n");
        sb.Append("  EnableManualAssignment: ").Append(EnableManualAssignment).Append("\n");
        sb.Append("  AgentOwnedRouting: ").Append(AgentOwnedRouting).Append("\n");
        sb.Append("  DirectRouting: ").Append(DirectRouting).Append("\n");
        sb.Append("  CallingPartyName: ").Append(CallingPartyName).Append("\n");
        sb.Append("  CallingPartyNumber: ").Append(CallingPartyNumber).Append("\n");
        sb.Append("  DefaultScripts: ").Append(DefaultScripts).Append("\n");
        sb.Append("  OutboundMessagingAddresses: ").Append(OutboundMessagingAddresses).Append("\n");
        sb.Append("  OutboundEmailAddress: ").Append(OutboundEmailAddress).Append("\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
        sb.Append("  SuppressInQueueCallRecording: ").Append(SuppressInQueueCallRecording).Append("\n");
        sb.Append("  SourceQueueId: ").Append(SourceQueueId).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as CreateQueueRequest);
    }

    /// <summary>
    /// Returns true if CreateQueueRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateQueueRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateQueueRequest other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                MemberCount == other.MemberCount ||
                MemberCount != null &&
                MemberCount.Equals(other.MemberCount)
            ) &&
            (
                UserMemberCount == other.UserMemberCount ||
                UserMemberCount != null &&
                UserMemberCount.Equals(other.UserMemberCount)
            ) &&
            (
                JoinedMemberCount == other.JoinedMemberCount ||
                JoinedMemberCount != null &&
                JoinedMemberCount.Equals(other.JoinedMemberCount)
            ) &&
            (
                MediaSettings == other.MediaSettings ||
                MediaSettings != null &&
                MediaSettings.Equals(other.MediaSettings)
            ) &&
            (
                RoutingRules == other.RoutingRules ||
                RoutingRules != null &&
                RoutingRules.SequenceEqual(other.RoutingRules)
            ) &&
            (
                ConditionalGroupRouting == other.ConditionalGroupRouting ||
                ConditionalGroupRouting != null &&
                ConditionalGroupRouting.Equals(other.ConditionalGroupRouting)
            ) &&
            (
                Bullseye == other.Bullseye ||
                Bullseye != null &&
                Bullseye.Equals(other.Bullseye)
            ) &&
            (
                ScoringMethod == other.ScoringMethod ||
                ScoringMethod != null &&
                ScoringMethod.Equals(other.ScoringMethod)
            ) &&
            (
                LastAgentRoutingMode == other.LastAgentRoutingMode ||
                LastAgentRoutingMode != null &&
                LastAgentRoutingMode.Equals(other.LastAgentRoutingMode)
            ) &&
            (
                AcwSettings == other.AcwSettings ||
                AcwSettings != null &&
                AcwSettings.Equals(other.AcwSettings)
            ) &&
            (
                SkillEvaluationMethod == other.SkillEvaluationMethod ||
                SkillEvaluationMethod != null &&
                SkillEvaluationMethod.Equals(other.SkillEvaluationMethod)
            ) &&
            (
                MemberGroups == other.MemberGroups ||
                MemberGroups != null &&
                MemberGroups.SequenceEqual(other.MemberGroups)
            ) &&
            (
                QueueFlow == other.QueueFlow ||
                QueueFlow != null &&
                QueueFlow.Equals(other.QueueFlow)
            ) &&
            (
                EmailInQueueFlow == other.EmailInQueueFlow ||
                EmailInQueueFlow != null &&
                EmailInQueueFlow.Equals(other.EmailInQueueFlow)
            ) &&
            (
                MessageInQueueFlow == other.MessageInQueueFlow ||
                MessageInQueueFlow != null &&
                MessageInQueueFlow.Equals(other.MessageInQueueFlow)
            ) &&
            (
                WhisperPrompt == other.WhisperPrompt ||
                WhisperPrompt != null &&
                WhisperPrompt.Equals(other.WhisperPrompt)
            ) &&
            (
                OnHoldPrompt == other.OnHoldPrompt ||
                OnHoldPrompt != null &&
                OnHoldPrompt.Equals(other.OnHoldPrompt)
            ) &&
            (
                AutoAnswerOnly == other.AutoAnswerOnly ||
                AutoAnswerOnly != null &&
                AutoAnswerOnly.Equals(other.AutoAnswerOnly)
            ) &&
            (
                CannedResponseLibraries == other.CannedResponseLibraries ||
                CannedResponseLibraries != null &&
                CannedResponseLibraries.Equals(other.CannedResponseLibraries)
            ) &&
            (
                EnableTranscription == other.EnableTranscription ||
                EnableTranscription != null &&
                EnableTranscription.Equals(other.EnableTranscription)
            ) &&
            (
                EnableAudioMonitoring == other.EnableAudioMonitoring ||
                EnableAudioMonitoring != null &&
                EnableAudioMonitoring.Equals(other.EnableAudioMonitoring)
            ) &&
            (
                EnableManualAssignment == other.EnableManualAssignment ||
                EnableManualAssignment != null &&
                EnableManualAssignment.Equals(other.EnableManualAssignment)
            ) &&
            (
                AgentOwnedRouting == other.AgentOwnedRouting ||
                AgentOwnedRouting != null &&
                AgentOwnedRouting.Equals(other.AgentOwnedRouting)
            ) &&
            (
                DirectRouting == other.DirectRouting ||
                DirectRouting != null &&
                DirectRouting.Equals(other.DirectRouting)
            ) &&
            (
                CallingPartyName == other.CallingPartyName ||
                CallingPartyName != null &&
                CallingPartyName.Equals(other.CallingPartyName)
            ) &&
            (
                CallingPartyNumber == other.CallingPartyNumber ||
                CallingPartyNumber != null &&
                CallingPartyNumber.Equals(other.CallingPartyNumber)
            ) &&
            (
                DefaultScripts == other.DefaultScripts ||
                DefaultScripts != null &&
                DefaultScripts.SequenceEqual(other.DefaultScripts)
            ) &&
            (
                OutboundMessagingAddresses == other.OutboundMessagingAddresses ||
                OutboundMessagingAddresses != null &&
                OutboundMessagingAddresses.Equals(other.OutboundMessagingAddresses)
            ) &&
            (
                OutboundEmailAddress == other.OutboundEmailAddress ||
                OutboundEmailAddress != null &&
                OutboundEmailAddress.Equals(other.OutboundEmailAddress)
            ) &&
            (
                PeerId == other.PeerId ||
                PeerId != null &&
                PeerId.Equals(other.PeerId)
            ) &&
            (
                SuppressInQueueCallRecording == other.SuppressInQueueCallRecording ||
                SuppressInQueueCallRecording != null &&
                SuppressInQueueCallRecording.Equals(other.SuppressInQueueCallRecording)
            ) &&
            (
                SourceQueueId == other.SourceQueueId ||
                SourceQueueId != null &&
                SourceQueueId.Equals(other.SourceQueueId)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (MemberCount != null)
            {
                hash = hash * 59 + MemberCount.GetHashCode();
            }

            if (UserMemberCount != null)
            {
                hash = hash * 59 + UserMemberCount.GetHashCode();
            }

            if (JoinedMemberCount != null)
            {
                hash = hash * 59 + JoinedMemberCount.GetHashCode();
            }

            if (MediaSettings != null)
            {
                hash = hash * 59 + MediaSettings.GetHashCode();
            }

            if (RoutingRules != null)
            {
                hash = hash * 59 + RoutingRules.GetHashCode();
            }

            if (ConditionalGroupRouting != null)
            {
                hash = hash * 59 + ConditionalGroupRouting.GetHashCode();
            }

            if (Bullseye != null)
            {
                hash = hash * 59 + Bullseye.GetHashCode();
            }

            if (ScoringMethod != null)
            {
                hash = hash * 59 + ScoringMethod.GetHashCode();
            }

            if (LastAgentRoutingMode != null)
            {
                hash = hash * 59 + LastAgentRoutingMode.GetHashCode();
            }

            if (AcwSettings != null)
            {
                hash = hash * 59 + AcwSettings.GetHashCode();
            }

            if (SkillEvaluationMethod != null)
            {
                hash = hash * 59 + SkillEvaluationMethod.GetHashCode();
            }

            if (MemberGroups != null)
            {
                hash = hash * 59 + MemberGroups.GetHashCode();
            }

            if (QueueFlow != null)
            {
                hash = hash * 59 + QueueFlow.GetHashCode();
            }

            if (EmailInQueueFlow != null)
            {
                hash = hash * 59 + EmailInQueueFlow.GetHashCode();
            }

            if (MessageInQueueFlow != null)
            {
                hash = hash * 59 + MessageInQueueFlow.GetHashCode();
            }

            if (WhisperPrompt != null)
            {
                hash = hash * 59 + WhisperPrompt.GetHashCode();
            }

            if (OnHoldPrompt != null)
            {
                hash = hash * 59 + OnHoldPrompt.GetHashCode();
            }

            if (AutoAnswerOnly != null)
            {
                hash = hash * 59 + AutoAnswerOnly.GetHashCode();
            }

            if (CannedResponseLibraries != null)
            {
                hash = hash * 59 + CannedResponseLibraries.GetHashCode();
            }

            if (EnableTranscription != null)
            {
                hash = hash * 59 + EnableTranscription.GetHashCode();
            }

            if (EnableAudioMonitoring != null)
            {
                hash = hash * 59 + EnableAudioMonitoring.GetHashCode();
            }

            if (EnableManualAssignment != null)
            {
                hash = hash * 59 + EnableManualAssignment.GetHashCode();
            }

            if (AgentOwnedRouting != null)
            {
                hash = hash * 59 + AgentOwnedRouting.GetHashCode();
            }

            if (DirectRouting != null)
            {
                hash = hash * 59 + DirectRouting.GetHashCode();
            }

            if (CallingPartyName != null)
            {
                hash = hash * 59 + CallingPartyName.GetHashCode();
            }

            if (CallingPartyNumber != null)
            {
                hash = hash * 59 + CallingPartyNumber.GetHashCode();
            }

            if (DefaultScripts != null)
            {
                hash = hash * 59 + DefaultScripts.GetHashCode();
            }

            if (OutboundMessagingAddresses != null)
            {
                hash = hash * 59 + OutboundMessagingAddresses.GetHashCode();
            }

            if (OutboundEmailAddress != null)
            {
                hash = hash * 59 + OutboundEmailAddress.GetHashCode();
            }

            if (PeerId != null)
            {
                hash = hash * 59 + PeerId.GetHashCode();
            }

            if (SuppressInQueueCallRecording != null)
            {
                hash = hash * 59 + SuppressInQueueCallRecording.GetHashCode();
            }

            if (SourceQueueId != null)
            {
                hash = hash * 59 + SourceQueueId.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
