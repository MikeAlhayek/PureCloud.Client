using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILearningApi
{
    Task<LearningAssignment> GetLearningAssignmentAsync(string assignmentId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    Task<LearningModule> GetLearningModuleAsync(string moduleId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    Task<LearningAssignment> CreateLearningAssignmentAsync(LearningAssignmentCreate body, CancellationToken cancellationToken = default);

    Task<LearningModule> UpdateLearningModuleAsync(string moduleId, LearningModuleRequest body, CancellationToken cancellationToken = default);

    Task DeleteLearningAssignmentAsync(string assignmentId, CancellationToken cancellationToken = default);
}