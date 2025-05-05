using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationCreateBody
/// </summary>

public partial class EvaluationCreateBody : IEquatable<EvaluationCreateBody>
{
    /// <summary>
    /// Gets or Sets ResourceType
    /// </summary>
    
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
    /// Gets or Sets ResourceType
    /// </summary>
    [JsonPropertyName("resourceType")]
    public ResourceTypeEnum? ResourceType { get; set; }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationCreateBody" /> class.
    /// </summary>
    /// <param name="EvaluationForm">Evaluation form used for evaluation (must be included for a successful request).</param>
    /// <param name="Evaluator">User ID of the evaluator (must be included for a successful request).</param>
    /// <param name="Agent">User ID of the agent (must be included for a successful request).</param>
    /// <param name="AgentHasRead">AgentHasRead.</param>
    /// <param name="Answers">Answers.</param>
    /// <param name="Calibration">Calibration.</param>
    /// <param name="EvaluationContextId">EvaluationContextId.</param>
    /// <param name="Conversation">Conversation.</param>
    /// <param name="ResourceType">ResourceType.</param>
    /// <param name="EvaluationSource">EvaluationSource.</param>
    /// <param name="Rescore">Rescore.</param>
    /// <param name="Queue">Queue.</param>
    /// <param name="ReleaseDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Status">Status.</param>
    /// <param name="NeverRelease">NeverRelease.</param>
    /// <param name="DateAssigneeChanged">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Assignee">Assignee.</param>
    public EvaluationCreateBody(EvaluationCreateEvalForm EvaluationForm = null, EvaluationCreateUser Evaluator = null, EvaluationCreateUser Agent = null, bool? AgentHasRead = null, EvaluationScoringSet Answers = null, EvaluationCreateCalibration Calibration = null, string EvaluationContextId = null, EvaluationCreateConversation Conversation = null, ResourceTypeEnum? ResourceType = null, EvaluationSource EvaluationSource = null, bool? Rescore = null, EvaluationCreateQueue Queue = null, DateTime? ReleaseDate = null, StatusEnum? Status = null, bool? NeverRelease = null, DateTime? DateAssigneeChanged = null, EvaluationCreateUser Assignee = null)
    {
        this.EvaluationForm = EvaluationForm;
        this.Evaluator = Evaluator;
        this.Agent = Agent;
        this.AgentHasRead = AgentHasRead;
        this.Answers = Answers;
        this.Calibration = Calibration;
        this.EvaluationContextId = EvaluationContextId;
        this.Conversation = Conversation;
        this.ResourceType = ResourceType;
        this.EvaluationSource = EvaluationSource;
        this.Rescore = Rescore;
        this.Queue = Queue;
        this.ReleaseDate = ReleaseDate;
        this.Status = Status;
        this.NeverRelease = NeverRelease;
        this.DateAssigneeChanged = DateAssigneeChanged;
        this.Assignee = Assignee;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Evaluation form used for evaluation (must be included for a successful request)
    /// </summary>
    /// <value>Evaluation form used for evaluation (must be included for a successful request)</value>
    [JsonPropertyName("evaluationForm")]
    public EvaluationCreateEvalForm EvaluationForm { get; set; }



    /// <summary>
    /// User ID of the evaluator (must be included for a successful request)
    /// </summary>
    /// <value>User ID of the evaluator (must be included for a successful request)</value>
    [JsonPropertyName("evaluator")]
    public EvaluationCreateUser Evaluator { get; set; }



    /// <summary>
    /// User ID of the agent (must be included for a successful request)
    /// </summary>
    /// <value>User ID of the agent (must be included for a successful request)</value>
    [JsonPropertyName("agent")]
    public EvaluationCreateUser Agent { get; set; }



    /// <summary>
    /// Gets or Sets AgentHasRead
    /// </summary>
    [JsonPropertyName("agentHasRead")]
    public bool? AgentHasRead { get; set; }



    /// <summary>
    /// Gets or Sets Answers
    /// </summary>
    [JsonPropertyName("answers")]
    public EvaluationScoringSet Answers { get; set; }



    /// <summary>
    /// Gets or Sets Calibration
    /// </summary>
    [JsonPropertyName("calibration")]
    public EvaluationCreateCalibration Calibration { get; set; }



    /// <summary>
    /// Gets or Sets EvaluationContextId
    /// </summary>
    [JsonPropertyName("evaluationContextId")]
    public string EvaluationContextId { get; set; }



    /// <summary>
    /// Gets or Sets Conversation
    /// </summary>
    [JsonPropertyName("conversation")]
    public EvaluationCreateConversation Conversation { get; set; }





    /// <summary>
    /// Gets or Sets EvaluationSource
    /// </summary>
    [JsonPropertyName("evaluationSource")]
    public EvaluationSource EvaluationSource { get; set; }



    /// <summary>
    /// Gets or Sets Rescore
    /// </summary>
    [JsonPropertyName("rescore")]
    public bool? Rescore { get; set; }



    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    [JsonPropertyName("queue")]
    public EvaluationCreateQueue Queue { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("releaseDate")]
    public DateTime? ReleaseDate { get; set; }





    /// <summary>
    /// Gets or Sets NeverRelease
    /// </summary>
    [JsonPropertyName("neverRelease")]
    public bool? NeverRelease { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateAssigneeChanged")]
    public DateTime? DateAssigneeChanged { get; set; }



    /// <summary>
    /// Gets or Sets Assignee
    /// </summary>
    [JsonPropertyName("assignee")]
    public EvaluationCreateUser Assignee { get; set; }



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
        sb.Append("class EvaluationCreateBody {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
        sb.Append("  Evaluator: ").Append(Evaluator).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  AgentHasRead: ").Append(AgentHasRead).Append("\n");
        sb.Append("  Answers: ").Append(Answers).Append("\n");
        sb.Append("  Calibration: ").Append(Calibration).Append("\n");
        sb.Append("  EvaluationContextId: ").Append(EvaluationContextId).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
        sb.Append("  EvaluationSource: ").Append(EvaluationSource).Append("\n");
        sb.Append("  Rescore: ").Append(Rescore).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  NeverRelease: ").Append(NeverRelease).Append("\n");
        sb.Append("  DateAssigneeChanged: ").Append(DateAssigneeChanged).Append("\n");
        sb.Append("  Assignee: ").Append(Assignee).Append("\n");
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
        return Equals(obj as EvaluationCreateBody);
    }

    /// <summary>
    /// Returns true if EvaluationCreateBody instances are equal
    /// </summary>
    /// <param name="other">Instance of EvaluationCreateBody to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EvaluationCreateBody other)
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
                AgentHasRead == other.AgentHasRead ||
                AgentHasRead != null &&
                AgentHasRead.Equals(other.AgentHasRead)
            ) &&
            (
                Answers == other.Answers ||
                Answers != null &&
                Answers.Equals(other.Answers)
            ) &&
            (
                Calibration == other.Calibration ||
                Calibration != null &&
                Calibration.Equals(other.Calibration)
            ) &&
            (
                EvaluationContextId == other.EvaluationContextId ||
                EvaluationContextId != null &&
                EvaluationContextId.Equals(other.EvaluationContextId)
            ) &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                ResourceType == other.ResourceType ||
                ResourceType != null &&
                ResourceType.Equals(other.ResourceType)
            ) &&
            (
                EvaluationSource == other.EvaluationSource ||
                EvaluationSource != null &&
                EvaluationSource.Equals(other.EvaluationSource)
            ) &&
            (
                Rescore == other.Rescore ||
                Rescore != null &&
                Rescore.Equals(other.Rescore)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                ReleaseDate == other.ReleaseDate ||
                ReleaseDate != null &&
                ReleaseDate.Equals(other.ReleaseDate)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                NeverRelease == other.NeverRelease ||
                NeverRelease != null &&
                NeverRelease.Equals(other.NeverRelease)
            ) &&
            (
                DateAssigneeChanged == other.DateAssigneeChanged ||
                DateAssigneeChanged != null &&
                DateAssigneeChanged.Equals(other.DateAssigneeChanged)
            ) &&
            (
                Assignee == other.Assignee ||
                Assignee != null &&
                Assignee.Equals(other.Assignee)
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

            if (AgentHasRead != null)
            {
                hash = hash * 59 + AgentHasRead.GetHashCode();
            }

            if (Answers != null)
            {
                hash = hash * 59 + Answers.GetHashCode();
            }

            if (Calibration != null)
            {
                hash = hash * 59 + Calibration.GetHashCode();
            }

            if (EvaluationContextId != null)
            {
                hash = hash * 59 + EvaluationContextId.GetHashCode();
            }

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (ResourceType != null)
            {
                hash = hash * 59 + ResourceType.GetHashCode();
            }

            if (EvaluationSource != null)
            {
                hash = hash * 59 + EvaluationSource.GetHashCode();
            }

            if (Rescore != null)
            {
                hash = hash * 59 + Rescore.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (ReleaseDate != null)
            {
                hash = hash * 59 + ReleaseDate.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (NeverRelease != null)
            {
                hash = hash * 59 + NeverRelease.GetHashCode();
            }

            if (DateAssigneeChanged != null)
            {
                hash = hash * 59 + DateAssigneeChanged.GetHashCode();
            }

            if (Assignee != null)
            {
                hash = hash * 59 + Assignee.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
