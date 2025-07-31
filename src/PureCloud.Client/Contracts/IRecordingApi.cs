using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IRecordingApi
{
    Task<Recording> GetConversationRecordingAsync(string conversationId, string recordingId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, IEnumerable<string> mediaFormats = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<Annotation>> GetConversationRecordingAnnotationsAsync(string conversationId, string recordingId, CancellationToken cancellationToken = default);

    Task DeleteConversationRecordingAnnotationAsync(string conversationId, string recordingId, string annotationId, CancellationToken cancellationToken = default);

    Task<IEnumerable<Recording>> GetConversationRecordingsAsync(string conversationId, int? maxWaitMs = null, string formatId = null, IEnumerable<string> mediaFormats = null, string locale = null, bool? includePauseAnnotationsForScreenRecordings = null, CancellationToken cancellationToken = default);

    Task<OrphanRecordingListing> GetOrphanrecordingsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null, string media = null, CancellationToken cancellationToken = default);

    Task<OrphanRecording> DeleteOrphanrecordingAsync(string orphanId, CancellationToken cancellationToken = default);

    Task<BatchDownloadJobStatusResult> GetRecordingBatchrequestAsync(string jobId, CancellationToken cancellationToken = default);

    Task<BatchDownloadJobSubmissionResult> CreateRecordingBatchrequestAsync(BatchDownloadJobSubmission body, CancellationToken cancellationToken = default);

    Task<Annotation> GetConversationRecordingAnnotationAsync(string conversationId, string recordingId, string annotationId, CancellationToken cancellationToken = default);

    Task<Annotation> CreateConversationRecordingAnnotationAsync(string conversationId, string recordingId, Annotation body, CancellationToken cancellationToken = default);

    Task<Annotation> UpdateConversationRecordingAnnotationAsync(string conversationId, string recordingId, string annotationId, Annotation body, CancellationToken cancellationToken = default);

    Task<bool> DeleteRecordingCrossplatformMediaretentionpoliciesAsync(string ids, CancellationToken cancellationToken = default);

    Task<bool> DeleteRecordingCrossplatformMediaretentionpolicyAsync(string policyId, CancellationToken cancellationToken = default);

    Task<bool> DeleteRecordingJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<bool> DeleteRecordingMediaretentionpoliciesAsync(string ids, CancellationToken cancellationToken = default);

    Task<bool> DeleteRecordingMediaretentionpolicyAsync(string policyId, CancellationToken cancellationToken = default);

    Task<OrphanRecording> GetOrphanrecordingAsync(string orphanId, CancellationToken cancellationToken = default);

    Task<Recording> GetOrphanrecordingMediaAsync(string orphanId, string formatId = null, string emailFormatId = null, string chatFormatId = null, string messageFormatId = null, bool? download = null, string fileName = null, string locale = null, IEnumerable<string> mediaFormats = null, CancellationToken cancellationToken = default);

    Task<PolicyEntityListing> GetRecordingCrossplatformMediaretentionpoliciesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null, CancellationToken cancellationToken = default);

    Task<CrossPlatformPolicy> GetRecordingCrossplatformMediaretentionpolicyAsync(string policyId, CancellationToken cancellationToken = default);

    Task<RecordingJob> GetRecordingJobAsync(string jobId, CancellationToken cancellationToken = default);

    Task<FailedRecordingEntityListing> GetRecordingJobFailedrecordingsAsync(string jobId, int? pageSize = null, int? pageNumber = null, bool? includeTotal = null, string cursor = null, CancellationToken cancellationToken = default);

    Task<RecordingJobEntityListing> GetRecordingJobsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string state = null, bool? showOnlyMyJobs = null, string jobType = null, bool? includeTotal = null, string cursor = null, CancellationToken cancellationToken = default);

    Task<RecordingEncryptionConfiguration> GetRecordingKeyconfigurationAsync(string keyConfigurationId, CancellationToken cancellationToken = default);

    Task<RecordingEncryptionConfigurationListing> GetRecordingKeyconfigurationsAsync(CancellationToken cancellationToken = default);

    Task<PolicyEntityListing> GetRecordingMediaretentionpoliciesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, IEnumerable<string> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null, int? deleteDaysThreshold = null, CancellationToken cancellationToken = default);

    Task<Policy> GetRecordingMediaretentionpolicyAsync(string policyId, CancellationToken cancellationToken = default);

    Task<EncryptionKeyEntityListing> GetRecordingRecordingkeysAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<KeyRotationSchedule> GetRecordingRecordingkeysRotationscheduleAsync(CancellationToken cancellationToken = default);

    Task<RecordingSettings> GetRecordingSettingsAsync(bool? createDefault = null, CancellationToken cancellationToken = default);

    Task<RecordingUploadReport> GetRecordingUploadsReportAsync(string reportId, CancellationToken cancellationToken = default);

    Task<RecordingRetentionCursorEntityListing> GetRecordingsRetentionQueryAsync(int? retentionThresholdDays, string cursor = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<ScreenRecordingActiveSessions> GetRecordingsScreensessionsDetailsAsync(CancellationToken cancellationToken = default);

    Task<CrossPlatformPolicy> UpdateRecordingCrossplatformMediaretentionpolicyAsync(string policyId, CrossPlatformPolicy body, CancellationToken cancellationToken = default);

    Task<Policy> UpdateRecordingMediaretentionpolicyAsync(string policyId, Policy body, CancellationToken cancellationToken = default);

    Task<CrossPlatformPolicy> CreateRecordingCrossplatformMediaretentionpolicyAsync(CrossPlatformPolicy body, CancellationToken cancellationToken = default);

    Task<RecordingJob> CreateRecordingJobAsync(RecordingJobsQuery body, CancellationToken cancellationToken = default);

    Task<RecordingEncryptionConfiguration> CreateRecordingKeyconfigurationAsync(RecordingEncryptionConfiguration body, CancellationToken cancellationToken = default);

    Task<RecordingEncryptionConfiguration> ValidateRecordingKeyconfigurationAsync(RecordingEncryptionConfiguration body, CancellationToken cancellationToken = default);

    Task<EncryptionKey> CreateRecordingRecordingkeysAsync(CancellationToken cancellationToken = default);

    Task<Policy> CreateRecordingMediaretentionpolicyAsync(Policy body, CancellationToken cancellationToken = default);

    Task<IEnumerable<RecordingMetadata>> GetConversationRecordingmetadataAsync(string conversationId, CancellationToken cancellationToken = default);

    Task<RecordingUploadReport> CreateRecordingUploadsReportAsync(RecordingUploadReportRequest body, CancellationToken cancellationToken = default);

    Task<IEnumerable<AddressableEntityRef>> CreateRecordingsDeletionprotectionAsync(string conversationIds, CancellationToken cancellationToken = default);

    Task<IEnumerable<AddressableEntityRef>> UpdateRecordingsDeletionprotectionAsync(bool? protect = null, string conversationIds = null, CancellationToken cancellationToken = default);

    Task<Recording> UpdateConversationRecordingAsync(string conversationId, string recordingId, Recording body, bool? clearExport = null, CancellationToken cancellationToken = default);

    Task<CrossPlatformPolicy> ReplaceRecordingCrossplatformMediaretentionpolicyAsync(string policyId, CrossPlatformPolicy body, CancellationToken cancellationToken = default);

    Task<RecordingJob> UpdateRecordingJobAsync(string jobId, ExecuteRecordingJobsQuery body, CancellationToken cancellationToken = default);

    Task<RecordingEncryptionConfiguration> ReplaceRecordingKeyconfigurationAsync(string keyConfigurationId, RecordingEncryptionConfiguration body, CancellationToken cancellationToken = default);

    Task<Policy> ReplaceRecordingMediaretentionpolicyAsync(string policyId, Policy body, CancellationToken cancellationToken = default);

    Task<KeyRotationSchedule> UpdateRecordingRecordingkeysRotationscheduleAsync(KeyRotationSchedule body, CancellationToken cancellationToken = default);

    Task<RecordingSettings> UpdateRecordingSettingsAsync(RecordingSettings body, CancellationToken cancellationToken = default);
}