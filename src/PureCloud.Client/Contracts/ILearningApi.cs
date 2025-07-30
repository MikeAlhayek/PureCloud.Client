using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILearningApi
{
    /// <summary>
    /// Delete a learning assignment
    /// </summary>
    /// <param name="assignmentId">Learning Assignment ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<bool> DeleteLearningAssignmentAsync(string assignmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a learning module
    /// </summary>
    /// <param name="moduleId">The ID of the learning module</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<bool> DeleteLearningModuleAsync(string moduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Learning Assignment
    /// </summary>
    /// <param name="assignmentId">Learning Assignment ID</param>
    /// <param name="expands">Fields to expand in response</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignment> GetLearningAssignmentAsync(string assignmentId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Learning Assignment Step
    /// </summary>
    /// <param name="assignmentId">Learning Assignment ID</param>
    /// <param name="stepId">Learning Assignment Step ID</param>
    /// <param name="shareableContentObjectId">Shareable Content Object ID</param>
    /// <param name="defaultShareableContentObject">Default Shareable Content Object</param>
    /// <param name="expands">Fields to expand in response</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignmentStep> GetLearningAssignmentStepAsync(string assignmentId, string stepId, string shareableContentObjectId = null, string defaultShareableContentObject = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// List Learning Assignments
    /// </summary>
    /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID</param>
    /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDTHH:mm:ss/YYYY-MM-DDTHH:mm:ss</param>
    /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDTHH:mm:ss/YYYY-MM-DDTHH:mm:ss</param>
    /// <param name="overdue">Specifies if only the non-overdue (overdue is \"False\") or overdue (overdue is \"True\") assignments are returned. If overdue is \"Any\" or if the overdue parameter is not supplied, all assignments are returned</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pass">Specifies if only the failed (pass is \"False\") or passed (pass is \"True\") assignments (completed with assessment)are returned. If pass is \"Any\" or if the pass parameter is not supplied, all assignments are returned</param>
    /// <param name="minPercentageScore">The minimum percentage score required</param>
    /// <param name="maxPercentageScore">The maximum percentage score required</param>
    /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc)</param>
    /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate</param>
    /// <param name="userId">Specifies the list of user IDs to be queried, up to 100 user IDs.</param>
    /// <param name="types">Specifies the assignment types.</param>
    /// <param name="states">Specifies the assignment states</param>
    /// <param name="expands">Specifies the expand option for returning additional information</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignmentsDomainEntity> GetLearningAssignmentsAsync(string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string pass = null, float? minPercentageScore = null, float? maxPercentageScore = null, string sortOrder = null, string sortBy = null, IEnumerable<string> userId = null, IEnumerable<string> types = null, IEnumerable<string> states = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get current user Learning Assignments
    /// </summary>
    /// <param name="moduleId">Specifies the ID of the learning module. Fetch assignments for learning module ID</param>
    /// <param name="interval">Specifies the range of dueDates to be queried. Milliseconds will be truncated. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDTHH:mm:ss/YYYY-MM-DDTHH:mm:ss</param>
    /// <param name="completionInterval">Specifies the range of completion dates to be used for filtering. A maximum of 1 year can be specified in the range. End date is not inclusive. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDTHH:mm:ss/YYYY-MM-DDTHH:mm:ss</param>
    /// <param name="overdue">Specifies if only the non-overdue (overdue is \"False\") or overdue (overdue is \"True\") assignments are returned. If overdue is \"Any\" or if the overdue parameter is not supplied, all assignments are returned</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="pass">Specifies if only the failed (pass is \"False\") or passed (pass is \"True\") assignments (completed with assessment)are returned. If pass is \"Any\" or if the pass parameter is not supplied, all assignments are returned</param>
    /// <param name="minPercentageScore">The minimum percentage score required</param>
    /// <param name="maxPercentageScore">The maximum percentage score required</param>
    /// <param name="sortOrder">Specifies result set sort order; if not specified, default sort order is descending (Desc)</param>
    /// <param name="sortBy">Specifies which field to sort the results by, default sort is by recommendedCompletionDate</param>
    /// <param name="types">Specifies the assignment types.</param>
    /// <param name="states">Specifies the assignment states</param>
    /// <param name="expands">Specifies the expand option for returning additional information</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignmentsDomainEntity> GetLearningAssignmentsMeAsync(string moduleId = null, string interval = null, string completionInterval = null, string overdue = null, int? pageSize = null, int? pageNumber = null, string pass = null, float? minPercentageScore = null, float? maxPercentageScore = null, string sortOrder = null, string sortBy = null, IEnumerable<string> types = null, IEnumerable<string> states = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a learning module
    /// </summary>
    /// <param name="moduleId">The ID of the learning module</param>
    /// <param name="expands">Fields to expand in response</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningModule> GetLearningModuleAsync(string moduleId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a specific Learning Module job status
    /// </summary>
    /// <param name="moduleId">The ID of the learning module</param>
    /// <param name="jobId">The ID of the learning module job</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningModuleJobResponse> GetLearningModuleJobAsync(string moduleId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a learning module preview
    /// </summary>
    /// <param name="moduleId">The ID of the learning module</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningModulePreviewGetResponse> GetLearningModulePreviewAsync(string moduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a learning module rule
    /// </summary>
    /// <param name="moduleId">The ID of the learning module</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningModuleRule> GetLearningModuleRuleAsync(string moduleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a specific version of a published module
    /// </summary>
    /// <param name="moduleId">The ID of the learning module</param>
    /// <param name="versionId">The version of learning module</param>
    /// <param name="expands">Fields to expand in response</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningModule> GetLearningModuleVersionAsync(string moduleId, string versionId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all learning modules of an organization
    /// </summary>
    /// <param name="isArchived">Archive status</param>
    /// <param name="types">Specifies the module types.</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="sortBy">Sort by</param>
    /// <param name="searchTerm">Search Term</param>
    /// <param name="expands">Fields to expand in response</param>
    /// <param name="isPublished">Specifies if only the Published (isPublished is \"True\") or Unpublished (isPublished is \"False\") modules are returned. If isPublished is \"Any\" or omitted, both published and unpublished modules are returned</param>
    /// <param name="statuses">Specifies the module statuses to filter by</param>
    /// <param name="externalIds">Specifies the module external IDs to filter by. Only one ID is allowed</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningModulesDomainEntityListing> GetLearningModulesAsync(bool? isArchived = null, IEnumerable<string> types = null, int? pageSize = null, int? pageNumber = null, string sortOrder = null, string sortBy = null, string searchTerm = null, IEnumerable<string> expands = null, string isPublished = null, IEnumerable<string> statuses = null, IEnumerable<string> externalIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get learning modules assigned to a user
    /// </summary>
    /// <param name="userIds">The IDs of the users to retrieve assigned modules for</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="searchTerm">Search Term</param>
    /// <param name="overdue">Specifies if only modules with overdue/not overdue (overdue is \"True\" or \"False\") assignments are returned. If overdue is \"Any\" or if the overdue parameter is not supplied, all assigned modules are returned</param>
    /// <param name="assignmentStates">Specifies the assignment states to filter by</param>
    /// <param name="expands">Fields to expand in response</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<AssignedLearningModuleDomainEntityListing> GetLearningModulesAssignmentsAsync(IEnumerable<string> userIds, int? pageSize = null, int? pageNumber = null, string searchTerm = null, string overdue = null, IEnumerable<string> assignmentStates = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a learning module cover art
    /// </summary>
    /// <param name="coverArtId">Key identifier for the cover art</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningModuleCoverArtResponse> GetLearningModulesCoverartCoverArtIdAsync(string coverArtId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get SCORM package information
    /// </summary>
    /// <param name="scormId">The ID of the SCORM package</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningScormResponse> GetLearningScormScormIdAsync(string scormId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Learning Assignment
    /// </summary>
    /// <param name="assignmentId">Learning Assignment ID</param>
    /// <param name="body">Learning assignment to update</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignment> UpdateLearningAssignmentAsync(string assignmentId, LearningAssignmentUpdate body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reschedule Learning Assignment
    /// </summary>
    /// <param name="assignmentId">Learning Assignment ID</param>
    /// <param name="body">Assignment reschedule data</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignment> UpdateLearningAssignmentRescheduleAsync(string assignmentId, LearningAssignmentReschedule body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Learning Assignment Step
    /// </summary>
    /// <param name="assignmentId">Learning Assignment ID</param>
    /// <param name="stepId">Learning Assignment Step ID</param>
    /// <param name="body">Learning assignment step to update</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignmentStep> UpdateLearningAssignmentStepAsync(string assignmentId, string stepId, LearningAssignmentStep body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a user's assignment for a learning module
    /// </summary>
    /// <param name="moduleId">The ID of the learning module</param>
    /// <param name="userId">The ID of the user</param>
    /// <param name="body">The learning assignment to update</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignment> UpdateLearningModuleUserAssignmentsAsync(string moduleId, string userId, LearningAssignmentExternalUpdate body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Score learning assessment for preview
    /// </summary>
    /// <param name="body">Assessment scoring request</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<AssessmentScoringSet> CreateLearningAssessmentsScoringAsync(LearningAssessmentScoringRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reassign a learning assignment
    /// </summary>
    /// <param name="assignmentId">Learning Assignment ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignment> CreateLearningAssignmentReassignAsync(string assignmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reset Learning Assignment
    /// </summary>
    /// <param name="assignmentId">Learning Assignment ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignment> CreateLearningAssignmentResetAsync(string assignmentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create Learning Assignment
    /// </summary>
    /// <param name="body">Learning assignment to create</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignment> CreateLearningAssignmentAsync(LearningAssignmentCreate body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve aggregated assignment data
    /// </summary>
    /// <param name="body">Assignment query</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignmentAggregateResponse> CreateLearningAssignmentsAggregatesQueryAsync(LearningAssignmentAggregateParam body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add multiple learning assignments
    /// </summary>
    /// <param name="body">Assignment bulk add request</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignmentBulkAddResponse> CreateLearningAssignmentsBulkaddAsync(IEnumerable<LearningAssignmentItem> body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove multiple learning assignments
    /// </summary>
    /// <param name="body">Assignment IDs to remove</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignmentBulkRemoveResponse> CreateLearningAssignmentsBulkremoveAsync(IEnumerable<string> body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Starts a specified operation on learning module
    /// </summary>
    /// <param name="moduleId">The ID of the learning module</param>
    /// <param name="body">The learning module job request</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningModuleJobResponse> CreateLearningModuleJobsAsync(string moduleId, LearningModuleJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Publish a Learning module
    /// </summary>
    /// <param name="moduleId">The ID of the learning module</param>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningModulePublishResponse> CreateLearningModulePublishAsync(string moduleId, LearningModulePublishRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new learning module
    /// </summary>
    /// <param name="body">The learning module to be created</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningModule> CreateLearningModuleAsync(LearningModuleRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get users for learning module rule
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="body">Learning assignment query</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningAssignmentUserListing> CreateLearningRulesQueryAsync(int? pageSize, int? pageNumber, LearningAssignmentUserQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of possible schedule slots for learning modules
    /// </summary>
    /// <param name="body">Learning schedule slots query request</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningScheduleSlotsQueryResponse> CreateLearningScheduleslotsQueryAsync(LearningScheduleSlotsQueryRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Upload a SCORM package
    /// </summary>
    /// <param name="body">SCORM upload request</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningScormUploadResponse> CreateLearningScormAsync(LearningScormUploadRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a learning module
    /// </summary>
    /// <param name="moduleId">The ID of the learning module</param>
    /// <param name="body">The learning module to be updated</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningModule> UpdateLearningModuleAsync(string moduleId, LearningModuleRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a learning module preview
    /// </summary>
    /// <param name="moduleId">The ID of the learning module</param>
    /// <param name="body">The learning module preview update request</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningModulePreviewUpdateResponse> UpdateLearningModulePreviewAsync(string moduleId, LearningModulePreviewUpdateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a learning module rule
    /// </summary>
    /// <param name="moduleId">The ID of the learning module</param>
    /// <param name="body">The learning module rule to be updated</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    Task<LearningModuleRule> UpdateLearningModuleRuleAsync(string moduleId, LearningModuleRule body, CancellationToken cancellationToken = default);
}