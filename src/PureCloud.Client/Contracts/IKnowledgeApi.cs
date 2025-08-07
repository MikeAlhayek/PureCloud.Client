using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IKnowledgeApi
{
    Task<KnowledgeBase> GetKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default);

    Task<KnowledgeBase> CreateKnowledgeKnowledgebasesAsync(KnowledgeBaseCreateRequest body, CancellationToken cancellationToken = default);

    Task<SalesforceSourceResponse> UpdateKnowledgeKnowledgebaseSourcesSalesforceSourceAsync(string knowledgeBaseId, string sourceId, SalesforceSourceRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeBase> DeleteKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default);

    Task<KnowledgeBaseListing> GetKnowledgeKnowledgebasesAsync(string before = null, string after = null, string pageSize = null, string name = null, string coreLanguage = null, bool? published = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    Task<CategoryResponseListing> GetKnowledgeKnowledgebaseCategoriesAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string parentId = null, bool? isRoot = null, string name = null, string sortBy = null, string expand = null, bool? includeDocumentCount = null, CancellationToken cancellationToken = default);

    Task<CategoryResponse> CreateKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, CategoryCreateRequest body, CancellationToken cancellationToken = default);

    Task<CategoryResponse> UpdateKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CategoryUpdateRequest body, CancellationToken cancellationToken = default);

    Task<bool> DeleteKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CancellationToken cancellationToken = default);

    Task<KnowledgeDocumentResponseListing> GetKnowledgeKnowledgebaseDocumentsAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string interval = null, IEnumerable<string> documentId = null, IEnumerable<string> categoryId = null, bool? includeSubcategories = null, bool? includeDrafts = null, IEnumerable<string> labelIds = null, IEnumerable<string> expand = null, IEnumerable<string> externalIds = null, CancellationToken cancellationToken = default);

    Task<KnowledgeDocumentResponse> GetKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, IEnumerable<string> expand = null, string state = null, CancellationToken cancellationToken = default);

    Task<KnowledgeDocumentResponse> CreateKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, KnowledgeDocumentCreateRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeDocumentResponse> UpdateKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentReq body, CancellationToken cancellationToken = default);

    Task<bool> DeleteKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, CancellationToken cancellationToken = default);

    Task<LabelListing> GetKnowledgeKnowledgebaseLabelsAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string name = null, bool? includeDocumentCount = null, CancellationToken cancellationToken = default);

    Task<LabelResponse> CreateKnowledgeKnowledgebaseLabelAsync(string knowledgeBaseId, LabelCreateRequest body, CancellationToken cancellationToken = default);

    Task<bool> DeleteKnowledgeKnowledgebaseLabelAsync(string knowledgeBaseId, string labelId, CancellationToken cancellationToken = default);

    Task<KnowledgeImportJobResponse> GetKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    Task<KnowledgeImportJobResponse> CreateKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, KnowledgeImportJobRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeSearchResponse> CreateKnowledgeKnowledgebaseSearchAsync(string knowledgeBaseId, KnowledgeSearchRequest body = null, CancellationToken cancellationToken = default);

    Task<KnowledgeGuestDocumentResponseListing> GetKnowledgeGuestSessionDocumentsAsync(string sessionId, IEnumerable<string> categoryId = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseDocumentVariationAsync(string knowledgeBaseId, string documentId, string documentVariationId, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseExportJobAsync(string knowledgeBaseId, string exportJobId, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseLanguageDocumentsImportAsync(string knowledgeBaseId, string languageCode, string importId, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseSourcesSalesforceSourceIdAsync(string knowledgeBaseId, string sourceId, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseSourcesServicenowSourceIdAsync(string knowledgeBaseId, string sourceId, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseSynchronizeJobAsync(string knowledgeBaseId, string syncJobId, CancellationToken cancellationToken = default);

    Task PatchKnowledgeGuestSessionDocumentsSearchSearchIdAsync(string sessionId, string searchId, SearchUpdateRequest body, CancellationToken cancellationToken = default);

    Task<CategoryResponse> PatchKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CategoryUpdateRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeDocumentResponse> PatchKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentReq body, CancellationToken cancellationToken = default);

    Task PatchKnowledgeKnowledgebaseDocumentsSearchSearchIdAsync(string knowledgeBaseId, string searchId, SearchUpdateRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeParseJobResponse> PatchKnowledgeKnowledgebaseParseJobAsync(string knowledgeBaseId, string parseJobId, KnowledgeParseJobRequestPatch body, CancellationToken cancellationToken = default);

    Task PostKnowledgeGuestSessionDocumentCopiesAsync(string sessionId, string documentId, KnowledgeGuestDocumentCopy body = null, CancellationToken cancellationToken = default);

    Task PostKnowledgeGuestSessionDocumentViewsAsync(string sessionId, string documentId, KnowledgeGuestDocumentView body = null, CancellationToken cancellationToken = default);

    Task<KnowledgeGuestDocumentPresentation> PostKnowledgeGuestSessionDocumentsPresentationsAsync(string sessionId, KnowledgeGuestDocumentPresentation body, CancellationToken cancellationToken = default);

    Task<CategoryResponseListing> PostKnowledgeKnowledgebaseCategoriesAsync(string knowledgeBaseId, CategoryCreateRequest body, CancellationToken cancellationToken = default);

    Task PostKnowledgeKnowledgebaseDocumentCopiesAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentCopy body = null, CancellationToken cancellationToken = default);

    Task<KnowledgeDocumentFeedbackResponse> PostKnowledgeKnowledgebaseDocumentFeedbackAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentFeedback body, CancellationToken cancellationToken = default);

    Task<DocumentVariationListing> PostKnowledgeKnowledgebaseDocumentVariationsAsync(string knowledgeBaseId, string documentId, DocumentVariationRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeDocumentVersion> PostKnowledgeKnowledgebaseDocumentVersionsAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentVersion body, CancellationToken cancellationToken = default);

    Task PostKnowledgeKnowledgebaseDocumentViewsAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentView body = null, CancellationToken cancellationToken = default);

    Task<KnowledgeAnswerDocumentsResponse> PostKnowledgeKnowledgebaseDocumentsAnswersAsync(string knowledgeBaseId, KnowledgeDocumentAnswersRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeDocumentResponse> PostKnowledgeKnowledgebaseDocumentsAsync(string knowledgeBaseId, KnowledgeDocumentCreateRequest body, CancellationToken cancellationToken = default);

    Task<BulkResponse> PostKnowledgeKnowledgebaseDocumentsBulkRemoveAsync(string knowledgeBaseId, KnowledgeDocumentBulkRemoveRequest body, CancellationToken cancellationToken = default);

    Task<BulkResponse> PostKnowledgeKnowledgebaseDocumentsBulkUpdateAsync(string knowledgeBaseId, KnowledgeDocumentBulkUpdateRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeDocumentPresentation> PostKnowledgeKnowledgebaseDocumentsPresentationsAsync(string knowledgeBaseId, KnowledgeDocumentPresentation body, CancellationToken cancellationToken = default);

    Task<KnowledgeDocumentSearchResponse> PostKnowledgeKnowledgebaseDocumentsSearchAsync(string knowledgeBaseId, KnowledgeDocumentSearchRequest body = null, CancellationToken cancellationToken = default);

    Task<KnowledgeDocumentSuggestionResponse> PostKnowledgeKnowledgebaseDocumentsSearchSuggestionsAsync(string knowledgeBaseId, KnowledgeDocumentSuggestionRequest body = null, CancellationToken cancellationToken = default);

    Task<DocumentVersionListing> PostKnowledgeKnowledgebaseDocumentsVersionsBulkAddAsync(string knowledgeBaseId, KnowledgeDocumentBulkVersionAddRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeExportJobResponse> PostKnowledgeKnowledgebaseExportJobsAsync(string knowledgeBaseId, KnowledgeExportJobRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeImportJobResponse> PostKnowledgeKnowledgebaseImportJobsAsync(string knowledgeBaseId, KnowledgeImportJobRequest body, CancellationToken cancellationToken = default);

    Task<LabelResponse> PostKnowledgeKnowledgebaseLabelsAsync(string knowledgeBaseId, LabelCreateRequest body, CancellationToken cancellationToken = default);

    Task<CategoryResponse> PostKnowledgeKnowledgebaseLanguageCategoriesAsync(string knowledgeBaseId, string languageCode, CategoryCreateRequest body, CancellationToken cancellationToken = default);

    Task<UploadUrlResponse> PostKnowledgeKnowledgebaseLanguageDocumentUploadsAsync(string knowledgeBaseId, string languageCode, UploadUrlRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeDocumentResponse> PostKnowledgeKnowledgebaseLanguageDocumentsAsync(string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeImportJobResponse> PostKnowledgeKnowledgebaseLanguageDocumentsImportsAsync(string knowledgeBaseId, string languageCode, KnowledgeImportJobRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingPromoteAsync(string knowledgeBaseId, string languageCode, string trainingId, CancellationToken cancellationToken = default);

    Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingsAsync(string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default);

    Task<KnowledgeParseJobResponse> PostKnowledgeKnowledgebaseParseJobImportAsync(string knowledgeBaseId, string parseJobId, CancellationToken cancellationToken = default);

    Task<KnowledgeParseJobResponse> PostKnowledgeKnowledgebaseParseJobsAsync(string knowledgeBaseId, KnowledgeParseJobRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeSearchResponse> PostKnowledgeKnowledgebaseSearchAsync(string knowledgeBaseId, KnowledgeSearchRequest body = null, CancellationToken cancellationToken = default);

    Task<SalesforceSourceResponse> PostKnowledgeKnowledgebaseSourcesSalesforceAsync(string knowledgeBaseId, SalesforceSourceRequest body, CancellationToken cancellationToken = default);

    Task<SynchronizeJob> PostKnowledgeKnowledgebaseSourcesSalesforceSourceIdSyncAsync(string knowledgeBaseId, string sourceId, CancellationToken cancellationToken = default);

    Task<ServiceNowSourceResponse> PostKnowledgeKnowledgebaseSourcesServicenowAsync(string knowledgeBaseId, ServiceNowSourceRequest body, CancellationToken cancellationToken = default);

    Task<SynchronizeJob> PostKnowledgeKnowledgebaseSourcesServicenowSourceIdSyncAsync(string knowledgeBaseId, string sourceId, CancellationToken cancellationToken = default);

    Task<SynchronizeJob> PostKnowledgeKnowledgebaseSynchronizeJobsAsync(string knowledgeBaseId, SynchronizeRequest body, CancellationToken cancellationToken = default);

    Task<GetUploadSourceUrlJobStatusResponse> PostKnowledgeKnowledgebaseUploadsUrlsJobsAsync(string knowledgeBaseId, GetUploadSourceUrlRequest body, CancellationToken cancellationToken = default);

    Task<KnowledgeBase> PostKnowledgeKnowledgebasesAsync(KnowledgeBaseCreateRequest body, CancellationToken cancellationToken = default);

    Task<SalesforceSourceResponse> PutKnowledgeKnowledgebaseSourcesSalesforceSourceIdAsync(string knowledgeBaseId, string sourceId, SalesforceSourceRequest body, CancellationToken cancellationToken = default);

    Task<ServiceNowSourceResponse> PutKnowledgeKnowledgebaseSourcesServicenowSourceIdAsync(string knowledgeBaseId, string sourceId, ServiceNowSourceRequest body, CancellationToken cancellationToken = default);
}