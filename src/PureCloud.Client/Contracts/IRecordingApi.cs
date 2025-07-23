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
}