using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

/// <summary>
/// Recording API interface for managing call recordings, metadata, and retention policies.
/// </summary>
public interface IRecordingApi
{
    /// <summary>
    /// Get a conversation recording.
    /// </summary>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="recordingId">Recording ID</param>
    /// <param name="formatId">The desired media format</param>
    /// <param name="emailFormatId">The desired media format for email</param>
    /// <param name="chatFormatId">The desired media format for chat</param>
    /// <param name="messageFormatId">The desired media format for message</param>
    /// <param name="download">Whether to download the recording</param>
    /// <param name="fileName">The name to give the downloaded file</param>
    /// <param name="locale">The desired locale</param>
    /// <param name="mediaFormats">The desired media formats</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recording details</returns>
    Task<Recording> GetConversationRecordingAsync(string conversationId, string recordingId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, string[] mediaFormats = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get annotations for a conversation recording.
    /// </summary>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="recordingId">Recording ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of annotations</returns>
    Task<Annotation[]> GetConversationRecordingAnnotationsAsync(string conversationId, string recordingId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a conversation recording annotation.
    /// </summary>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="recordingId">Recording ID</param>
    /// <param name="annotationId">Annotation ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task DeleteConversationRecordingAnnotationAsync(string conversationId, string recordingId, string annotationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all recordings for a conversation.
    /// </summary>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="maxWaitMs">Maximum wait time in milliseconds</param>
    /// <param name="formatId">The desired media format</param>
    /// <param name="mediaFormats">The desired media formats</param>
    /// <param name="locale">The desired locale</param>
    /// <param name="includePauseAnnotationsForScreenRecordings">Include pause annotations for screen recordings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of recordings</returns>
    Task<Recording[]> GetConversationRecordingsAsync(string conversationId, int? maxWaitMs = null, string formatId = null, string[] mediaFormats = null, string locale = null, bool? includePauseAnnotationsForScreenRecordings = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get orphaned recordings.
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="expand">Expand fields</param>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="hasConversation">Filter by has conversation</param>
    /// <param name="media">Media type filter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Orphan recording listing</returns>
    Task<OrphanRecordingListing> GetOrphanrecordingsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string[] expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null, string media = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an orphaned recording.
    /// </summary>
    /// <param name="orphanId">Orphan ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Deleted orphan recording</returns>
    Task<OrphanRecording> DeleteOrphanrecordingAsync(string orphanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get batch download job status.
    /// </summary>
    /// <param name="jobId">Job ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Batch download job status</returns>
    Task<BatchDownloadJobStatusResult> GetRecordingBatchrequestAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Submit a batch download job.
    /// </summary>
    /// <param name="body">Batch download job submission</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Batch download job submission result</returns>
    Task<BatchDownloadJobSubmissionResult> CreateRecordingBatchrequestAsync(BatchDownloadJobSubmission body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a conversation recording annotation.
    /// </summary>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="recordingId">Recording ID</param>
    /// <param name="annotationId">Annotation ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Annotation details</returns>
    Task<Annotation> GetConversationRecordingAnnotationAsync(string conversationId, string recordingId, string annotationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a conversation recording annotation.
    /// </summary>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="recordingId">Recording ID</param>
    /// <param name="body">Annotation details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created annotation</returns>
    Task<Annotation> CreateConversationRecordingAnnotationAsync(string conversationId, string recordingId, Annotation body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a conversation recording annotation.
    /// </summary>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="recordingId">Recording ID</param>
    /// <param name="annotationId">Annotation ID</param>
    /// <param name="body">Updated annotation details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated annotation</returns>
    Task<Annotation> UpdateConversationRecordingAnnotationAsync(string conversationId, string recordingId, string annotationId, Annotation body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete cross platform media retention policies.
    /// </summary>
    /// <param name="ids">Policy IDs to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> DeleteRecordingCrossplatformMediaretentionpoliciesAsync(string ids, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a cross platform media retention policy.
    /// </summary>
    /// <param name="policyId">Policy ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> DeleteRecordingCrossplatformMediaretentionpolicyAsync(string policyId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a recording job.
    /// </summary>
    /// <param name="jobId">Job ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> DeleteRecordingJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete media retention policies.
    /// </summary>
    /// <param name="ids">Policy IDs to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> DeleteRecordingMediaretentionpoliciesAsync(string ids, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a media retention policy.
    /// </summary>
    /// <param name="policyId">Policy ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> DeleteRecordingMediaretentionpolicyAsync(string policyId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get an orphaned recording.
    /// </summary>
    /// <param name="orphanId">Orphan ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Orphan recording details</returns>
    Task<OrphanRecording> GetOrphanrecordingAsync(string orphanId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get orphaned recording media.
    /// </summary>
    /// <param name="orphanId">Orphan ID</param>
    /// <param name="formatId">The desired media format</param>
    /// <param name="emailFormatId">The desired media format for email</param>
    /// <param name="chatFormatId">The desired media format for chat</param>
    /// <param name="messageFormatId">The desired media format for message</param>
    /// <param name="download">Whether to download the recording</param>
    /// <param name="fileName">The name to give the downloaded file</param>
    /// <param name="locale">The desired locale</param>
    /// <param name="mediaFormats">The desired media formats</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recording details</returns>
    Task<Recording> GetOrphanrecordingMediaAsync(string orphanId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, string[] mediaFormats = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get cross platform media retention policies.
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="expand">Expand fields</param>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="name">Policy name filter</param>
    /// <param name="enabled">Enabled filter</param>
    /// <param name="summary">Summary filter</param>
    /// <param name="hasErrors">Has errors filter</param>
    /// <param name="deleteDaysThreshold">Delete days threshold</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Policy entity listing</returns>
    Task<PolicyEntityListing> GetRecordingCrossplatformMediaretentionpoliciesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string[] expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a cross platform media retention policy.
    /// </summary>
    /// <param name="policyId">Policy ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Cross platform policy details</returns>
    Task<CrossPlatformPolicy> GetRecordingCrossplatformMediaretentionpolicyAsync(string policyId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a recording job.
    /// </summary>
    /// <param name="jobId">Job ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recording job details</returns>
    Task<RecordingJob> GetRecordingJobAsync(string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get failed recordings for a job.
    /// </summary>
    /// <param name="jobId">Job ID</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="includeTotal">Include total count</param>
    /// <param name="cursor">Cursor for pagination</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Failed recording entity listing</returns>
    Task<FailedRecordingEntityListing> GetRecordingJobFailedrecordingsAsync(string jobId, int? pageSize = null, int? pageNumber = null, bool? includeTotal = null, string cursor = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get recording jobs.
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="state">Job state filter</param>
    /// <param name="showOnlyMyJobs">Show only my jobs</param>
    /// <param name="jobType">Job type filter</param>
    /// <param name="includeTotal">Include total count</param>
    /// <param name="cursor">Cursor for pagination</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recording job entity listing</returns>
    Task<RecordingJobEntityListing> GetRecordingJobsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string state = null, bool? showOnlyMyJobs = null, string jobType = null, bool? includeTotal = null, string cursor = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get recording key configuration.
    /// </summary>
    /// <param name="keyConfigurationId">Key configuration ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recording encryption configuration</returns>
    Task<RecordingEncryptionConfiguration> GetRecordingKeyconfigurationAsync(string keyConfigurationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get recording key configurations.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recording encryption configuration listing</returns>
    Task<RecordingEncryptionConfigurationListing> GetRecordingKeyconfigurationsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get media retention policies.
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="sortBy">Sort by field</param>
    /// <param name="expand">Expand fields</param>
    /// <param name="nextPage">Next page</param>
    /// <param name="previousPage">Previous page</param>
    /// <param name="name">Policy name filter</param>
    /// <param name="enabled">Enabled filter</param>
    /// <param name="summary">Summary filter</param>
    /// <param name="hasErrors">Has errors filter</param>
    /// <param name="deleteDaysThreshold">Delete days threshold</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Policy entity listing</returns>
    Task<PolicyEntityListing> GetRecordingMediaretentionpoliciesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string[] expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a media retention policy.
    /// </summary>
    /// <param name="policyId">Policy ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Policy details</returns>
    Task<Policy> GetRecordingMediaretentionpolicyAsync(string policyId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get recording encryption keys.
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Encryption key entity listing</returns>
    Task<EncryptionKeyEntityListing> GetRecordingRecordingkeysAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get recording key rotation schedule.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Key rotation schedule</returns>
    Task<KeyRotationSchedule> GetRecordingRecordingkeysRotationscheduleAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get recording settings.
    /// </summary>
    /// <param name="createDefault">Create default settings if not found</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recording settings</returns>
    Task<RecordingSettings> GetRecordingSettingsAsync(bool? createDefault = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get recording upload report.
    /// </summary>
    /// <param name="reportId">Report ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recording upload report</returns>
    Task<RecordingUploadReport> GetRecordingUploadsReportAsync(string reportId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get recordings retention query.
    /// </summary>
    /// <param name="retentionThresholdDays">Retention threshold in days</param>
    /// <param name="cursor">Cursor for pagination</param>
    /// <param name="pageSize">Page size</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recording retention cursor entity listing</returns>
    Task<RecordingRetentionCursorEntityListing> GetRecordingsRetentionQueryAsync(int? retentionThresholdDays, string cursor = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get screen recording session details.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Screen recording active sessions</returns>
    Task<ScreenRecordingActiveSessions> GetRecordingsScreensessionsDetailsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a cross platform media retention policy.
    /// </summary>
    /// <param name="policyId">Policy ID</param>
    /// <param name="body">Updated policy details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated cross platform policy</returns>
    Task<CrossPlatformPolicy> UpdateRecordingCrossplatformMediaretentionpolicyAsync(string policyId, CrossPlatformPolicy body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a media retention policy.
    /// </summary>
    /// <param name="policyId">Policy ID</param>
    /// <param name="body">Updated policy details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated policy</returns>
    Task<Policy> UpdateRecordingMediaretentionpolicyAsync(string policyId, Policy body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a cross platform media retention policy.
    /// </summary>
    /// <param name="body">Policy details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created cross platform policy</returns>
    Task<CrossPlatformPolicy> CreateRecordingCrossplatformMediaretentionpolicyAsync(CrossPlatformPolicy body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a recording job.
    /// </summary>
    /// <param name="body">Recording jobs query</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created recording job</returns>
    Task<RecordingJob> CreateRecordingJobAsync(RecordingJobsQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a recording key configuration.
    /// </summary>
    /// <param name="body">Recording encryption configuration</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created recording encryption configuration</returns>
    Task<RecordingEncryptionConfiguration> CreateRecordingKeyconfigurationAsync(RecordingEncryptionConfiguration body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Validate a recording key configuration.
    /// </summary>
    /// <param name="body">Recording encryption configuration to validate</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Validated recording encryption configuration</returns>
    Task<RecordingEncryptionConfiguration> ValidateRecordingKeyconfigurationAsync(RecordingEncryptionConfiguration body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create recording encryption keys.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created encryption key</returns>
    Task<EncryptionKey> CreateRecordingRecordingkeysAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a media retention policy.
    /// </summary>
    /// <param name="body">Policy details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created policy</returns>
    Task<Policy> CreateRecordingMediaretentionpolicyAsync(Policy body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get conversation recording metadata.
    /// </summary>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recording metadata array</returns>
    Task<RecordingMetadata[]> GetConversationRecordingmetadataAsync(string conversationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a recording upload report.
    /// </summary>
    /// <param name="body">Recording upload report request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created recording upload report</returns>
    Task<RecordingUploadReport> CreateRecordingUploadsReportAsync(RecordingUploadReportRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create recordings deletion protection.
    /// </summary>
    /// <param name="conversationIds">Conversation IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Addressable entity references array</returns>
    Task<AddressableEntityRef[]> CreateRecordingsDeletionprotectionAsync(string conversationIds, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update recordings deletion protection.
    /// </summary>
    /// <param name="protect">Protection status</param>
    /// <param name="conversationIds">Conversation IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Addressable entity references array</returns>
    Task<AddressableEntityRef[]> UpdateRecordingsDeletionprotectionAsync(bool? protect = null, string conversationIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a conversation recording.
    /// </summary>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="recordingId">Recording ID</param>
    /// <param name="body">Updated recording details</param>
    /// <param name="clearExport">Clear export flag</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated recording</returns>
    Task<Recording> UpdateConversationRecordingAsync(string conversationId, string recordingId, Recording body, bool? clearExport = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Replace a cross platform media retention policy.
    /// </summary>
    /// <param name="policyId">Policy ID</param>
    /// <param name="body">Policy details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Replaced cross platform policy</returns>
    Task<CrossPlatformPolicy> ReplaceRecordingCrossplatformMediaretentionpolicyAsync(string policyId, CrossPlatformPolicy body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a recording job.
    /// </summary>
    /// <param name="jobId">Job ID</param>
    /// <param name="body">Execute recording jobs query</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated recording job</returns>
    Task<RecordingJob> UpdateRecordingJobAsync(string jobId, ExecuteRecordingJobsQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Replace a recording key configuration.
    /// </summary>
    /// <param name="keyConfigurationId">Key configuration ID</param>
    /// <param name="body">Recording encryption configuration</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Replaced recording encryption configuration</returns>
    Task<RecordingEncryptionConfiguration> ReplaceRecordingKeyconfigurationAsync(string keyConfigurationId, RecordingEncryptionConfiguration body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Replace a media retention policy.
    /// </summary>
    /// <param name="policyId">Policy ID</param>
    /// <param name="body">Policy details</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Replaced policy</returns>
    Task<Policy> ReplaceRecordingMediaretentionpolicyAsync(string policyId, Policy body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update recording key rotation schedule.
    /// </summary>
    /// <param name="body">Key rotation schedule</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated key rotation schedule</returns>
    Task<KeyRotationSchedule> UpdateRecordingRecordingkeysRotationscheduleAsync(KeyRotationSchedule body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update recording settings.
    /// </summary>
    /// <param name="body">Recording settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated recording settings</returns>
    Task<RecordingSettings> UpdateRecordingSettingsAsync(RecordingSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get specific conversation recording metadata.
    /// </summary>
    /// <param name="conversationId">Conversation ID</param>
    /// <param name="recordingId">Recording ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Recording metadata</returns>
    Task<RecordingMetadata> GetConversationRecordingmetadataRecordingIdAsync(string conversationId, string recordingId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create local encryption keys.
    /// </summary>
    /// <param name="body">Local encryption key request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created encryption key</returns>
    Task<EncryptionKey> CreateRecordingLocalkeysAsync(LocalEncryptionKeyRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Acknowledge screen recording sessions.
    /// </summary>
    /// <param name="body">Acknowledge screen recording request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> CreateRecordingsScreensessionsAcknowledgeAsync(AcknowledgeScreenRecordingRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create screen session metadata.
    /// </summary>
    /// <param name="body">Screen recording metadata request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success status</returns>
    Task<bool> CreateRecordingsScreensessionsMetadataAsync(ScreenRecordingMetaDataRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update orphan recording information.
    /// </summary>
    /// <param name="orphanId">Orphan ID</param>
    /// <param name="body">Orphan update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated recording</returns>
    Task<Recording> UpdateOrphanrecordingAsync(string orphanId, OrphanUpdateRequest body = null, CancellationToken cancellationToken = default);
}