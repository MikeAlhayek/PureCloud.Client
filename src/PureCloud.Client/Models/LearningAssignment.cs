using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LearningAssignment
{
    /// <summary>
    /// The Learning Assignment state
    /// </summary>
    /// <value>The Learning Assignment state</value>
    public LearningAssignmentStateEnum? State { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The assessment associated with this assignment
    /// </summary>
    /// <value>The assessment associated with this assignment</value>
    public LearningAssessment Assessment { get; set; }

    /// <summary>
    /// The user who created the assignment
    /// </summary>
    public UserReference CreatedBy { get; set; }

    /// <summary>
    /// The date when the assignment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the assignment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The user who modified the assignment
    /// </summary>
    /// <value>The user who modified the assignment</value>
    public UserReference ModifiedBy { get; set; }

    /// <summary>
    /// The date when the assignment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the assignment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// True if the assignment is overdue
    /// </summary>
    /// <value>True if the assignment is overdue</value
    public bool? IsOverdue { get; set; }

    /// <summary>
    /// The user&#39;s percentage score for this assignment
    /// </summary>
    /// <value>The user&#39;s percentage score for this assignment</value>
    public float? PercentageScore { get; set; }

    /// <summary>
    /// The user&#39;s percentage score for this assignment&#39;s assessment
    /// </summary>
    /// <value>The user&#39;s percentage score for this assignment&#39;s assessment</value>
    public float? AssessmentPercentageScore { get; set; }

    /// <summary>
    /// True if this assignment was created by a Rule
    /// </summary>
    /// <value>True if this assignment was created by a Rule</value>
    public bool? IsRule { get; set; }

    /// <summary>
    /// True if this assignment was created manually
    /// </summary>
    /// <value>True if this assignment was created manually</value>
    public bool? IsManual { get; set; }

    /// <summary>
    /// True if the assessment was passed
    /// </summary>
    /// <value>True if the assessment was passed</value>
    public bool? IsPassed { get; set; }

    /// <summary>
    /// True if the assignment is based on latest module
    /// </summary>
    /// <value>True if the assignment is based on latest module</value>
    public bool? IsLatest { get; set; }

    /// <summary>
    /// The assessment completion percentage of assignment
    /// </summary>
    /// <value>The assessment completion percentage of assignment</value>
    public float? AssessmentCompletionPercentage { get; set; }

    /// <summary>
    /// The overall completion percentage of assignment
    /// </summary>
    /// <value>The overall completion percentage of assignment</value>
    public float? CompletionPercentage { get; set; }

    /// <summary>
    /// List of assignment steps
    /// </summary>
    /// <value>List of assignment steps</value>
    public IEnumerable<LearningAssignmentStep> Steps { get; set; }

    /// <summary>
    /// The next assignment step
    /// </summary>
    /// <value>The next assignment step</value>
    public LearningAssignmentStep NextStep { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }

    /// <summary>
    /// The recommended completion date of the assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The recommended completion date of the assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateRecommendedForCompletion { get; set; }

    /// <summary>
    /// The version of Learning module assigned
    /// </summary>
    /// <value>The version of Learning module assigned</value>
    public int? Version { get; set; }

    /// <summary>
    /// The Learning module object associated with this assignment
    /// </summary>
    /// <value>The Learning module object associated with this assignment</value
    public LearningModule Module { get; set; }

    /// <summary>
    /// The user to whom the assignment is assigned
    /// </summary>
    /// <value>The user to whom the assignment is assigned</value>
    public UserReference User { get; set; }

    /// <summary>
    /// The assessment form associated with this assignment
    /// </summary>
    /// <value>The assessment form associated with this assignment</value>
    public AssessmentForm AssessmentForm { get; set; }

    /// <summary>
    /// The length in minutes of the assignment
    /// </summary>
    /// <value>The length in minutes of the assignment</value>
    public int? LengthInMinutes { get; set; }
}
