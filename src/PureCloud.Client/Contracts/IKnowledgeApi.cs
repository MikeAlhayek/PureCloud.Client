using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IKnowledgeApi
{
    /// <summary>
    /// Get knowledge base
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Knowledge base details</returns>
    Task<KnowledgeBase> GetKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create new knowledge base
    /// </summary>
    /// <param name="body">Knowledge base creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created knowledge base</returns>
    Task<KnowledgeBase> PostKnowledgeKnowledgebasesAsync(KnowledgeBaseCreateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Salesforce Knowledge integration source
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="sourceId">Source ID</param>
    /// <param name="body">Salesforce source update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated Salesforce source response</returns>
    Task<SalesforceSourceResponse> PutKnowledgeKnowledgebaseSourcesSalesforceSourceIdAsync(string knowledgeBaseId, string sourceId, SalesforceSourceRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete knowledge base
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Deleted knowledge base</returns>
    Task<KnowledgeBase> DeleteKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default);
}