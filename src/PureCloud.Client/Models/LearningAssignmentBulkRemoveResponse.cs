namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentBulkRemoveResponse
/// </summary>
public sealed class LearningAssignmentBulkRemoveResponse
{
    /// <summary>
    /// LearningAssignmentBulkRemoveResponse
    /// </summary>
    public IEnumerable<LearningAssignmentEntity> Entities { get; set; }

    /// <summary>
    /// The learning assignments that were not removed due to missing permissions
    /// </summary>
    public IEnumerable<DisallowedEntityLearningAssignmentReference> DisallowedEntities { get; set; }
}
