using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILearningApi
{
    /// <summary>
    /// Delete a learning assignment
    /// </summary>
    Task<bool> DeleteLearningAssignmentAsync(string assignmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a learning module
    /// </summary>
    Task<bool> DeleteLearningModuleAsync(string moduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Learning Assignment
    /// </summary>
    Task<LearningAssignment> GetLearningAssignmentAsync(string assignmentId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Learning Assignment Step
    /// </summary>
    Task<LearningAssignmentStep> GetLearningAssignmentStepAsync(string assignmentId, string stepId, string shareableContentObjectId = null, string defaultShareableContentObject = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Learning Assignments
    /// </summary>
    Task<LearningAssignmentsDomainEntity> GetLearningAssignmentsAsync(string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string pass = null, float? minPercentageScore = null, float? maxPercentageScore = null, string sortOrder = null, string sortBy = null, IEnumerable<string> userId = null, IEnumerable<string> types = null, IEnumerable<string> states = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get current user Learning Assignments
    /// </summary>
    Task<LearningAssignmentsDomainEntity> GetLearningAssignmentsMeAsync(string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string pass = null, float? minPercentageScore = null, float? maxPercentageScore = null, string sortOrder = null, string sortBy = null, IEnumerable<string> types = null, IEnumerable<string> states = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a learning module
    /// </summary>
    Task<LearningModule> GetLearningModuleAsync(string moduleId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a specific Learning Module job status
    /// </summary>
    Task<LearningModuleJobResponse> GetLearningModuleJobAsync(string moduleId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a learning module preview
    /// </summary>
    Task<LearningModulePreviewGetResponse> GetLearningModulePreviewAsync(string moduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a learning module rule
    /// </summary>
    Task<LearningModuleRule> GetLearningModuleRuleAsync(string moduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a specific version of a published module
    /// </summary>
    Task<LearningModule> GetLearningModuleVersionAsync(string moduleId, string versionId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all learning modules of an organization
    /// </summary>
    Task<LearningModulesDomainEntityListing> GetLearningModulesAsync(bool? isArchived = null, IEnumerable<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, IEnumerable<string> expand = null, string isPublished = null, IEnumerable<string> statuses = null, IEnumerable<string> externalIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get learning modules assigned to a user
    /// </summary>
    Task<AssignedLearningModuleDomainEntityListing> GetLearningModulesAssignmentsAsync(IEnumerable<string> userIds, int? pageSize = null, int? pageNumber = null, string searchTerm = null, string overdue = null, IEnumerable<string> assignmentStates = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a learning module cover art
    /// </summary>
    Task<LearningModuleCoverArtResponse> GetLearningModulesCoverartCoverArtIdAsync(string coverArtId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SCORM package information
    /// </summary>
    Task<LearningScormResponse> GetLearningScormScormIdAsync(string scormId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Learning Assignment
    /// </summary>
    Task<LearningAssignment> UpdateLearningAssignmentAsync(string assignmentId, LearningAssignmentUpdate body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reschedule Learning Assignment
    /// </summary>
    Task<LearningAssignment> UpdateLearningAssignmentRescheduleAsync(string assignmentId, LearningAssignmentReschedule body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Learning Assignment Step
    /// </summary>
    Task<LearningAssignmentStep> UpdateLearningAssignmentStepAsync(string assignmentId, string stepId, LearningAssignmentStep body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user's assignment for a learning module
    /// </summary>
    Task<LearningAssignment> UpdateLearningModuleUserAssignmentsAsync(string moduleId, string userId, LearningAssignmentExternalUpdate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Score learning assessment for preview
    /// </summary>
    Task<AssessmentScoringSet> CreateLearningAssessmentsScoringAsync(LearningAssessmentScoringRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reassign a learning assignment
    /// </summary>
    Task<LearningAssignment> CreateLearningAssignmentReassignAsync(string assignmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reset Learning Assignment
    /// </summary>
    Task<LearningAssignment> CreateLearningAssignmentResetAsync(string assignmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Learning Assignment
    /// </summary>
    Task<LearningAssignment> CreateLearningAssignmentAsync(LearningAssignmentCreate body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve aggregated assignment data
    /// </summary>
    Task<LearningAssignmentAggregateResponse> CreateLearningAssignmentsAggregatesQueryAsync(LearningAssignmentAggregateParam body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add multiple learning assignments
    /// </summary>
    Task<LearningAssignmentBulkAddResponse> CreateLearningAssignmentsBulkaddAsync(IEnumerable<LearningAssignmentItem> body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove multiple learning assignments
    /// </summary>
    Task<LearningAssignmentBulkRemoveResponse> CreateLearningAssignmentsBulkremoveAsync(IEnumerable<string> body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Starts a specified operation on learning module
    /// </summary>
    Task<LearningModuleJobResponse> CreateLearningModuleJobsAsync(string moduleId, LearningModuleJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Publish a Learning module
    /// </summary>
    Task<LearningModulePublishResponse> CreateLearningModulePublishAsync(string moduleId, LearningModulePublishRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new learning module
    /// </summary>
    Task<LearningModule> CreateLearningModuleAsync(LearningModuleRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get users for learning module rule
    /// </summary>
    Task<LearningAssignmentUserListing> CreateLearningRulesQueryAsync(int? pageSize, int? pageNumber, LearningAssignmentUserQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of possible schedule slots for learning modules
    /// </summary>
    Task<LearningScheduleSlotsQueryResponse> CreateLearningScheduleslotsQueryAsync(LearningScheduleSlotsQueryRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Upload a SCORM package
    /// </summary>
    Task<LearningScormUploadResponse> CreateLearningScormAsync(LearningScormUploadRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a learning module
    /// </summary>
    Task<LearningModule> UpdateLearningModuleAsync(string moduleId, LearningModuleRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a learning module preview
    /// </summary>
    Task<LearningModulePreviewUpdateResponse> UpdateLearningModulePreviewAsync(string moduleId, LearningModulePreviewUpdateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a learning module rule
    /// </summary>
    Task<LearningModuleRule> UpdateLearningModuleRuleAsync(string moduleId, LearningModuleRule body, CancellationToken cancellationToken = default);
}