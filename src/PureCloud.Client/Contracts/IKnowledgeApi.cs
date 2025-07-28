using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IKnowledgeApi
{
    // Core existing methods (working)
    Task<KnowledgeBase> GetKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default);
    Task<KnowledgeBase> CreateKnowledgeKnowledgebasesAsync(KnowledgeBaseCreateRequest body, CancellationToken cancellationToken = default);
    Task<SalesforceSourceResponse> UpdateKnowledgeKnowledgebaseSourcesSalesforceSourceAsync(string knowledgeBaseId, string sourceId, SalesforceSourceRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeBase> DeleteKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default);

    // Document operations
    Task<KnowledgeDocumentResponse> GetKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, List<string> expand = null, string state = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentResponseListing> GetKnowledgeKnowledgebaseDocumentsAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, bool? includeSubcategories = null, bool? includeDrafts = null, List<string> categories = null, string title = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentResponse> PostKnowledgeKnowledgebaseDocumentsAsync(string knowledgeBaseId, KnowledgeDocumentCreateRequest body, CancellationToken cancellationToken = default);
    Task DeleteKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, CancellationToken cancellationToken = default);

    // Knowledge base listing
    Task<KnowledgeBaseListing> GetKnowledgeKnowledgebasesAsync(string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string coreLanguage = null, bool? published = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    // Export operations
    Task<KnowledgeExportJobResponse> GetKnowledgeKnowledgebaseExportJobAsync(string knowledgeBaseId, string exportJobId, CancellationToken cancellationToken = default);
    Task<KnowledgeExportJobResponse> PostKnowledgeKnowledgebaseExportJobsAsync(string knowledgeBaseId, KnowledgeExportJobRequest body, CancellationToken cancellationToken = default);
    Task DeleteKnowledgeKnowledgebaseExportJobAsync(string knowledgeBaseId, string exportJobId, CancellationToken cancellationToken = default);

    // Import operations  
    Task<KnowledgeImportJobResponse> GetKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, CancellationToken cancellationToken = default);
    Task<KnowledgeImportJobResponse> PostKnowledgeKnowledgebaseImportJobsAsync(string knowledgeBaseId, KnowledgeImportJobRequest body, CancellationToken cancellationToken = default);
    Task DeleteKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, CancellationToken cancellationToken = default);

    // Training operations
    Task<KnowledgeTraining> GetKnowledgeKnowledgebaseLanguageTrainingAsync(string knowledgeBaseId, string languageCode, string trainingId, CancellationToken cancellationToken = default);
    Task<TrainingListing> GetKnowledgeKnowledgebaseLanguageTrainingsAsync(string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, KnowledgeTraining.StatusEnum? knowledgeTrainingState = null, CancellationToken cancellationToken = default);
    Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingsAsync(string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default);
    Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingPromoteAsync(string knowledgeBaseId, string languageCode, string trainingId, CancellationToken cancellationToken = default);

    // Search operations  
    Task<KnowledgeSearchResponse> PostKnowledgeKnowledgebaseSearchAsync(string knowledgeBaseId, KnowledgeSearchRequest body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentSearch> PostKnowledgeKnowledgebaseDocumentsSearchAsync(string knowledgeBaseId, KnowledgeDocumentSearchRequest body = null, CancellationToken cancellationToken = default);

    // Language document operations
    Task<KnowledgeDocument> GetKnowledgeKnowledgebaseLanguageDocumentAsync(string documentId, string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default);
    Task<DocumentListing> GetKnowledgeKnowledgebaseLanguageDocumentsAsync(string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null, string sortBy = null, string sortOrder = null, List<string> documentIds = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocument> PostKnowledgeKnowledgebaseLanguageDocumentsAsync(string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeDocument> DeleteKnowledgeKnowledgebaseLanguageDocumentAsync(string documentId, string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default);
}