using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsEvaluation
/// </summary>
[DataContract]
public partial class AnalyticsEvaluation : IEquatable<AnalyticsEvaluation>
{
    /// <summary>
    /// Status of evaluation
    /// </summary>
    /// <value>Status of evaluation</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EvaluationStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Finished for "Finished"
        /// </summary>
        [EnumMember(Value = "Finished")]
        Finished,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Inreview for "InReview"
        /// </summary>
        [EnumMember(Value = "InReview")]
        Inreview,

        /// <summary>
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Retracted for "Retracted"
        /// </summary>
        [EnumMember(Value = "Retracted")]
        Retracted
    }
    /// <summary>
    /// Status of evaluation
    /// </summary>
    /// <value>Status of evaluation</value>
    [DataMember(Name = "evaluationStatus", EmitDefaultValue = false)]
    public EvaluationStatusEnum? EvaluationStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsEvaluation" /> class.
    /// </summary>
    /// <param name="AssigneeApplicable">Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable.</param>
    /// <param name="AssigneeId">UserId of the assignee.</param>
    /// <param name="CalibrationId">The calibration ID used for the purpose of training evaluators.</param>
    /// <param name="ContextId">A unique identifier for an evaluation form, regardless of version.</param>
    /// <param name="Deleted">Whether the evaluation has been deleted.</param>
    /// <param name="EvaluationId">Unique identifier for the evaluation.</param>
    /// <param name="EvaluationStatus">Status of evaluation.</param>
    /// <param name="EvaluatorId">A unique identifier of the user who evaluated the interaction.</param>
    /// <param name="EventTime">Specifies when an evaluation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="FormId">ID of the evaluation form used.</param>
    /// <param name="FormName">Name of the evaluation form used.</param>
    /// <param name="QueueId">The ID of the associated queue.</param>
    /// <param name="Released">Whether the evaluation has been released.</param>
    /// <param name="Rescored">Whether the evaluation has been rescored at least once.</param>
    /// <param name="UserId">ID of the agent the evaluation was performed against.</param>
    /// <param name="OTotalCriticalScore">OTotalCriticalScore.</param>
    /// <param name="OTotalScore">OTotalScore.</param>
    public AnalyticsEvaluation(bool? AssigneeApplicable = null, string AssigneeId = null, string CalibrationId = null, string ContextId = null, bool? Deleted = null, string EvaluationId = null, EvaluationStatusEnum? EvaluationStatus = null, string EvaluatorId = null, DateTime? EventTime = null, string FormId = null, string FormName = null, string QueueId = null, bool? Released = null, bool? Rescored = null, string UserId = null, long? OTotalCriticalScore = null, long? OTotalScore = null)
    {
        this.AssigneeApplicable = AssigneeApplicable;
        this.AssigneeId = AssigneeId;
        this.CalibrationId = CalibrationId;
        this.ContextId = ContextId;
        this.Deleted = Deleted;
        this.EvaluationId = EvaluationId;
        this.EvaluationStatus = EvaluationStatus;
        this.EvaluatorId = EvaluatorId;
        this.EventTime = EventTime;
        this.FormId = FormId;
        this.FormName = FormName;
        this.QueueId = QueueId;
        this.Released = Released;
        this.Rescored = Rescored;
        this.UserId = UserId;
        this.OTotalCriticalScore = OTotalCriticalScore;
        this.OTotalScore = OTotalScore;

    }



    /// <summary>
    /// Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable
    /// </summary>
    /// <value>Indicates whether an assignee is applicable for the evaluation. Set to false when assignee is not applicable</value>
    [DataMember(Name = "assigneeApplicable", EmitDefaultValue = false)]
    public bool? AssigneeApplicable { get; set; }



    /// <summary>
    /// UserId of the assignee
    /// </summary>
    /// <value>UserId of the assignee</value>
    [DataMember(Name = "assigneeId", EmitDefaultValue = false)]
    public string AssigneeId { get; set; }



    /// <summary>
    /// The calibration ID used for the purpose of training evaluators
    /// </summary>
    /// <value>The calibration ID used for the purpose of training evaluators</value>
    [DataMember(Name = "calibrationId", EmitDefaultValue = false)]
    public string CalibrationId { get; set; }



    /// <summary>
    /// A unique identifier for an evaluation form, regardless of version
    /// </summary>
    /// <value>A unique identifier for an evaluation form, regardless of version</value>
    [DataMember(Name = "contextId", EmitDefaultValue = false)]
    public string ContextId { get; set; }



    /// <summary>
    /// Whether the evaluation has been deleted
    /// </summary>
    /// <value>Whether the evaluation has been deleted</value>
    [DataMember(Name = "deleted", EmitDefaultValue = false)]
    public bool? Deleted { get; set; }



    /// <summary>
    /// Unique identifier for the evaluation
    /// </summary>
    /// <value>Unique identifier for the evaluation</value>
    [DataMember(Name = "evaluationId", EmitDefaultValue = false)]
    public string EvaluationId { get; set; }





    /// <summary>
    /// A unique identifier of the user who evaluated the interaction
    /// </summary>
    /// <value>A unique identifier of the user who evaluated the interaction</value>
    [DataMember(Name = "evaluatorId", EmitDefaultValue = false)]
    public string EvaluatorId { get; set; }



    /// <summary>
    /// Specifies when an evaluation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Specifies when an evaluation occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "eventTime", EmitDefaultValue = false)]
    public DateTime? EventTime { get; set; }



    /// <summary>
    /// ID of the evaluation form used
    /// </summary>
    /// <value>ID of the evaluation form used</value>
    [DataMember(Name = "formId", EmitDefaultValue = false)]
    public string FormId { get; set; }



    /// <summary>
    /// Name of the evaluation form used
    /// </summary>
    /// <value>Name of the evaluation form used</value>
    [DataMember(Name = "formName", EmitDefaultValue = false)]
    public string FormName { get; set; }



    /// <summary>
    /// The ID of the associated queue
    /// </summary>
    /// <value>The ID of the associated queue</value>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public string QueueId { get; set; }



    /// <summary>
    /// Whether the evaluation has been released
    /// </summary>
    /// <value>Whether the evaluation has been released</value>
    [DataMember(Name = "released", EmitDefaultValue = false)]
    public bool? Released { get; set; }



    /// <summary>
    /// Whether the evaluation has been rescored at least once
    /// </summary>
    /// <value>Whether the evaluation has been rescored at least once</value>
    [DataMember(Name = "rescored", EmitDefaultValue = false)]
    public bool? Rescored { get; set; }



    /// <summary>
    /// ID of the agent the evaluation was performed against
    /// </summary>
    /// <value>ID of the agent the evaluation was performed against</value>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// Gets or Sets OTotalCriticalScore
    /// </summary>
    [DataMember(Name = "oTotalCriticalScore", EmitDefaultValue = false)]
    public long? OTotalCriticalScore { get; set; }



    /// <summary>
    /// Gets or Sets OTotalScore
    /// </summary>
    [DataMember(Name = "oTotalScore", EmitDefaultValue = false)]
    public long? OTotalScore { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsEvaluation {\n");

        sb.Append("  AssigneeApplicable: ").Append(AssigneeApplicable).Append("\n");
        sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
        sb.Append("  CalibrationId: ").Append(CalibrationId).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
        sb.Append("  Deleted: ").Append(Deleted).Append("\n");
        sb.Append("  EvaluationId: ").Append(EvaluationId).Append("\n");
        sb.Append("  EvaluationStatus: ").Append(EvaluationStatus).Append("\n");
        sb.Append("  EvaluatorId: ").Append(EvaluatorId).Append("\n");
        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  FormId: ").Append(FormId).Append("\n");
        sb.Append("  FormName: ").Append(FormName).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  Released: ").Append(Released).Append("\n");
        sb.Append("  Rescored: ").Append(Rescored).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  OTotalCriticalScore: ").Append(OTotalCriticalScore).Append("\n");
        sb.Append("  OTotalScore: ").Append(OTotalScore).Append("\n");
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
        return Equals(obj as AnalyticsEvaluation);
    }

    /// <summary>
    /// Returns true if AnalyticsEvaluation instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsEvaluation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsEvaluation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AssigneeApplicable == other.AssigneeApplicable ||
                AssigneeApplicable != null &&
                AssigneeApplicable.Equals(other.AssigneeApplicable)
            ) &&
            (
                AssigneeId == other.AssigneeId ||
                AssigneeId != null &&
                AssigneeId.Equals(other.AssigneeId)
            ) &&
            (
                CalibrationId == other.CalibrationId ||
                CalibrationId != null &&
                CalibrationId.Equals(other.CalibrationId)
            ) &&
            (
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
            ) &&
            (
                Deleted == other.Deleted ||
                Deleted != null &&
                Deleted.Equals(other.Deleted)
            ) &&
            (
                EvaluationId == other.EvaluationId ||
                EvaluationId != null &&
                EvaluationId.Equals(other.EvaluationId)
            ) &&
            (
                EvaluationStatus == other.EvaluationStatus ||
                EvaluationStatus != null &&
                EvaluationStatus.Equals(other.EvaluationStatus)
            ) &&
            (
                EvaluatorId == other.EvaluatorId ||
                EvaluatorId != null &&
                EvaluatorId.Equals(other.EvaluatorId)
            ) &&
            (
                EventTime == other.EventTime ||
                EventTime != null &&
                EventTime.Equals(other.EventTime)
            ) &&
            (
                FormId == other.FormId ||
                FormId != null &&
                FormId.Equals(other.FormId)
            ) &&
            (
                FormName == other.FormName ||
                FormName != null &&
                FormName.Equals(other.FormName)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                Released == other.Released ||
                Released != null &&
                Released.Equals(other.Released)
            ) &&
            (
                Rescored == other.Rescored ||
                Rescored != null &&
                Rescored.Equals(other.Rescored)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                OTotalCriticalScore == other.OTotalCriticalScore ||
                OTotalCriticalScore != null &&
                OTotalCriticalScore.Equals(other.OTotalCriticalScore)
            ) &&
            (
                OTotalScore == other.OTotalScore ||
                OTotalScore != null &&
                OTotalScore.Equals(other.OTotalScore)
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
            if (AssigneeApplicable != null)
            {
                hash = hash * 59 + AssigneeApplicable.GetHashCode();
            }

            if (AssigneeId != null)
            {
                hash = hash * 59 + AssigneeId.GetHashCode();
            }

            if (CalibrationId != null)
            {
                hash = hash * 59 + CalibrationId.GetHashCode();
            }

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            if (Deleted != null)
            {
                hash = hash * 59 + Deleted.GetHashCode();
            }

            if (EvaluationId != null)
            {
                hash = hash * 59 + EvaluationId.GetHashCode();
            }

            if (EvaluationStatus != null)
            {
                hash = hash * 59 + EvaluationStatus.GetHashCode();
            }

            if (EvaluatorId != null)
            {
                hash = hash * 59 + EvaluatorId.GetHashCode();
            }

            if (EventTime != null)
            {
                hash = hash * 59 + EventTime.GetHashCode();
            }

            if (FormId != null)
            {
                hash = hash * 59 + FormId.GetHashCode();
            }

            if (FormName != null)
            {
                hash = hash * 59 + FormName.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (Released != null)
            {
                hash = hash * 59 + Released.GetHashCode();
            }

            if (Rescored != null)
            {
                hash = hash * 59 + Rescored.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (OTotalCriticalScore != null)
            {
                hash = hash * 59 + OTotalCriticalScore.GetHashCode();
            }

            if (OTotalScore != null)
            {
                hash = hash * 59 + OTotalScore.GetHashCode();
            }

            return hash;
        }
    }
}
