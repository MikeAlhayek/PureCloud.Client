using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IUploadsApi
{
    /// <summary>
    /// Get content upload from URL job status
    /// </summary>
    Task<GetUploadSourceUrlJobStatusResponse> GetKnowledgeUploadJobStatusAsync(string knowledgeBaseId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates pre-signed URL to upload a prize image for gamification contests
    /// </summary>
    Task<UploadUrlResponse> CreateGamificationPrizeImageUploadAsync(GamificationContestPrizeImageUploadUrlRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create upload presigned URL for draft function package file
    /// </summary>
    Task<FunctionUploadResponse> CreateIntegrationFunctionUploadAsync(string actionId, FunctionUploadRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a presigned URL for uploading a knowledge import file with a set of documents
    /// </summary>
    Task<UploadUrlResponse> CreateKnowledgeDocumentUploadAsync(UploadUrlRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create content upload from URL job
    /// </summary>
    Task<CreateUploadSourceUrlJobResponse> CreateKnowledgeUploadJobAsync(string knowledgeBaseId, CreateUploadSourceUrlJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a presigned URL for uploading a chat corpus which will be used for mining by intent miner
    /// </summary>
    Task<UploadUrlResponse> CreateLanguageUnderstandingMinerUploadAsync(string minerId, object body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates pre-signed URL to upload cover art for learning modules
    /// </summary>
    Task<UploadUrlResponse> CreateLearningCoverArtUploadAsync(LearningCoverArtUploadUrlRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates presigned url for uploading a public asset image
    /// </summary>
    Task<UploadUrlResponse> CreatePublicAssetImageUploadAsync(UploadUrlRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates presigned url for uploading a recording file
    /// </summary>
    Task<UploadUrlResponse> CreateRecordingUploadAsync(UploadUrlRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates presigned url for uploading WFM historical data file. Requires data in csv format
    /// </summary>
    Task<UploadUrlResponse> CreateWorkforceManagementHistoricalDataUploadAsync(UploadUrlRequest body, CancellationToken cancellationToken = default);
}