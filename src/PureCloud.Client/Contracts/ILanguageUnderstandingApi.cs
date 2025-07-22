using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ILanguageUnderstandingApi
{
    /// <summary>
    /// Get NLU Domain
    /// </summary>
    Task<NluDomain> GetLanguageUnderstandingDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all NLU Domains
    /// </summary>
    Task<NluDomainListing> GetLanguageUnderstandingDomainsAsync(int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get NLU Domain feedback
    /// </summary>
    Task<NluFeedbackListing> GetLanguageUnderstandingDomainFeedbackAsync(string domainId, string intentName = null, string assessment = null, string dateStart = null, string dateEnd = null, bool? includeDeleted = null, string language = null, int? pageNumber = null, int? pageSize = null, bool? enableCursorPagination = null, bool? includeTrainingUtterances = null, string after = null, IEnumerable<string> fields = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get NLU Domain Version
    /// </summary>
    Task<NluDomainVersion> GetLanguageUnderstandingDomainVersionAsync(string domainId, string domainVersionId, bool? includeUtterances = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get NLU Domain Versions
    /// </summary>
    Task<NluDomainVersionListing> GetLanguageUnderstandingDomainVersionsAsync(string domainId, bool? includeUtterances = null, int? pageNumber = null, int? pageSize = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get miner information
    /// </summary>
    Task<Miner> GetLanguageUnderstandingMinerAsync(string minerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all miners
    /// </summary>
    Task<MinerListing> GetLanguageUnderstandingMinersAsync(string minerType = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create NLU Domain
    /// </summary>
    Task<NluDomain> CreateLanguageUnderstandingDomainAsync(NluDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create feedback for NLU Domain
    /// </summary>
    Task<NluFeedbackResponse> CreateLanguageUnderstandingDomainFeedbackAsync(string domainId, NluFeedbackRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create miner
    /// </summary>
    Task<Miner> CreateLanguageUnderstandingMinerAsync(Miner body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update NLU Domain
    /// </summary>
    Task<NluDomain> UpdateLanguageUnderstandingDomainAsync(string domainId, NluDomain body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete NLU Domain
    /// </summary>
    Task DeleteLanguageUnderstandingDomainAsync(string domainId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete miner
    /// </summary>
    Task DeleteLanguageUnderstandingMinerAsync(string minerId, CancellationToken cancellationToken = default);
}