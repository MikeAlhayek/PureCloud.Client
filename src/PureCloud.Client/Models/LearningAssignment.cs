using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module assignment with user information
/// </summary>
public sealed class LearningAssignment
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
}
