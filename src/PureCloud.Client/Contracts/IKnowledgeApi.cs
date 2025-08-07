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
}