using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IKnowledgeApi
{
    // Delete operations (13 methods)
    Task<KnowledgeBase> DeleteKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default);
    Task<CategoryResponse> DeleteKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CancellationToken cancellationToken = default);
    Task DeleteKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, CancellationToken cancellationToken = default);
    Task DeleteKnowledgeKnowledgebaseDocumentVariationAsync(string documentVariationId, string documentId, string knowledgeBaseId, CancellationToken cancellationToken = default);
    Task DeleteKnowledgeKnowledgebaseExportJobAsync(string knowledgeBaseId, string exportJobId, CancellationToken cancellationToken = default);
    Task DeleteKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, CancellationToken cancellationToken = default);
    Task<LabelResponse> DeleteKnowledgeKnowledgebaseLabelAsync(string knowledgeBaseId, string labelId, CancellationToken cancellationToken = default);
    Task<KnowledgeCategory> DeleteKnowledgeKnowledgebaseLanguageCategoryAsync(string categoryId, string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default);
    Task<KnowledgeDocument> DeleteKnowledgeKnowledgebaseLanguageDocumentAsync(string documentId, string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default);
    Task DeleteKnowledgeKnowledgebaseLanguageDocumentsImportAsync(string knowledgeBaseId, string languageCode, string importId, CancellationToken cancellationToken = default);
    Task DeleteKnowledgeKnowledgebaseSourcesSalesforceSourceIdAsync(string knowledgeBaseId, string sourceId, CancellationToken cancellationToken = default);
    Task DeleteKnowledgeKnowledgebaseSourcesServicenowSourceIdAsync(string knowledgeBaseId, string sourceId, CancellationToken cancellationToken = default);
    Task DeleteKnowledgeKnowledgebaseSynchronizeJobAsync(string knowledgeBaseId, string syncJobId, CancellationToken cancellationToken = default);

    // Get operations (39 methods)
    Task<GuestCategoryResponseListing> GetKnowledgeGuestSessionCategoriesAsync(string sessionId, string before = null, string after = null, string pageSize = null, string parentId = null, bool? isRoot = null, string name = null, string sortBy = null, string expand = null, bool? includeDocumentCount = null, CancellationToken cancellationToken = default);
    Task<KnowledgeGuestDocumentResponse> GetKnowledgeGuestSessionDocumentAsync(string sessionId, string documentId, CancellationToken cancellationToken = default);
    Task<KnowledgeGuestDocumentResponseListing> GetKnowledgeGuestSessionDocumentsAsync(string sessionId, List<string> categoryId = null, int? pageSize = null, CancellationToken cancellationToken = default);
    Task<KnowledgeIntegrationOptionsResponse> GetKnowledgeIntegrationOptionsAsync(string integrationId, List<string> knowledgeBaseIds = null, CancellationToken cancellationToken = default);
    Task<KnowledgeBase> GetKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default);
    Task<CategoryResponseListing> GetKnowledgeKnowledgebaseCategoriesAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string parentId = null, bool? isRoot = null, string name = null, string sortBy = null, string expand = null, bool? includeDocumentCount = null, CancellationToken cancellationToken = default);
    Task<CategoryResponse> GetKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentResponse> GetKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, List<string> expand = null, string state = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentFeedbackResponseListing> GetKnowledgeKnowledgebaseDocumentFeedbackAsync(string knowledgeBaseId, string documentId, string before = null, string after = null, string pageSize = null, bool? onlyCommented = null, string documentVersionId = null, string documentVariationId = null, string appType = null, string queryType = null, string userId = null, string queueId = null, string state = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentFeedbackResponse> GetKnowledgeKnowledgebaseDocumentFeedbackFeedbackIdAsync(string knowledgeBaseId, string documentId, string feedbackId, CancellationToken cancellationToken = default);
    Task<DocumentVariationResponse> GetKnowledgeKnowledgebaseDocumentVariationAsync(string knowledgeBaseId, string documentId, string documentVariationId, string documentState = null, List<string> expand = null, CancellationToken cancellationToken = default);
    Task<DocumentVariationResponseListing> GetKnowledgeKnowledgebaseDocumentVariationsAsync(string knowledgeBaseId, string documentId, string before = null, string after = null, string pageSize = null, string documentState = null, List<string> expand = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentVersion> GetKnowledgeKnowledgebaseDocumentVersionAsync(string knowledgeBaseId, string documentId, string versionId, List<string> expand = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentVersionVariation> GetKnowledgeKnowledgebaseDocumentVersionVariationAsync(string knowledgeBaseId, string documentId, string versionId, string variationId, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentVersionVariationListing> GetKnowledgeKnowledgebaseDocumentVersionVariationsAsync(string knowledgeBaseId, string documentId, string versionId, string before = null, string after = null, string pageSize = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentVersionListing> GetKnowledgeKnowledgebaseDocumentVersionsAsync(string knowledgeBaseId, string documentId, string before = null, string after = null, string pageSize = null, List<string> expand = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentResponseListing> GetKnowledgeKnowledgebaseDocumentsAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string interval = null, List<string> documentId = null, List<string> categoryId = null, bool? includeSubcategories = null, bool? includeDrafts = null, List<string> labelIds = null, List<string> expand = null, List<string> externalIds = null, CancellationToken cancellationToken = default);
    Task<KnowledgeExportJobResponse> GetKnowledgeKnowledgebaseExportJobAsync(string knowledgeBaseId, string exportJobId, CancellationToken cancellationToken = default);
    Task<KnowledgeImportJobResponse> GetKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, List<string> expand = null, CancellationToken cancellationToken = default);
    Task<LabelResponse> GetKnowledgeKnowledgebaseLabelAsync(string knowledgeBaseId, string labelId, CancellationToken cancellationToken = default);
    Task<LabelListing> GetKnowledgeKnowledgebaseLabelsAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string name = null, bool? includeDocumentCount = null, CancellationToken cancellationToken = default);
    Task<CategoryListing> GetKnowledgeKnowledgebaseLanguageCategoriesAsync(string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string name = null, CancellationToken cancellationToken = default);
    Task<KnowledgeExtendedCategory> GetKnowledgeKnowledgebaseLanguageCategoryAsync(string categoryId, string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default);
    Task<KnowledgeDocument> GetKnowledgeKnowledgebaseLanguageDocumentAsync(string documentId, string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentContentUpload> GetKnowledgeKnowledgebaseLanguageDocumentUploadAsync(string documentId, string knowledgeBaseId, string languageCode, string uploadId, CancellationToken cancellationToken = default);
    Task<DocumentListing> GetKnowledgeKnowledgebaseLanguageDocumentsAsync(string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string categories = null, string title = null, string sortBy = null, string sortOrder = null, List<string> documentIds = null, CancellationToken cancellationToken = default);
    Task<KnowledgeImport> GetKnowledgeKnowledgebaseLanguageDocumentsImportAsync(string knowledgeBaseId, string languageCode, string importId, CancellationToken cancellationToken = default);
    Task<KnowledgeTraining> GetKnowledgeKnowledgebaseLanguageTrainingAsync(string knowledgeBaseId, string languageCode, string trainingId, CancellationToken cancellationToken = default);
    Task<TrainingListing> GetKnowledgeKnowledgebaseLanguageTrainingsAsync(string knowledgeBaseId, string languageCode, string before = null, string after = null, string limit = null, string pageSize = null, string knowledgeDocumentsState = null, CancellationToken cancellationToken = default);
    Task<OperationListing> GetKnowledgeKnowledgebaseOperationsAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, List<string> userId = null, List<string> type = null, List<string> status = null, string interval = null, List<string> sourceId = null, CancellationToken cancellationToken = default);
    Task<OperationCreatorUserResponse> GetKnowledgeKnowledgebaseOperationsUsersQueryAsync(string knowledgeBaseId, CancellationToken cancellationToken = default);
    Task<KnowledgeParseJobResponse> GetKnowledgeKnowledgebaseParseJobAsync(string knowledgeBaseId, string parseJobId, List<string> expand = null, CancellationToken cancellationToken = default);
    Task<List<SourceBaseResponse>> GetKnowledgeKnowledgebaseSourcesAsync(string knowledgeBaseId, string type = null, List<string> expand = null, List<string> ids = null, CancellationToken cancellationToken = default);
    Task<SalesforceSourceResponse> GetKnowledgeKnowledgebaseSourcesSalesforceSourceIdAsync(string knowledgeBaseId, string sourceId, List<string> expand = null, CancellationToken cancellationToken = default);
    Task<ServiceNowSourceResponse> GetKnowledgeKnowledgebaseSourcesServicenowSourceIdAsync(string knowledgeBaseId, string sourceId, List<string> expand = null, CancellationToken cancellationToken = default);
    Task<KnowledgeSyncJobResponse> GetKnowledgeKnowledgebaseSynchronizeJobAsync(string knowledgeBaseId, string syncJobId, CancellationToken cancellationToken = default);
    Task<UnansweredGroup> GetKnowledgeKnowledgebaseUnansweredGroupAsync(string knowledgeBaseId, string groupId, string app = null, string dateStart = null, string dateEnd = null, CancellationToken cancellationToken = default);
    Task<UnansweredPhraseGroup> GetKnowledgeKnowledgebaseUnansweredGroupPhrasegroupAsync(string knowledgeBaseId, string groupId, string phraseGroupId, string app = null, string dateStart = null, string dateEnd = null, CancellationToken cancellationToken = default);
    Task<UnansweredGroups> GetKnowledgeKnowledgebaseUnansweredGroupsAsync(string knowledgeBaseId, string app = null, string dateStart = null, string dateEnd = null, CancellationToken cancellationToken = default);
    Task<GetUploadSourceUrlJobStatusResponse> GetKnowledgeKnowledgebaseUploadsUrlsJobAsync(string knowledgeBaseId, string jobId, CancellationToken cancellationToken = default);
    Task<KnowledgeBaseListing> GetKnowledgeKnowledgebasesAsync(string before = null, string after = null, string limit = null, string pageSize = null, string name = null, string coreLanguage = null, bool? published = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    // Patch operations (11 methods)
    Task PatchKnowledgeGuestSessionDocumentsSearchSearchIdAsync(string sessionId, string searchId, SearchUpdateRequest body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeBase> PatchKnowledgeKnowledgebaseAsync(string knowledgeBaseId, KnowledgeBaseUpdateRequest body, CancellationToken cancellationToken = default);
    Task<CategoryResponse> PatchKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CategoryUpdateRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentResponse> PatchKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentReq body, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentFeedbackResponse> PatchKnowledgeKnowledgebaseDocumentFeedbackFeedbackIdAsync(string knowledgeBaseId, string documentId, string feedbackId, KnowledgeDocumentFeedbackUpdateRequest body = null, CancellationToken cancellationToken = default);
    Task<DocumentVariationResponse> PatchKnowledgeKnowledgebaseDocumentVariationAsync(string documentVariationId, string documentId, string knowledgeBaseId, DocumentVariationRequest body, CancellationToken cancellationToken = default);
    Task PatchKnowledgeKnowledgebaseDocumentsSearchSearchIdAsync(string knowledgeBaseId, string searchId, SearchUpdateRequest body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeImportJobResponse> PatchKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, ImportStatusRequest body, CancellationToken cancellationToken = default);
    Task<LabelResponse> PatchKnowledgeKnowledgebaseLabelAsync(string knowledgeBaseId, string labelId, LabelUpdateRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeExtendedCategory> PatchKnowledgeKnowledgebaseLanguageCategoryAsync(string categoryId, string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeDocument> PatchKnowledgeKnowledgebaseLanguageDocumentAsync(string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body, CancellationToken cancellationToken = default);
    Task<DocumentListing> PatchKnowledgeKnowledgebaseLanguageDocumentsAsync(string knowledgeBaseId, string languageCode, List<KnowledgeDocumentBulkRequest> body, CancellationToken cancellationToken = default);
    Task<KnowledgeImport> PatchKnowledgeKnowledgebaseLanguageDocumentsImportAsync(string knowledgeBaseId, string languageCode, string importId, ImportStatusRequest body, CancellationToken cancellationToken = default);
    Task PatchKnowledgeKnowledgebaseParseJobAsync(string knowledgeBaseId, string parseJobId, KnowledgeParseJobRequestPatch body, CancellationToken cancellationToken = default);
    Task<KnowledgeSyncJobResponse> PatchKnowledgeKnowledgebaseSynchronizeJobAsync(string knowledgeBaseId, string syncJobId, SyncStatusRequest body, CancellationToken cancellationToken = default);
    Task<UnansweredPhraseGroupUpdateResponse> PatchKnowledgeKnowledgebaseUnansweredGroupPhrasegroupAsync(string knowledgeBaseId, string groupId, string phraseGroupId, UnansweredPhraseGroupPatchRequestBody body, CancellationToken cancellationToken = default);

    // Post operations (52 methods)
    Task<UploadUrlResponse> PostKnowledgeDocumentuploadsAsync(UploadUrlRequest body, CancellationToken cancellationToken = default);
    Task PostKnowledgeGuestSessionDocumentCopiesAsync(string sessionId, string documentId, KnowledgeGuestDocumentCopy body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeGuestDocumentFeedback> PostKnowledgeGuestSessionDocumentFeedbackAsync(string sessionId, string documentId, KnowledgeGuestDocumentFeedback body = null, CancellationToken cancellationToken = default);
    Task PostKnowledgeGuestSessionDocumentViewsAsync(string sessionId, string documentId, KnowledgeGuestDocumentView body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeGuestAnswerDocumentsResponse> PostKnowledgeGuestSessionDocumentsAnswersAsync(string sessionId, KnowledgeDocumentsAnswerFilter body, CancellationToken cancellationToken = default);
    Task PostKnowledgeGuestSessionDocumentsPresentationsAsync(string sessionId, KnowledgeGuestDocumentPresentation body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentGuestSearch> PostKnowledgeGuestSessionDocumentsSearchAsync(string sessionId, List<string> expand = null, KnowledgeDocumentGuestSearchRequest body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeGuestDocumentSuggestion> PostKnowledgeGuestSessionDocumentsSearchSuggestionsAsync(string sessionId, KnowledgeGuestDocumentSuggestionRequest body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeGuestSession> PostKnowledgeGuestSessionsAsync(KnowledgeGuestSession body, CancellationToken cancellationToken = default);
    Task<CategoryResponse> PostKnowledgeKnowledgebaseCategoriesAsync(string knowledgeBaseId, CategoryCreateRequest body, CancellationToken cancellationToken = default);
    Task PostKnowledgeKnowledgebaseDocumentCopiesAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentCopy body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentFeedbackResponse> PostKnowledgeKnowledgebaseDocumentFeedbackAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentFeedback body = null, CancellationToken cancellationToken = default);
    Task<DocumentVariationResponse> PostKnowledgeKnowledgebaseDocumentVariationsAsync(string knowledgeBaseId, string documentId, DocumentVariationRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentVersion> PostKnowledgeKnowledgebaseDocumentVersionsAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentVersion body, CancellationToken cancellationToken = default);
    Task PostKnowledgeKnowledgebaseDocumentViewsAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentView body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentResponse> PostKnowledgeKnowledgebaseDocumentsAsync(string knowledgeBaseId, KnowledgeDocumentCreateRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeAnswerDocumentsResponse> PostKnowledgeKnowledgebaseDocumentsAnswersAsync(string knowledgeBaseId, KnowledgeDocumentsAnswerFilter body, CancellationToken cancellationToken = default);
    Task<BulkResponse> PostKnowledgeKnowledgebaseDocumentsBulkRemoveAsync(string knowledgeBaseId, KnowledgeDocumentBulkRemoveRequest body, CancellationToken cancellationToken = default);
    Task<BulkResponse> PostKnowledgeKnowledgebaseDocumentsBulkUpdateAsync(string knowledgeBaseId, KnowledgeDocumentBulkUpdateRequest body, CancellationToken cancellationToken = default);
    Task PostKnowledgeKnowledgebaseDocumentsPresentationsAsync(string knowledgeBaseId, KnowledgeDocumentPresentation body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentQueryResponse> PostKnowledgeKnowledgebaseDocumentsQueryAsync(string knowledgeBaseId, List<string> expand = null, KnowledgeDocumentQuery body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentSearch> PostKnowledgeKnowledgebaseDocumentsSearchAsync(string knowledgeBaseId, List<string> expand = null, KnowledgeDocumentSearchRequest body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentSuggestion> PostKnowledgeKnowledgebaseDocumentsSearchSuggestionsAsync(string knowledgeBaseId, KnowledgeDocumentSuggestionRequest body = null, CancellationToken cancellationToken = default);
    Task<BulkResponse> PostKnowledgeKnowledgebaseDocumentsVersionsBulkAddAsync(string knowledgeBaseId, KnowledgeDocumentBulkVersionAddRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeExportJobResponse> PostKnowledgeKnowledgebaseExportJobsAsync(string knowledgeBaseId, KnowledgeExportJobRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeImportJobResponse> PostKnowledgeKnowledgebaseImportJobsAsync(string knowledgeBaseId, KnowledgeImportJobRequest body, CancellationToken cancellationToken = default);
    Task<LabelResponse> PostKnowledgeKnowledgebaseLabelsAsync(string knowledgeBaseId, LabelCreateRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeExtendedCategory> PostKnowledgeKnowledgebaseLanguageCategoriesAsync(string knowledgeBaseId, string languageCode, KnowledgeCategoryRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeDocumentContentUpload> PostKnowledgeKnowledgebaseLanguageDocumentUploadsAsync(string documentId, string knowledgeBaseId, string languageCode, KnowledgeDocumentContentUpload body, CancellationToken cancellationToken = default);
    Task<KnowledgeDocument> PostKnowledgeKnowledgebaseLanguageDocumentsAsync(string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeImport> PostKnowledgeKnowledgebaseLanguageDocumentsImportsAsync(string knowledgeBaseId, string languageCode, KnowledgeImport body, CancellationToken cancellationToken = default);
    Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingPromoteAsync(string knowledgeBaseId, string languageCode, string trainingId, CancellationToken cancellationToken = default);
    Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingsAsync(string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default);
    Task PostKnowledgeKnowledgebaseParseJobImportAsync(string knowledgeBaseId, string parseJobId, KnowledgeParseJobRequestImport body, CancellationToken cancellationToken = default);
    Task<KnowledgeParseJobResponse> PostKnowledgeKnowledgebaseParseJobsAsync(string knowledgeBaseId, KnowledgeParseJobRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeSearchResponse> PostKnowledgeKnowledgebaseSearchAsync(string knowledgeBaseId, KnowledgeSearchRequest body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeSyncJobResponse> PostKnowledgeKnowledgebaseSourcesSalesforceAsync(string knowledgeBaseId, SalesforceSourceRequest body, CancellationToken cancellationToken = default);
    Task<SourceSyncResponse> PostKnowledgeKnowledgebaseSourcesSalesforceSourceIdSyncAsync(string knowledgeBaseId, string sourceId, object body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeSyncJobResponse> PostKnowledgeKnowledgebaseSourcesServicenowAsync(string knowledgeBaseId, ServiceNowSourceRequest body, CancellationToken cancellationToken = default);
    Task<SourceSyncResponse> PostKnowledgeKnowledgebaseSourcesServicenowSourceIdSyncAsync(string knowledgeBaseId, string sourceId, object body = null, CancellationToken cancellationToken = default);
    Task<KnowledgeSyncJobResponse> PostKnowledgeKnowledgebaseSynchronizeJobsAsync(string knowledgeBaseId, KnowledgeSyncJobRequest body, CancellationToken cancellationToken = default);
    Task<CreateUploadSourceUrlJobResponse> PostKnowledgeKnowledgebaseUploadsUrlsJobsAsync(string knowledgeBaseId, CreateUploadSourceUrlJobRequest body, CancellationToken cancellationToken = default);
    Task<KnowledgeBase> PostKnowledgeKnowledgebasesAsync(KnowledgeBaseCreateRequest body, CancellationToken cancellationToken = default);

    // Put operations (2 methods)
    Task<SalesforceSourceResponse> PutKnowledgeKnowledgebaseSourcesSalesforceSourceIdAsync(string knowledgeBaseId, string sourceId, SalesforceSourceRequest body, CancellationToken cancellationToken = default);
    Task<ServiceNowSourceResponse> PutKnowledgeKnowledgebaseSourcesServicenowSourceIdAsync(string knowledgeBaseId, string sourceId, ServiceNowSourceRequest body, CancellationToken cancellationToken = default);
}