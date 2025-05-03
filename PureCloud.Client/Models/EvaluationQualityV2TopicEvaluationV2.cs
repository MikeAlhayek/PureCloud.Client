using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationQualityV2TopicEvaluationV2
/// </summary>

public partial class EvaluationQualityV2TopicEvaluationV2 : IEquatable<EvaluationQualityV2TopicEvaluationV2>
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
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Finished for "Finished"
        /// </summary>
        [EnumMember(Value = "Finished")]
        Finished,

        /// <summary>
        /// Enum Inreview for "InReview"
        /// </summary>
        [EnumMember(Value = "InReview")]
        Inreview,

        /// <summary>
        /// Enum Retracted for "Retracted"
        /// </summary>
        [EnumMember(Value = "Retracted")]
        Retracted
    }
    /// <summary>
    /// Gets or Sets PreviousStatus
    /// </summary>
    
    public enum PreviousStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Finished for "Finished"
        /// </summary>
        [EnumMember(Value = "Finished")]
        Finished,

        /// <summary>
        /// Enum Inreview for "InReview"
        /// </summary>
        [EnumMember(Value = "InReview")]
        Inreview,

        /// <summary>
        /// Enum Retracted for "Retracted"
        /// </summary>
        [EnumMember(Value = "Retracted")]
        Retracted
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Gets or Sets PreviousStatus
    /// </summary>
    [JsonPropertyName("previousStatus")]
    public PreviousStatusEnum? PreviousStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationQualityV2TopicEvaluationV2" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="Agent">Agent.</param>
    /// <param name="Evaluator">Evaluator.</param>
    /// <param name="EventTime">EventTime.</param>
    /// <param name="EvaluationFormId">EvaluationFormId.</param>
    /// <param name="FormName">FormName.</param>
    /// <param name="ScoringSet">ScoringSet.</param>
    /// <param name="ContextId">ContextId.</param>
    /// <param name="Status">Status.</param>
    /// <param name="AgentHasRead">AgentHasRead.</param>
    /// <param name="ReleaseDate">ReleaseDate.</param>
    /// <param name="AssignedDate">AssignedDate.</param>
    /// <param name="ChangedDate">ChangedDate.</param>
    /// <param name="EventType">EventType.</param>
    /// <param name="ResourceId">ResourceId.</param>
    /// <param name="ResourceType">ResourceType.</param>
    /// <param name="DivisionIds">DivisionIds.</param>
    /// <param name="Rescore">Rescore.</param>
    /// <param name="ConversationDate">ConversationDate.</param>
    /// <param name="MediaType">MediaType.</param>
    /// <param name="Calibration">Calibration.</param>
    /// <param name="EvaluationSource">EvaluationSource.</param>
    /// <param name="AssigneeUserId">AssigneeUserId.</param>
    /// <param name="PreviousAssigneeUserId">PreviousAssigneeUserId.</param>
    /// <param name="AssigneeApplicable">AssigneeApplicable.</param>
    /// <param name="EvaluationContextId">EvaluationContextId.</param>
    /// <param name="DisputeCount">DisputeCount.</param>
    /// <param name="Version">Version.</param>
    /// <param name="PreviousStatus">PreviousStatus.</param>
    /// <param name="DeclinedReview">DeclinedReview.</param>
    /// <param name="RetractedEvaluation">RetractedEvaluation.</param>
    /// <param name="RescoreCount">RescoreCount.</param>
    /// <param name="EvaluatorCommentHasUpdated">EvaluatorCommentHasUpdated.</param>
    /// <param name="AgentCommentHasUpdated">AgentCommentHasUpdated.</param>
    /// <param name="PreviousRescoreCount">PreviousRescoreCount.</param>
    /// <param name="PreviousEvaluatorUserId">PreviousEvaluatorUserId.</param>
    public EvaluationQualityV2TopicEvaluationV2(string Id = null, string ConversationId = null, EvaluationQualityV2TopicUser Agent = null, EvaluationQualityV2TopicUser Evaluator = null, DateTime? EventTime = null, string EvaluationFormId = null, string FormName = null, EvaluationQualityV2TopicEvaluationScoringSet ScoringSet = null, string ContextId = null, StatusEnum? Status = null, bool? AgentHasRead = null, DateTime? ReleaseDate = null, DateTime? AssignedDate = null, DateTime? ChangedDate = null, string EventType = null, string ResourceId = null, string ResourceType = null, List<string> DivisionIds = null, bool? Rescore = null, DateTime? ConversationDate = null, List<string> MediaType = null, EvaluationQualityV2TopicCalibration Calibration = null, EvaluationQualityV2TopicEvaluationSource EvaluationSource = null, string AssigneeUserId = null, string PreviousAssigneeUserId = null, bool? AssigneeApplicable = null, string EvaluationContextId = null, long? DisputeCount = null, long? Version = null, PreviousStatusEnum? PreviousStatus = null, bool? DeclinedReview = null, EvaluationQualityV2TopicEvaluationReference RetractedEvaluation = null, long? RescoreCount = null, bool? EvaluatorCommentHasUpdated = null, bool? AgentCommentHasUpdated = null, long? PreviousRescoreCount = null, string PreviousEvaluatorUserId = null)
    {
        this.Id = Id;
        this.ConversationId = ConversationId;
        this.Agent = Agent;
        this.Evaluator = Evaluator;
        this.EventTime = EventTime;
        this.EvaluationFormId = EvaluationFormId;
        this.FormName = FormName;
        this.ScoringSet = ScoringSet;
        this.ContextId = ContextId;
        this.Status = Status;
        this.AgentHasRead = AgentHasRead;
        this.ReleaseDate = ReleaseDate;
        this.AssignedDate = AssignedDate;
        this.ChangedDate = ChangedDate;
        this.EventType = EventType;
        this.ResourceId = ResourceId;
        this.ResourceType = ResourceType;
        this.DivisionIds = DivisionIds;
        this.Rescore = Rescore;
        this.ConversationDate = ConversationDate;
        this.MediaType = MediaType;
        this.Calibration = Calibration;
        this.EvaluationSource = EvaluationSource;
        this.AssigneeUserId = AssigneeUserId;
        this.PreviousAssigneeUserId = PreviousAssigneeUserId;
        this.AssigneeApplicable = AssigneeApplicable;
        this.EvaluationContextId = EvaluationContextId;
        this.DisputeCount = DisputeCount;
        this.Version = Version;
        this.PreviousStatus = PreviousStatus;
        this.DeclinedReview = DeclinedReview;
        this.RetractedEvaluation = RetractedEvaluation;
        this.RescoreCount = RescoreCount;
        this.EvaluatorCommentHasUpdated = EvaluatorCommentHasUpdated;
        this.AgentCommentHasUpdated = AgentCommentHasUpdated;
        this.PreviousRescoreCount = PreviousRescoreCount;
        this.PreviousEvaluatorUserId = PreviousEvaluatorUserId;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    [JsonPropertyName("agent")]
    public EvaluationQualityV2TopicUser Agent { get; set; }



    /// <summary>
    /// Gets or Sets Evaluator
    /// </summary>
    [JsonPropertyName("evaluator")]
    public EvaluationQualityV2TopicUser Evaluator { get; set; }



    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    [JsonPropertyName("eventTime")]
    public DateTime? EventTime { get; set; }



    /// <summary>
    /// Gets or Sets EvaluationFormId
    /// </summary>
    [JsonPropertyName("evaluationFormId")]
    public string EvaluationFormId { get; set; }



    /// <summary>
    /// Gets or Sets FormName
    /// </summary>
    [JsonPropertyName("formName")]
    public string FormName { get; set; }



    /// <summary>
    /// Gets or Sets ScoringSet
    /// </summary>
    [JsonPropertyName("scoringSet")]
    public EvaluationQualityV2TopicEvaluationScoringSet ScoringSet { get; set; }



    /// <summary>
    /// Gets or Sets ContextId
    /// </summary>
    [JsonPropertyName("contextId")]
    public string ContextId { get; set; }





    /// <summary>
    /// Gets or Sets AgentHasRead
    /// </summary>
    [JsonPropertyName("agentHasRead")]
    public bool? AgentHasRead { get; set; }



    /// <summary>
    /// Gets or Sets ReleaseDate
    /// </summary>
    [JsonPropertyName("releaseDate")]
    public DateTime? ReleaseDate { get; set; }



    /// <summary>
    /// Gets or Sets AssignedDate
    /// </summary>
    [JsonPropertyName("assignedDate")]
    public DateTime? AssignedDate { get; set; }



    /// <summary>
    /// Gets or Sets ChangedDate
    /// </summary>
    [JsonPropertyName("changedDate")]
    public DateTime? ChangedDate { get; set; }



    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    [JsonPropertyName("eventType")]
    public string EventType { get; set; }



    /// <summary>
    /// Gets or Sets ResourceId
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string ResourceId { get; set; }



    /// <summary>
    /// Gets or Sets ResourceType
    /// </summary>
    [JsonPropertyName("resourceType")]
    public string ResourceType { get; set; }



    /// <summary>
    /// Gets or Sets DivisionIds
    /// </summary>
    [JsonPropertyName("divisionIds")]
    public List<string> DivisionIds { get; set; }



    /// <summary>
    /// Gets or Sets Rescore
    /// </summary>
    [JsonPropertyName("rescore")]
    public bool? Rescore { get; set; }



    /// <summary>
    /// Gets or Sets ConversationDate
    /// </summary>
    [JsonPropertyName("conversationDate")]
    public DateTime? ConversationDate { get; set; }



    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    [JsonPropertyName("mediaType")]
    public List<string> MediaType { get; set; }



    /// <summary>
    /// Gets or Sets Calibration
    /// </summary>
    [JsonPropertyName("calibration")]
    public EvaluationQualityV2TopicCalibration Calibration { get; set; }



    /// <summary>
    /// Gets or Sets EvaluationSource
    /// </summary>
    [JsonPropertyName("evaluationSource")]
    public EvaluationQualityV2TopicEvaluationSource EvaluationSource { get; set; }



    /// <summary>
    /// Gets or Sets AssigneeUserId
    /// </summary>
    [JsonPropertyName("assigneeUserId")]
    public string AssigneeUserId { get; set; }



    /// <summary>
    /// Gets or Sets PreviousAssigneeUserId
    /// </summary>
    [JsonPropertyName("previousAssigneeUserId")]
    public string PreviousAssigneeUserId { get; set; }



    /// <summary>
    /// Gets or Sets AssigneeApplicable
    /// </summary>
    [JsonPropertyName("assigneeApplicable")]
    public bool? AssigneeApplicable { get; set; }



    /// <summary>
    /// Gets or Sets EvaluationContextId
    /// </summary>
    [JsonPropertyName("evaluationContextId")]
    public string EvaluationContextId { get; set; }



    /// <summary>
    /// Gets or Sets DisputeCount
    /// </summary>
    [JsonPropertyName("disputeCount")]
    public long? DisputeCount { get; set; }



    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [JsonPropertyName("version")]
    public long? Version { get; set; }





    /// <summary>
    /// Gets or Sets DeclinedReview
    /// </summary>
    [JsonPropertyName("declinedReview")]
    public bool? DeclinedReview { get; set; }



    /// <summary>
    /// Gets or Sets RetractedEvaluation
    /// </summary>
    [JsonPropertyName("retractedEvaluation")]
    public EvaluationQualityV2TopicEvaluationReference RetractedEvaluation { get; set; }



    /// <summary>
    /// Gets or Sets RescoreCount
    /// </summary>
    [JsonPropertyName("rescoreCount")]
    public long? RescoreCount { get; set; }



    /// <summary>
    /// Gets or Sets EvaluatorCommentHasUpdated
    /// </summary>
    [JsonPropertyName("evaluatorCommentHasUpdated")]
    public bool? EvaluatorCommentHasUpdated { get; set; }



    /// <summary>
    /// Gets or Sets AgentCommentHasUpdated
    /// </summary>
    [JsonPropertyName("agentCommentHasUpdated")]
    public bool? AgentCommentHasUpdated { get; set; }



    /// <summary>
    /// Gets or Sets PreviousRescoreCount
    /// </summary>
    [JsonPropertyName("previousRescoreCount")]
    public long? PreviousRescoreCount { get; set; }



    /// <summary>
    /// Gets or Sets PreviousEvaluatorUserId
    /// </summary>
    [JsonPropertyName("previousEvaluatorUserId")]
    public string PreviousEvaluatorUserId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EvaluationQualityV2TopicEvaluationV2 {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  Evaluator: ").Append(Evaluator).Append("\n");
        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  EvaluationFormId: ").Append(EvaluationFormId).Append("\n");
        sb.Append("  FormName: ").Append(FormName).Append("\n");
        sb.Append("  ScoringSet: ").Append(ScoringSet).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  AgentHasRead: ").Append(AgentHasRead).Append("\n");
        sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
        sb.Append("  AssignedDate: ").Append(AssignedDate).Append("\n");
        sb.Append("  ChangedDate: ").Append(ChangedDate).Append("\n");
        sb.Append("  EventType: ").Append(EventType).Append("\n");
        sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
        sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
        sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
        sb.Append("  Rescore: ").Append(Rescore).Append("\n");
        sb.Append("  ConversationDate: ").Append(ConversationDate).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  Calibration: ").Append(Calibration).Append("\n");
        sb.Append("  EvaluationSource: ").Append(EvaluationSource).Append("\n");
        sb.Append("  AssigneeUserId: ").Append(AssigneeUserId).Append("\n");
        sb.Append("  PreviousAssigneeUserId: ").Append(PreviousAssigneeUserId).Append("\n");
        sb.Append("  AssigneeApplicable: ").Append(AssigneeApplicable).Append("\n");
        sb.Append("  EvaluationContextId: ").Append(EvaluationContextId).Append("\n");
        sb.Append("  DisputeCount: ").Append(DisputeCount).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  PreviousStatus: ").Append(PreviousStatus).Append("\n");
        sb.Append("  DeclinedReview: ").Append(DeclinedReview).Append("\n");
        sb.Append("  RetractedEvaluation: ").Append(RetractedEvaluation).Append("\n");
        sb.Append("  RescoreCount: ").Append(RescoreCount).Append("\n");
        sb.Append("  EvaluatorCommentHasUpdated: ").Append(EvaluatorCommentHasUpdated).Append("\n");
        sb.Append("  AgentCommentHasUpdated: ").Append(AgentCommentHasUpdated).Append("\n");
        sb.Append("  PreviousRescoreCount: ").Append(PreviousRescoreCount).Append("\n");
        sb.Append("  PreviousEvaluatorUserId: ").Append(PreviousEvaluatorUserId).Append("\n");
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
        return Equals(obj as EvaluationQualityV2TopicEvaluationV2);
    }

    /// <summary>
    /// Returns true if EvaluationQualityV2TopicEvaluationV2 instances are equal
    /// </summary>
    /// <param name="other">Instance of EvaluationQualityV2TopicEvaluationV2 to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EvaluationQualityV2TopicEvaluationV2 other)
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
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                Agent == other.Agent ||
                Agent != null &&
                Agent.Equals(other.Agent)
            ) &&
            (
                Evaluator == other.Evaluator ||
                Evaluator != null &&
                Evaluator.Equals(other.Evaluator)
            ) &&
            (
                EventTime == other.EventTime ||
                EventTime != null &&
                EventTime.Equals(other.EventTime)
            ) &&
            (
                EvaluationFormId == other.EvaluationFormId ||
                EvaluationFormId != null &&
                EvaluationFormId.Equals(other.EvaluationFormId)
            ) &&
            (
                FormName == other.FormName ||
                FormName != null &&
                FormName.Equals(other.FormName)
            ) &&
            (
                ScoringSet == other.ScoringSet ||
                ScoringSet != null &&
                ScoringSet.Equals(other.ScoringSet)
            ) &&
            (
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                AgentHasRead == other.AgentHasRead ||
                AgentHasRead != null &&
                AgentHasRead.Equals(other.AgentHasRead)
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
                EventType == other.EventType ||
                EventType != null &&
                EventType.Equals(other.EventType)
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
                DivisionIds == other.DivisionIds ||
                DivisionIds != null &&
                DivisionIds.SequenceEqual(other.DivisionIds)
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
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.SequenceEqual(other.MediaType)
            ) &&
            (
                Calibration == other.Calibration ||
                Calibration != null &&
                Calibration.Equals(other.Calibration)
            ) &&
            (
                EvaluationSource == other.EvaluationSource ||
                EvaluationSource != null &&
                EvaluationSource.Equals(other.EvaluationSource)
            ) &&
            (
                AssigneeUserId == other.AssigneeUserId ||
                AssigneeUserId != null &&
                AssigneeUserId.Equals(other.AssigneeUserId)
            ) &&
            (
                PreviousAssigneeUserId == other.PreviousAssigneeUserId ||
                PreviousAssigneeUserId != null &&
                PreviousAssigneeUserId.Equals(other.PreviousAssigneeUserId)
            ) &&
            (
                AssigneeApplicable == other.AssigneeApplicable ||
                AssigneeApplicable != null &&
                AssigneeApplicable.Equals(other.AssigneeApplicable)
            ) &&
            (
                EvaluationContextId == other.EvaluationContextId ||
                EvaluationContextId != null &&
                EvaluationContextId.Equals(other.EvaluationContextId)
            ) &&
            (
                DisputeCount == other.DisputeCount ||
                DisputeCount != null &&
                DisputeCount.Equals(other.DisputeCount)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                PreviousStatus == other.PreviousStatus ||
                PreviousStatus != null &&
                PreviousStatus.Equals(other.PreviousStatus)
            ) &&
            (
                DeclinedReview == other.DeclinedReview ||
                DeclinedReview != null &&
                DeclinedReview.Equals(other.DeclinedReview)
            ) &&
            (
                RetractedEvaluation == other.RetractedEvaluation ||
                RetractedEvaluation != null &&
                RetractedEvaluation.Equals(other.RetractedEvaluation)
            ) &&
            (
                RescoreCount == other.RescoreCount ||
                RescoreCount != null &&
                RescoreCount.Equals(other.RescoreCount)
            ) &&
            (
                EvaluatorCommentHasUpdated == other.EvaluatorCommentHasUpdated ||
                EvaluatorCommentHasUpdated != null &&
                EvaluatorCommentHasUpdated.Equals(other.EvaluatorCommentHasUpdated)
            ) &&
            (
                AgentCommentHasUpdated == other.AgentCommentHasUpdated ||
                AgentCommentHasUpdated != null &&
                AgentCommentHasUpdated.Equals(other.AgentCommentHasUpdated)
            ) &&
            (
                PreviousRescoreCount == other.PreviousRescoreCount ||
                PreviousRescoreCount != null &&
                PreviousRescoreCount.Equals(other.PreviousRescoreCount)
            ) &&
            (
                PreviousEvaluatorUserId == other.PreviousEvaluatorUserId ||
                PreviousEvaluatorUserId != null &&
                PreviousEvaluatorUserId.Equals(other.PreviousEvaluatorUserId)
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

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (Agent != null)
            {
                hash = hash * 59 + Agent.GetHashCode();
            }

            if (Evaluator != null)
            {
                hash = hash * 59 + Evaluator.GetHashCode();
            }

            if (EventTime != null)
            {
                hash = hash * 59 + EventTime.GetHashCode();
            }

            if (EvaluationFormId != null)
            {
                hash = hash * 59 + EvaluationFormId.GetHashCode();
            }

            if (FormName != null)
            {
                hash = hash * 59 + FormName.GetHashCode();
            }

            if (ScoringSet != null)
            {
                hash = hash * 59 + ScoringSet.GetHashCode();
            }

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (AgentHasRead != null)
            {
                hash = hash * 59 + AgentHasRead.GetHashCode();
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

            if (EventType != null)
            {
                hash = hash * 59 + EventType.GetHashCode();
            }

            if (ResourceId != null)
            {
                hash = hash * 59 + ResourceId.GetHashCode();
            }

            if (ResourceType != null)
            {
                hash = hash * 59 + ResourceType.GetHashCode();
            }

            if (DivisionIds != null)
            {
                hash = hash * 59 + DivisionIds.GetHashCode();
            }

            if (Rescore != null)
            {
                hash = hash * 59 + Rescore.GetHashCode();
            }

            if (ConversationDate != null)
            {
                hash = hash * 59 + ConversationDate.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (Calibration != null)
            {
                hash = hash * 59 + Calibration.GetHashCode();
            }

            if (EvaluationSource != null)
            {
                hash = hash * 59 + EvaluationSource.GetHashCode();
            }

            if (AssigneeUserId != null)
            {
                hash = hash * 59 + AssigneeUserId.GetHashCode();
            }

            if (PreviousAssigneeUserId != null)
            {
                hash = hash * 59 + PreviousAssigneeUserId.GetHashCode();
            }

            if (AssigneeApplicable != null)
            {
                hash = hash * 59 + AssigneeApplicable.GetHashCode();
            }

            if (EvaluationContextId != null)
            {
                hash = hash * 59 + EvaluationContextId.GetHashCode();
            }

            if (DisputeCount != null)
            {
                hash = hash * 59 + DisputeCount.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (PreviousStatus != null)
            {
                hash = hash * 59 + PreviousStatus.GetHashCode();
            }

            if (DeclinedReview != null)
            {
                hash = hash * 59 + DeclinedReview.GetHashCode();
            }

            if (RetractedEvaluation != null)
            {
                hash = hash * 59 + RetractedEvaluation.GetHashCode();
            }

            if (RescoreCount != null)
            {
                hash = hash * 59 + RescoreCount.GetHashCode();
            }

            if (EvaluatorCommentHasUpdated != null)
            {
                hash = hash * 59 + EvaluatorCommentHasUpdated.GetHashCode();
            }

            if (AgentCommentHasUpdated != null)
            {
                hash = hash * 59 + AgentCommentHasUpdated.GetHashCode();
            }

            if (PreviousRescoreCount != null)
            {
                hash = hash * 59 + PreviousRescoreCount.GetHashCode();
            }

            if (PreviousEvaluatorUserId != null)
            {
                hash = hash * 59 + PreviousEvaluatorUserId.GetHashCode();
            }

            return hash;
        }
    }
}
