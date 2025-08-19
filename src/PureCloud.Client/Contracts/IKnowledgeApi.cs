using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IKnowledgeApi
{
    /// <summary>
    /// Get knowledge base by ID.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeBase</returns>
    Task<KnowledgeBase> GetKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create new knowledge base.
    /// </summary>
    /// <param name="body">Knowledge base create request</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeBase</returns>
    Task<KnowledgeBase> CreateKnowledgeKnowledgebasesAsync(KnowledgeBaseCreateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Salesforce Knowledge integration source.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="sourceId">Source ID</param>
    /// <param name="body">Salesforce source update request</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>SalesforceSourceResponse</returns>
    Task<SalesforceSourceResponse> UpdateKnowledgeKnowledgebaseSourcesSalesforceSourceAsync(string knowledgeBaseId, string sourceId, SalesforceSourceRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete knowledge base.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeBase</returns>
    Task<KnowledgeBase> DeleteKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get knowledge bases.
    /// </summary>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned.</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned.</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 100.</param>
    /// <param name="name">Filter by name.</param>
    /// <param name="coreLanguage">Filter by core language.</param>
    /// <param name="published">Filter by published status.</param>
    /// <param name="sortBy">Sort by field.</param>
    /// <param name="sortOrder">Sort order.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeBaseListing</returns>
    Task<KnowledgeBaseListing> GetKnowledgeKnowledgebasesAsync(string before = null, string after = null, string pageSize = null, string name = null, string coreLanguage = null, bool? published = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get categories for a knowledge base.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned.</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned.</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 100.</param>
    /// <param name="parentId">Filter by parent category ID.</param>
    /// <param name="isRoot">Filter by root categories.</param>
    /// <param name="name">Filter by name.</param>
    /// <param name="sortBy">Sort by field.</param>
    /// <param name="expand">Fields to expand.</param>
    /// <param name="includeDocumentCount">Include document count.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>CategoryResponseListing</returns>
    Task<CategoryResponseListing> GetKnowledgeKnowledgebaseCategoriesAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string parentId = null, bool? isRoot = null, string name = null, string sortBy = null, string expand = null, bool? includeDocumentCount = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create new category for knowledge base.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Category create request</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>CategoryResponse</returns>
    Task<CategoryResponse> CreateKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, CategoryCreateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update category.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="categoryId">Category ID</param>
    /// <param name="body">Category update request</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>CategoryResponse</returns>
    Task<CategoryResponse> UpdateKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CategoryUpdateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete category.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="categoryId">Category ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get documents.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned.</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned.</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 100.</param>
    /// <param name="interval">Interval</param>
    /// <param name="documentId">Document ID</param>
    /// <param name="categoryId">Category ID</param>
    /// <param name="includeSubcategories">Includesubcategories</param>
    /// <param name="includeDrafts">Includedrafts</param>
    /// <param name="labelIds">label IDs</param>
    /// <param name="expand">Fields to expand.</param>
    /// <param name="externalIds">external IDs</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeDocumentResponseListing</returns>
    Task<KnowledgeDocumentResponseListing> GetKnowledgeKnowledgebaseDocumentsAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string interval = null, IEnumerable<string> documentId = null, IEnumerable<string> categoryId = null, bool? includeSubcategories = null, bool? includeDrafts = null, IEnumerable<string> labelIds = null, IEnumerable<string> expand = null, IEnumerable<string> externalIds = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get basedocumentasync.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="documentId">Document ID</param>
    /// <param name="expand">Fields to expand.</param>
    /// <param name="state">State</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeDocumentResponse</returns>
    Task<KnowledgeDocumentResponse> GetKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, IEnumerable<string> expand = null, string state = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create basedocumentasync.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeDocumentResponse</returns>
    Task<KnowledgeDocumentResponse> CreateKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, KnowledgeDocumentCreateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update resource.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="documentId">Document ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeDocumentResponse</returns>
    Task<KnowledgeDocumentResponse> UpdateKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentReq body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete resource.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="documentId">Document ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get labels.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="before">The cursor that points to the start of the set of entities that has been returned.</param>
    /// <param name="after">The cursor that points to the end of the set of entities that has been returned.</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 100.</param>
    /// <param name="name">Filter by name.</param>
    /// <param name="includeDocumentCount">Includedocumentcount</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>LabelListing</returns>
    Task<LabelListing> GetKnowledgeKnowledgebaseLabelsAsync(string knowledgeBaseId, string before = null, string after = null, string pageSize = null, string name = null, bool? includeDocumentCount = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create baselabelasync.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>LabelResponse</returns>
    Task<LabelResponse> CreateKnowledgeKnowledgebaseLabelAsync(string knowledgeBaseId, LabelCreateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete resource.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="labelId">label ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>True if successful</returns>
    Task<bool> DeleteKnowledgeKnowledgebaseLabelAsync(string knowledgeBaseId, string labelId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get import job information.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="importJobId">importJob ID</param>
    /// <param name="expand">Fields to expand.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeImportJobResponse</returns>
    Task<KnowledgeImportJobResponse> GetKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create import job.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeImportJobResponse</returns>
    Task<KnowledgeImportJobResponse> CreateKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, KnowledgeImportJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Perform search operation.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeSearchResponse</returns>
    Task<KnowledgeSearchResponse> CreateKnowledgeKnowledgebaseSearchAsync(string knowledgeBaseId, KnowledgeSearchRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get documents.
    /// </summary>
    /// <param name="sessionId">session ID</param>
    /// <param name="categoryId">Category ID</param>
    /// <param name="pageSize">Number of entities to return. Maximum of 100.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeGuestDocumentResponseListing</returns>
    Task<KnowledgeGuestDocumentResponseListing> GetKnowledgeGuestSessionDocumentsAsync(string sessionId, IEnumerable<string> categoryId = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseDocumentVariationAsync(string knowledgeBaseId, string documentId, string documentVariationId, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseExportJobAsync(string knowledgeBaseId, string exportJobId, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseImportJobAsync(string knowledgeBaseId, string importJobId, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseLanguageDocumentsImportAsync(string knowledgeBaseId, string languageCode, string importId, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseSourcesSalesforceSourceIdAsync(string knowledgeBaseId, string sourceId, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseSourcesServicenowSourceIdAsync(string knowledgeBaseId, string sourceId, CancellationToken cancellationToken = default);

    Task DeleteKnowledgeKnowledgebaseSynchronizeJobAsync(string knowledgeBaseId, string syncJobId, CancellationToken cancellationToken = default);

    Task PatchKnowledgeGuestSessionDocumentsSearchSearchIdAsync(string sessionId, string searchId, SearchUpdateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update resource.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="categoryId">Category ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>CategoryResponse</returns>
    Task<CategoryResponse> PatchKnowledgeKnowledgebaseCategoryAsync(string knowledgeBaseId, string categoryId, CategoryUpdateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update resource.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="documentId">Document ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeDocumentResponse</returns>
    Task<KnowledgeDocumentResponse> PatchKnowledgeKnowledgebaseDocumentAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentReq body, CancellationToken cancellationToken = default);

    Task PatchKnowledgeKnowledgebaseDocumentsSearchSearchIdAsync(string knowledgeBaseId, string searchId, SearchUpdateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update resource.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="parseJobId">parseJob ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeParseJobResponse</returns>
    Task<KnowledgeParseJobResponse> PatchKnowledgeKnowledgebaseParseJobAsync(string knowledgeBaseId, string parseJobId, KnowledgeParseJobRequestPatch body, CancellationToken cancellationToken = default);

    Task PostKnowledgeGuestSessionDocumentCopiesAsync(string sessionId, string documentId, KnowledgeGuestDocumentCopy body = null, CancellationToken cancellationToken = default);

    Task PostKnowledgeGuestSessionDocumentViewsAsync(string sessionId, string documentId, KnowledgeGuestDocumentView body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create or process documents.
    /// </summary>
    /// <param name="sessionId">session ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeGuestDocumentPresentation</returns>
    Task<KnowledgeGuestDocumentPresentation> PostKnowledgeGuestSessionDocumentsPresentationsAsync(string sessionId, KnowledgeGuestDocumentPresentation body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create new category.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>CategoryResponseListing</returns>
    Task<CategoryResponseListing> PostKnowledgeKnowledgebaseCategoriesAsync(string knowledgeBaseId, CategoryCreateRequest body, CancellationToken cancellationToken = default);

    Task PostKnowledgeKnowledgebaseDocumentCopiesAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentCopy body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create feedback.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="documentId">Document ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeDocumentFeedbackResponse</returns>
    Task<KnowledgeDocumentFeedbackResponse> PostKnowledgeKnowledgebaseDocumentFeedbackAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentFeedback body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create document variation.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="documentId">Document ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>DocumentVariationListing</returns>
    Task<DocumentVariationListing> PostKnowledgeKnowledgebaseDocumentVariationsAsync(string knowledgeBaseId, string documentId, DocumentVariationRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create version.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="documentId">Document ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeDocumentVersion</returns>
    Task<KnowledgeDocumentVersion> PostKnowledgeKnowledgebaseDocumentVersionsAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentVersion body, CancellationToken cancellationToken = default);

    Task PostKnowledgeKnowledgebaseDocumentViewsAsync(string knowledgeBaseId, string documentId, KnowledgeDocumentView body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create or process documents.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeAnswerDocumentsResponse</returns>
    Task<KnowledgeAnswerDocumentsResponse> PostKnowledgeKnowledgebaseDocumentsAnswersAsync(string knowledgeBaseId, KnowledgeDocumentAnswersRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create or process documents.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeDocumentResponse</returns>
    Task<KnowledgeDocumentResponse> PostKnowledgeKnowledgebaseDocumentsAsync(string knowledgeBaseId, KnowledgeDocumentCreateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create or process documents.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>BulkResponse</returns>
    Task<BulkResponse> PostKnowledgeKnowledgebaseDocumentsBulkRemoveAsync(string knowledgeBaseId, KnowledgeDocumentBulkRemoveRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create or process documents.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>BulkResponse</returns>
    Task<BulkResponse> PostKnowledgeKnowledgebaseDocumentsBulkUpdateAsync(string knowledgeBaseId, KnowledgeDocumentBulkUpdateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create or process documents.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeDocumentPresentation</returns>
    Task<KnowledgeDocumentPresentation> PostKnowledgeKnowledgebaseDocumentsPresentationsAsync(string knowledgeBaseId, KnowledgeDocumentPresentation body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create or process documents.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeDocumentSearchResponse</returns>
    Task<KnowledgeDocumentSearchResponse> PostKnowledgeKnowledgebaseDocumentsSearchAsync(string knowledgeBaseId, KnowledgeDocumentSearchRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create or process documents.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeDocumentSuggestionResponse</returns>
    Task<KnowledgeDocumentSuggestionResponse> PostKnowledgeKnowledgebaseDocumentsSearchSuggestionsAsync(string knowledgeBaseId, KnowledgeDocumentSuggestionRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create or process documents.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>DocumentVersionListing</returns>
    Task<DocumentVersionListing> PostKnowledgeKnowledgebaseDocumentsVersionsBulkAddAsync(string knowledgeBaseId, KnowledgeDocumentBulkVersionAddRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create export job.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeExportJobResponse</returns>
    Task<KnowledgeExportJobResponse> PostKnowledgeKnowledgebaseExportJobsAsync(string knowledgeBaseId, KnowledgeExportJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create import job.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeImportJobResponse</returns>
    Task<KnowledgeImportJobResponse> PostKnowledgeKnowledgebaseImportJobsAsync(string knowledgeBaseId, KnowledgeImportJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create new label.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>LabelResponse</returns>
    Task<LabelResponse> PostKnowledgeKnowledgebaseLabelsAsync(string knowledgeBaseId, LabelCreateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create new category.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="languageCode">Language code</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>CategoryResponse</returns>
    Task<CategoryResponse> PostKnowledgeKnowledgebaseLanguageCategoriesAsync(string knowledgeBaseId, string languageCode, CategoryCreateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create upload job.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="languageCode">Language code</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>UploadUrlResponse</returns>
    Task<UploadUrlResponse> PostKnowledgeKnowledgebaseLanguageDocumentUploadsAsync(string knowledgeBaseId, string languageCode, UploadUrlRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create or process documents.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="languageCode">Language code</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeDocumentResponse</returns>
    Task<KnowledgeDocumentResponse> PostKnowledgeKnowledgebaseLanguageDocumentsAsync(string knowledgeBaseId, string languageCode, KnowledgeDocumentRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create or process documents.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="languageCode">Language code</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeImportJobResponse</returns>
    Task<KnowledgeImportJobResponse> PostKnowledgeKnowledgebaseLanguageDocumentsImportsAsync(string knowledgeBaseId, string languageCode, KnowledgeImportJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create training.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="languageCode">Language code</param>
    /// <param name="trainingId">training ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeTraining</returns>
    Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingPromoteAsync(string knowledgeBaseId, string languageCode, string trainingId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create training.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="languageCode">Language code</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeTraining</returns>
    Task<KnowledgeTraining> PostKnowledgeKnowledgebaseLanguageTrainingsAsync(string knowledgeBaseId, string languageCode, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create import job.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="parseJobId">parseJob ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeParseJobResponse</returns>
    Task<KnowledgeParseJobResponse> PostKnowledgeKnowledgebaseParseJobImportAsync(string knowledgeBaseId, string parseJobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create parse job.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeParseJobResponse</returns>
    Task<KnowledgeParseJobResponse> PostKnowledgeKnowledgebaseParseJobsAsync(string knowledgeBaseId, KnowledgeParseJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Perform search operation.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeSearchResponse</returns>
    Task<KnowledgeSearchResponse> PostKnowledgeKnowledgebaseSearchAsync(string knowledgeBaseId, KnowledgeSearchRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create source integration.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>SalesforceSourceResponse</returns>
    Task<SalesforceSourceResponse> PostKnowledgeKnowledgebaseSourcesSalesforceAsync(string knowledgeBaseId, SalesforceSourceRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create source integration.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="sourceId">source ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>SynchronizeJob</returns>
    Task<SynchronizeJob> PostKnowledgeKnowledgebaseSourcesSalesforceSourceIdSyncAsync(string knowledgeBaseId, string sourceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create source integration.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>ServiceNowSourceResponse</returns>
    Task<ServiceNowSourceResponse> PostKnowledgeKnowledgebaseSourcesServicenowAsync(string knowledgeBaseId, ServiceNowSourceRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create source integration.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="sourceId">source ID</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>SynchronizeJob</returns>
    Task<SynchronizeJob> PostKnowledgeKnowledgebaseSourcesServicenowSourceIdSyncAsync(string knowledgeBaseId, string sourceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create synchronization job.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>SynchronizeJob</returns>
    Task<SynchronizeJob> PostKnowledgeKnowledgebaseSynchronizeJobsAsync(string knowledgeBaseId, SynchronizeRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create upload job.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>GetUploadSourceUrlJobStatusResponse</returns>
    Task<GetUploadSourceUrlJobStatusResponse> PostKnowledgeKnowledgebaseUploadsUrlsJobsAsync(string knowledgeBaseId, GetUploadSourceUrlRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create new knowledge base.
    /// </summary>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>KnowledgeBase</returns>
    Task<KnowledgeBase> PostKnowledgeKnowledgebasesAsync(KnowledgeBaseCreateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Perform putknowledgeknowledgebasesourcessalesforcesourceidasync operation.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="sourceId">source ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>SalesforceSourceResponse</returns>
    Task<SalesforceSourceResponse> PutKnowledgeKnowledgebaseSourcesSalesforceSourceIdAsync(string knowledgeBaseId, string sourceId, SalesforceSourceRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Perform putknowledgeknowledgebasesourcesservicenowsourceidasync operation.
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="sourceId">source ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>ServiceNowSourceResponse</returns>
    Task<ServiceNowSourceResponse> PutKnowledgeKnowledgebaseSourcesServicenowSourceIdAsync(string knowledgeBaseId, string sourceId, ServiceNowSourceRequest body, CancellationToken cancellationToken = default);
}
