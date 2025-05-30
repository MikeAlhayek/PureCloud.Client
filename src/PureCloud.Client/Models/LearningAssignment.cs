using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module assignment with user information
/// </summary>

public partial class LearningAssignment : IEquatable<LearningAssignment>
{
    /// <summary>
    /// The Learning Assignment state
    /// </summary>
    /// <value>The Learning Assignment state</value>
    
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
        /// Enum Assigned for "Assigned"
        /// </summary>
        [EnumMember(Value = "Assigned")]
        Assigned,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Deleted for "Deleted"
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted,

        /// <summary>
        /// Enum Notcompleted for "NotCompleted"
        /// </summary>
        [EnumMember(Value = "NotCompleted")]
        Notcompleted,

        /// <summary>
        /// Enum Invalidschedule for "InvalidSchedule"
        /// </summary>
        [EnumMember(Value = "InvalidSchedule")]
        Invalidschedule
    }
    /// <summary>
    /// The Learning Assignment state
    /// </summary>
    /// <value>The Learning Assignment state</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignment" /> class.
    /// </summary>
    /// <param name="Assessment">The assessment associated with this assignment.</param>
    /// <param name="State">The Learning Assignment state.</param>
    /// <param name="DateRecommendedForCompletion">The recommended completion date of the assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Version">The version of Learning module assigned.</param>
    /// <param name="Module">The Learning module object associated with this assignment.</param>
    /// <param name="User">The user to whom the assignment is assigned.</param>
    /// <param name="AssessmentForm">The assessment form associated with this assignment.</param>
    /// <param name="LengthInMinutes">The length in minutes of the assignment.</param>
    public LearningAssignment(LearningAssessment Assessment = null, StateEnum? State = null, DateTime? DateRecommendedForCompletion = null, int? Version = null, LearningModule Module = null, UserReference User = null, AssessmentForm AssessmentForm = null, int? LengthInMinutes = null)
    {
        this.Assessment = Assessment;
        this.State = State;
        this.DateRecommendedForCompletion = DateRecommendedForCompletion;
        this.Version = Version;
        this.Module = Module;
        this.User = User;
        this.AssessmentForm = AssessmentForm;
        this.LengthInMinutes = LengthInMinutes;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The assessment associated with this assignment
    /// </summary>
    /// <value>The assessment associated with this assignment</value>
    [JsonPropertyName("assessment")]
    public LearningAssessment Assessment { get; set; }



    /// <summary>
    /// The user who created the assignment
    /// </summary>
    /// <value>The user who created the assignment</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; set; }



    /// <summary>
    /// The date when the assignment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the assignment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The user who modified the assignment
    /// </summary>
    /// <value>The user who modified the assignment</value>
    [JsonPropertyName("modifiedBy")]
    public UserReference ModifiedBy { get; set; }



    /// <summary>
    /// The date when the assignment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the assignment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// True if the assignment is overdue
    /// </summary>
    /// <value>True if the assignment is overdue</value>
    [JsonPropertyName("isOverdue")]
    public bool? IsOverdue { get; set; }



    /// <summary>
    /// The user&#39;s percentage score for this assignment
    /// </summary>
    /// <value>The user&#39;s percentage score for this assignment</value>
    [JsonPropertyName("percentageScore")]
    public float? PercentageScore { get; set; }



    /// <summary>
    /// The user&#39;s percentage score for this assignment&#39;s assessment
    /// </summary>
    /// <value>The user&#39;s percentage score for this assignment&#39;s assessment</value>
    [JsonPropertyName("assessmentPercentageScore")]
    public float? AssessmentPercentageScore { get; set; }



    /// <summary>
    /// True if this assignment was created by a Rule
    /// </summary>
    /// <value>True if this assignment was created by a Rule</value>
    [JsonPropertyName("isRule")]
    public bool? IsRule { get; set; }



    /// <summary>
    /// True if this assignment was created manually
    /// </summary>
    /// <value>True if this assignment was created manually</value>
    [JsonPropertyName("isManual")]
    public bool? IsManual { get; set; }



    /// <summary>
    /// True if the assessment was passed
    /// </summary>
    /// <value>True if the assessment was passed</value>
    [JsonPropertyName("isPassed")]
    public bool? IsPassed { get; set; }



    /// <summary>
    /// True if the assignment is based on latest module
    /// </summary>
    /// <value>True if the assignment is based on latest module</value>
    [JsonPropertyName("isLatest")]
    public bool? IsLatest { get; set; }



    /// <summary>
    /// The assessment completion percentage of assignment
    /// </summary>
    /// <value>The assessment completion percentage of assignment</value>
    [JsonPropertyName("assessmentCompletionPercentage")]
    public float? AssessmentCompletionPercentage { get; set; }



    /// <summary>
    /// The overall completion percentage of assignment
    /// </summary>
    /// <value>The overall completion percentage of assignment</value>
    [JsonPropertyName("completionPercentage")]
    public float? CompletionPercentage { get; set; }



    /// <summary>
    /// List of assignment steps
    /// </summary>
    /// <value>List of assignment steps</value>
    [JsonPropertyName("steps")]
    public List<LearningAssignmentStep> Steps { get; set; }



    /// <summary>
    /// The next assignment step
    /// </summary>
    /// <value>The next assignment step</value>
    [JsonPropertyName("nextStep")]
    public LearningAssignmentStep NextStep { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }





    /// <summary>
    /// The recommended completion date of the assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The recommended completion date of the assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateRecommendedForCompletion")]
    public DateTime? DateRecommendedForCompletion { get; set; }



    /// <summary>
    /// The version of Learning module assigned
    /// </summary>
    /// <value>The version of Learning module assigned</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The Learning module object associated with this assignment
    /// </summary>
    /// <value>The Learning module object associated with this assignment</value>
    [JsonPropertyName("module")]
    public LearningModule Module { get; set; }



    /// <summary>
    /// The user to whom the assignment is assigned
    /// </summary>
    /// <value>The user to whom the assignment is assigned</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The assessment form associated with this assignment
    /// </summary>
    /// <value>The assessment form associated with this assignment</value>
    [JsonPropertyName("assessmentForm")]
    public AssessmentForm AssessmentForm { get; set; }



    /// <summary>
    /// The length in minutes of the assignment
    /// </summary>
    /// <value>The length in minutes of the assignment</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignment {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Assessment: ").Append(Assessment).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  IsOverdue: ").Append(IsOverdue).Append("\n");
        sb.Append("  PercentageScore: ").Append(PercentageScore).Append("\n");
        sb.Append("  AssessmentPercentageScore: ").Append(AssessmentPercentageScore).Append("\n");
        sb.Append("  IsRule: ").Append(IsRule).Append("\n");
        sb.Append("  IsManual: ").Append(IsManual).Append("\n");
        sb.Append("  IsPassed: ").Append(IsPassed).Append("\n");
        sb.Append("  IsLatest: ").Append(IsLatest).Append("\n");
        sb.Append("  AssessmentCompletionPercentage: ").Append(AssessmentCompletionPercentage).Append("\n");
        sb.Append("  CompletionPercentage: ").Append(CompletionPercentage).Append("\n");
        sb.Append("  Steps: ").Append(Steps).Append("\n");
        sb.Append("  NextStep: ").Append(NextStep).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  DateRecommendedForCompletion: ").Append(DateRecommendedForCompletion).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Module: ").Append(Module).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  AssessmentForm: ").Append(AssessmentForm).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
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
        return Equals(obj as LearningAssignment);
    }

    /// <summary>
    /// Returns true if LearningAssignment instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssignment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssignment other)
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
                Assessment == other.Assessment ||
                Assessment != null &&
                Assessment.Equals(other.Assessment)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                IsOverdue == other.IsOverdue ||
                IsOverdue != null &&
                IsOverdue.Equals(other.IsOverdue)
            ) &&
            (
                PercentageScore == other.PercentageScore ||
                PercentageScore != null &&
                PercentageScore.Equals(other.PercentageScore)
            ) &&
            (
                AssessmentPercentageScore == other.AssessmentPercentageScore ||
                AssessmentPercentageScore != null &&
                AssessmentPercentageScore.Equals(other.AssessmentPercentageScore)
            ) &&
            (
                IsRule == other.IsRule ||
                IsRule != null &&
                IsRule.Equals(other.IsRule)
            ) &&
            (
                IsManual == other.IsManual ||
                IsManual != null &&
                IsManual.Equals(other.IsManual)
            ) &&
            (
                IsPassed == other.IsPassed ||
                IsPassed != null &&
                IsPassed.Equals(other.IsPassed)
            ) &&
            (
                IsLatest == other.IsLatest ||
                IsLatest != null &&
                IsLatest.Equals(other.IsLatest)
            ) &&
            (
                AssessmentCompletionPercentage == other.AssessmentCompletionPercentage ||
                AssessmentCompletionPercentage != null &&
                AssessmentCompletionPercentage.Equals(other.AssessmentCompletionPercentage)
            ) &&
            (
                CompletionPercentage == other.CompletionPercentage ||
                CompletionPercentage != null &&
                CompletionPercentage.Equals(other.CompletionPercentage)
            ) &&
            (
                Steps == other.Steps ||
                Steps != null &&
                Steps.SequenceEqual(other.Steps)
            ) &&
            (
                NextStep == other.NextStep ||
                NextStep != null &&
                NextStep.Equals(other.NextStep)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                DateRecommendedForCompletion == other.DateRecommendedForCompletion ||
                DateRecommendedForCompletion != null &&
                DateRecommendedForCompletion.Equals(other.DateRecommendedForCompletion)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Module == other.Module ||
                Module != null &&
                Module.Equals(other.Module)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                AssessmentForm == other.AssessmentForm ||
                AssessmentForm != null &&
                AssessmentForm.Equals(other.AssessmentForm)
            ) &&
            (
                LengthInMinutes == other.LengthInMinutes ||
                LengthInMinutes != null &&
                LengthInMinutes.Equals(other.LengthInMinutes)
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

            if (Assessment != null)
            {
                hash = hash * 59 + Assessment.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (IsOverdue != null)
            {
                hash = hash * 59 + IsOverdue.GetHashCode();
            }

            if (PercentageScore != null)
            {
                hash = hash * 59 + PercentageScore.GetHashCode();
            }

            if (AssessmentPercentageScore != null)
            {
                hash = hash * 59 + AssessmentPercentageScore.GetHashCode();
            }

            if (IsRule != null)
            {
                hash = hash * 59 + IsRule.GetHashCode();
            }

            if (IsManual != null)
            {
                hash = hash * 59 + IsManual.GetHashCode();
            }

            if (IsPassed != null)
            {
                hash = hash * 59 + IsPassed.GetHashCode();
            }

            if (IsLatest != null)
            {
                hash = hash * 59 + IsLatest.GetHashCode();
            }

            if (AssessmentCompletionPercentage != null)
            {
                hash = hash * 59 + AssessmentCompletionPercentage.GetHashCode();
            }

            if (CompletionPercentage != null)
            {
                hash = hash * 59 + CompletionPercentage.GetHashCode();
            }

            if (Steps != null)
            {
                hash = hash * 59 + Steps.GetHashCode();
            }

            if (NextStep != null)
            {
                hash = hash * 59 + NextStep.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (DateRecommendedForCompletion != null)
            {
                hash = hash * 59 + DateRecommendedForCompletion.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Module != null)
            {
                hash = hash * 59 + Module.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (AssessmentForm != null)
            {
                hash = hash * 59 + AssessmentForm.GetHashCode();
            }

            if (LengthInMinutes != null)
            {
                hash = hash * 59 + LengthInMinutes.GetHashCode();
            }

            return hash;
        }
    }
}
