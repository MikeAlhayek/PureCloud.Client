using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationResponse
/// </summary>

public partial class EvaluationResponse : IEquatable<EvaluationResponse>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pending for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// Enum Inprogress for "INPROGRESS"
        /// </summary>
        [EnumMember(Value = "INPROGRESS")]
        Inprogress,

        /// <summary>
        /// Enum Finished for "FINISHED"
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        Finished,

        /// <summary>
        /// Enum Inreview for "INREVIEW"
        /// </summary>
        [EnumMember(Value = "INREVIEW")]
        Inreview,

        /// <summary>
        /// Enum Retracted for "RETRACTED"
        /// </summary>
        [EnumMember(Value = "RETRACTED")]
        Retracted
    }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    
    public enum MediaTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Call for "CALL"
        /// </summary>
        [EnumMember(Value = "CALL")]
        Call,

        /// <summary>
        /// Enum Callback for "CALLBACK"
        /// </summary>
        [EnumMember(Value = "CALLBACK")]
        Callback,

        /// <summary>
        /// Enum Chat for "CHAT"
        /// </summary>
        [EnumMember(Value = "CHAT")]
        Chat,

        /// <summary>
        /// Enum Cobrowse for "COBROWSE"
        /// </summary>
        [EnumMember(Value = "COBROWSE")]
        Cobrowse,

        /// <summary>
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email,

        /// <summary>
        /// Enum Message for "MESSAGE"
        /// </summary>
        [EnumMember(Value = "MESSAGE")]
        Message,

        /// <summary>
        /// Enum InternalMessage for "INTERNAL_MESSAGE"
        /// </summary>
        [EnumMember(Value = "INTERNAL_MESSAGE")]
        InternalMessage,

        /// <summary>
        /// Enum SocialExpression for "SOCIAL_EXPRESSION"
        /// </summary>
        [EnumMember(Value = "SOCIAL_EXPRESSION")]
        SocialExpression,

        /// <summary>
        /// Enum Video for "VIDEO"
        /// </summary>
        [EnumMember(Value = "VIDEO")]
        Video,

        /// <summary>
        /// Enum Screenshare for "SCREENSHARE"
        /// </summary>
        [EnumMember(Value = "SCREENSHARE")]
        Screenshare
    }
    /// <summary>
    /// The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.
    /// </summary>
    /// <value>The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.</value>
    
    public enum ResourceTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.
    /// </summary>
    /// <value>The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources.</value>
    [JsonPropertyName("resourceType")]
    public ResourceTypeEnum? ResourceType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationResponse" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Conversation">Conversation.</param>
    /// <param name="EvaluationForm">Evaluation form used for evaluation..</param>
    /// <param name="Evaluator">Evaluator.</param>
    /// <param name="Agent">Agent.</param>
    /// <param name="Calibration">Calibration.</param>
    /// <param name="Status">Status.</param>
    /// <param name="Answers">Answers.</param>
    /// <param name="AgentHasRead">AgentHasRead.</param>
    /// <param name="Assignee">Assignee.</param>
    /// <param name="AssigneeApplicable">Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable..</param>
    /// <param name="ReleaseDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="AssignedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ChangedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="RevisionCreatedDate">Date of when evaluation revision is created. Null if there is no revision. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Queue">Queue.</param>
    /// <param name="MediaType">List of different communication types used in conversation..</param>
    /// <param name="Rescore">Is only true when evaluation is re-scored..</param>
    /// <param name="ConversationDate">Date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ConversationEndDate">End date of conversation if it had completed before evaluation creation. Null if created before the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="NeverRelease">Signifies if the evaluation is never to be released. This cannot be set true if release date is also set..</param>
    /// <param name="Assigned">Set to false to unassign the evaluation. This cannot be set to false when assignee is also set..</param>
    /// <param name="DateAssigneeChanged">Date when the assignee was last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ResourceId">Only used for email evaluations. Will be null for all other evaluations..</param>
    /// <param name="ResourceType">The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources..</param>
    /// <param name="Redacted">Is only true when the user making the request does not have sufficient permissions to see evaluation.</param>
    /// <param name="IsScoringIndex">IsScoringIndex.</param>
    /// <param name="AuthorizedActions">List of user authorized actions on evaluation. Possible values: assign, edit, editScore, editAgentSignoff, delete, release, viewAudit.</param>
    /// <param name="HasAssistanceFailed">Is true when evaluation assistance didn&#39;t execute successfully.</param>
    public EvaluationResponse(string Name = null, ConversationReference Conversation = null, EvaluationFormResponse EvaluationForm = null, User Evaluator = null, User Agent = null, Calibration Calibration = null, StatusEnum? Status = null, EvaluationScoringSet Answers = null, bool? AgentHasRead = null, User Assignee = null, bool? AssigneeApplicable = null, DateTime? ReleaseDate = null, DateTime? AssignedDate = null, DateTime? ChangedDate = null, DateTime? RevisionCreatedDate = null, Queue Queue = null, List<MediaTypeEnum> MediaType = null, bool? Rescore = null, DateTime? ConversationDate = null, DateTime? ConversationEndDate = null, bool? NeverRelease = null, bool? Assigned = null, DateTime? DateAssigneeChanged = null, string ResourceId = null, ResourceTypeEnum? ResourceType = null, bool? Redacted = null, bool? IsScoringIndex = null, List<string> AuthorizedActions = null, bool? HasAssistanceFailed = null)
    {
        this.Name = Name;
        this.Conversation = Conversation;
        this.EvaluationForm = EvaluationForm;
        this.Evaluator = Evaluator;
        this.Agent = Agent;
        this.Calibration = Calibration;
        this.Status = Status;
        this.Answers = Answers;
        this.AgentHasRead = AgentHasRead;
        this.Assignee = Assignee;
        this.AssigneeApplicable = AssigneeApplicable;
        this.ReleaseDate = ReleaseDate;
        this.AssignedDate = AssignedDate;
        this.ChangedDate = ChangedDate;
        this.RevisionCreatedDate = RevisionCreatedDate;
        this.Queue = Queue;
        this.MediaType = MediaType;
        this.Rescore = Rescore;
        this.ConversationDate = ConversationDate;
        this.ConversationEndDate = ConversationEndDate;
        this.NeverRelease = NeverRelease;
        this.Assigned = Assigned;
        this.DateAssigneeChanged = DateAssigneeChanged;
        this.ResourceId = ResourceId;
        this.ResourceType = ResourceType;
        this.Redacted = Redacted;
        this.IsScoringIndex = IsScoringIndex;
        this.AuthorizedActions = AuthorizedActions;
        this.HasAssistanceFailed = HasAssistanceFailed;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Conversation
    /// </summary>
    [JsonPropertyName("conversation")]
    public ConversationReference Conversation { get; set; }



    /// <summary>
    /// Evaluation form used for evaluation.
    /// </summary>
    /// <value>Evaluation form used for evaluation.</value>
    [JsonPropertyName("evaluationForm")]
    public EvaluationFormResponse EvaluationForm { get; set; }



    /// <summary>
    /// Gets or Sets Evaluator
    /// </summary>
    [JsonPropertyName("evaluator")]
    public User Evaluator { get; set; }



    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    [JsonPropertyName("agent")]
    public User Agent { get; set; }



    /// <summary>
    /// Gets or Sets Calibration
    /// </summary>
    [JsonPropertyName("calibration")]
    public Calibration Calibration { get; set; }





    /// <summary>
    /// Gets or Sets Answers
    /// </summary>
    [JsonPropertyName("answers")]
    public EvaluationScoringSet Answers { get; set; }



    /// <summary>
    /// Gets or Sets AgentHasRead
    /// </summary>
    [JsonPropertyName("agentHasRead")]
    public bool? AgentHasRead { get; set; }



    /// <summary>
    /// Gets or Sets Assignee
    /// </summary>
    [JsonPropertyName("assignee")]
    public User Assignee { get; set; }



    /// <summary>
    /// Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable.
    /// </summary>
    /// <value>Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable.</value>
    [JsonPropertyName("assigneeApplicable")]
    public bool? AssigneeApplicable { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("releaseDate")]
    public DateTime? ReleaseDate { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("assignedDate")]
    public DateTime? AssignedDate { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("changedDate")]
    public DateTime? ChangedDate { get; set; }



    /// <summary>
    /// Date of when evaluation revision is created. Null if there is no revision. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date of when evaluation revision is created. Null if there is no revision. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("revisionCreatedDate")]
    public DateTime? RevisionCreatedDate { get; set; }



    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    [JsonPropertyName("queue")]
    public Queue Queue { get; set; }



    /// <summary>
    /// List of different communication types used in conversation.
    /// </summary>
    /// <value>List of different communication types used in conversation.</value>
    [JsonPropertyName("mediaType")]
    public List<MediaTypeEnum> MediaType { get; set; }



    /// <summary>
    /// Is only true when evaluation is re-scored.
    /// </summary>
    /// <value>Is only true when evaluation is re-scored.</value>
    [JsonPropertyName("rescore")]
    public bool? Rescore { get; set; }



    /// <summary>
    /// Date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("conversationDate")]
    public DateTime? ConversationDate { get; set; }



    /// <summary>
    /// End date of conversation if it had completed before evaluation creation. Null if created before the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>End date of conversation if it had completed before evaluation creation. Null if created before the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("conversationEndDate")]
    public DateTime? ConversationEndDate { get; set; }



    /// <summary>
    /// Signifies if the evaluation is never to be released. This cannot be set true if release date is also set.
    /// </summary>
    /// <value>Signifies if the evaluation is never to be released. This cannot be set true if release date is also set.</value>
    [JsonPropertyName("neverRelease")]
    public bool? NeverRelease { get; set; }



    /// <summary>
    /// Set to false to unassign the evaluation. This cannot be set to false when assignee is also set.
    /// </summary>
    /// <value>Set to false to unassign the evaluation. This cannot be set to false when assignee is also set.</value>
    [JsonPropertyName("assigned")]
    public bool? Assigned { get; set; }



    /// <summary>
    /// Date when the assignee was last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the assignee was last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateAssigneeChanged")]
    public DateTime? DateAssigneeChanged { get; set; }



    /// <summary>
    /// Only used for email evaluations. Will be null for all other evaluations.
    /// </summary>
    /// <value>Only used for email evaluations. Will be null for all other evaluations.</value>
    [JsonPropertyName("resourceId")]
    public string ResourceId { get; set; }





    /// <summary>
    /// Is only true when the user making the request does not have sufficient permissions to see evaluation
    /// </summary>
    /// <value>Is only true when the user making the request does not have sufficient permissions to see evaluation</value>
    [JsonPropertyName("redacted")]
    public bool? Redacted { get; set; }



    /// <summary>
    /// Gets or Sets IsScoringIndex
    /// </summary>
    [JsonPropertyName("isScoringIndex")]
    public bool? IsScoringIndex { get; set; }



    /// <summary>
    /// List of user authorized actions on evaluation. Possible values: assign, edit, editScore, editAgentSignoff, delete, release, viewAudit
    /// </summary>
    /// <value>List of user authorized actions on evaluation. Possible values: assign, edit, editScore, editAgentSignoff, delete, release, viewAudit</value>
    [JsonPropertyName("authorizedActions")]
    public List<string> AuthorizedActions { get; set; }



    /// <summary>
    /// Is true when evaluation assistance didn&#39;t execute successfully
    /// </summary>
    /// <value>Is true when evaluation assistance didn&#39;t execute successfully</value>
    [JsonPropertyName("hasAssistanceFailed")]
    public bool? HasAssistanceFailed { get; set; }



    /// <summary>
    /// The source that created the evaluation.
    /// </summary>
    /// <value>The source that created the evaluation.</value>
    [JsonPropertyName("evaluationSource")]
    public EvaluationSource EvaluationSource { get; private set; }



    /// <summary>
    /// AI scoring details for the evaluation.
    /// </summary>
    /// <value>AI scoring details for the evaluation.</value>
    [JsonPropertyName("aiScoring")]
    public AiScoring AiScoring { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EvaluationResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
        sb.Append("  Evaluator: ").Append(Evaluator).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  Calibration: ").Append(Calibration).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Answers: ").Append(Answers).Append("\n");
        sb.Append("  AgentHasRead: ").Append(AgentHasRead).Append("\n");
        sb.Append("  Assignee: ").Append(Assignee).Append("\n");
        sb.Append("  AssigneeApplicable: ").Append(AssigneeApplicable).Append("\n");
        sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
        sb.Append("  AssignedDate: ").Append(AssignedDate).Append("\n");
        sb.Append("  ChangedDate: ").Append(ChangedDate).Append("\n");
        sb.Append("  RevisionCreatedDate: ").Append(RevisionCreatedDate).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  Rescore: ").Append(Rescore).Append("\n");
        sb.Append("  ConversationDate: ").Append(ConversationDate).Append("\n");
        sb.Append("  ConversationEndDate: ").Append(ConversationEndDate).Append("\n");
        sb.Append("  NeverRelease: ").Append(NeverRelease).Append("\n");
        sb.Append("  Assigned: ").Append(Assigned).Append("\n");
        sb.Append("  DateAssigneeChanged: ").Append(DateAssigneeChanged).Append("\n");
        sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
        sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
        sb.Append("  Redacted: ").Append(Redacted).Append("\n");
        sb.Append("  IsScoringIndex: ").Append(IsScoringIndex).Append("\n");
        sb.Append("  AuthorizedActions: ").Append(AuthorizedActions).Append("\n");
        sb.Append("  HasAssistanceFailed: ").Append(HasAssistanceFailed).Append("\n");
        sb.Append("  EvaluationSource: ").Append(EvaluationSource).Append("\n");
        sb.Append("  AiScoring: ").Append(AiScoring).Append("\n");
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
        return Equals(obj as EvaluationResponse);
    }

    /// <summary>
    /// Returns true if EvaluationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of EvaluationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EvaluationResponse other)
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
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                EvaluationForm == other.EvaluationForm ||
                EvaluationForm != null &&
                EvaluationForm.Equals(other.EvaluationForm)
            ) &&
            (
                Evaluator == other.Evaluator ||
                Evaluator != null &&
                Evaluator.Equals(other.Evaluator)
            ) &&
            (
                Agent == other.Agent ||
                Agent != null &&
                Agent.Equals(other.Agent)
            ) &&
            (
                Calibration == other.Calibration ||
                Calibration != null &&
                Calibration.Equals(other.Calibration)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Answers == other.Answers ||
                Answers != null &&
                Answers.Equals(other.Answers)
            ) &&
            (
                AgentHasRead == other.AgentHasRead ||
                AgentHasRead != null &&
                AgentHasRead.Equals(other.AgentHasRead)
            ) &&
            (
                Assignee == other.Assignee ||
                Assignee != null &&
                Assignee.Equals(other.Assignee)
            ) &&
            (
                AssigneeApplicable == other.AssigneeApplicable ||
                AssigneeApplicable != null &&
                AssigneeApplicable.Equals(other.AssigneeApplicable)
            ) &&
            (
                ReleaseDate == other.ReleaseDate ||
                ReleaseDate != null &&
                ReleaseDate.Equals(other.ReleaseDate)
            ) &&
            (
                AssignedDate == other.AssignedDate ||
                AssignedDate != null &&
                AssignedDate.Equals(other.AssignedDate)
            ) &&
            (
                ChangedDate == other.ChangedDate ||
                ChangedDate != null &&
                ChangedDate.Equals(other.ChangedDate)
            ) &&
            (
                RevisionCreatedDate == other.RevisionCreatedDate ||
                RevisionCreatedDate != null &&
                RevisionCreatedDate.Equals(other.RevisionCreatedDate)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.SequenceEqual(other.MediaType)
            ) &&
            (
                Rescore == other.Rescore ||
                Rescore != null &&
                Rescore.Equals(other.Rescore)
            ) &&
            (
                ConversationDate == other.ConversationDate ||
                ConversationDate != null &&
                ConversationDate.Equals(other.ConversationDate)
            ) &&
            (
                ConversationEndDate == other.ConversationEndDate ||
                ConversationEndDate != null &&
                ConversationEndDate.Equals(other.ConversationEndDate)
            ) &&
            (
                NeverRelease == other.NeverRelease ||
                NeverRelease != null &&
                NeverRelease.Equals(other.NeverRelease)
            ) &&
            (
                Assigned == other.Assigned ||
                Assigned != null &&
                Assigned.Equals(other.Assigned)
            ) &&
            (
                DateAssigneeChanged == other.DateAssigneeChanged ||
                DateAssigneeChanged != null &&
                DateAssigneeChanged.Equals(other.DateAssigneeChanged)
            ) &&
            (
                ResourceId == other.ResourceId ||
                ResourceId != null &&
                ResourceId.Equals(other.ResourceId)
            ) &&
            (
                ResourceType == other.ResourceType ||
                ResourceType != null &&
                ResourceType.Equals(other.ResourceType)
            ) &&
            (
                Redacted == other.Redacted ||
                Redacted != null &&
                Redacted.Equals(other.Redacted)
            ) &&
            (
                IsScoringIndex == other.IsScoringIndex ||
                IsScoringIndex != null &&
                IsScoringIndex.Equals(other.IsScoringIndex)
            ) &&
            (
                AuthorizedActions == other.AuthorizedActions ||
                AuthorizedActions != null &&
                AuthorizedActions.SequenceEqual(other.AuthorizedActions)
            ) &&
            (
                HasAssistanceFailed == other.HasAssistanceFailed ||
                HasAssistanceFailed != null &&
                HasAssistanceFailed.Equals(other.HasAssistanceFailed)
            ) &&
            (
                EvaluationSource == other.EvaluationSource ||
                EvaluationSource != null &&
                EvaluationSource.Equals(other.EvaluationSource)
            ) &&
            (
                AiScoring == other.AiScoring ||
                AiScoring != null &&
                AiScoring.Equals(other.AiScoring)
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

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (EvaluationForm != null)
            {
                hash = hash * 59 + EvaluationForm.GetHashCode();
            }

            if (Evaluator != null)
            {
                hash = hash * 59 + Evaluator.GetHashCode();
            }

            if (Agent != null)
            {
                hash = hash * 59 + Agent.GetHashCode();
            }

            if (Calibration != null)
            {
                hash = hash * 59 + Calibration.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Answers != null)
            {
                hash = hash * 59 + Answers.GetHashCode();
            }

            if (AgentHasRead != null)
            {
                hash = hash * 59 + AgentHasRead.GetHashCode();
            }

            if (Assignee != null)
            {
                hash = hash * 59 + Assignee.GetHashCode();
            }

            if (AssigneeApplicable != null)
            {
                hash = hash * 59 + AssigneeApplicable.GetHashCode();
            }

            if (ReleaseDate != null)
            {
                hash = hash * 59 + ReleaseDate.GetHashCode();
            }

            if (AssignedDate != null)
            {
                hash = hash * 59 + AssignedDate.GetHashCode();
            }

            if (ChangedDate != null)
            {
                hash = hash * 59 + ChangedDate.GetHashCode();
            }

            if (RevisionCreatedDate != null)
            {
                hash = hash * 59 + RevisionCreatedDate.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (Rescore != null)
            {
                hash = hash * 59 + Rescore.GetHashCode();
            }

            if (ConversationDate != null)
            {
                hash = hash * 59 + ConversationDate.GetHashCode();
            }

            if (ConversationEndDate != null)
            {
                hash = hash * 59 + ConversationEndDate.GetHashCode();
            }

            if (NeverRelease != null)
            {
                hash = hash * 59 + NeverRelease.GetHashCode();
            }

            if (Assigned != null)
            {
                hash = hash * 59 + Assigned.GetHashCode();
            }

            if (DateAssigneeChanged != null)
            {
                hash = hash * 59 + DateAssigneeChanged.GetHashCode();
            }

            if (ResourceId != null)
            {
                hash = hash * 59 + ResourceId.GetHashCode();
            }

            if (ResourceType != null)
            {
                hash = hash * 59 + ResourceType.GetHashCode();
            }

            if (Redacted != null)
            {
                hash = hash * 59 + Redacted.GetHashCode();
            }

            if (IsScoringIndex != null)
            {
                hash = hash * 59 + IsScoringIndex.GetHashCode();
            }

            if (AuthorizedActions != null)
            {
                hash = hash * 59 + AuthorizedActions.GetHashCode();
            }

            if (HasAssistanceFailed != null)
            {
                hash = hash * 59 + HasAssistanceFailed.GetHashCode();
            }

            if (EvaluationSource != null)
            {
                hash = hash * 59 + EvaluationSource.GetHashCode();
            }

            if (AiScoring != null)
            {
                hash = hash * 59 + AiScoring.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
