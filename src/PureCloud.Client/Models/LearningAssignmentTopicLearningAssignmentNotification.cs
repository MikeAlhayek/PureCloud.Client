using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LearningAssignmentTopicLearningAssignmentNotification
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public LearningAssignmentTopicLearningAssignmentNotificationStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public LearningAssignmentTopicLearningAssignmentNotificationTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public LearningAssignmentTopicUserReference User { get; set; }

    /// <summary>
    /// Gets or Sets Module
    /// </summary>
    public LearningAssignmentTopicLearningModuleReference Module { get; set; }

    /// <summary>
    /// Gets or Sets Version
    public long? Version { get; set; }

    /// <summary>
    /// Gets or Sets DateRecommendedForCompletion
    /// </summary>
    public DateTime? DateRecommendedForCompletion { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    public LearningAssignmentTopicUserReference CreatedBy { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    public LearningAssignmentTopicUserReference ModifiedBy { get; set; }

    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Gets or Sets IsOverdue
    /// </summary>
    public bool? IsOverdue { get; set; }

    /// <summary>
    /// Gets or Sets LengthInMinutes
    /// </summary>
    public long? LengthInMinutes { get; set; }

    /// <summary>
    /// Gets or Sets PercentageScore
    /// </summary>
    public double? PercentageScore { get; set; }

    /// <summary>
    /// Gets or Sets IsPassed
    /// </summary>
    public bool? IsPassed { get; set; }
}
